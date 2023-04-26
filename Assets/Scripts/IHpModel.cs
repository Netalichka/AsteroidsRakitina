using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVVM.Model
{

    public interface IHpModel
    {
        float MaxHp { get; }
        float CurrentHp { get; set; }
    }
}
