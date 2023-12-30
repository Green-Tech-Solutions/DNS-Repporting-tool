using DNS.Repporting.Tool.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace DNS.Repporting.Tool.Core;

public class ConfigurationService : IConfigurationService
{
    private readonly ILogger<RapportService> _log;
    private readonly IConfiguration _config;

    public ConfigurationService(ILogger<RapportService> log, IConfiguration config)
    {
        _log = log;
        _config = config;
    }

    public void SetupConfigurations()
    {
    }
}
