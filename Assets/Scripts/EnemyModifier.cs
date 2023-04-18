using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Chain_of_Responsibility
{

    public class EnemyModifier 
    {
        protected EnemyChain _enemyChain;
        protected EnemyModifier Next;

        public EnemyModifier(EnemyChain enemyChain)
        {
            _enemyChain = enemyChain;
        }

        public void Add(EnemyModifier cm)
        {
            if(Next != null)
            {
                Next.Add(cm);
            }

            else
            {
                Next = cm;
            }
        }

        public virtual void Handle() => Next?.Handle();
    }
}
