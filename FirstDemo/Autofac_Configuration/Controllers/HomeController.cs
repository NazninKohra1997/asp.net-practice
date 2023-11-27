using Autofac_Configuration.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Autofac_Configuration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //for DI
        private readonly IGetPhoneCall _phoneCall;
        //for DI

        //for Autofac
        private readonly ISmsSender _smsSender;
        //for Autofac
        public HomeController(ILogger<HomeController> logger, IGetPhoneCall phoneCall, ISmsSender smsSender)
        {
            _logger = logger;
            _phoneCall = phoneCall;
            _smsSender = smsSender;
        }

        public IActionResult Index()
        {
            return View();
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