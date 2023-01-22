using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class ObjectPool : MonoBehaviour
    {
        public static ObjectPool instance;

        private readonly List<GameObject> _pooledObjects = new();
        [SerializeField] private int amountOfPool = 20;
        [SerializeField] private GameObject bulletPrefab;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        private void Start()
        {
            for (var i = 0; i < amountOfPool; i++)
            {
                var obj = Instantiate(bulletPrefab);
                obj.SetActive(false);
                _pooledObjects.Add(obj);
            }
        }

        public GameObject GetPooledObject()
        {
            foreach (var objectInPool in _pooledObjects)
            {
                if (!objectInPool.activeInHierarchy)
                    return objectInPool;
            }

            return null;
        }

        public void UpdatePool()
        {
            
        }
    }
}
