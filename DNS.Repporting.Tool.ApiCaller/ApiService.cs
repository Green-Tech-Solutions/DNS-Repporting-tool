using DNS.Repporting.Tool.Core;
using DNS.Repporting.Tool.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS.Repporting.Tool.ApiCaller
{
    public class ApiService
    {
        private readonly ILogger<RapportService> _log;

        private readonly IConfiguration _config;

        public ApiService(ILogger<RapportService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }

        public async Task<string> GetLogsAsync(string profile,string url,ApiInformation apiInformation )
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(apiInformation.Logs);
            request.Method = HttpMethod.Get;
            request.Headers.Add( "APIKEy","1234");
            HttpResponseMessage response = await httpClient.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();
            var statusCode = response.StatusCode;

            return responseString; 
        }
    }
}
