using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServices webServices = new WebServices();
            IWebRequest request = new WebAdapter(webServices);
            WebClient client = new WebClient(request);
            client.DoWork();

        }
    }
}
