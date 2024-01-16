
using Autofac;
using project.Domain.Training.Features;

namespace project.Web.Areas.Admin.Models
{
    public class CourseCreateModel
    {
        private ICourseManagementService _courseManagementService;
        private ILifetimeScope _scope;

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


        internal void Resolve(ILifetimeScope scope)
        {
            scope = _scope;
            _courseManagementService = _scope.Resolve<ICourseManagementService>();
        }
        internal void CreateCourse()
        {
           _courseManagementService.CreateCourse(Title, Description, Fees);
        }
    }
}
