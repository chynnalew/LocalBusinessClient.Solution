using LocalBusinessClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;

namespace LocalBusinessClient.Controllers
{
  public class BusinessesController : Controller
  {
    public IActionResult Index()
    {
      var allBusinesses = Business.GetBusinesses().OrderBy(model => model.Name);
      return View(allBusinesses);
    }
  }
}