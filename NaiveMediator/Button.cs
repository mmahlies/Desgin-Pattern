using System;
using System.Collections.Generic;
using System.Text;

namespace NaiveMediator
{
    public class Button : IComponent
    {
        public string Name { get => "submit"; set { } }

        public void Action()
        {
            // check for check box state and do some other logic based on this state
        }
    }
}
