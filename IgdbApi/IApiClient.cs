using IgdbApi.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IgdbApi
{
    public interface IApiClient
    {
        Task<T> Get<T>(string requestUri);
    }
}
