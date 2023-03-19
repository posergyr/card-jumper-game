using Managers;
using ScriptableSource;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace Behaviors
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(Movement))]
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private InputManager inputManager;
        [SerializeField] private WeaponStats stats;
        
        private GameObject _projectile;
        private Movement _movement;
        
        private Vector3 _offset;

        private bool _turnedRight;
        private bool _upgraded;
        
        private void OnEnable()
        {
            inputManager.ShootTheArrow += ShootTheArrow;
        }

        private void OnDisable()
        {
            inputManager.ShootTheArrow -= ShootTheArrow;
        }

        private void Start()
        {
            _movement = gameObject.GetComponent<Movement>();
        }

        private void Update()
        {
            OffsetFlip();
        }

        private void OffsetFlip()
        {
            if (_movement.InputVectorX < 0)
            {
                _offset = new Vector3(-2.00f, 0.00f, 0.00f);
                _turnedRight = true;
            }
            else if (_movement.InputVectorX > 0)
            {
                _offset = new Vector3(2.00f, 0.00f, 0.00f);
                _turnedRight = false;
            }
        }

        private void ShootTheArrow()
        {
            _projectile = ObjectPool.instance.GetPooledObject();

            if (_projectile != null)
            {
                var stockDamage = stats.UpgradeDamageArrow;
                var upgradedDamage = stats.StockDamageArrow;

                var turnedRight = _projectile.gameObject.GetComponent<ProjectileLogic>();
                
                _projectile.transform.position = transform.position + _offset;
                _projectile.SetActive(true);
                
                turnedRight.StatsDamageArrow = _upgraded ? stockDamage : upgradedDamage;
                turnedRight.TurnedRight = _turnedRight;
            }
        }
        
        public void StatsModifier()
        {
            _upgraded = true;
        }
    }
}
