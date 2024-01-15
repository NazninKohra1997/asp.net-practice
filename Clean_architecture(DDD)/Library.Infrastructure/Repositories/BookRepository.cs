using Library.Domain.Entities;
using Library.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repositories
{
	public class BookRepository : Repository<Book, Guid>, IBookRepository
	{
		public BookRepository(DbContext context) : base(context)
		{
		}
	}
}
