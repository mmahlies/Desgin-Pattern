using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class HasMoney : ICommand
    {
        public bool Dispense(Machine machine)
        {
            Console.WriteLine("dispensing wait your product");                                 
            if (machine.StockCount> 1)
            {                
                machine.ChangeState(new Idle());
            }
            else
            {
                machine.ChangeState(new OutOfStock());
            }
            return true;
        }

        public void InsertDollar(Machine machine)
        {
            Console.WriteLine("reciving 1 Dollar");
            machine.ChangeState(new HasMoney());
        }

        public void ReturnMoney(Machine machine)
        {
            Console.WriteLine("returning  1 Dollar");
            machine.ChangeState(new Idle());
        }
    }
}
