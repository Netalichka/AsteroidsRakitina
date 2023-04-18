using System.Collections;
using System.Collections.Generic;

namespace Asteroids.Chain_of_Responsibility
{

    public class EnemyChain 
    {
        public string Name;
        public int Attack;
        public int Defense;

        public EnemyChain(string name, int attack, int defense)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
        }
    }
}
