using LeedsBeerQuest.API.Models;
using LeedsBeerQuest.API.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeedsBeerQuest.API.Services
{
    public class PubReviewService : IPubReviewService
    {
        private readonly HttpClient client;


        public PubReviewService(IHttpClientFactory httpClientFactory)
        {
            client = httpClientFactory.CreateClient("PubReviewsApi");
        }
        public async Task<List<Review>> GetPubReviews(string pubName)
        {
            var url = $"?name=pubName";
            var result = new List<Review>();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<List<Review>>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            return result;
        }

        public async Task<List<Pub>> GetPubsAsync()
        {
            var url = $"?sql=SELECT DISTINCT name, address, lat, lng, phone, twitter, url, thumbnail  FROM dataset";
            var result = new PubResponse();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();

                result = JsonSerializer.Deserialize<PubResponse>(stringResponse,
                    new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            return result.Rows;
        }
    }
}
