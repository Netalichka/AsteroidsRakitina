using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Builder
{

    public class GameObjectPhysicsBuilder : GameObjectBuilder
    {
       public GameObjectPhysicsBuilder(GameObject gameObject) : base(gameObject) { }

        public GameObjectPhysicsBuilder BoxCollider2D()
        {
            GetOrAddComponent<BoxCollider2D>();
            return this;
        }

        public GameObjectPhysicsBuilder Rigidbody2D(float mass)
        {
            var component = GetOrAddComponent<Rigidbody2D>();
            component.mass = mass;
            return this;
        }

        private T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}
