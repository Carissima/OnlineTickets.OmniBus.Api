using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services;
using Services.Models;

namespace OnlineTickets.Bus.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OmnibusController : ControllerBase
    {
        private readonly ILogger<OmnibusController> _logger;
        private readonly IOmnibusService _service;

        public OmnibusController(ILogger<OmnibusController> logger, IOmnibusService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet, Route("routes")]
        public IEnumerable<Route> ListRoutes()
        {
            return _service.ListRoutes();
        }

        [HttpPost, Route("buses")]
        public IEnumerable<Services.Models.Bus> ListBuses(ListBusesRequest request)
        {
            return _service.ListBuses(request);
        }
    }
}
