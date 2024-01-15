using Library.Application.Features.Publish;
using Library.Domain.Repositories;
using project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application
{
	public interface IApplicationUnitOfWork : IUnitOfWork
	{
		IBookRepository BookRepository { get; }
	}
}
