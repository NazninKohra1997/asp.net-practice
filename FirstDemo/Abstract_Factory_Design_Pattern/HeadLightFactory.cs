﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Design_Pattern
{
   public abstract class HeadLightFactory
    {
        public abstract IHeadLight Create();
    }
}
