using System;
using System.Collections.Generic;
using System.Text;

namespace NaiveMediator
{
   public interface IComponent
    {
         String Name { get; set; }
         void Action();
    }
}
