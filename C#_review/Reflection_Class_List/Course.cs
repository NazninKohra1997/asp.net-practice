using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Class_List
{
   public class Course
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public List<Topic> Topics { get; private set; }

        public Course(int Id, string Name, List<Topic> Topics) {
            this.Id = Id;
            this.Name = Name;
            this.Topics = Topics;
        }
    }
}
