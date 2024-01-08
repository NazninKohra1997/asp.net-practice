using Microsoft.AspNetCore.Mvc;
using prac.Web.Areas.Admin.Models;

namespace prac.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = new CourseCreateModel();
            return View();
        }

        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Create(CourseCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                model.CreateCourse();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
