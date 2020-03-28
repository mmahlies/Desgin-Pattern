using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM("Ibm", 30) ;
            ibm.Rigister(new Investor("Mohamed"));
            ibm.Price = 55;

            Console.ReadLine();
        }
    }
}
