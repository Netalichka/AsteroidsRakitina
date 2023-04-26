using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVVM.Model;
using System;

namespace MVVM.ViewModel
{

    public interface IHpViewModel 
    {
       IHpModel HpModel { get; }
        bool IsDead { get; }
        void ApplyDamage(float damage);
        event Action<float> OnHpChange;
    }
}
