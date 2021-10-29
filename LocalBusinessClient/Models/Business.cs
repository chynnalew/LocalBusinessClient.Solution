using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LocalBusinessClient.Models
{
  public class Business
  {
    public int BusinessId {get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Genre { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public static List<Business> GetBusinesses()
    {
      var apiCall = ApiHelper.GetAll();
      string result = apiCall.Result;
      JArray jasonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Business> businesses = JsonConvert.DeserializeObject<List<Business>>(jasonResponse.ToString());

      return businesses;
    }

    public static Business GetDetails(int id)
    {
      var apiCall = ApiHelper.Get(id);
      string result = apiCall.Result;
      JObject jasonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Business business = JsonConvert.DeserializeObject<Business>(jasonResponse.ToString());

      return business;
    }
  }
}