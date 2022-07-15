using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageText2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hudDamageText;
    public Transform hudPos;


    public void TakeDamage(int damage)
    {
        GameObject hudText = Instantiate(hudDamageText); // 생성할 텍스트 오브젝트
        hudText.transform.position = hudPos.position; // 표시될 위치
        hudText.GetComponent<DamageText>().damage = damage; // 데미지 전달
    }
}
