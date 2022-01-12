using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private string chestTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(chestTag))
        {
            gameObject.SetActive(false);
        }
    }

}




