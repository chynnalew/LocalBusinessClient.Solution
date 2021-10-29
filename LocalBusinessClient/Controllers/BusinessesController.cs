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

    public IActionResult Details(int id)
    {
      var business = Business.GetDetails(id);
      return View(business);
    }

    public IActionResult Edit(int id)
    {
      var business = Business.GetDetails(id);
      return View(business);
    }

    [HttpPost]
    public async Task<IActionResult> Details(int id, Business business)
    {
      business.BusinessId = id;
      await Business.Put(business);
      return RedirectToAction("Details", id);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Business business)
    {
      await Business.Post(business);
      return RedirectToAction("Index");
    }
  }
}