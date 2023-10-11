using Event;

Notification notification = new Notification();

notification.OnText += Message;
notification.GetMessage("Hello");

void Message(string text1)
{
   Console.WriteLine(text1);
}