using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    

    public static Animator animator;


   
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {

    }

    public static void Attack()
    {
        Effect.staticSound = true;
        TextTesting.isAttacked = true;
    }
}
