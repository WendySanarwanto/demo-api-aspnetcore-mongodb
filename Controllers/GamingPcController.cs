using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using com.wendysa.apidemo.Repositories;

namespace demo_api_mongodb.Controllers
{
    // TODO: Interpolate the api version's number
    [Route("api/v1/[controller]")] // API Path will be available at http://domainpath/api/v1/gamingpc
    public class GamingPcController : Controller {
        private const int RECORDS_LIMIT = 10;

        public GamingPcController(IGamingPcRepository gamingPcRepository) { 
            this.GamingPcRepository = gamingPcRepository;
        }

        public IGamingPcRepository GamingPcRepository { get; set; }

        [HttpGet] // http://domainpath/api/v1/gamingpc Verb: GET (asynchronous)
        public async Task<IActionResult> GetGamingPcList(){
            var allRecords = await GamingPcRepository.getAllAsync(RECORDS_LIMIT);
            return new ObjectResult(allRecords);
        }        
    }
}