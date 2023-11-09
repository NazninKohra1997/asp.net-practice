using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Single_Responsibility_Principal_
{
    public class CreatePassword : PasswordEncryption
    {
        public string Password { get; private set; }

        public CreatePassword(string password) { 
          Password = password;
        }

        public void Create()
        {
            Encrypt(Password);
        }
    }
}
