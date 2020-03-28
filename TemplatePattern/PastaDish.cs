using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    abstract class PastaDish
    {
        public  void MakeARecipe() {
            BoilWater();
            AddPasta();
            ServeTheDish();
        }

        public  void ServeTheDish()
        {
            Console.WriteLine("serve the dish");
        }

        public abstract void AddPasta();

        public void BoilWater() {
            Console.WriteLine("boil water");
        }
    }       
}
