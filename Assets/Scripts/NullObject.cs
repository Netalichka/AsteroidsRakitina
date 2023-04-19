using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Observer
{

    public class NullObject : MonoBehaviour
    {
        public event Action Doing = () => { };
        private void Start()
        {
            Doing.Invoke();
        }
    }
}
