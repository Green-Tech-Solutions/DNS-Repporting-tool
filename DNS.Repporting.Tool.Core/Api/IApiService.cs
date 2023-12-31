

using DNS.Repporting.Tool.Models;

namespace DNS.Repporting.Tool.ApiCaller
{
    public interface IApiService
    {
        Task<List<ProfileGeneral>> GetProfilesAsync();
    }
}