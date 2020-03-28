using System;
using System.Collections.Generic;
using System.Text;

namespace NaiveMediator
{
    class CheckBox : IComponent
    {
        public string Name { get => "CheckBox"; set { } }

        public void Action()
        {
            // show hide some other element and be coubled to those element
        }
    }
}
