using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_01.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
