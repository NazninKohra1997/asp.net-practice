using project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Domain.Repositories
{
	public interface ICourseRepository : IRepositoryBase<Course,Guid>
	{
	}
}
