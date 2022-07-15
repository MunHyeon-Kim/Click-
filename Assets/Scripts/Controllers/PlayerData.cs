using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public static long TotalDamage;

    public Text DamageText;
    public Text GoldText;
    public Text DiaMondText;

    public static long nomalDamage;
    public static long Damage ;
    public static long Damage2;

    public static long nowHp;
    public static long HP;//체력
    public static float critical;//치명
    public static float criticalDamage;//치명댐
    public static int recovery;//회복
    public static long WeaponDamage = 100;
    private bool isAttackDelay = false;

    public static float Gold;
    public static float shield;
    public static float Diamond;

    public Text Gold1;
    public Text Gold2;
    public Text Gold3;
    public Text Gold4;
    public Text Gold5;

    public static string NickName = "후링이";

    public static float piberGage;

    public static void SetNickName(string Name)
    {
        NickName = Name;
    }

    void Start()
    {
        StartCoroutine(Delay());
        Damage = 1;
        //Damage = DataController.Instance.gameData.Damage;
        Gold = DataController.Instance.gameData.Gold;
        shield = DataController.Instance.gameData.shield;
        recovery = DataController.Instance.gameData.recovery;
        critical = DataController.Instance.gameData.critical;
        Diamond = DataController.Instance.gameData.Diamond;
        if (HP < 10)
            HP = 10;
        nowHp = HP;
        if (recovery < 1)
            recovery = 1;
        if (Damage < 1)
            Damage = 1;
        if (critical < 1)
            critical = 1;
        if (criticalDamage < 1)
            criticalDamage = 1;
    }

    
    void Update()
    {
        GoldText.text = $"{Gold}";
        DiaMondText.text = $"{Diamond}";
        DamageText.text = $"{Damage}";
        Gold1.text = $"공격력 수련 : {(1000 + (PlayerData.Damage - 1) * 100)}";
        Gold2.text = $"체력수련 : {(1000 + (PlayerData.HP / 10 - 1) * 100)}";
        Gold3.text = $"회복력 수련 : {(1000 + (PlayerData.recovery - 1) * 100)}";
        Gold4.text = $"치명타 데미지 : {(1000 + (PlayerData.criticalDamage - 1) * 100)}";
        Gold5.text = $"치명타 확률 : {(1000 + (PlayerData.critical - 1) * 100)}";

    }

    void Recovery()
    {
        
            if (nowHp < HP)
            {
                nowHp += recovery;

            }
            else
            {
                nowHp = HP;
            }
    
    }


    IEnumerator Delay()
    {
        while (true)
        {
            Recovery();

            yield return new WaitForSecondsRealtime(1f);
        }
        
        
    }
}
