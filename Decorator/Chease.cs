using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Chease : DecoratePizza
    {
        public Chease(Pizza pizza)
            : base(pizza)
        {

        }
        public override decimal GetPrice()
        {
            return this.pizza.GetPrice() + 5;
        }
    }
}
