using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{

    public interface IDealingDamage 
    {
        void Visit(EnemyVisitor hit, InfoCollision info);
        void Visit(Enviroment hit, InfoCollision info);
        void Visit(Knight hit, InfoCollision info);
    }
}
