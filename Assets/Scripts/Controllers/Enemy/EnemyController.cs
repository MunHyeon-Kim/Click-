using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyController : MonoBehaviour
{
    static EnemyController instance; // 유일성이 보장된다
    public static EnemyController Instance { get { return instance; } }

    public Slider hpbar;
    public Slider Playerbar;
    public Slider GageBar;
    public GameObject GoldBox;
    public GameObject GoldBox2;

    public static long totalDamage;

    public static long Hp;
    public static long Eteru;
    public static long MaxHp;
    public static bool isstaticRevive = false;



    private float Timer2 = 5.0f;
    public static bool staticTimer = false;
    private float Temp2;

    public static bool inPiber = false;


    private float Gage;
    private float MaxGage = 100;

    public static int EnemyCounter = 0;


    public static GameObject _thisEnemy;

    public static int currentEnemy = 1;


    public static int MaxEnemy = 1;

    public static float Timer = 30.0f;

    public static int stageClicked = -1;

    public static long Damage = 1;

    private void StageChange() {

        currentEnemy = stageClicked;
        Delete2();
        Revive();

        stageClicked = -1;
    }

    public void Delete2()
    {
        GameObject.Destroy(_thisEnemy);
    }

    public void staticRevive()
    {
        Debug.Log($"static 리바이브 {currentEnemy}");

        _thisEnemy = Instantiate(Resources.Load<GameObject>($"Prefabs/Enemy/Anemi ({currentEnemy})"));
        _thisEnemy.transform.position = new Vector3(1.0f, -1.0f, 0);


        isstaticRevive = false;
    }

    public void Revive()
    {
        Debug.Log($"리바이브 {currentEnemy}");
        _thisEnemy = Instantiate(Resources.Load<GameObject>($"Prefabs/Enemy/Anemi ({currentEnemy})"));
        _thisEnemy.transform.position = new Vector3(1.0f,-1.0f, 0);
        


    }

    public static void Attacked()
    {
        System.Random rand = new System.Random();
        int criticalP = rand.Next(1, 1001);
        

        if(PlayerData.nowHp > 0)
            PlayerData.nowHp -= Damage;

        if (criticalP < PlayerData.critical * 1)
        {
            Debug.Log($"크리딜 들어옴{(PlayerData.Damage + (long)(PlayerData.Damage * (long)(PlayerData.criticalDamage) / 10)) * PlayerData.WeaponDamage / 100}");

            totalDamage = (PlayerData.Damage + (long)(PlayerData.Damage * (long)(PlayerData.criticalDamage)/10) ) * PlayerData.WeaponDamage/100 ;
            Hp -= totalDamage;
        }
        else
        {
            Debug.Log($"딜 들어옴{(long)PlayerData.Damage * PlayerData.WeaponDamage / 100}");
            totalDamage = (long)PlayerData.Damage * PlayerData.WeaponDamage / 100;
            Hp -= (long)PlayerData.Damage * PlayerData.WeaponDamage/100;
        }

        
    }



    public void Death()
    {

        if (MaxEnemy == currentEnemy)
            MaxEnemy+=1;
        if (MaxEnemy == 22)
            MaxEnemy += 1;
        Gage += 1f;

        EnemyCounter++;
        GoldBoxC();
        Debug.Log("죽");

        PlayerData.Gold += Eteru;
        GameObject.Destroy(_thisEnemy);

        //RandomTreaser();

        Revive();

        
    }

    public void GoldBoxC ()
    {
        System.Random rand = new System.Random();
        int percent = rand.Next(0, 100);
        if (percent < 3)
        {
            float os = (float)rand.NextDouble();
            os *= 2;
            os -= 1f;
            GoldBox2 = GameObject.Instantiate(GoldBox, _thisEnemy.transform.position, Quaternion.identity);
            Rigidbody2D soJu = GoldBox2.GetComponent<Rigidbody2D>();
            Debug.Log($"os{os}");
            soJu.AddForce(new Vector2(os, 1), ForceMode2D.Impulse);
        }
    }

    public static void DesTroyEnemy()
    {
        GameObject.Destroy(_thisEnemy);
    }

    

    


    void Start()
    {
        Gage = 0;
        currentEnemy = DataController.Instance.gameData.currentStage;
        Revive();
    }

    
    void Update()
    {
        if (isstaticRevive == true)
            staticRevive();
        if (Hp < 0)
            Death();
        
        if (stageClicked != -1)
            StageChange();
        Hpbar();
        Gagebar();
        Piber();
        PlayerHpbar();
    }

    void PlayerHpbar()
    {

        if (PlayerData.HP<=0)
        {
            Playerbar.value = 0;
            return;
        }
        if(PlayerData.HP>0)
            Playerbar.value = (float)PlayerData.nowHp / (float)PlayerData.HP;
    }

    void Hpbar()
    {

        if (Hp <= 0)
        {
            hpbar.value = 0;
            return;
        }

        hpbar.value = (float)Hp / (float)MaxHp;
    }

    void Gagebar()
    {

        if (Gage >= MaxGage)
        {
            // Piber();
            if ((ClickEvent.mode == 0 || ClickEvent.mode == 10) && !staticTimer)
            {

                
                Temp2 = ClickEvent.AttackDelayTime;
                PlayerData.Damage *= 5;
                ClickEvent.AttackDelayTime = 0.05f;

                staticTimer = true;
            }
            GageBar.value = 0;
            return;
        }

        GageBar.value = Gage / MaxGage;
    }

    void Piber()
    {
        if (staticTimer)
        {
            if (Timer2 > 0)
            {
                Timer2 -= Time.deltaTime;


                if (Timer2 <= 0)
                {
                    ClickEvent.AttackDelayTime = Temp2;
                    PlayerData.Damage /= 5;
                    staticTimer = false;
                    Timer2 = 5.0f;
                    Gage = 0f;
                }
            }
        }

    }
}
