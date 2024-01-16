using Autofac;
using DDD_01.Domain.Features.Training;

namespace DDD_01.web.Areas.Admin.Models
{
    public class CourseCreateModel
    {
        private ILifetimeScope _scope;
        
        private ICourseManagementService _courseManagementService;

        public CourseCreateModel(ICourseManagementService courseManagementService) {
            _courseManagementService = courseManagementService;
        }

        public CourseCreateModel()
        {

        }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Fees { get; set; }

        internal void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _courseManagementService = _scope.Resolve<ICourseManagementService>();
        }

        internal void CreateCourse()
        {
            _courseManagementService.CreateCourse(Title, Description, Fees);
        }
    }
}
