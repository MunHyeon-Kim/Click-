using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class 파워업적 : MonoBehaviour
{
    public static int power = 1;
    public Text Text;

    public static int HP = 1;
    public Text Text2;

    public static int Critical = 1;
    public Text Text3;

    public static int Recovery = 1;
    public Text Text4;

    public static int Stage = 1;
    public Text Text5;

    public static int EnemyCounter = 1;
    public Text Text6;


    public void Chapter()
    {
        if (Stage * 8 <= EnemyController.MaxEnemy)
        {
            Stage++;
            PlayerData.Diamond += 8;

        }

        Text5.text = $"{Stage}챕터 클리어";
    }

    public void powerButtonClick()
    {
        if (power * 10 <= PlayerData.Damage)
        {
            power ++;
            PlayerData.Diamond += 2;

        }

        Text.text = $"파워 {power * 10} 달성";
    }


    public void HPButtonClick()
    {
        if (HP * 10 <= PlayerData.HP)
        {
            HP++;
            PlayerData.Diamond += 2;

        }

        Text2.text = $"체력 {HP * 10} 달성";
    }

    public void CriticalButtonClick()
    {
        if (Critical * 10 <= PlayerData.criticalDamage)
        {
            Critical++;
            PlayerData.Diamond += 2;

        }

        Text3.text = $"  치명타파워 {Critical * 10} 달성";
    }

    public void RecoveryButtonClick()
    {
        if (Recovery * 10 <= PlayerData.recovery)
        {
            Recovery++;
            PlayerData.Diamond += 2;

        }

        Text4.text = $"회복력 { Recovery * 10 } 달성";
    }

    public void CounterButton()
    {
        if (EnemyCounter * 300 <= EnemyController.EnemyCounter)
        {
            EnemyCounter++;
            PlayerData.Diamond += 10;

        }

        Text6.text = $"몬스터사냥 { EnemyCounter * 300 } 달성";
    }

}
