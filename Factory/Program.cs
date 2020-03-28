using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryObject;
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // factory object
            KnifeFactory factory = new KnifeFactory();
            KnifeStore consumerObject = new KnifeStore(factory);
            consumerObject.OrderKnife("ChefsKnife");

            // factory method

        }

    }

}
