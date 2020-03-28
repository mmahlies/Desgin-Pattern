using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class SpaghittiDish : PastaDish
    {
        public override void AddPasta()
        {
            // add specific component
            Console.WriteLine("SpaghittiDish pasta");
        }
    }
}
