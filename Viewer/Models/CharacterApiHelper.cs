using RestSharp;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Viewer.Models
{
    class CharacterApiHelper
    {
        public static async Task<string> GetAll()
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"characters", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> Get(int id)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"characters/{id}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task Post(string newCharacter)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"characters", Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newCharacter);
            var response = await client.ExecuteTaskAsync(request);
        }

        public static async Task Put(int id, string newCharacter)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"characters/{id}", Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(newCharacter);
            var response = await client.ExecuteTaskAsync(request);
        }

        public static async Task Delete(int id)
        {
            RestClient client = new RestClient("http://localhost:5004/api");
            RestRequest request = new RestRequest($"characters/{id}", Method.DELETE);
            request.AddHeader("Content-Type", "application/json");
            var response = await client.ExecuteTaskAsync(request);
        }

    }
}