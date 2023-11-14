using Microsoft.AspNetCore.Mvc;

namespace Area.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {

        //for area
        [Area("Admin")]
        //for area
        public IActionResult Index()
        {
            return View();
        }
    }
}
