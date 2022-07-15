using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GooglePlayLoginSample : MonoBehaviour
{
    private void Awake()
    {
        PlayGamesPlatform.InitializeInstance(new PlayGamesClientConfiguration.Builder().Build()); // 초기화함수 , 인스턴스 생성
        //디버그용 변수
        PlayGamesPlatform.DebugLogEnabled = true;
        //구글 관련 서비스 활성화. 
        PlayGamesPlatform.Activate();
    }

    public void Do_Login()
    {
        if (!Social.localUser.authenticated)// 현재 기기와 연결된 계정이 인증이 아직 안됬는가?
        {
            //계정인증 
            Social.localUser.Authenticate((bool isSuccess) =>
            {
                if (isSuccess)
                {
                    Debug.Log("인증 성공 -> " + Social.localUser.userName);
                }
                else
                {
                    Debug.Log("인증실패");
                }
            }

            );
        }
    }

    public void Do_Logout()
    {
        //로그아웃
        ((PlayGamesPlatform)Social.Active).SignOut();
    }

    public void Do_ShowLeaderBoard()
    {

        //보고할점수, 리더보드ID, callback함수
        Social.ReportScore(123, "CgkIz-yBlPMOEAIQAQ", (bool isSuccess) => { });
        //리더보드 출력 
        Social.ShowLeaderboardUI();
    }

}
