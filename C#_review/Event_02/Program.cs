using Event_02;

Information information = new Information();

information.GetText += Info;

information.Mail("Hey, Are you There!");

void Info(string text){
    Console.WriteLine(text);
}