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
        GameObject hudText = Instantiate(hudDamageText); // ������ �ؽ�Ʈ ������Ʈ
        hudText.transform.position = hudPos.position; // ǥ�õ� ��ġ
        hudText.GetComponent<DamageText>().damage = damage; // ������ ����
    }
}
