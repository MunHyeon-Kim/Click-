using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{

    [SerializeField]
    GameObject Stage1;

    public static bool clicked = false;

    public void click()
    {
        if (ClickEvent.mode == 0)
        {
            if (clicked == false)
            {
                Stage1.SetActive(true);
                clicked = true;
            }
            else if (clicked == true)
            {
                Stage1.SetActive(false);
                clicked = false;
            }
        }
    }


}
