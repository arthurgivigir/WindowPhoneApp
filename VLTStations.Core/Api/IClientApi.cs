using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ConsumindoServicos.Api
{
    public interface IClientApi
    {
        string BaseUrl { get; }
        void SetHeader(string header, string value);
        Task<HttpResponseMessage> PostAsync(Uri uri, FormUrlEncodedContent values, CancellationToken cts);
        Task<HttpResponseMessage> PostMultiPartFormAsync(Uri uri, MultipartFormDataContent values);
        Task<string> GetStringAsync(string url);
        Task<HttpResponseMessage> GetAsync(string url);
    }
}