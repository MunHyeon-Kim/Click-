using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickEvent : MonoBehaviour
{
    public static int mode = 0;
    public bool isAttackDelay;
    public static float AttackDelayTime = 0.1f;

    public GameObject smith1;
    public GameObject smith2;
    public static int surunsum = 0;
    int temp = 1;

    public void URLButton()
    {
        Application.OpenURL("http://unity3d.com/");
    }



    public void Attacked()
    {
        if ((mode == 0 || mode == 10) && PlayerData.nowHp > 0)
        {
            if (!isAttackDelay)
            {
                isAttackDelay = true;
                 Player.Attack();
                 EnemyController.Attacked();

                 StartCoroutine(AttackDelay());
            }
            else
            {
                Debug.Log("Delay");
            }
        }

        if (mode == 1)
        {
            if (!isAttackDelay)
            {
                isAttackDelay = true;
                Smith.Attack();
                if (temp == 1)
                {
                    smith1.SetActive(false);
                    smith2.SetActive(true);
                    temp = 2;
                }
                else {
                    smith1.SetActive(true);
                    smith2.SetActive(false);
                    temp = 1;
                }
                StartCoroutine(AttackDelay());
            }
            else
            {
                Debug.Log("Delay");
            }

        }

        
    }

    

    public void DamageButton()
    {
        if (mode == 0)
        {
            if (PlayerData.Gold < (1000 + (PlayerData.Damage / 10 - 1) * 100))
                return;

            if (PlayerData.Damage > 999)
                return;
            

            if (PowerBuff.staticTimer && EnemyController.staticTimer)
            {
                PlayerData.Gold -= (1000+(PlayerData.Damage/25-1)*100);
                PlayerData.Damage += 25;
            }
            else if (PowerBuff.staticTimer && !EnemyController.staticTimer)
            {
                PlayerData.Gold -= (1000 + (PlayerData.Damage / 5 - 1) * 100);
                PlayerData.Damage += 5;
            }
            else if (!PowerBuff.staticTimer && EnemyController.staticTimer)
            {
                PlayerData.Gold -= (1000 + (PlayerData.Damage / 5 - 1) * 100);
                PlayerData.Damage += 5;
            } else
            {
                PlayerData.Gold -= (1000 + (PlayerData.Damage - 1) * 100);
                PlayerData.Damage += 1;
            }

            surunsum++;

            
        }
        
    }

    public void HpButton()
    {
        if (PlayerData.HP > 9999)
            return;

        if (mode == 0)
        {
            if (PlayerData.Gold < (1000 + (PlayerData.HP / 10 - 1) * 100))
                return;

            PlayerData.Gold -= (1000 + (PlayerData.HP/10 - 1) * 100);
            PlayerData.HP += 10;
        }
        surunsum++;
    }

    public void RecoveryButton()
    {
        if (PlayerData.recovery > 999)
            return;

        if (mode == 0)
        {
            if (PlayerData.Gold < (1000 + (PlayerData.recovery - 1) * 100))
                return;

            PlayerData.Gold -= (1000 + (PlayerData.recovery - 1) * 100); 
            PlayerData.recovery += 1;
        }
        surunsum++;

    }

    public void CriticalDamageButton()
    {
        if (PlayerData.criticalDamage > 999)
            return;

        if (mode == 0)
        {
            if (PlayerData.Gold < (1000 + (PlayerData.recovery - 1) * 100))
                return;
            

            PlayerData.Gold -= (1000 + (PlayerData.criticalDamage - 1) * 100);
            PlayerData.criticalDamage += 1;
        }
        surunsum++;
    }
    public void CriticalPerCentButton()
    {
        if (mode == 0)
        {
            if (PlayerData.Gold < (1000 + (PlayerData.critical - 1) * 100))
                return;
            if (PlayerData.critical > 999)
                return;

            PlayerData.Gold -= (1000 + (PlayerData.critical - 1) * 100);
            PlayerData.critical += 1;
        }
        surunsum++;
    }


    IEnumerator AttackDelay()
    {
        yield return new WaitForSecondsRealtime(AttackDelayTime);
        isAttackDelay = false;
    }

}

