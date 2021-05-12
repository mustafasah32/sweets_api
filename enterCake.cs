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

    public static class enterCake
    {
        [FunctionName("enterCake")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var cake = JsonConvert.DeserializeObject<Cake>(requestBody);

            if (dbmock.Cakes.Any(c => c.Name == cake.Name))
            {
                return new OkObjectResult("-1");
            }
            else
            {
                var id = dbmock.Cakes.Count.ToString();
                dbmock.Cakes.Add(new Cake(id, cake.Comment, cake.Name, cake.ImageUrl, cake.YumFactor));
                return new OkObjectResult(id);
            }
        }
    }
}
