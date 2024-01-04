using DDD_01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_01.Application.Features.Training
{
    public class CourseManagementService
    {
        private readonly IApplicationUnitOfWork _unitOfWork;

        public CourseManagementService(IApplicationUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateCourse(string title, uint fees, string description)
        {
            Course course = new Course()
            {
                Title = title,
                Fees = fees,
                Description = description
            };
            _unitOfWork.CourseRepository.Add(course);
            _unitOfWork.Save();
        }
    }
}
