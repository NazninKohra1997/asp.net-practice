

using Library.Application.Features.Publish;
using Library.Domain.Features.Publish;

namespace Library.Web.Areas.Admin.Models
{
	public class BookModel
	{
        private readonly IPublishService _publishService;

        public BookModel(IPublishService publishService)
        {
            _publishService = publishService;
        }

        public BookModel()
        {

        }
		public string Title { get; set; }
		public string AuthorName {  get; set; }

        internal void BookPublication()
        {
           _publishService.BookPublication(Title, AuthorName);
        }
    }
}
