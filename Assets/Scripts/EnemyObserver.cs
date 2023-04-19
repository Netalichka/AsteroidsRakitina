using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Observer
{



    public class EnemyObserver : MonoBehaviour, IHit
    {
        public event Action<float> OnHitChange = delegate (float f) { };
        public void Hit(float damage)
        {
            OnHitChange.Invoke(damage);
        }
    }
}
