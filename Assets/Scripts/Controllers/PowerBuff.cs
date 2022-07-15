using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBuff : MonoBehaviour
{
    // Start is called before the first frame update

    private float Timer = 5.0f;
    public static bool staticTimer = false;

    public static bool inBuff = false;

    public void PowerBuf()
    {
        if (PlayerData.Diamond < 5)
            return;

        if ((ClickEvent.mode == 0 || ClickEvent.mode == 10)&&!staticTimer )
        {
            PlayerData.Damage *= 5;
            PlayerData.Diamond -= 5;
            staticTimer = true;
        }

    }


    // Update is called once per frame
    void Update()
    {
        if (staticTimer)
        {
            if (Timer > 0)
            {
                Timer -= Time.deltaTime;


                if (Timer <= 0)
                {
                    PlayerData.Damage /= 5;
                    staticTimer = false;
                    Timer = 5.0f;
                }
            }
        }

    }
}
