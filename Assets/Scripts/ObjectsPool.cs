using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPool
{
    public GameObject prefab;
    private List<GameObject> pool;
    private Transform container;
    public bool autoExpand;


    public ObjectsPool(GameObject _prefab, Transform _container, int _size)
    {
        prefab = _prefab;
        container = _container;
        CreatePool(_size);
    }


    private void CreatePool(int _size)
    {
        pool = new List<GameObject>();

        for (int i = 0; i < _size; i++)
            CreateObject();

    }

    private GameObject CreateObject(bool isActive = false)
    {
        GameObject obj = GameObject.Instantiate(prefab, container);
        obj.SetActive(isActive);
        pool.Add(obj);
        return obj;
    }
    
    public bool HasFreeObject(out GameObject _obj)
    {
        foreach (var item in pool)
        {
            if (!item.activeInHierarchy)
            {
                _obj = item;
                item.SetActive(true);
                return true;
            }
        }
        _obj = null;
        return false;
    }

    public GameObject GetFreeGameObject()
    {
        if (HasFreeObject(out GameObject obj))
            return obj;

        if (autoExpand)
            CreateObject(true);
        
        return null;
    }

}
    