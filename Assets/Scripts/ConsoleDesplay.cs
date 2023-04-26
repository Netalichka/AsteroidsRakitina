using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Visitor
{

    public class ConsoleDesplay :IDealingDamage
    {
        public void Visit(EnemyVisitor hit, InfoCollision info)
        {
            Debug.Log($"{nameof(EnemyVisitor)} - {info.Damage}");
        }

        public void Visit(Enviroment hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Enviroment)} - {info.Damage}");
        }

        public void Visit(Knight hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Knight)} - {info.Damage}");
        }
    }
}
