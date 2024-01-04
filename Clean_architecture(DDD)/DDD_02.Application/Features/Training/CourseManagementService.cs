using DDD_01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_02.Application.Features.Training
{
    public class CourseManagementService 
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public CourseManagementService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateCourse(string title, string description, uint fees)
        {
            Course course = new Course
            {
                Title = title,
                Description = description,
                Fees = fees
            };

            _unitOfWork.CourseRepository.Add(course);
            _unitOfWork.Save();
        }
    }
}
