using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StatePattern
{

    public class StateTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }

        
    }
}
