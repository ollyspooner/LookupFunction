using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq;
using LookupFunction.Models;

namespace LookupFunction
{
    public class LookupFunction
    {
        private readonly ApplicationDbContext _context;

        public LookupFunction(ApplicationDbContext context)
        {
            _context = context;
        }
        // [FunctionName("LookupFunction")]
        // public static async Task<IActionResult> Run(
        //     [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        //     ILogger log)
        // {
        //     log.LogInformation("C# HTTP trigger function processed a request.");

        //     string name = req.Query["name"];

        //     string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        //     dynamic data = JsonConvert.DeserializeObject(requestBody);
        //     name = name ?? data?.name;

        //     string responseMessage = string.IsNullOrEmpty(name)
        //         ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
        //         : $"Hello, {name}. This HTTP triggered function executed successfully.";

        //     return new OkObjectResult(responseMessage);
        // }
        [FunctionName("search")]
        public IActionResult OrganisationSearch(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)]
            HttpRequest req, ILogger log)
        {
            string name = req.Query["name"];

            log.LogInformation("C# HTTP GET trigger function processed organisation search request.");

            if( string.IsNullOrEmpty(name) ) {
                return new OkObjectResult( "Pass a \"name\" parameter in the query string to search for an organisation." );
            }

            var organisationsArray = _context.Organisations.Where(b => b.Name.Contains(name)).ToArray();
            return new OkObjectResult(organisationsArray);
        }

    }
}
