using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting2 : MonoBehaviour
{

    public Toggle toggle2;

    public void Function_toggle2(bool value2)
    {
        if (value2)
        {
            Effect.soundOn = 1;
        }
        else
        {
            Effect.soundOn = 0;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        toggle2.onValueChanged.AddListener((value2) =>
        {
            Function_toggle2(value2);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
