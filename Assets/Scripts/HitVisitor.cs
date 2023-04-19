using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{

    public abstract class HitVisitor : MonoBehaviour
    {
        public float Health;
        public TextMesh TextMesh;
        public abstract void Activate(IDealingDamage value, float damage);
    }
}
