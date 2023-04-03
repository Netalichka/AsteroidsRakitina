using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
{
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Transform _barrel;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private float _force;

        private Camera _camera;
        //private Vector3 _move;

        //private IMove _moveTransform;
        //private IRotation _rotation;

        private Ship _ship;

        private void Start()
        {
            _camera = Camera.main;
           var moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);
        }


        private void Update()
    {
            //var deltaTime = Time.deltaTime;
            //var speed = deltaTime * _speed;
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            //_rotation.Rotation(direction);
            _ship.Rotation(direction);
            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                //if(_moveTransform is AccelerationMove accelerationMove)
                //{
                   _ship.AddAcceleration();
                //}
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                //if (_moveTransform is AccelerationMove accelerationMove)
                //{
                    _ship.RemoveAcceleration();
                //}
            }

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
