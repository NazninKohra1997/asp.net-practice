using prac.Application.Features.Training;
using prac.Domain.Features.Training;
using System.Reflection;

namespace prac.Web.Areas.Admin.Models
{
    public class CourseCreateModel 
    {

		private readonly ICourseManagementService _courseManagementService;

		public CourseCreateModel(ICourseManagementService courseManagementService)
		{
			_courseManagementService = courseManagementService;
		}

		public CourseCreateModel()
		{

		}
        public string Title {  get; set; }
        public string Description { get; set; }
        public uint Fees {  get; set; }

		internal void CreateCourse()
		{
			_courseManagementService.CreateCourse(Title, Description, Fees);
		}
	}
}
