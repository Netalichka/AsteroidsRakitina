using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Observer
{

    public class ObserverTest : MonoBehaviour
    {
        public EnemyObserver enemyObserver;
        public float Damage;
        private Camera _mainCamera;
        private float _dedicateDistance = 20.0f;

        private void Start()
        {
            _mainCamera = Camera.main;
            var listenerHit = new ListenerHit();
            listenerHit.Add(enemyObserver);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out var hit, _dedicateDistance))
                {
                    if(hit.collider.TryGetComponent<IHit>(out var enemyObserver))
                    {
                        enemyObserver.Hit(Damage);
                    }
                }
            }
        }
    }
}
