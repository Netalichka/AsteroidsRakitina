using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{

    public class Knight : HitVisitor
    {
        public float Armor;
        public override void Activate(IDealingDamage value, float damage)
        {
            value.Visit(this, new InfoCollision(damage));
        }
    }
}
