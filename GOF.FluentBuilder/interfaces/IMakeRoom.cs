using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.FluentBuilder.interfaces
{
   public interface IMakeRoom
    {
        IMakeDoor MakeRoom(int n);


    }
}
