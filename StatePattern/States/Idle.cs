using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.States
{
    class Idle : ICommand
    {
        public bool Dispense(Machine machine)
        {
            Console.WriteLine("there are no money");
            return false;
        }

        public void InsertDollar(Machine machine)
        {
            Console.WriteLine("we recived 1 dollar waithing for your chooice");

            machine.ChangeState(new HasMoney());
        }

        public void ReturnMoney(Machine machine)
        {
            Console.WriteLine("there are no money");
        }
    }
}
