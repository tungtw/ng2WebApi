using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Web.Hosting;
using MongoDB.Driver;
using Newtonsoft.Json;

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

        public IEnumerable<ChartData> GetChartDataFromText()
        {
            var filepath = HostingEnvironment.MapPath(@"~/App_Data/chart-Data.json");
            if (filepath != null)
            {
                var json = File.ReadAllText(filepath);
                var chartData = JsonConvert.DeserializeObject<ChartData>(json);
                return new[] {chartData};
            }
            return Enumerable.Empty<ChartData>();
        }
    }
}