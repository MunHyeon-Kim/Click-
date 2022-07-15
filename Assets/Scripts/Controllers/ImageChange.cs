using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChange : MonoBehaviour
{

    GameObject image1;
    GameObject image2;
    GameObject image3;

    public void image1C()
    {
        Clear();
        image1.SetActive(true);
    }

    public void image2C()
    {
        Clear();
        image2.SetActive(true);
    }
    public void image3C()
    {
        Clear();
        image3.SetActive(true);
    }


    void Clear()
    {
        image1.SetActive(false);
        image2.SetActive(false);
        image3.SetActive(false);
    }
    
}
