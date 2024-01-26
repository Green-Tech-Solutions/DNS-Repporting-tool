using DNS.Repporting.Tool.ApiCaller;
using DNS.Repporting.Tool.Models;
using DNS.Repporting.Tool.Core.Rapport.CreatePDF;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Xml.Linq;

namespace DNS.Repporting.Tool.Core.Rapport
{
    public class RapportService : IRapportService
    {
        private readonly ILogger<RapportService> _log;
        private readonly IConfiguration _config;
        private readonly IConfigurationService _configurationService;
        private readonly IApiService _apiService;

        public RapportService(ILogger<RapportService> log, IConfiguration config, IConfigurationService configurationService, IApiService apiService)
        {
            _log = log;
            _config = config;
            _configurationService = configurationService;
            _apiService = apiService;
        }

        public async Task CreateRapportAsync()
        {
            _log.LogInformation("Creating rapport");
            _log.LogInformation(_config.GetValue<string>("configText"));
            var response = await _apiService.GetProfilesAsync();
            foreach(ProfileGeneral pro in response)
            {
                _log.LogInformation(pro.name);
            }
           
            //  _configurationService.SetupConfigurations();
            CreatePDFService createPDFService = new CreatePDFService();
            createPDFService.GenerateReppport();

        }
    }
}
