using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StatePattern
{

    public abstract class State 
    {
        public abstract void Handle(Context context);
    }
}
