using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageControll : MonoBehaviour
{

    public int stage;
    public GameObject screen;

    public void SetMonster()
    {
        
        //Stage.clicked = true;
        if (ClickEvent.mode == 0)
        {
            if (EnemyController.MaxEnemy < stage)
                return;

            if (stage >= 22)
            {
                EnemyController.stageClicked = stage + 1;
            }
            else
                EnemyController.stageClicked = stage;

            screen.SetActive(false);
        }
        
    }

    
}
