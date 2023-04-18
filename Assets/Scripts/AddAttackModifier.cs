using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Chain_of_Responsibility
{

    public class AddAttackModifier : EnemyModifier

    {
        private readonly int _attack;
        public AddAttackModifier(EnemyChain enemyChain, int attack) : base(enemyChain)
        {
            _attack = attack;
        }

        public override void Handle()
        {
            _enemyChain.Attack += _attack;
            base.Handle();
            
        }
    }
}
