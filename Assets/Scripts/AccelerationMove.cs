using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{


    internal class AccelerationMove : MoveTransform
    {
        private readonly float _acceleration;
        public AccelerationMove(Transform transform, float speed, float acceleration) : base(transform, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}
