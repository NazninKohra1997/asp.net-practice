using Library.Domain;
using Library.Domain.Entities;
using Library.Domain.Features.Publish;
using project.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Features.Publish
{
	public class PublishService : IPublishService
	{
		private readonly IApplicationUnitOfWork _unitOfWork;

		public PublishService(IApplicationUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		public void BookPublication(string title, string authorName)
		{
			Book book = new Book
			{
				Title = title,
				AuthorName = authorName
			};
			_unitOfWork.BookRepository.Add(book);
			_unitOfWork.Save();
		}
	}
}
