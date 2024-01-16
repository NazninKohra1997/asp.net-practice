using Autofac;
using Library.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BookPublishController : Controller
	{
		private readonly ILifetimeScope _scope;
		private readonly ILogger<BookPublishController> _logger;

		public BookPublishController(ILifetimeScope scope, ILogger<BookPublishController> logger)
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
			var model = _scope.Resolve<BookModel>();
			return View(model);
		}

		[HttpPost,ValidateAntiForgeryToken]
		public IActionResult Create([FromServices]BookModel model)
		{
			if (ModelState.IsValid)
			{
				model.Resolve(_scope);
				model.BookPublication();
				return RedirectToAction("Index");
			}
			return View(model);
		}
	}
}
