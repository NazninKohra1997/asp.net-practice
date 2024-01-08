using DDD_01.web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DDD_01.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult Create()
        {
            var model = new CourseCreateModel();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(CourseCreateModel model)
        {
            if (ModelState.IsValid)
            {
                model.CreateCourse();
                return RedirectToAction("Index"); 
            }
            return View(model);

        }
    }
}
