using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS.Repporting.Tool.Core
{
    public class RapportService
    {
        private readonly ILogger<RapportService> _log;
        private readonly IConfiguration _config;

        public RapportService(ILogger<RapportService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }

        public void CreateRapport()
        {
            _log.LogInformation("Creating rapport");
            Console.ReadLine();
        }
    }
}
