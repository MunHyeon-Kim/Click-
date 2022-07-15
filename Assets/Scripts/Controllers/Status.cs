using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Status : MonoBehaviour
{
    //최대대미지 체력 회복력 크확 크뎀 현재 칭호 닉네임 사용중인 무기
    [SerializeField]
    Text Nick;
    [SerializeField]
    Text Max;
    [SerializeField]
    Text HP;
    [SerializeField]
    Text recovery;
    [SerializeField]
    Text CriticalP;
    [SerializeField]
    Text CriticalD;
    [SerializeField]
    Text Stage;
    [SerializeField]
    Text Weapon;

    public void status()
    {
        PlayerData.TotalDamage = PlayerData.Damage * (long)((PlayerData.criticalDamage * 10) / 10) * PlayerData.WeaponDamage;
        //Nick.text = $"{PlayerData.NickName}";
        Stage.text = $" {EnemyController.MaxEnemy}";
        Max.text = $" {PlayerData.TotalDamage}";
        HP.text = $"{PlayerData.HP}";
        recovery.text = $" {PlayerData.recovery}";
        CriticalP.text = $"{PlayerData.critical/10}%";
        CriticalD.text = $" {PlayerData.criticalDamage/10}배";

    }
    
}
