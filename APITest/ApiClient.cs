using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace APITest
{
    public class ApiClient : IComparable<ApiClient>
    {
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<T> GetAsync<T>(string url)
        {

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to retrieve data from {url}. Status Code: {response.StatusCode}");
            }

            var content = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(content);

            // Access the Latitude property on the result object
       
            var latitude = result;

            return latitude;
        }
            public async Task<T> PostAsync<T>(string url, object data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to post data to {url}. Status Code: {response.StatusCode}");
            }

            var result = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(result);
        }


        public int CompareTo(ApiClient other)
        {
            // You can compare two ApiClient objects based on their properties or any other logic you want to implement
            // For example, you can compare the BaseAddress of the HttpClient object:

            return this._httpClient.BaseAddress.ToString().CompareTo(other._httpClient.BaseAddress.ToString());
        }
        
    }
}
