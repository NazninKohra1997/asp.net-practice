using prac.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac.Application.Features.Training
{
    public class CoursemanagementService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public CoursemanagementService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _unitOfWork = applicationUnitOfWork;
        }

        public void CreateCourse(string title, string description, uint feees)
        {
            Course course = new Course
            {
                Title = title,
                Description = description,
                Fees = feees
            };

            _unitOfWork.CourseRepository.Add(course);
            _unitOfWork.Save();
        }
    }
}
