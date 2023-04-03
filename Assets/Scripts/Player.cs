using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        //private Vector3 _move;

        private IMove _moveTransform;

        private void Start()
        {
            _moveTransform = new AccelerationMove(transform, _speed, _acceleration);
        }


        private void Update()
    {
            //var deltaTime = Time.deltaTime;
            //var speed = deltaTime * _speed;
            _moveTransform.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical") * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if(_moveTransform is AccelerationMove accelerationMove)
                {
                    accelerationMove.AddAcceleration();
                }
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                if (_moveTransform is AccelerationMove accelerationMove)
                {
                    accelerationMove.RemoveAcceleration();
                }
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
