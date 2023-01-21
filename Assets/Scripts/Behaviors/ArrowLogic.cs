using Managers;
using UnityEngine;

namespace Behaviors
{
    [RequireComponent(typeof(Rigidbody))]
    public class ArrowLogic : MonoBehaviour
    {
        private Rigidbody _rigidbody;

        private float _statsDamageArrow;
        private readonly float _speed = 50.00f;

        public float StatsDamageArrow
        {
            set => _statsDamageArrow = value;
        }

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            var vector = new Vector3(0, 0, 1);
            var deltaSpeed = _speed * Time.fixedDeltaTime;
            
            _rigidbody.MovePosition(transform.position + vector * deltaSpeed);
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag($"Enemy"))
                other.gameObject.GetComponent<HealthManager>().DecreaseHealth(_statsDamageArrow);

            gameObject.SetActive(false);
        }

    }
}
