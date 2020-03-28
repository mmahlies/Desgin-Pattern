using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    interface ICommand
    {
        void InsertDollar(Machine machine);
        void ReturnMoney(Machine machine);
        bool Dispense(Machine machine);
    }
}
