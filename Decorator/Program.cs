using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizza LargePizaWithChease = new Chease(new LargePiza());           
         var price1 =   LargePizaWithChease.GetPrice();

         Pizza largePizza = new LargePiza();
         largePizza = new Chease(largePizza);
         largePizza = new Marchome(largePizza);
         var price2 = largePizza.GetPrice();
       
        }
    }
}
