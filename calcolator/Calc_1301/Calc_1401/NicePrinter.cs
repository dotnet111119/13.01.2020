using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_1401
{
    public class NicePrinter
    {
        public void Print(object sender, NumberEventArgs n)
        {
            Console.WriteLine($"Printing very nice {n.Number}");
        }
    }
}
