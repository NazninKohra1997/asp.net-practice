using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_and_class
{
    public class Course
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public List<Topic> Topics { get; private set; }

        public Course(int id, string name, List<Topic> topics)
        {
            Id = id;
            Name = name;
            Topics = topics;
        }
    }
}
