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

    public ActionResult Delete(int id)
    {
      var business = Business.GetDetails(id);
      return View(business);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirm(int id)
    {
      await Business.Delete(id);
      return RedirectToAction("Index");
    }
    public ActionResult Search()
    {
      return View();
    }

    public IActionResult SearchResults(string name, string type, string genre, int price)
    {
      
      var searchResults = Business.Search(name, type, genre, price);
      return View(searchResults);
    }
  }
}