using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Observer
{

    public  class ListenerHit
    {
        public void Add(IHit value)
        {
            value.OnHitChange += ValueOnOnHitChange;

        }

        public void Remove(IHit value)
        {
            value.OnHitChange -= ValueOnOnHitChange;

        }

        private void ValueOnOnHitChange(float damage)
        {
            Debug.Log(damage);
        }
    }
}
