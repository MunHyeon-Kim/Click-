using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour
{
    [SerializeField]
    GameObject Stage;
    [SerializeField]
    GameObject Stage2;
    [SerializeField]
    GameObject Stage3;
    [SerializeField]
    GameObject Stage4;
    [SerializeField]
    GameObject Stage5;
    [SerializeField]
    GameObject Stage6;
    [SerializeField]
    GameObject Stage7;
    [SerializeField]
    GameObject Stage8;
    [SerializeField]
    GameObject Stage9;
    [SerializeField]
    GameObject Stage10;
    [SerializeField]
    GameObject Stage11;
    [SerializeField]
    GameObject Stage12;
    [SerializeField]
    GameObject Stage13;
    [SerializeField]
    GameObject Stage14;
    [SerializeField]
    GameObject Stage15;
    [SerializeField]
    GameObject Stage16;
    [SerializeField]
    GameObject Stage17;
    [SerializeField]
    GameObject Stage18;
    [SerializeField]
    GameObject Stage19;
    [SerializeField]
    GameObject Stage20;



    public int chapter;

    private static bool clicked = false;

    public void click()
    {
        if (ClickEvent.mode == 0)
        {
            if (chapter == 1)
            {
                if (clicked == false)
                {
                    Stage.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage.SetActive(false);
                    clicked = false;
                }
            }

            if (chapter == 2)
            {
                if (clicked == false)
                {
                    Stage2.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage2.SetActive(false);
                    clicked = false;
                }
            }
            if (chapter == 3)
            {
                if (clicked == false)
                {
                    Stage3.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage3.SetActive(false);
                    clicked = false;
                }
            }
            if (chapter == 4)
            {
                if (clicked == false)
                {
                    Stage4.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage4.SetActive(false);
                    clicked = false;
                }
            }
            if (chapter == 5)
            {
                if (clicked == false)
                {
                    Stage5.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage5.SetActive(false);
                    clicked = false;
                }
            }
            if (chapter == 6)
            {
                if (clicked == false)
                {
                    Stage6.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage6.SetActive(false);
                    clicked = false;
                }
            }
            if (chapter == 7)
            {
                if (clicked == false)
                {
                    Stage7.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage7.SetActive(false);
                    clicked = false;
                }
            }
            if (chapter == 8)
            {
                if (clicked == false)
                {
                    Stage8.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage8.SetActive(false);
                    clicked = false;
                }
            }
            if (chapter == 9)
            {
                if (clicked == false)
                {
                    Stage9.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage9.SetActive(false);
                    clicked = false;
                }
            }
            if (chapter == 10)
            {
                if (clicked == false)
                {
                    Stage10.SetActive(true);
                    clicked = true;
                }
                else if (clicked == true)
                {
                    Stage10.SetActive(false);
                    clicked = false;
                }
            }
        }

    }


}
