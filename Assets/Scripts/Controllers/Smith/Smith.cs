using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Smith : MonoBehaviour
{
    public static int SmithJob = 1;

    public static int FRankSword = 1;
    public static int F2RankSword = 0;
    public static int ERankSword = 0;
    public static int E2RankSword = 0;

    public static int DRankSword = 0;
    public static int D2RankSword = 0;
    public static int CRankSword = 0;
    public static int C2RankSword = 0;
    public static int BRankSword = 0;
    public static int B2RankSword = 0;

    public static int ARankSword = 0;
    public static int SRankSword = 0;
    public static int LRankSword = 0;

    public static int f1 = 0;
    public static int f2 = 0;
    public static int d1 = 0;
    public static int d2 = 0;
    public static int c1 = 0;
    public static int c2 = 0;
    public static int b1 = 0;
    public static int b2 = 0;
    public static int a = 0;
    public static int s = 0;
    public static int l = 0;

    [SerializeField]
    GameObject Charactor;
    [SerializeField]
    GameObject Smith3;
    [SerializeField]
    public Text textdd;

    public static int hp = 1000;

    public static int damage = 10;

    public static int RankupPercent = 100;
    public static int RankdownPercent = 0;

    private static int _point = 0;

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
    public static int temp = -1;

    public static int CreatePercent = 700;

    private void Update()
    {
        if (temp == 1) { StartCoroutine(imshow(FSword)); temp = -1; }
        if (temp == 2) { StartCoroutine(imshow(F2Sword)); temp = -1; }
        if (temp == 3) { StartCoroutine(imshow(DSword)); temp = -1; }
        if (temp == 4) { StartCoroutine(imshow(D2Sword)); temp = -1; }
        if (temp == 5) { StartCoroutine(imshow(CSword)); temp = -1; }
        if (temp == 6) { StartCoroutine(imshow(C2Sword)); temp = -1; }
        if (temp == 7) { StartCoroutine(imshow(BSword)); temp = -1; }
        if (temp == 8) { StartCoroutine(imshow(B2Sword)); temp = -1; }
        if (temp == 9) { StartCoroutine(imshow(ASword)); temp = -1; }
        if (temp == 10) { StartCoroutine(imshow(SSword)); temp = -1; }
        if (temp == 11) { StartCoroutine(imshow(LSword)); temp = -1; }
    }

    private void Start()
    {
        // SmithJob = GameData. ....
        SetInfo();
    }

    public void SetInfo()
    {
       
        if (SmithJob == 1)
        {
            hp = 1000;
            damage = 100;
            RankupPercent = 100;
            RankdownPercent = 0;
            CreatePercent = 700;

        }
        if (SmithJob == 2)
        {
            hp = 1000;
            damage = 100;
            RankupPercent = 100;
            RankdownPercent = 100;
            CreatePercent = 700;
        }
        if (SmithJob == 3)
        {
            hp = 1000;
            damage = 100;
            RankupPercent = 100;
            RankdownPercent = 100;
            CreatePercent = 700;
        }
        if (SmithJob == 4)
        {
            hp = 1000;
            damage = 100;
            RankupPercent = 100;
            RankdownPercent = 100;
            CreatePercent = 700;
        }
        if (SmithJob == 5)
        {
            hp = 1000;
            damage = 100;
            RankupPercent = 100;
            RankdownPercent = 100;
            CreatePercent = 700;
        }
    }



    private static bool Rand(int percent) 
    {
        System.Random random = new System.Random();

        const int max = 1000;

        int percent2 = random.Next(max)+1;

        if (percent >= percent2)
            return true;
        else
            return false;

    }

    private static int Randup(int uppercent,int downpercent)
    {
        System.Random random = new System.Random();

        const int max = 1000;

        int uppercent2 = random.Next(max) + 1;

        if (uppercent >= uppercent2)
            return 1;
        else
        { 
            int downpercent2 = random.Next(max) + 1;
            if (downpercent >= downpercent2)
                return -1;
            else
                return 0;
        }

        
    }

    static IEnumerator imshow(GameObject sword) {
        int count = 1;

        while (true)
        {
            sword.SetActive(true);
            if (count == 2)
                break;
            count++;
            yield return new WaitForSecondsRealtime(1.0f);
        }

        sword.SetActive(false);

    }

    public static void Create()
    {
        if(SmithJob == 1)
        {
            if (Rand(CreatePercent) == true)
            {
                if (Randup(RankupPercent, RankdownPercent) == 1)
                {
                    temp = 2;
                    Debug.Log($"F2RankSword{F2RankSword}");
                    F2RankSword += 1;
                }
                else if (Randup(RankupPercent, RankdownPercent) == 0)
                {
                    temp = 1;
                    Debug.Log($"FRankSword{FRankSword}");
                    FRankSword += 1;
                }

                else
                    return;
            }
            else
                return;
        }

        if (SmithJob == 2)
        {
            if (Rand(CreatePercent) == true)
            {
                if (Randup(RankupPercent, RankdownPercent) == 1)
                {
                    temp = 4;
                    Debug.Log($"D2RankSword{D2RankSword}");
                    D2RankSword += 1;
                }
                else if (Randup(RankupPercent, RankdownPercent) == 0)
                {
                    temp = 3;
                    Debug.Log($"DRankSword{DRankSword}");
                    DRankSword += 1;
                }

                else if (Randup(RankupPercent, RankdownPercent) == -1)
                {
                    temp = 2;
                    Debug.Log($"FRankSword{FRankSword}");
                    F2RankSword += 1;
                }
                    
            }
            else
                return;
        }

        if (SmithJob == 3)
        {
            if (Rand(CreatePercent) == true)
            {
                if (Randup(RankupPercent, RankdownPercent) == 1)
                {
                    temp = 6;
                    Debug.Log($"c2RankSword{C2RankSword}");
                    C2RankSword += 1;
                }
                else if (Randup(RankupPercent, RankdownPercent) == 0)
                {
                    temp = 5;
                    Debug.Log($"CRankSword{CRankSword}");
                    CRankSword += 1;
                }

                else if (Randup(RankupPercent, RankdownPercent) == -1)
                {
                    temp = 4;
                    Debug.Log($"DRankSword{D2RankSword}");
                    D2RankSword += 1;
                }

            }
            else
                return;
        }

        if (SmithJob == 4)
        {
            if (Rand(CreatePercent) == true)
            {
                if (Randup(RankupPercent, RankdownPercent) == 1)
                {
                    temp = 8;
                    Debug.Log($"C2RankSword{C2RankSword}");
                    B2RankSword += 1;
                }
                else if (Randup(RankupPercent, RankdownPercent) == 0)
                {
                    temp = 7;
                    Debug.Log($"BRankSword{BRankSword}");
                    BRankSword += 1;
                }

                else if (Randup(RankupPercent, RankdownPercent) == -1)
                {
                    temp = 6;
                    Debug.Log($"CRankSword{CRankSword}");
                    C2RankSword += 1;
                }

            }
            else
                return;
        }

        if (SmithJob == 5)
        {
            if (Rand(CreatePercent) == true)
            {
                if (Randup(RankupPercent, RankdownPercent) == 1)
                {
                    temp = 10;
                    Debug.Log($"B2RankSword{B2RankSword}");
                    LRankSword += 1;
                }
                else if (Randup(RankupPercent, RankdownPercent) == 0)
                {
                    temp = 9;
                    Debug.Log($"BRankSword{BRankSword}");
                    ARankSword += 1;
                }

                else if (Randup(RankupPercent, RankdownPercent) == -1)
                {
                    temp = 8;
                    Debug.Log($"CRankSword{CRankSword}");
                    B2RankSword += 1;
                }

            }
            else
                return;
        }


    }

    
    public static void Attack()
    {
        Debug.Log("SmithAttack");

        _point += damage;
        if (_point == hp)
        {
            _point = 0;
            //랜덤으로 무기생성
            Create();
        }
    }

    public void CharactorChange()
    {


        if (ClickEvent.mode == 0)
        {
            Charactor.SetActive(false);
            Smith3.SetActive(true);
            EnemyController.DesTroyEnemy();
            ClickEvent.mode = 1;
            textdd.text = "사냥\n";
        }
        else if(ClickEvent.mode == 1)
        {
            Charactor.SetActive(true);
            Smith3.SetActive(false);
            EnemyController.isstaticRevive = true;
            ClickEvent.mode = 0;
            textdd.text = "제작\n";
        }

    }


}
