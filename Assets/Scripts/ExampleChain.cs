using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Chain_of_Responsibility
{

    public class ExampleChain : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            var asteroid = new EnemyChain("Enemy_Asteroid", 1, 1);

            var root = new EnemyModifier(asteroid);
            root.Add(new AddAttackModifier(asteroid, 5));
            root.Add(new AddAttackModifier(asteroid, 10));
            root.Add(new AddDefenceModifier(asteroid, 100));
            root.Handle();
        }

        
    }
}
