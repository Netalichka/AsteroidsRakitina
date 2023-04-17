using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Decorator
{

    public class ExampleDecorator : MonoBehaviour
    {
        private IFireDecorator _fire;
        [Header("Start Gun")]
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip _audioClip;

        private void Start()
        {
            IAmmunition ammunition = new Bullet(_bullet, 3.0f);
            _fire = new Weapon(ammunition, _barrelPosition,_audioSource, _audioClip, 999.0f);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fire.Fire();
            }
        }
    }
}
