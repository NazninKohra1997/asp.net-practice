namespace Dependency_Injection.Models
{
    public class HtmlEmail : IEmailSender
    {
        public void SendEmail(string emailSender, string body, string subject)
        {
            throw new NotImplementedException();
        }
    }
}
