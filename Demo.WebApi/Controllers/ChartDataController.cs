using System.Web.Http;
using System.Web.Http.Cors;
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
        public ChartData Get()
        {
            return _chartDataRepository.GetChartData();
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