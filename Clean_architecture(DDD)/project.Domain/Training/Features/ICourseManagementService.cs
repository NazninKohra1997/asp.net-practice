namespace project.Domain.Training.Features
{
    public interface ICourseManagementService
    {
        void CreateCourse(string title, string description, uint fees);
    }
}