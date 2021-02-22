using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.HttpClientHelper
{
    public class HttpClientHelper
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<Options> _options;
        public HttpClientHelper(IHttpClientFactory httpClientFactory, IOptions<Options> options)
        {
            _httpClient = httpClientFactory.CreateClient("WarehouseManagerClient");
            _options = options;
            _httpClient.BaseAddress = new Uri(options.Value.URL);
        }

        public async Task<T> Get<T>(string methodURL)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, methodURL);
            var response = await _httpClient.SendAsync(httpRequestMessage);
            string result = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var TResult = JsonConvert.DeserializeObject<T>(result);
                return TResult;
            }
            else
            {
                throw new HttpException(response.StatusCode, result);
            }
        }

        public async Task<T> Post<T>(string methodURL, object postObj)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, methodURL);
            if (postObj != null)
            {
                var jsonObj = JsonConvert.SerializeObject(postObj);
                httpRequestMessage.Content = new StringContent(jsonObj, Encoding.UTF8, "application/json");
            }
            var response = await _httpClient.SendAsync(httpRequestMessage);
            var result = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonResult = JsonConvert.DeserializeObject<T>(result);
                return jsonResult;
            }
            else
            {
                throw new HttpException(response.StatusCode, result);
            }
        }

        public async Task<T> PostStream<T>(string methodURL, Stream streamObj)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, methodURL);
            if (streamObj != null)
            {
                httpRequestMessage.Content = new StreamContent(streamObj);
            }
            var response = await _httpClient.SendAsync(httpRequestMessage);
            var result = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var streamResult = JsonConvert.DeserializeObject<T>(result);
                return streamResult;
            }
            else
            {
                throw new HttpException(response.StatusCode, result);
            }
        }

        public async Task<T> Put<T>(string methodURL, object putObject)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Put, methodURL);
            if (putObject != null)
            {
                var jsonObj = JsonConvert.SerializeObject(putObject);
                httpRequestMessage.Content = new StringContent(jsonObj, Encoding.UTF8, "application/json");
            }
            var response = await _httpClient.SendAsync(httpRequestMessage);
            var result = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var jsonResult = JsonConvert.DeserializeObject<T>(result);
                return jsonResult;
            }
            else
            {
                throw new HttpException(response.StatusCode, result);
            }
        }
    }

    public class Options
    {
        public string URL { get; set; }
        public int ClientKey { get; set; }
        public int ClientSecret { get; set; }
    }
    public class HttpException : Exception
    {
        public HttpException(HttpStatusCode code, string message) : base($"{(int)code} {message}")
        {
        }
    }
}
