using project.Domain;
using project.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Application
{
	public interface IApplicationUnitOfWork : IUnitOfWork
	{
		ICourseRepository CourseRepository { get; }
	}
}
