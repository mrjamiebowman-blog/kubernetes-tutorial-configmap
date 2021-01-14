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
        private readonly IOptionsMonitor<ValuesConfiguration> _valuesMonitoredConfiguration;
        private readonly ValuesConfiguration _valuesConfiguration;

        public ValuesController(ILogger<ValuesController> logger, IOptionsMonitor<ValuesConfiguration> valuesMonitoredConfiguration, ValuesConfiguration valuesConfiguration)
        {
            _logger = logger;
            _valuesMonitoredConfiguration = valuesMonitoredConfiguration;
            _valuesConfiguration = valuesConfiguration;
        }

        /// <summary>
        /// Standard method for getting configuration values. This does not update if you edit the appsettings.json.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Get()
        {
            if (_valuesConfiguration?.Message == null)
                return "Configuration is NULL";

            return _valuesConfiguration?.Message;
        }

        /// <summary>
        /// Will monitor the appsettings.json file for changes and update values when changed.
        /// This doesn't matter if you are using Kubernetes ConfigMaps because you more than likely will delete and re-create the pods.
        /// However, if you did get terminal access to each pod and updated the config it would re-load. This is not best practice...
        /// This technique is great for local development.
        /// </summary>
        /// <returns></returns>
        [HttpGet("ioptionsmonitor")]
        public string GetIOptionsMonitor()
        {
            if (_valuesMonitoredConfiguration?.CurrentValue?.Message == null)
                return "IOptionsMonitor Configuration is NULL";

            return "IOptionsMonitor Configuration: " + _valuesMonitoredConfiguration?.CurrentValue?.Message;
        }
    }
}
