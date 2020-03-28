using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class LargePiza: Pizza
    {
        public override decimal GetPrice()
        {
            return 20;
        }
    }
}
