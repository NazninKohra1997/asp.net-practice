using Library.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BookPublishController : Controller
	{

		private readonly ILogger<BookPublishController> _logger;

		public BookPublishController(ILogger<BookPublishController> logger)
		{
			_logger = logger;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create()
		{
			var model = new BookModel();
			return View(model);
		}

		[HttpPost,ValidateAntiForgeryToken]
		public IActionResult Create(BookModel model)
		{
			if (ModelState.IsValid)
			{
				model.BookPublication();
				return RedirectToAction("Index");
			}
			return View(model);
		}
	}
}
