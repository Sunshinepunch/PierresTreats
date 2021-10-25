using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}














// using Microsoft.AspNetCore.Mvc;

// namespace Bakery.Controllers
// {
//     public class HomeController : Controller
//     {

//     private readonly BakeryContext _db;

//     public HomeController(BakeryContext db)
//     {
//         _db = db;
//     }
//       [HttpGet("/")]
//       public ActionResult Index()
//       {
//         ViewBag.Flavors = _db.Flavors.ToList();
//         ViewBag.Treats = _db.Treats.ToList();
//         return View();
//       }

//     }
// }