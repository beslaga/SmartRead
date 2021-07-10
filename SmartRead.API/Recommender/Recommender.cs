using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.ML;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using SmartRead.API.Database;
using SmartRead.API.Database.Context;
using SmartRead.API.Recommender.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRead.API.Recommender
{
    public class Recommender : IRecommender
    {
        public static string workingDirectory = Directory.GetParent(Environment.CurrentDirectory).FullName + "\\SmartRead.API\\Recommender\\Data";
        
        private readonly SmartReadContext _context;
        private readonly PredictionEnginePool<ClanakRating, ClanakRatingPrediction> _predictionEnginePool;

        public Recommender(SmartReadContext context, PredictionEnginePool<ClanakRating, ClanakRatingPrediction> predictionEnginePool)
        {
            _context = context;
            _predictionEnginePool = predictionEnginePool;
        }

        public async Task<bool> TrainModel()
        {
            var data = await _context.KorisnikClanci.ToListAsync();
            
            BuildDataSpreadsheet(data);

            MLContext mlContext = new MLContext();
            IDataView trainingDataView = LoadData(mlContext);

            ITransformer model = BuildAndTrainModel(mlContext, trainingDataView);
            SaveModel(mlContext, trainingDataView.Schema, model);
            return true;
        }

        private void SaveModel(MLContext mlContext, DataViewSchema schema, ITransformer model)
        {
            var modelPath = Path.Combine(Environment.CurrentDirectory, "Recommender\\Data", "ClanakRecommenderModel.zip");
            mlContext.Model.Save(model, schema, modelPath);
        }

        private ITransformer BuildAndTrainModel(MLContext mlContext, IDataView trainingDataView)
        {
            IEstimator<ITransformer> estimator = mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "korisnikIdEncoded", inputColumnName: "korisnikId")
                .Append(mlContext.Transforms.Conversion.MapValueToKey(outputColumnName: "clanakIdEncoded", inputColumnName: "clanakId"));

            var options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = "korisnikIdEncoded",
                MatrixRowIndexColumnName = "clanakIdEncoded",
                LabelColumnName = "Label",
                NumberOfIterations = 20,
                ApproximationRank = 100
            };

            var trainerEstimator = estimator.Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));

            ITransformer model = trainerEstimator.Fit(trainingDataView);

            return model;
        }

        private IDataView LoadData(MLContext mlContext)
        {
            var trainingDataPath = Path.Combine(workingDirectory, "clanakRecommend-training-data.csv");

            
            IDataView trainingDataView = mlContext.Data.LoadFromTextFile<ClanakRating>(
                trainingDataPath, hasHeader: true, separatorChar: ',');


            return trainingDataView;
        }

        private void BuildDataSpreadsheet(List<KorisnikClanak> data)
        {
            System.Text.StringBuilder spreadsheet = new System.Text.StringBuilder();
            spreadsheet.AppendLine("korisnikId,clanakId,ocjena");
            foreach (var item in data)
            {
                var line = item.KorisnikId.ToString() + "," +
                    item.ClanakId.ToString() + "," +
                    item.Ocjena.ToString();

                spreadsheet.AppendLine(line);
            }

            File.WriteAllText(
                Path.Combine(
                workingDirectory, "clanakRecommend-training-data.csv"),
                spreadsheet.ToString());
        }

        public float PredictScore(int korisnikId, int clanakId)
        {
            var clanakRating = new ClanakRating
            {
                korisnikId = korisnikId,
                clanakId = clanakId
            };

            var prediction = _predictionEnginePool.Predict(
                modelName: "ClanakRatingAnalysisModel", example: clanakRating);

            return prediction.Score;
        }
    }
}
