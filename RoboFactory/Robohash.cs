using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboFactory
{
    public static class Robohash
    {
        public static async Task<Bitmap?> GenerateAsync(string hash)
        {
            // Define resource URL
            string url = $"https://robohash.org/{hash}.png";
            // Initialize HTTP client
            using var client = new HttpClient();
            // On error return null
            try
            {
                // Request and get response
                var response = await client.GetAsync(url);
                // Ensure that request is success
                response.EnsureSuccessStatusCode();
                // Get byte array of image
                var imageBytes = await response.Content.ReadAsByteArrayAsync();
                // Get image stream
                using var ms = new MemoryStream(imageBytes);
                // Return the image
                return new Bitmap(ms);
            }
            catch
            {
                // Otherwise, return null
                return null;
            }
        }
    }
}
