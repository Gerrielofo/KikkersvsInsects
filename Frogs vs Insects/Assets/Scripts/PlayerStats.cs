using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int money;
    public int startMoney = 500;

    public static int Lives;
    public int startLives = 50;

    public static int Rounds;
    private void Start()
    {
        Lives = startLives;
        money = startMoney;

        Rounds = 0;
    }
}
