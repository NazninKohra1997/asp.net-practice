using Course.Domain;
using Course.Domain.Entities;
using Course.Domain.Features.Training;
using Course.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Application.Features.Training
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
            Courses course = new Courses
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
