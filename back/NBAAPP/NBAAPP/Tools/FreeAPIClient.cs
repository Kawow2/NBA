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
        private string APIUrl { get; set; } = "https://free-nba.p.rapidapi.com";
        private HttpClient client { get; set; }
        public FreeAPIClient()
        {
            client = new HttpClient();
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

            while(!isEnd)
            {
                var result = await sendRequestGet(this.APIUrl + "/players?page="+currentPage+"&per_page=100");
                var data = JsonConvert.DeserializeObject<DataAPI<PlayerModel>>(result);
                listPlayer.AddRange(data?.Data.ToList());
                currentPage++;
                isEnd = currentPage == data.MetaData.TotalPages;
            }

           

            return listPlayer;
        }

        public async Task<List<TeamModel>> GetTeamsAsync()
        {
            var listTeam = new List<TeamModel>();
            var isEnd = false;
            var currentPage = 0;

            while (!isEnd)
            {
                var result = await sendRequestGet(APIUrl + "/teams?page=" + currentPage + "&per_page=100");
                var data = JsonConvert.DeserializeObject<DataAPI<TeamModel>>(result);
                listTeam.AddRange(data?.Data.ToList());
                currentPage++;
                isEnd = currentPage == data.MetaData.TotalPages;
            }

            return listTeam;
        }


        private async Task<string> sendRequestGet(string url)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
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
                return body;
            }

        }

      


        
    }
    public class DataAPI<T>
    {
        [JsonProperty("data")]
        public List<T> Data { get; set; }

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
