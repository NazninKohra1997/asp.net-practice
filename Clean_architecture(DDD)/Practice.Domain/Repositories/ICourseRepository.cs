using Practice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Domain.Repositories
{
	public interface ICourseRepository : IRepositoryBase<Course,Guid>
	{
	}
}
