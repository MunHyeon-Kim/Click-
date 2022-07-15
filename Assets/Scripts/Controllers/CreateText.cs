using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateText : MonoBehaviour
{
    [SerializeField]
    Text t;
    [SerializeField]
    Text t2;
    [SerializeField]
    private int mode;
    // Start is called before the first frame update
    void Start()
    {
        switch (mode)
        {
            case 1:
                t.text = $"FRankSword : {Smith.FRankSword}";
                break;
            case 2:
                t.text = $"DRankSword : {Smith.FRankSword}";
                break;
            case 3:
                t.text = $"CRankSword : {Smith.FRankSword}";
                break;
            case 4:
                t.text = $"BRankSword : {Smith.FRankSword}";
                break;
            case 5:
                t.text = $"ARankSword : {Smith.FRankSword}";
                break;
            case 6:
                t.text = $"LRankSword : {Smith.FRankSword}";
                break;
            default:
                break;
        }
    }

    public void merge()
    {
        switch (mode)
        {
            case 1:
                Smith.FRankSword -= 2;
                Smith.DRankSword += 1;
                t.text = $"FRankSword : {Smith.FRankSword}";
                t2.text = $"DRankSword : {Smith.DRankSword}";
                break;
            case 2:
                Smith.DRankSword -= 2;
                Smith.CRankSword += 1;
                t.text = $"DRankSword : {Smith.DRankSword}";
                t2.text = $"CRankSword : {Smith.CRankSword}";
                break;
            case 3:
                Smith.CRankSword -= 2;
                Smith.BRankSword += 1;
                t.text = $"CRankSword : {Smith.CRankSword}";
                t2.text = $"BRankSword : {Smith.BRankSword}";
                break;
            case 4:
                Smith.BRankSword -= 2;
                Smith.ARankSword += 1;
                t.text = $"BRankSword : {Smith.BRankSword}";
                t2.text = $"ARankSword : {Smith.ARankSword}";
                break;
            case 5:
                Smith.ARankSword -= 2;
                Smith.LRankSword += 1;
                t.text = $"ARankSword : {Smith.ARankSword}";
                t2.text = $"LRankSword : {Smith.LRankSword}";
                break;
            case 6:
                t.text = $"LRankSword : {Smith.LRankSword}";
                break;
            default:
                break;
        }


    }


}
