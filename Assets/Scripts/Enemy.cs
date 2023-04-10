using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{

internal abstract class Enemy : MonoBehaviour
{
        public Health Health( get: private set;)
        public static Enemy_Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Enemy_Asteroid>("Enemy/Enemy_Asteroid"));
            enemy.Health = hp;
            return enemy;
        }
}
}

