namespace DDD_02.Domain.Features.Training
{
    public interface ICourseManagementService
    {
        void CreateCourse(string title, string descripton, uint fees);
    }
}