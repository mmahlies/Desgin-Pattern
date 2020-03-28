using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class OutOfStock : ICommand
    {
        public bool Dispense(Machine machine)
        {
            Console.WriteLine("there are no money");
            return false;
        }

        public void InsertDollar(Machine machine)
        {
            Console.WriteLine("we are out of stock");
        }

        public void ReturnMoney(Machine machine)
        {
            Console.WriteLine("there are no money");
        }
    }
}
