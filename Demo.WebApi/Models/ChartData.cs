using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Demo.WebApi.Models
{
    [BsonIgnoreExtraElements]
    public class ChartData
    {
        [BsonElement("data")]
        public List<Datum> Data { get; set; }
    }

    public class Datum
    {
        [BsonElement("labels")]
        public List<string> Labels { get; set; }
        [BsonElement("datasets")]
        public List<Dataset> Datasets { get; set; }
    }

    public class Dataset
    {
        [BsonElement("data")]
        public List<double> Data { get; set; }
    }


    public sealed class ChartOptions
    {
        public Legend Legend;
        public Title Title;
    }

    public sealed class Legend
    {
    }

    public sealed class Title
    {
    }
}