using System.Collections.Generic;
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

        private IMongoDatabase Database { get; }

        private IMongoCollection<ChartData> ChartDataCollection
            => Database.GetCollection<ChartData>("charts");

        public IMongoCollection<Restaurant> RestaurantCollection
            => Database.GetCollection<Restaurant>("restaurants");


        public IEnumerable<ChartData> GetChartData()
        {
            var data = ChartDataCollection.Find(x => true).ToList(); //First();
            return data;
        }

        public IEnumerable<ChartData> GetChartData(string chartNo)
        {
            var data = GetChartData().Where(x => x.ChartNo == chartNo);
            return data;
        }
    }
}