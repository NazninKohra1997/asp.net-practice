namespace FirstDemo.Web.Models
{
    public interface IEmailSender
    {
         void SendEmail(string email, string subject, string body );
    }
}
