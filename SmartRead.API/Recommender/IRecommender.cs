using System.Threading.Tasks;

namespace SmartRead.API.Recommender
{
    public interface IRecommender
    {
        Task<bool> TrainModel();
        float PredictScore(int korisnikId, int clanakId);
    }
}
