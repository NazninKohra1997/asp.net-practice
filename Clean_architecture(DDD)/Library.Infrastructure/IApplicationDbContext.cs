﻿using Library.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
	public interface IApplicationDbContext
	{
		public DbSet<Book> Books { get; set; }
	}
}
