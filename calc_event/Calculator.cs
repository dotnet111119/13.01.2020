using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_1401
{
    public class Calculator
    {
        public event EventHandler<NumberEventArgs> NumberClickedEventHandler;

        public event EventHandler<EventArgs> DivideByZeroEventHandler;

        public void NumberWasClicked(int number)
        {
            OnNumberClicked(number);
            if (number == 0)
            {
                OnDivideByZero();
            }
            else
            {
                Console.WriteLine("Good Number was clicked...");
            }
        }

        private void OnDivideByZero()
        {
            if (DivideByZeroEventHandler != null)
            {
                DivideByZeroEventHandler.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnNumberClicked(int number)
        {
            if (NumberClickedEventHandler != null)
            {
                NumberClickedEventHandler.Invoke(this, new NumberEventArgs { Number = number });
            }
        }
    }
}
