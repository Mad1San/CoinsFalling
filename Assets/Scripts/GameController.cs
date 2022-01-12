using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject _spawnPoint;
    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private int poolSize = 10;

    private ObjectsPool pool;
    void Start()
    {
        pool = new ObjectsPool(_coinPrefab, _spawnPoint.transform, poolSize);
        pool.autoExpand = true;
    }

    public void CreateCoin()
    {
        GameObject coin = pool.GetFreeGameObject();
        if (coin == null)
            return; 

        coin.GetComponent<Rigidbody>().velocity = Vector3.zero;
        coin.transform.position = _spawnPoint.transform.position;
    }
}
