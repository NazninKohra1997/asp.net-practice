using Microsoft.EntityFrameworkCore;
using project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Infrastructure
{
	public interface IApplicationDbContext
	{
		public DbSet<Course> Courses { get; set; }
	}
}
