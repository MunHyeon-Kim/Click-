using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTesting : MonoBehaviour
{

    public GameObject hudDamageText;
    public Transform hudPos;
    public static bool isAttacked = false;

    public void TakeDamage()
    {
        GameObject hudText = Instantiate(hudDamageText); // ������ �ؽ�Ʈ ������Ʈ
        hudText.transform.position = new Vector2(1.4f,0.6f); // ǥ�õ� ��ġ
        isAttacked = false;
    }



    

    // Update is called once per frame
    void Update()
    {
        if (isAttacked == true)
        {
            TakeDamage();
        }
    }

}
