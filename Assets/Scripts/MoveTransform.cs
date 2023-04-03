using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
internal sealed class MoveTransform : MonoBehaviour
{
        private readonly Transform _transform;
        private readonly float _speed;
        private Vector3 _move;

        private MoveTransform(Transform transform, float speed)
        {
            _transform = transform;
            _speed = speed;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * _speed;
            _move.Set(horizontal * speed, vertical * speed, 0.0f);
            _transform.localPosition += _move;
        }


}
}

