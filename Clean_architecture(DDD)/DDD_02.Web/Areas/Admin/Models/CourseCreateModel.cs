using DDD_02.Domain.Features.Training;

namespace DDD_02.Web.Areas.Admin.Models
{
    public class CourseCreateModel
    {
        private readonly ICourseManagementService _courseManagementService;

        public CourseCreateModel(ICourseManagementService courseManagementService) { 
            _courseManagementService = courseManagementService;
        }

      
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Fees {  get; set; }
        internal void CreateCourse()
        {
           _courseManagementService.CreateCourse(Title, Description, Fees);
        }
    }
}
