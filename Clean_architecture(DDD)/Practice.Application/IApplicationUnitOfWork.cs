using Practice.Domain;
using Practice.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application
{
	public interface IApplicationUnitOfWork : IUnitOfWork
	{
		ICourseRepository CourseRepository { get; }
	}
}
