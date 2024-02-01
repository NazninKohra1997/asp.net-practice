namespace Demo.Infrastructure.Features.Training
{
    public interface ICourseManagementService
    {
        void CreateCourse(string title, string description, uint fees);
    }
}