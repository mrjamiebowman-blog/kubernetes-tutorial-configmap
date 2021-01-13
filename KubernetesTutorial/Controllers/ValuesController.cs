using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace KubernetesTutorial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IOptionsMonitor<ValuesConfiguration> _valuesConfiguration;

        public ValuesController(ILogger<ValuesController> logger, IOptionsMonitor<ValuesConfiguration> valuesConfiguration)
        {
            _logger = logger;
            _valuesConfiguration = valuesConfiguration;
        }

        [HttpGet]
        public string Get()
        {
            if (_valuesConfiguration?.CurrentValue?.Message == null)
                return "Configuration is NULL";

            return _valuesConfiguration?.CurrentValue?.Message;
        }
    }
}
