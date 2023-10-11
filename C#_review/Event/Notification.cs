using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
   public class Notification
    {
        public string Text { get; set; }

        public event Action<string> OnText;

        public void GetMessage(string text)
        {
            Text = text;
            OnText.Invoke(Text);
        }
    }
}
