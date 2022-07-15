using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    int on = 0;

    public GameObject inventory;
    public GameObject FSword;
    public GameObject F2Sword;
    public GameObject DSword;
    public GameObject D2Sword;
    public GameObject CSword;
    public GameObject C2Sword;
    public GameObject BSword;
    public GameObject B2Sword;
    public GameObject ASword;
    public GameObject SSword;
    public GameObject LSword;

    public GameObject ins;

    public static int SwordRank;

    public void inventoryset() {
        int length = Smith.LRankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.l++;
            Smith.LRankSword--;
            ins = GameObject.Instantiate(LSword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.SRankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.s++;
            Smith.SRankSword--;
            ins = GameObject.Instantiate(SSword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.ARankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.a++;
            Smith.ARankSword--;
            ins = GameObject.Instantiate(ASword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.B2RankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.b2++;
            Smith.B2RankSword--;
            ins = GameObject.Instantiate(B2Sword);
            ins.transform.parent = inventory.transform;
        }
        length = Smith.BRankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.b1++;
            Smith.BRankSword--;
            ins = GameObject.Instantiate(BSword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.C2RankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.c2++;
            Smith.C2RankSword--;
            ins = GameObject.Instantiate(C2Sword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.CRankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.c1++;
            Smith.CRankSword--;
            ins = GameObject.Instantiate(CSword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.D2RankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.d2++;
            Smith.D2RankSword--;
            ins = GameObject.Instantiate(D2Sword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.DRankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.d1++;
            Smith.DRankSword--;
            ins = GameObject.Instantiate(DSword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.FRankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.f1++;
            Smith.FRankSword--;
            ins = GameObject.Instantiate(FSword);
            ins.transform.parent = inventory.transform;
        }

        length = Smith.F2RankSword;
        for (int i = 0; i < length; i++)
        {
            Smith.f2++;
            Smith.F2RankSword--;
            ins = GameObject.Instantiate(F2Sword);
            ins.transform.parent = inventory.transform;
        }

        if (Smith.l > 0)
            PlayerData.WeaponDamage = 170000;
        else if (Smith.s > 0)
            PlayerData.WeaponDamage = 70840;
        else if (Smith.a > 0)
            PlayerData.WeaponDamage = 14000;
        else if (Smith.b2 > 0)
            PlayerData.WeaponDamage = 6670;
        else if (Smith.b1 > 0)
            PlayerData.WeaponDamage = 1755;
        else if (Smith.c2 > 0)
            PlayerData.WeaponDamage = 975;
        else if (Smith.c1 > 0)
            PlayerData.WeaponDamage = 360;
        else if (Smith.d2 > 0)
            PlayerData.WeaponDamage = 240;
        else if (Smith.f2 > 0)
            PlayerData.WeaponDamage = 130;
        else
            PlayerData.WeaponDamage = 110;

    }

    public void merge() {

        Transform[] childList = GetComponentsInChildren<Transform>(true);
        if (childList != null)
        {
            for (int i = 1; i < childList.Length; i++)
            {
                if (childList[i] != transform)
                    Destroy(childList[i].gameObject);
            }
        }


        while (Smith.f1 > 1)
        {
            Smith.f1 -= 2;
            Smith.f2 += 1;
        }

        while (Smith.f2 > 1)
        {
            Smith.f2 -= 2;
            Smith.d1 += 1;
        }

        while (Smith.d1 > 1)
        {
            Smith.d1 -= 2;
            Smith.d2 += 1;
        }

        while (Smith.c1 > 1)
        {
            Smith.c1 -= 2;
            Smith.c2 += 1;
        }

        while (Smith.c2 > 1)
        {
            Smith.c2 -= 2;
            Smith.b1 += 1;
        }

        while (Smith.b1 > 1)
        {
            Smith.b1 -= 2;
            Smith.b2 += 1;
        }

        while (Smith.b2 > 1)
        {
            Smith.b2 -= 2;
            Smith.a += 1;
        }

        while (Smith.a > 1)
        {
            Smith.a -= 2;
            Smith.s += 1;
        }

        while (Smith.s > 1)
        {
            Smith.s -= 2;
            Smith.l += 1;
        }


        Smith.F2RankSword = Smith.f2;
        Smith.FRankSword = Smith.f1;
        Smith.D2RankSword = Smith.d2;
        Smith.DRankSword = Smith.d1;
        Smith.C2RankSword = Smith.c2;
        Smith.CRankSword = Smith.c1;
        Smith.B2RankSword = Smith.b2;
        Smith.BRankSword = Smith.b1;
        Smith.ARankSword = Smith.a;
        Smith.SRankSword = Smith.s;
        Smith.LRankSword = Smith.l;

        Smith.f2 = 0;
        Smith.f1 = 0;
        Smith.d2 = 0;
        Smith.d1 = 0;
        Smith.c2 = 0;
        Smith.c1 = 0;
        Smith.b2 = 0;
        Smith.b1 = 0;
        Smith.a = 0;
        Smith.s = 0;
        Smith.l = 0;

        inventoryset();

    }
    
    // Start is called before the first frame update
    void Start()
    {
        inventoryset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
