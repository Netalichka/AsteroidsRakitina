using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StatePattern
{

    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
           context.State = new ConcreteStateB();
        }
    }
}
