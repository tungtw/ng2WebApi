using System.ComponentModel.Composition;
using System.Linq;
using MongoDB.Driver;

namespace Demo.WebApi.Models
{
    [Export]
    public class ChartDataRepository
    {
        public ChartDataRepository()
        {
            var client = new MongoClient(@"mongodb://localhost");
            Database = client.GetDatabase("Demo");
        }

        public IMongoDatabase Database { get; }

        public IMongoCollection<ChartData> ChartDataCollection
            => Database.GetCollection<ChartData>("charts");

        public IMongoCollection<Restaurant> RestaurantCollection
            => Database.GetCollection<Restaurant>("restaurants");


        public ChartData GetChartData()
        {
            var data = ChartDataCollection.Find(x => true).ToList().First();
            return data;
        }
    }
}