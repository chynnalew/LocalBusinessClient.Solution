using System.Threading.Tasks;
using RestSharp;

namespace LocalBusinessClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"LocalBusinesses");
      IRestResponse response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"LocalBusinesses/{id}", Method.GET);
      IRestResponse response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newBusiness)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"LocalBusinesses", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBusiness);
      IRestResponse response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newBusiness)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"newBusinesses", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newBusiness);
      IRestResponse response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"LocalBusinesses/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      IRestResponse response = await client.ExecuteTaskAsync(request);
    }

    public static async Task<string> Search(string name, string type, string genre, int price)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"LocalBusinesses/?name={name}&type={type}&genre={genre}&price={price}", Method.GET);
      IRestResponse response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}