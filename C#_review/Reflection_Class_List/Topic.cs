using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Class_List
{
   public class Topic
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Topic(int Id,string Name) { 
            this.Id = Id;
            this.Name = Name;
        }
    }
}
