using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public  class SandwitchMaker
    {
        private SandwitchBuilder sandwitchBuilder;
        public SandwitchMaker(SandwitchBuilder sandwitchBuilder)
        {
            this.sandwitchBuilder = sandwitchBuilder;
        }

        public  void CreateSandWitch(){

            sandwitchBuilder.ApplyVegetables();
            sandwitchBuilder.ApplyMeatAndCheese();
            /// specific process
        }

        public  Sandwitch GetSandWitch()
        {
            return sandwitchBuilder.GetSandwich();
        }
    }
}
