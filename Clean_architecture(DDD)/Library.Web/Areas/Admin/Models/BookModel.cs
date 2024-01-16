

using Autofac;
using Library.Application.Features.Publish;
using Library.Domain.Features.Publish;

namespace Library.Web.Areas.Admin.Models
{
	public class BookModel
	{
        private ILifetimeScope _scope;
        private  IPublishService _publishService;

        public string Title { get; set; }
        public string AuthorName { get; set; }

        public BookModel(IPublishService publishService)
        {
            _publishService = publishService;
        }

      
		public BookModel()
        {

        }

        internal void Resolve(ILifetimeScope scope)
        {
            scope = _scope;
            _publishService = scope.Resolve<IPublishService>();
        }

        internal void BookPublication()
        {
           _publishService.BookPublication(Title, AuthorName);
        }
    }
}
