using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{

    internal sealed class AsteroidFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Enemy_Asteroid>("Enemies/Enemy_Asteroid"));
            enemy.DependencyInjectHealth(hp);
            return enemy;
        }
    }
}
