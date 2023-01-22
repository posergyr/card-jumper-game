using System.Collections;
using Interfaces;
using UnityEngine;

namespace Behaviors
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class ArrowLogic : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2d;

        private float _statsDamageArrow;
        private readonly float _speed = 50.00f;
        
        [SerializeField] private float lifeTime = 2.00f;

        public float StatsDamageArrow
        {
            set => _statsDamageArrow = value;
        }

        private void Start()
        {
            _rigidbody2d = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            var vector = new Vector3(1, 0, 0);
            var deltaSpeed = _speed * Time.fixedDeltaTime;

            _rigidbody2d.MovePosition(transform.position + vector * deltaSpeed);

            if (gameObject.activeSelf)
                StartCoroutine(WaitAndDestroy(lifeTime));
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out IDamageable damageable))
                damageable.Damage(_statsDamageArrow);
            
            gameObject.SetActive(false);
        }

        private IEnumerator WaitAndDestroy(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            gameObject.SetActive(false);
        }
    }
}
