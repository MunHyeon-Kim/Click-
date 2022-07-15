using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update

    public int mode;

    public void PickUpWeapon()
    {
        System.Random rand = new System.Random();

        if (mode == 1)
        {
            if (PlayerData.Gold < 1000)
                return;
            else
            {
                PlayerData.Gold -= 1000;
                int r1 = rand.Next(0, 4);
                int r2 = rand.Next(0, 2);
                Smith.FRankSword += r1;
                Smith.DRankSword += r1;

            }
        }

        if (mode == 2)
        {
            if (PlayerData.Gold < 5000)
                return;
            else
            {
                PlayerData.Gold -= 1000;
                int r1 = rand.Next(0, 4);
                int r2 = rand.Next(0, 2);
                Smith.FRankSword += r1;
                Smith.DRankSword += r1;

            }
        }

        if (mode == 3)
        {
            if (PlayerData.Diamond < 500)
                return;
            else
            {
                PlayerData.Diamond -= 1000;
                int r1 = rand.Next(0, 4);
                int r2 = rand.Next(0, 2);
                Smith.FRankSword += r1;
                Smith.DRankSword += r1;

            }
        }

        if (mode == 4)
        {
            if (PlayerData.Diamond < 5000)
                return;
            else
            {
                PlayerData.Diamond -= 5000;
                int r1 = rand.Next(0, 4);
                int r2 = rand.Next(0, 2);
                Smith.FRankSword += r1;
                Smith.DRankSword += r1;

            }
        }

    }

    
}
