namespace Dependency_Injection.Models
{
    public interface IEmailSender
    {
        public void SendEmail(string emailSender, string body, string subject);
    }
}
