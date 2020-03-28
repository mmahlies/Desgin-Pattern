using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class SandwitchBuilder
    {
        protected Sandwitch sandwich;
        public abstract void MakeBread();
        public abstract void PrepareBread();
        public abstract void ApplyMeatAndCheese();
        public abstract void ApplyVegetables();
        public Sandwitch GetSandwich()
        {
            return sandwich;
        }

    }
}
