using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionMark : MonoBehaviour
{


    public int stage;


    // Update is called once per frame
    void Update()
    {
        if(stage <= EnemyController.MaxEnemy)
            this.gameObject.SetActive(false);
    }
}
