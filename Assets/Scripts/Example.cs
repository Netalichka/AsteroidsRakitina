using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Builder
{

    public class Example : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;
        // Start is called before the first frame update
        private void Start()
        {
            var gameObjectBuilder = new GameObjectBuilder();
            GameObject player = gameObjectBuilder.Visual.Name("Roman").Sprite(_sprite).Physics.Rigidbody2D(5).BoxCollider2D();
        }

    }
}
