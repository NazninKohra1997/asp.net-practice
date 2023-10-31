using Client_Server_side_validation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Client_Server_side_validation.Controllers
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

       // public IActionResult Testing()
        //{
          //  var form = new Form();
            //return View(form);
        //}

        public IActionResult Testing(Form form)
        {
            form = new Form();
           if(ModelState.IsValid)
            {
                int x = 1;
            }
            return View(form);
        }

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