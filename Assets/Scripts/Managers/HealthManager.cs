using Behaviors;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    public class HealthManager : MonoBehaviour
    {
        [SerializeField] private float healthMax = 100.00f;
        private float _currentHealth;
        
        [SerializeField] private Image healthBarSprite;
        [SerializeField] private Wallet wallet;

        private void Start()
        {
            _currentHealth = healthMax;
            UpdateHealthBar();
        }

        private void Update()
        {
            UpdateHealthBar();
            
            if (_currentHealth <= 0)
                DestroyOnZeroHealth();
        }

        private void UpdateHealthBar()
        {
            healthBarSprite.fillAmount = _currentHealth / healthMax;
        }

        public void DecreaseHealth(float amount)
        {
            _currentHealth -= amount;
        }

        private void DestroyOnZeroHealth()
        {
            wallet.AddGold(350.00f);
            Destroy(gameObject);
        }
    }
}
