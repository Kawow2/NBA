using NBAAPP.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Text.Json.Serialization;
using System.Diagnostics;
using NBAAPP.Interface;

namespace NBAAPP.Tools
{
    public class FreeAPIClient
    {

        public FreeAPIClient()
        {
        }


        public async Task<List<PlayerModel>> FillTablePlayer()
        {
            return await GetPlayersAsync();
        }

        public async Task<List<PlayerModel>> GetPlayersAsync()
        {
            var listPlayer = new List<PlayerModel>();
            var isEnd = false;
            var currentPage = 0;
            var url = "https://free-nba.p.rapidapi.com/players?per_page=100&page=";
            var client = new HttpClient();

            while(!isEnd)
            {
                isEnd = await SendRequest(listPlayer, currentPage, url, client, isEnd);
                Thread.Sleep(800);
                Debug.WriteLine("currentpage : "+currentPage);
                currentPage++;
            }

            return listPlayer;
        }

        private async Task<bool> SendRequest(List<PlayerModel> listPlayer, int currentPage, string url, HttpClient client,bool isEnd)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url + currentPage),
                Headers =
                    {
                        { "X-RapidAPI-Key", "0a7170eb62msh388edd5640a1585p1d75d6jsn734327957277" },
                        { "X-RapidAPI-Host", "free-nba.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<DataAPI>(body);
                listPlayer.AddRange(data?.Data);
                if (currentPage == 2)
                    return true;
            }

            return false;
        }

        
    }
    public class DataAPI
    {
        [JsonProperty("data")]
        public List<PlayerModel> Data { get; set; }

        [JsonProperty("meta")]
        public MetadataAPI MetaData { get; set; }
    }

    public class MetadataAPI
    {
        [JsonProperty("total_pages")]
        public int? TotalPages { get; set; }
        [JsonProperty("current_page")]
        public int? CurrentPage { get; set; }
        [JsonProperty("next_page")]
        public int? NextPage { get; set; }
    }
        
        
    
}
