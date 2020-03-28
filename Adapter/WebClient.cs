using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class WebClient
    {
        IWebRequest webRequester;
        public WebClient(IWebRequest webRequester)
        {
            this.webRequester = webRequester;
        }

        internal IWebRequest IWebRequest
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void DoWork()
        {
              int status  =  webRequester.Request(new object());

        }
    }
}
