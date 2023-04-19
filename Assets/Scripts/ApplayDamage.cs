using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{

    public class ApplayDamage : IDealingDamage
    {
        public void Visit(EnemyVisitor hit, InfoCollision info)
        {
            hit.Health -= info.Damage;
            hit.TextMesh.text = hit.Health.ToString();
        }

        public void Visit(Enviroment hit, InfoCollision info)
        {

        }

        public void Visit(Knight hit, InfoCollision info)
        {
            var armor = hit.Armor;

            armor -= info.Damage; ;
            hit.TextMesh.text = hit.Health.ToString();
        }
    }
}
