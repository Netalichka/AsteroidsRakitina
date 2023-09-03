using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace MVVM.Model
{

    public interface IHpModel
    {
        float MaxHp { get; }
        float CurrentHp { get; set; }
    }
}
