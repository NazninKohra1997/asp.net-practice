using Html_tag_helper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Html_tag_helper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        //for html_tag_helper
        public IActionResult HelperTest()
        {
            var helper = new Helper();
            return View(helper);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult HelperTest(Helper helper)
        {
            helper = new Helper();

            if (ModelState.IsValid)
            {
                int x = 5;
            }
            return View(helper);
        }

        //for html_tag_helper

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}