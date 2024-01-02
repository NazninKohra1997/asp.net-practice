using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_01.Domain.Entities
{
    public interface IEntity<T>
    {
        T Id { get; set; } 
    }
}
