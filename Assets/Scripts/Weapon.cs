using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Decorator
{

    public class Weapon : IFireDecorator
    {
        private Transform _barrelPosition;
        private IAmmunition _bullet;
        private float _force;
        private AudioClip _audioClip;
        private IAmmunition ammunition;
        private Transform barrelPosition;
        private AudioSource audioSource;
        private AudioClip audioClip;
        private readonly AudioSource _audioSource;

        public Weapon(IAmmunition bullet, Transform barrelPosition, AudioSource audioSource, AudioClip audioClip, float forse)
        {
            _bullet = bullet;
            _barrelPosition = barrelPosition;
            _force = forse;
            _audioSource = audioSource;
            _audioClip = audioClip;

        }

        public Weapon(IAmmunition ammunition, Transform barrelPosition, AudioSource audioSource, AudioClip audioClip)
        {
            this.ammunition = ammunition;
            this.barrelPosition = barrelPosition;
            this.audioSource = audioSource;
            this.audioClip = audioClip;
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrelPosition = barrelPosition;
        }

        public void SetBullet(IAmmunition bullet)
        {
            _bullet = bullet;
        }

        public void SetForce(float force)
        {
            _force = force;
        }

        public void SetAudioClip(AudioClip audioClip)
        {
            _audioClip = audioClip;
        }

        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance, _barrelPosition.position, Quaternion.identity);
            bullet.AddForce(_barrelPosition.forward * _force);
            Object.Destroy(bullet.gameObject, _bullet.TimeToDestroy);
            _audioSource.PlayOneShot(_audioClip);
        }
    }
}
