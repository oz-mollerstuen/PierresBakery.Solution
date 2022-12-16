using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{

  public static class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index
    {
      return View();
    }

  }
}