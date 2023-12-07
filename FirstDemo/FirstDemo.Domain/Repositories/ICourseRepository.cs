using FirstDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FirstDemo.Domain.IRepositoryBase;

namespace FirstDemo.Domain.Repositories
{
   public interface ICourseRepository : IRepositoryBase<Course, Guid>
    {
    }
}
