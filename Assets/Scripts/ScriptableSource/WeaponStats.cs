using UnityEngine;

namespace ScriptableSource
{
    [CreateAssetMenu(fileName = "WeaponStats", menuName = "ScriptableObjects/WeaponStats", order = 1)]
    public class WeaponStats : ScriptableObject
    {
        public float StockDamageArrow { get; } = 10.00f;
        public float UpgradeDamageArrow { get; } = 500.00f;
    }
}
