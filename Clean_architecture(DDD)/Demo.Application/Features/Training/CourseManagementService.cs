using Demo.Domain;
using Demo.Domain.Entities;
using Demo.Infrastructure;
using Demo.Infrastructure.Features.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Features.Training
{
    public class CourseManagementService : ICourseManagementService
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

            _unitOfWork.courses.Add(course);
            _unitOfWork.Save();


        }
    }
}
