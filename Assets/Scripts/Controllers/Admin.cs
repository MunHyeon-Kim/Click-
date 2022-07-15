using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Admin : MonoBehaviour
{

    public InputField Gold;
    public InputField Dia;



    public void Submit()
    {
        if (Gold == null || Dia == null)
            return;
        PlayerData.Gold = (float.Parse(Gold.text));
        PlayerData.Diamond = (float.Parse(Dia.text));
    }
}
