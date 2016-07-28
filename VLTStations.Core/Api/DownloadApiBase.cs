using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumindoServicos.Api
{
    public class DownloadApiBase : ApiBase
    {
        protected readonly ClientApi ApiClient = new ClientApi();

        public async Task<string> GetContentImage(string url)
        {
            var imageData = await ApiClient.GetAsync(url);
            var contentType = imageData.Content.Headers.ContentType;
            if (contentType.MediaType == "application/json")
                return await imageData.Content.ReadAsStringAsync();
            var byteContent = await imageData.Content.ReadAsByteArrayAsync();
            return Convert.ToBase64String(byteContent, 0, byteContent.Length);
        }

        public async Task<HttpResponseMessage> GetContent(string url)
        {
            return await ApiClient.GetAsync(url);
        }
    }
}
