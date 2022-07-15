using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int g = 0;
    public Text g1;
    Text g2;
    Text g3;
    Text g4;

    private void Start()
    {
        if (g == 1)
        {
            if (ClickEvent.surunsum < 50)
            {
                g1.text = "골드 구입\n240 다이아 : 132500골드";
            }
            else
            {
                g1.text = $"골드 구입\n240 다이아 : {100 * (long)Math.Pow(2, EnemyController.MaxEnemy - 1)}골드";
            }
        }
        
    }

    public void Gold240()
    {
        if (PlayerData.Diamond <= 239)
            return;

        if (ClickEvent.surunsum < 50)
        {
            g1.text = "골드 구입\n240 다이아 : 132500골드";
            PlayerData.Diamond -= 240;
            PlayerData.Gold += 132500;
        }
        else {
            g1.text = $"골드 구입\n240 다이아 : {100 * (long)Math.Pow(2, EnemyController.MaxEnemy - 1)}골드";
            PlayerData.Gold += 100 * (long)Math.Pow(2, EnemyController.MaxEnemy - 1);
        }
         
    }

    /*public void Gold120()
    {
        if (PlayerData.Diamond <= 4)
            return;

        if (ClickEvent.surunsum < 50)
        {
            g2.text = "골드 구입\n240 다이아 : 180만골드";
            PlayerData.Diamond -= 120;
            PlayerData.Gold += 1800000;
        }
        else
        {
            g2.text = $"골드 구입\n240 다이아 : {50 * (long)Math.Pow(2, EnemyController.MaxEnemy - 1)}골드";
            PlayerData.Gold += 50 * (long)Math.Pow(2, EnemyController.MaxEnemy - 1);
        }

    }
    public void Gold40()
    {
        if (PlayerData.Diamond <= 4)
            return;

        if (ClickEvent.surunsum < 50)
        {
            g2.text = "골드 구입\n240 다이아 : 6만골드";
            PlayerData.Diamond -= 120;
            PlayerData.Gold += 60000;
        }
        else
        {
            g2.text = $"골드 구입\n240 다이아 : {50 * (long)Math.Pow(2, EnemyController.MaxEnemy - 1)}골드";
            PlayerData.Gold += 50 * (long)Math.Pow(2, EnemyController.MaxEnemy - 1);
        }

    }*/



    public void DiaMond()
    {
        //결제 완료되면
        PlayerData.Diamond += 240;
    }

    public void DiaMond2()
    {
        //결제 완료되면
        PlayerData.Diamond += 756;
    }
    public void DiaMond3()
    {
        //결제 완료되면
        PlayerData.Diamond += 1320;
    }
    public void DiaMond4()
    {
        //결제 완료되면
        PlayerData.Diamond += 2760;
    }
}
