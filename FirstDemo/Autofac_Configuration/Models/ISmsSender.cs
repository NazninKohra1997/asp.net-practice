namespace Autofac_Configuration.Models
{
    public interface ISmsSender
    {
        void SendSms(string message); // no need of access modifier
    }
}
