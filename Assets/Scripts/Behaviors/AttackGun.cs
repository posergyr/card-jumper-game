using Managers;
using ScriptableSource;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

namespace Behaviors
{
    public class AttackGun : MonoBehaviour
    {
        [SerializeField] private InputManager inputManager;
        [SerializeField] private WeaponStats stats;

        private GameObject _bullet;
        
        private float _arrowLogic;
        private bool _upgraded;
        
        private void OnEnable()
        {
            inputManager.ShootTheArrow += ShootTheArrow;
        }

        private void OnDisable()
        {
            inputManager.ShootTheArrow -= ShootTheArrow;
        }

        private void ShootTheArrow()
        {
            _bullet = ObjectPool.instance.GetPooledObject();

            if (_bullet != null)
            {
                var stockDamage = stats.UpgradeDamageArrow;
                var upgradedDamage = stats.StockDamageArrow;
                var vectorForward = new Vector3(2.5f, 0, 0);

                _bullet.transform.position = transform.position + vectorForward;
                _bullet.SetActive(true);
                
                _bullet.gameObject.GetComponent<ArrowLogic>().StatsDamageArrow 
                    = _upgraded ? stockDamage : upgradedDamage;
            }
        }
        
        public void StatsModifier()
        {
            _upgraded = true;
        }
        
    }
}
