using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Adapter
{

    public interface IAttack
    {
        void Attack(Vector3 position);
    }
}
