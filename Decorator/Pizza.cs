﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Pizza
    {
        public int Price { get; set; }
        public abstract decimal GetPrice();
    }
}
