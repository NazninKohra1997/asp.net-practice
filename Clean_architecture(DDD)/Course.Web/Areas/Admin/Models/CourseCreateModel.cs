using Autofac;
using Course.Application.Features.Training;
using Course.Domain.Features.Training;
using Course.Domain.Repositories;

namespace Course.Web.Areas.Admin.Models
{
    public class CourseCreateModel 
    {
        private ILifetimeScope _scope;
        private ICourseManagementService _courseManagementService;
        public string Title { get; set; }
        public string Description { get; set; }
        public uint Fees { get; set; }


        public CourseCreateModel()
        {

        }
        public CourseCreateModel(ICourseManagementService courseManagementService) {
             _courseManagementService = courseManagementService;
           
        }
     

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
