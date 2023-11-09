using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Interface_Segragation_Principal_
{
   public class SendingApplication : IEmail, IPrinter
    {

        public void Print(string textfile) {
            Console.WriteLine(textfile);
        }

        public void EmailAdress(string mail, string pasword)
        {
            Console.WriteLine($"Mail is sent to {mail}");
        }
    }
}
