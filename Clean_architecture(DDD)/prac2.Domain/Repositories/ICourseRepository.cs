using prac2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac2.Domain.Repositories
{
   public interface ICourseRepository : IRepositoryBase<Course,Guid>
    {
    }
}
