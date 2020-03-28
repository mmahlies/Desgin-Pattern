using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class WebAdapter : IWebRequest
    {
        WebServices Service;
        public WebAdapter(WebServices currentServices)
        {
            this.Service = currentServices;
        }

        internal WebServices WebServices
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        // how to deal with service and return int
        public int Request(object objectInput)
        {
            // take objectInput and convert to apropiriate state to deal with services and make appropriate return type

            return int.Parse(Service.GetData());
        }
    }


    interface IWebRequest
    {
        int Request(object objectInput);
    }
}
