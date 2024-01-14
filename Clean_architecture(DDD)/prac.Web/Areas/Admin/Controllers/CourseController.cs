﻿using Autofac;
using Microsoft.AspNetCore.Mvc;
using prac.Web.Areas.Admin.Models;

namespace prac.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {

		private readonly ILifetimeScope _scope;
		private readonly ILogger _logger;

        public CourseController(ILifetimeScope scope, ILogger<CourseController> logger)
		{
			_scope = scope;
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create()
        {
            var model = _scope.Resolve<CourseCreateModel>();
            return View(model);
        }

        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Create([FromServices]CourseCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                model.CreateCourse();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
