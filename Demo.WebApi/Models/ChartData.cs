using System.Collections.Generic;
using JetBrains.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Demo.WebApi.Models
{
    [BsonIgnoreExtraElements]
    [UsedImplicitly]
    public sealed class ChartData
    {
        [BsonElement("chartNo")]
        public string ChartNo { get; set; }

        [BsonElement("data")]
        public List<Datum> Data { get; set; }
    }

    [UsedImplicitly]
    public sealed class Datum
    {
        [BsonElement("labels")]
        public List<string> Labels { get; set; }
        [BsonElement("datasets")]
        public List<Dataset> Datasets { get; set; }
    }

    [UsedImplicitly]
    public sealed class Dataset
    {
        [BsonElement("data")]
        public List<double> Data { get; set; }
    }


    public sealed class ChartOptions
    {
        public Legend Legend;
        public Title Title;
    }

    public abstract class Legend
    {
    }

    public abstract class Title
    {
    }
}