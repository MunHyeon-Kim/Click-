using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public Toggle toggle;

    public void Function_toggle(bool value)
    {
        if (value)
        {
            SoundManager.staticSound = true;
            SoundManager.soundOn = 1;
        }
        else
        {
            SoundManager.soundOn = 0;
        }
            
    }

    

    private void Start()
    {
        toggle.onValueChanged.AddListener((value) =>
        {
            Function_toggle(value);
        });
        
    }


}
