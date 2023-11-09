using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Single_Responsibility_Principal_
{
   public class  PasswordEncryption        //here this class can do only Encryption. So it's SRP
    {
        public  void Encrypt(string Password)
        {
            int sum = 0;
            foreach(var pass in Password)
            {
                if(pass== '#' || pass == '$')
                {
                    sum++;
                }
            }

            if(sum == 0)
            {
                Console.WriteLine("Create strong password");
            }
            else
            {
                Console.WriteLine("Your password is confirmed!");
            }
        }
    }
}
