using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumindoServicos.Api
{
    public class ApiGetBase<T> : ApiBase
    {
        protected readonly IClientApi ApiClient = new ClientApi();
        protected async Task<T> GetAsyncTemplate()
        {
            var url = ApiClient.BaseUrl + Url;
            var result = await ApiClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}