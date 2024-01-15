using Library.Application;
using Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
//using Library.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
	internal class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
	{
		public IBookRepository BookRepository { get; private set; }
		public ApplicationUnitOfWork(DbContext dbContext) : base(dbContext)
		{
		}

		

		
	}
}
