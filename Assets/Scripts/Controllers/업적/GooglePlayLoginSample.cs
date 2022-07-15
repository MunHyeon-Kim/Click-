using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GooglePlayLoginSample : MonoBehaviour
{
    private void Awake()
    {
        PlayGamesPlatform.InitializeInstance(new PlayGamesClientConfiguration.Builder().Build()); // �ʱ�ȭ�Լ� , �ν��Ͻ� ����
        //����׿� ����
        PlayGamesPlatform.DebugLogEnabled = true;
        //���� ���� ���� Ȱ��ȭ. 
        PlayGamesPlatform.Activate();
    }

    public void Do_Login()
    {
        if (!Social.localUser.authenticated)// ���� ���� ����� ������ ������ ���� �ȉ�°�?
        {
            //�������� 
            Social.localUser.Authenticate((bool isSuccess) =>
            {
                if (isSuccess)
                {
                    Debug.Log("���� ���� -> " + Social.localUser.userName);
                }
                else
                {
                    Debug.Log("��������");
                }
            }

            );
        }
    }

    public void Do_Logout()
    {
        //�α׾ƿ�
        ((PlayGamesPlatform)Social.Active).SignOut();
    }

    public void Do_ShowLeaderBoard()
    {

        //����������, ��������ID, callback�Լ�
        Social.ReportScore(123, "CgkIz-yBlPMOEAIQAQ", (bool isSuccess) => { });
        //�������� ��� 
        Social.ShowLeaderboardUI();
    }

}
