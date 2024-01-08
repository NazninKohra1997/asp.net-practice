using DDD_02.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace DDD_02.Web.Areas.Admin.Controllers
{
    public class CourseController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            var model = new CourseCreateModel();
            return View();
        }


        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Create(CourseCreateModel model)
        {
            if(ModelState.IsValid)
            {
                model.CreateCourse();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
