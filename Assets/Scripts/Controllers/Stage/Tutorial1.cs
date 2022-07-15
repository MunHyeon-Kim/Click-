using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial1 : MonoBehaviour
{
    [SerializeField]
    GameObject name;
    [SerializeField]
    public InputField inputField;
    [SerializeField]
    GameObject tuto1;
    [SerializeField]
    GameObject tuto2;
    [SerializeField]
    GameObject tuto3;
    [SerializeField]
    GameObject tuto4;
    [SerializeField]
    GameObject tuto5;
    [SerializeField]
    GameObject tuto6;

    // Start is called before the first frame update
    void Start()
    {
        if (ClickEvent.mode == 20)
        {
            name.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Okbutton()
    {
        
        PlayerData.NickName = inputField.text;
        ClickEvent.mode++;
        name.SetActive(false);
        
    }

    public void tutorial()
    {
        if (ClickEvent.mode == 21)
        {
            tuto1.SetActive(true);
            ClickEvent.mode++;
        }

        else if (ClickEvent.mode == 22)
        {
            tuto1.SetActive(false);
            tuto2.SetActive(true);
            ClickEvent.mode++;
        }

        else if (ClickEvent.mode == 23)
        {
            tuto2.SetActive(false);
            tuto3.SetActive(true);
            ClickEvent.mode++;
        }
        else if (ClickEvent.mode == 24)
        {
            tuto3.SetActive(false);
            tuto4.SetActive(true);
            ClickEvent.mode++;
        }

        else if (ClickEvent.mode == 25)
        {
            tuto4.SetActive(false);
            tuto5.SetActive(true);
            ClickEvent.mode++;
        }

        else if (ClickEvent.mode == 26)
        {
            tuto5.SetActive(false);
            tuto6.SetActive(true);
            ClickEvent.mode++;
        }
        else if (ClickEvent.mode == 27)
        {
            tuto6.SetActive(false);
            ClickEvent.mode = 0;
        }

    }
}
