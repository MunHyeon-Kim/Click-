using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmithButton : MonoBehaviour
{

    public void heirlow()
    {
        if (PlayerData.Gold < 1000)
            return;

        PlayerData.Gold -= 1000;
        Smith.SmithJob = 1;
    }
    public void heiremiddle()
    {
        if (PlayerData.Gold < 1000)
            return;

        PlayerData.Gold -= 1000;
        Smith.SmithJob = 2;
    }

    public void heirehigh()
    {
        if (PlayerData.Gold < 1000)
            return;

        PlayerData.Gold -= 1000;
        Smith.SmithJob = 3;
    }
    public void heiresuper()
    {
        if (PlayerData.Gold < 1000)
            return;

        PlayerData.Gold -= 1000;
        Smith.SmithJob = 4;
    }
    public void heirelegend()
    {
        if (PlayerData.Gold < 1000)
            return;

        PlayerData.Gold -= 1000;
        Smith.SmithJob = 5;
    }
}
