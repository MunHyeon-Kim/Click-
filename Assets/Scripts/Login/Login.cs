using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public Text NickName;

    public GameObject canvas;

    public static bool NickNameSeted = false;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OkButtonPressed()
    {
        Debug.Log($"´Ð³×ÀÓ : {NickName.text}");

        if (NickName.text == "")
            return;
        PlayerData.SetNickName(NickName.text);
        NickNameSeted = true;
        canvas.SetActive(false);
        

    }

    public void PressScreenToStart() {
        
        if(NickNameSeted == true)
            SceneManager.LoadScene("Game");
        //Managers.Scene.LoadScene(Define.Scene.Game);
            
    }
}
