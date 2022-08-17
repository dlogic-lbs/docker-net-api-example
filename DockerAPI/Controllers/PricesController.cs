using Microsoft.AspNetCore.Mvc;

namespace DockerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PricesController : ControllerBase
    {
        private readonly ILogger<PricesController> _logger;

        public PricesController(ILogger<PricesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]        
        public IEnumerable<Prices> Get(uint ProductId)
        {
            // TODO we could implement much more sophisticated system of getting product prices than this one is ..
            // examples being: 
            // - SQL or MySQL databases
            // - NoSQL such as MongoDB
            // - other kinds of document repositories made up of documents in XML, JSON, CSV or other formats
            // .. 
            // NOTE: For illustration purposes this will have to do.

            return new List<Prices>() { 
                new Prices(1001, new List<Money>() { 
                    new Money("GBP", 8.95),
                    new Money("EUR", 10.75),
                }),
                new Prices(1209, new List<Money>() {
                    new Money("GBP", 7.45),
                    new Money("EUR", 8.85),
                }),
                new Prices(3315, new List<Money>() {
                    new Money("GBP", 21.95),
                    new Money("EUR", 25.95),
                }),
                new Prices(4877, new List<Money>() {
                    new Money("GBP", 15.95),
                    new Money("EUR", 18.95),
                }),
            }.ToArray();
        }
    }
}
