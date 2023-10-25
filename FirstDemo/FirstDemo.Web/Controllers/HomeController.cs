using FirstDemo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace FirstDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;

        public HomeController(ILogger<HomeController> logger, IEmailSender emailSender,ISmsSender smsSender) 
        {
            _logger = logger; 
            _emailSender = emailSender;
            _smsSender = smsSender;
        }      

        public IActionResult Index()
        {
            Model2 model2 = new Model2();
            model2.Name = "Hello world!";
            _logger.LogInformation("I'm in home page");
           
            return View(model2); 
        }

        //[HttpPost, ValidateAntiForgeryToken]
        public IActionResult Test() {
            var model = new Model_tag();
            
           return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Test(Model_tag model)
        {
            model = new Model_tag();
            if (ModelState.IsValid)
            {
                int x = 5;
            }
            return View(model);
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