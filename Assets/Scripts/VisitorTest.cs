using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace Visitor
{

    public class VisitorTest : MonoBehaviour
    {
        public float Damage;
        private Camera _mainCamera;
        private float _dedicateDistance = 20.0f;

        private void Start()
        {
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out var hit, _dedicateDistance))
                {
                    if(hit.collider.TryGetComponent<HitVisitor>(out var damage))
                    {
                        damage.Activate(new ConsoleDesplay(), Damage);
                        damage.Activate(new ApplayDamage(), Damage);
                    }
                }
            }
        }
    }
}
