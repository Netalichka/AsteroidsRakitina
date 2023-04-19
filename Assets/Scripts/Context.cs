using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StatePattern
{

    public class Context
    {
        private State _state;
        public Context(State state)
        {
            State = state;
        }

        public State State
        {
            set
            {
                _state = value;
                Debug.Log("State:" + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
