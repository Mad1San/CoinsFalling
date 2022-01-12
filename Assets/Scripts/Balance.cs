using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    private static int maxBalance = 30;
    private static int balance = 30;

    public static void ReduceBalance(int amount = 1)
    {
        balance = balance == 1 ? maxBalance : balance - amount;
    }

    public static int GetBalance()
    {
        return balance;
    }
}
