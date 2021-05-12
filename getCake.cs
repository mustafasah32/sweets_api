using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Sweets.Cakes.Models;
using System.Linq;

namespace Sweets.Cakes
{

    public static class getCake
    {
        [FunctionName("getCake")]
        public static async Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var cake = JsonConvert.DeserializeObject<Cake>(requestBody);
            
            return new OkObjectResult(dbmock.Cakes.SingleOrDefault(c=>c.Id==cake.Id));
        }
    }
}
