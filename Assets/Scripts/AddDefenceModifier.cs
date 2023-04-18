using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Chain_of_Responsibility
{

    public class AddDefenceModifier : EnemyModifier
    {
        private readonly int _maxDefense;

        public AddDefenceModifier(EnemyChain enemyChain, int maxDefense) : base(enemyChain)
        {
            _maxDefense = maxDefense;
        }

        public override void Handle()
        {
            if(_enemyChain.Defense <= _maxDefense)
            {
                _enemyChain.Defense++;
            }
            base.Handle();
        }
    }
}
