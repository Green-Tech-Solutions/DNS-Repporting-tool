using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DNS.Repporting.Tool.Core
{
    public class RapportService : IRapportService
    {
        private readonly ILogger<RapportService> _log;
        private readonly IConfiguration _config;
        private readonly IConfigurationService _configurationService;

        public RapportService(ILogger<RapportService> log, IConfiguration config, IConfigurationService configurationService)
        {
            _log = log;
            _config = config;
            _configurationService = configurationService;
        }

        public void CreateRapport()
        {
            _log.LogInformation("Creating rapport");
            _log.LogInformation(_config.GetValue<string>("configText"));

            _configurationService.SetupConfigurations();
            
        }
    }
}
