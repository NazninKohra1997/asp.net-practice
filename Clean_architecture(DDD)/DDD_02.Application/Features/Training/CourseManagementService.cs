using DDD_02.Domain.Entities;
using DDD_02.Domain.Features.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_02.Application.Features.Training
{

    public class CourseManagementService : ICourseManagementService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public CourseManagementService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateCourse(string title, string descripton, uint fees)
        {
            Course course = new Course
            {
                Title = title,
                Description = descripton,
                Fees = fees
            };

            _unitOfWork.CourseRepository.Add(course);
            _unitOfWork.Save();
        }
    }
}
