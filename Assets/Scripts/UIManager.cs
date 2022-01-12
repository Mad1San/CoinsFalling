using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    [SerializeField] private Text _balanceTxt;
    [SerializeField] private GameController gameContr;


    void Start()    
    {
        UpdateLabel();
    }

    public void OnSpawnButtonClick()
    {
        Balance.ReduceBalance();
        UpdateLabel();
        gameContr.CreateCoin();
    }

    void UpdateLabel()
    {
        _balanceTxt.text = Balance.GetBalance().ToString();
    }


}
