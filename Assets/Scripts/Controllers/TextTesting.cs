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
        GameObject hudText = Instantiate(hudDamageText); // 생성할 텍스트 오브젝트
        hudText.transform.position = new Vector2(1.4f,0.6f); // 표시될 위치
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
