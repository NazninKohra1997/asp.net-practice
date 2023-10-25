namespace FirstDemo.Web.Models
{
    public interface ISmsSender
    {
       public void SendSms(string mobile, string message);
    }
}
