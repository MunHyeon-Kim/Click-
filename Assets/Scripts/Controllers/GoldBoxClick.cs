using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBoxClick : MonoBehaviour
{
    private GameObject target;

    private string name = "GoldBox(Clone)";

    void FixedUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {

            CastRay();

            if (target != null)
            {
                Debug.Log($"Target : {target.name}");
                if (target.name == name)
                {  //Ÿ�� ������Ʈ�� ��ũ��Ʈ�� ���� ������Ʈ���

                    // ���⿡ ������ �ڵ带 �����ϴ�.

                    PlayerData.Gold += 1000;

                    Destroy(target);


                }
            }
            

            

        }

    }

    void CastRay() // ���� ��Ʈó�� �κ�.  ���̸� ���� ó���մϴ�. 

    {

        target = null;



        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);



        if (hit.collider != null)
        { //��Ʈ�Ǿ��ٸ� ���⼭ ����

            //Debug.Log (hit.collider.name);  //�� �κ��� Ȱ��ȭ �ϸ�, ���õ� ������Ʈ�� �̸��� ���� ���ɴϴ�. 

            target = hit.collider.gameObject;  //��Ʈ �� ���� ������Ʈ�� Ÿ������ ����

        }

    }
}
