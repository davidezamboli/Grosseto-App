using LastDanceMAUI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace LastDanceMAUI.Manager
{
    public class NetworkManager
    {
        static public NetworkManager Instance = new NetworkManager();
        string _baseUri = "https://api.jsonbin.io/v3/b/";
        private readonly HttpClient _httpClient;

        public NetworkManager()
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(_baseUri) };
        }

        public async Task<RecordLocation> GetLocationFromJsonAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<RootLocation>("6620334ce41b4d34e4e60a2c");

            return response.recordLocation;
        }

        public async Task<List<Daily>> GetWeatherFromJsonAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<RootWeather>("662034fead19ca34f85bbe8b");

            return response.recordWeather.timelines.daily;
        }
    }
}
