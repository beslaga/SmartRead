using Microsoft.ML.Data;

namespace SmartRead.API.Recommender.Models
{
    public class ClanakRating
    {
        [LoadColumn(0)]
        public float korisnikId;
        [LoadColumn(1)]
        public float clanakId;
        [ColumnName("Label"), LoadColumn(2)]
        public float ocjena;
    }
}
