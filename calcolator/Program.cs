using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_1401
{
    class Program
    {

        //public delegate int my_del(int x);

        static void Main(string[] args)
        {
            //my_del del1 = x => { return 1; };
            Func<int, int> del1 = i => { return 1; };

            Calculator c = new Calculator();

            NicePrinter nice = new NicePrinter();

            ErrorPrinter error = new ErrorPrinter();

            c.NumberClickedEventHandler += nice.Print;
            c.NumberClickedEventHandler += (sender, e) => { Console.WriteLine("My number clicked listener ..."); };

            c.DivideByZeroEventHandler += error.Print;
            c.DivideByZeroEventHandler += (sender, e) => { Console.WriteLine("My divide by zero listener ..."); };

            c.NumberWasClicked(12);
            c.NumberWasClicked(33);
            c.NumberWasClicked(45);

            c.NumberWasClicked(0);
        }

    }
}
