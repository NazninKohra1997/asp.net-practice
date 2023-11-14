using Microsoft.AspNetCore.Mvc;

namespace Area_02.Areas.Admin_02.Controllers
{
    public class AreaController : Controller
    {
        //for area
        [Area("Admin_02")]
        //for area
        public IActionResult Index()
        {
            return View();
        }
    }
}
