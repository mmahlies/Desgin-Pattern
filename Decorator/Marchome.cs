using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Marchome : DecoratePizza
    {
        public Marchome(Pizza pizza)
            : base(pizza)
        {

        }
        public override decimal GetPrice()
        {
            return this.pizza.GetPrice() + 4;
        }
    }
}
