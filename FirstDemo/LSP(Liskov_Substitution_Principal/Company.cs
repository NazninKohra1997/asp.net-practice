using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Liskov_Substitution_Principal
{
    public class Company : WaterBottle  //all the items from the parent class are needed to copy here. So LSP is implemented.
    {
        public void ProductionInfo()
        {
            Console.WriteLine($"{CompanyName} produces {WaterAmount}litre {Number} bottle everyday");
        } 
    }
}
