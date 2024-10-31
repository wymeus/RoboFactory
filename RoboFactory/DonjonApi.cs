using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoboFactory
{
    public static class DonjonApi
    {
        public static async Task<List<string>> GetRandomNamesAsync(string type = "Orcish+Male", int amount = 1)
        {
            // Define new list
            var results = new List<string>();
            // Initialize new HTTP client
            using var client = new HttpClient();
            // Define Donjon API base url
            var baseUrl = "https://donjon.bin.sh/name/rpc-name.fcgi?";
            // Define the endpoint and parameters
            var endpoint = $"type={type}&n={amount}&as_json=1";
            // Combine base URL and endpoint
            var url = $"{baseUrl}{endpoint}";
            // Request and get response
            var response = await client.GetAsync(url);
            // If request was success ...
            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                var content = await response.Content.ReadAsStringAsync();
                // Convert to list
                var resultList = JsonSerializer.Deserialize<List<string>>(content);
                // If result list is not empty ...
                if (resultList != null)
                {
                    // ...
                    foreach (var res in resultList)
                    {
                        // Add item into the return list
                        results.Add(res);
                    }
                }
            }
            // After all, return the list of results
            return results;
        }
    }
}
