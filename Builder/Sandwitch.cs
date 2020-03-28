using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class Sandwitch
    {
        public abstract int size { get; set; }
        public abstract float Price { get; set; }
        public abstract bool IsSpicy { get; set; }

      
    }
}
