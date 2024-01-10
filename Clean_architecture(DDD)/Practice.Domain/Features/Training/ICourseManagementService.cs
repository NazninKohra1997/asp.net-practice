using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Domain.Features.Training
{
	public interface ICourseManagementService
	{
		void CreateCourse(string title, string description, uint fees);
	}
}
