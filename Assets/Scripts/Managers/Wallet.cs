using System;
using System.Globalization;
using TMPro;
using UnityEngine;

namespace Managers
{
    public class Wallet : MonoBehaviour
    {
        private float _currencyGold;
        [SerializeField] private TextMeshProUGUI currencyUI;

        public float CurrencyGold => _currencyGold;
        
        private void Start()
        {
            currencyUI = currencyUI.GetComponent<TextMeshProUGUI>();
            ShowGoldInUI();
        }
        
        private void Update()
        {
            _currencyGold = (float)Math.Round(_currencyGold);
        }

        private void ShowGoldInUI()
        {
            currencyUI.text = _currencyGold.ToString(CultureInfo.InvariantCulture);
        }

        public void AddGold(float amount)
        {
            _currencyGold += amount;
            ShowGoldInUI();
        }

        public void DeleteGold(float amount)
        {
            if (_currencyGold >= amount)
            {
                _currencyGold -= amount;
                ShowGoldInUI();
            }
            else
                Debug.Log("Not enough money!");
        }
    }
}
