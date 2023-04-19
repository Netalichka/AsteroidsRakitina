using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StatePattern
{

    public class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
