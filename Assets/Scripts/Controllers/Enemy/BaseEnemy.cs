using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseEnemy : MonoBehaviour
{

    private float _Hp;
    private int _Eteru;

    //EnemyController EC = EnemyController.Instance;


    public abstract void SetEnemy();
    

    void Start()
    {
        SetEnemy();
    }


}
