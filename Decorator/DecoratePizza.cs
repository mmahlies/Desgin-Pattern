using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class DecoratePizza : Pizza
    {
        protected Pizza pizza;
        public   DecoratePizza(Pizza pizza)
        {
            this.pizza = pizza;
        }
    }
}
