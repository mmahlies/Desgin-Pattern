using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// The 'Director' part of the Builder design pattern. It uses a SandwitchBuilder to construct a Sandwich.
    /// </summary>
    public  class SandwitchMaker
    {
        private SandwitchBuilder sandwitchBuilder;
        /// <summary>
        /// Initializes a new instance of the <see cref="SandwitchMaker"/> class.
        /// </summary>
        /// <param name="sandwitchBuilder">The SandwitchBuilder that will be used to construct the Sandwich.</param>
        public SandwitchMaker(SandwitchBuilder sandwitchBuilder)
        {
            this.sandwitchBuilder = sandwitchBuilder;
        }

        public  void CreateSandWitch(){
        /// <summary>
        /// Uses the methods of the SandwitchBuilder to construct a Sandwich.
        /// </summary>
        public  void CreateSandWitch(){
            sandwitchBuilder.ApplyVegetables();
            sandwitchBuilder.ApplyMeatAndCheese();
            /// specific process
        }

        /// <summary>
        /// Returns the Sandwich object that has been constructed by the SandwitchBuilder.
        /// </summary>
        /// <returns>The constructed Sandwich.</returns>
        public  Sandwitch GetSandWitch()
        {
            return sandwitchBuilder.GetSandwich();
        }
    }
}
