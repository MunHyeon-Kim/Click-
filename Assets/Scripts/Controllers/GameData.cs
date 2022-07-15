using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable] // 직렬화

public class GameData
{
    
    public int currentStage = 1;
    public int PStage = 1;
    public int DStage = 1;
    public int CStage = 1;
    public int RStage = 1;

    public float Gold;
    public string NickName;
    public float Damage;
    public float Diamond;

    
    public  float shield;
    public  int recovery;
    public  float critical;

    // 각 챕터의 잠금여부
    public bool stage1;
    public bool stage2;
    public bool stage3;
    public bool stage4;
    public bool stage5;

    public int BGM = 1;
    public int EFFECTOn = 1;
    public int TextOn = 1;

}