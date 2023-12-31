using DNS.Repporting.Tool.Core;
using DNS.Repporting.Tool.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DNS.Repporting.Tool.ApiCaller
{
    public class ApiService : IApiService
    {
        private readonly ILogger<ApiService> _log;

        private readonly string Url;
        private readonly string? key;
        private readonly string? keyValue;

        public ApiService(ILogger<ApiService> log, IConfiguration config)
        {
            _log = log;
            Url = config.GetValue<string>("ApiInformation:Profiles");
            key = config.GetValue<string>("API:Key");
            keyValue = config.GetValue<string>("API:Value");
        }

        public async Task<List<ProfileGeneral>> GetProfilesAsync()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri(Url);
            request.Method = HttpMethod.Get;
            request.Headers.Add(key, keyValue);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            var respBody = await response.Content.ReadAsStringAsync();
            var statusCode = response.StatusCode;

            if (statusCode == HttpStatusCode.OK)
            {
                respBody = CleanResponse(respBody);
                return JsonSerializer.Deserialize<List<ProfileGeneral>>(respBody);
            }

            return new List<ProfileGeneral>();
        }

        private string CleanResponse(string respBody)
        {
            return respBody.Remove(respBody.Length - 1, 1).Remove(0, 8);
        }
    }
}
