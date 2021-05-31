using System;
using System.Collections.Generic;
using System.Text;

namespace GOF.FluentBuilder.interfaces
{
   public interface IMakeDoor
    {
        IProduceMaze MakeDoor(int r1No, int r2No);
    }
}
