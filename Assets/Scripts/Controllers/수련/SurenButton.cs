using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurenButton : MonoBehaviour
{
    [SerializeField]
    GameObject su;
    [SerializeField]
    GameObject su2;
    public void suryenbutton()
    {
        if(ClickEvent.mode == 0)
            su.SetActive(true);
        if (ClickEvent.mode == 1)
            su2.SetActive(true);
    }
    public void Clear()
    {
        su.SetActive(false);
        su2.SetActive(false);
    }
}
