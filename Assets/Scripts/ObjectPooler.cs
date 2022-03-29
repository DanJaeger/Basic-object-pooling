using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;

    [SerializeField] GameObject objectToPool;
    [SerializeField] int amountToPool;

    List<GameObject> pooledObjects;
    private void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        for(int i=0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
