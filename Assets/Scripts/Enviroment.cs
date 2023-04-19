using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{

    public class Enviroment : HitVisitor
    {
        public override void Activate(IDealingDamage value, float damage)
        {
            value.Visit(this, new InfoCollision(damage));
        }
    }
}
