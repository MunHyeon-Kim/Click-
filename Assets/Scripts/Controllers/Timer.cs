using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer2 : MonoBehaviour
{

    private float _Timer = 30.0f;
    private Text text;
    public static bool TimerStart;

    
    void Update()
    {
        if (_Timer > 0 && TimerStart)
        {
            _Timer -= Time.deltaTime;
            int _Timer2 = (int)_Timer;
            text.text = text.text = "남은시간 : " + _Timer;
        }
        else
        {
            text.text = "";
            _Timer = 30.0f;
            TimerStart = false;
        }
           
    }
}
