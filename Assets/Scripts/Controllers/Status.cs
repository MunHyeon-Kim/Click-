using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Status : MonoBehaviour
{
    //�ִ����� ü�� ȸ���� ũȮ ũ�� ���� Īȣ �г��� ������� ����
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
        CriticalD.text = $" {PlayerData.criticalDamage/10}��";

    }
    
}
