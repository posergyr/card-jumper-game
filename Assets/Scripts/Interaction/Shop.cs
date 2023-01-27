using Behaviors;
using Managers;
using UnityEngine;
using ScriptableSource;
using UnityEngine.Serialization;

namespace Interaction
{
    public class Shop : MonoBehaviour
    {
        [SerializeField] private InputManager inputManager;
        [SerializeField] private Wallet playersWallet;
        [FormerlySerializedAs("attackGun")] [SerializeField] private Weapon weapon;

        private void OnEnable()
        {
            inputManager.BuyUpgrade += BuyUpgrade;
        }
        
        private void OnDisable()
        {
            inputManager.BuyUpgrade -= BuyUpgrade;
        }

        private void BuyUpgrade()
        {
            if (playersWallet.CurrencyGold >= 1000.00f)
            {
                playersWallet.DeleteGold(1000.00f);
                weapon.StatsModifier();
            }
            else
                Debug.Log("Not enough money!");
        }
    }
}
