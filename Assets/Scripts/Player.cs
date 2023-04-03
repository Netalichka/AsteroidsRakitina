using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
{
        [SerializeField] private float _speed;
        [SerializeField] private float _hp;
        [SerializeField] private Transform _barrel;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private float _force;
        //private Vector3 _move;

        private MoveTransform _moveTransform;

        private void Start()
        {
            _moveTransform = new MoveTransform(transform, _speed);
        }


        void Update()
    {
            //var deltaTime = Time.deltaTime;
            //var speed = deltaTime * _speed;
            _moveTransform.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * Time.deltaTime);

            //transform.localPosition += _move;

            if (Input.GetButtonDown("Fire1"))
            {
                var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
                temAmmunition.AddForce(_barrel.up * _force);

            }

    }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
           
            }
            else
            {
                _hp--;
            }

        }

    }
}