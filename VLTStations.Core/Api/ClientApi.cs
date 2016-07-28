using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ConsumindoServicos.Api
{
    public class ClientApi : IClientApi
    {
        public ClientApi()
        {
            BaseUrl = "http://dadosabertos.rio.rj.gov.br/EstacoesVLT/api/v1/rest/EstacoesVLT.cfm?token=633AAA2A-C6D8-4F9F-89CE5DA8B63CD15C&pretty=false&filter=";
        }
        public string BaseUrl { get; }
        private readonly HttpClient _httpClient = new HttpClient(new HttpClientHandler());
        public void SetHeader(string header, string value)
        {
            _httpClient.DefaultRequestHeaders.Add(header, value);
        }

        public async Task<HttpResponseMessage> PostAsync(Uri uri, FormUrlEncodedContent values, CancellationToken cts)
        {
            return await _httpClient.PostAsync(uri, values, cts);
        }

        public async Task<HttpResponseMessage> PostMultiPartFormAsync(Uri uri, MultipartFormDataContent values)
        {
            return await _httpClient.PostAsync(uri, values);
        }

        public async Task<string> GetStringAsync(string url)
        {
            return await _httpClient.GetStringAsync(url);
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }
    }
}