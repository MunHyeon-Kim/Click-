using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class Enemy1 : MonoBehaviour
{
    [SerializeField]
    private long _Hp = 10;
    [SerializeField]
    private long _Eteru = 100;

    [SerializeField]
    public static long _Damage = 100;

    public static int Number;

    //EnemyController EC = EnemyController.Instance;


    public void SetEnemy() {


        for (int i = 1; i < 100; i++)
        {
            if (EnemyController.currentEnemy == i)
            {
                EnemyController.Hp = _Hp * (long)Math.Pow(2,i-1);

                EnemyController.Damage = (long)Math.Pow(2, i - 1);
                EnemyController.Eteru = _Eteru * (long)Math.Pow(2, i - 1); 
                EnemyController.MaxHp = EnemyController.Hp;
            }
        }


    }

    public static double MyPow(double to1, int to2)
    {
        double num = 1;
        for (int i = 0; i < to2; i++)
        {
            num = num * to1;
        }
        return num;
    }


    void Start()
    {
        SetEnemy();
    }


}
