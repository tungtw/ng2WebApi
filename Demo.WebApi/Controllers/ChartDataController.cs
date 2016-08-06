using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.OData;
using Demo.WebApi.Models;

namespace Demo.WebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ChartDataController : ApiController
    {
        private readonly ChartDataRepository _chartDataRepository;

        public ChartDataController()
        {
            _chartDataRepository = new ChartDataRepository();
        }

        // GET: api/ChartData
        [EnableQuery()]
        public ChartData Get()
        {
            return _chartDataRepository.GetChartData().First();
        }

        [EnableQuery()]
        public ChartData Get(string chartNo)
        {
            return _chartDataRepository.GetChartData(chartNo).First();
        }

        // GET: api/ChartData/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ChartData
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ChartData/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ChartData/5
        public void Delete(int id)
        {
        }
    }
}