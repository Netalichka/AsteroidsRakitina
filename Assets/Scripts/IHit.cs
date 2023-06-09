using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Observer
{

    public interface IHit 
    {
        event Action<float> OnHitChange;
        void Hit(float damage);
    }
}
