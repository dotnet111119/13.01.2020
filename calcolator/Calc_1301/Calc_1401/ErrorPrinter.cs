using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_1401
{
    public class ErrorPrinter
    {
        public void Print(object sender, EventArgs n)
        {
            Console.WriteLine($"Printing in red --- EROR !!! divide by zero !!!!");
        }
    }
}
