using UnityEngine;

namespace Behaviors
{
    [RequireComponent(typeof(Rigidbody))]
    public class EnemyAI : MonoBehaviour
    {
        private Transform _transform;

        public float speed = 5.00f;
        
        [SerializeField] private Vector3 pointA;
        [SerializeField] private Vector3 pointB;

        private void Update()
        {
            //PingPong between 0 and 1
            var time = Mathf.PingPong(Time.time * speed, 1);
            transform.position = Vector3.Lerp(pointA, pointB, time);
        }
    }
}
