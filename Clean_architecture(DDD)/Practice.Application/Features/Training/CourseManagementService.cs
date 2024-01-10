using Practice.Domain;
using Practice.Domain.Entities;
using Practice.Domain.Features.Training;
using Practice.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Features.Training
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

			_unitOfWork.CourseRepository.Add(course);
			_unitOfWork.Save();

		}

		
	}
}
