using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatePattern.States;
namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Machine m1 = new Machine(5);
            m1.InsertDollar();
            m1.Dispense();
        }
    }
}
