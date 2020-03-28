using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer
{
    interface IObserver
    {       
        void Update(Stock stock);
    }
}
