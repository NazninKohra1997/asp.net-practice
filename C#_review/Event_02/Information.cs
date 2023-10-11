using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_02
{
    public class Information
    {
        public string Text { get; private set; }

        public event Action<string> GetText;

        public void Mail(string text)
        {
            Text = text;
            GetText.Invoke(Text);

        }
    }
}
