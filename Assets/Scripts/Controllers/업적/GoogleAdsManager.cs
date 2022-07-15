using System;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleAdsManager : MonoBehaviour
{
    private static InterstitialAd interstitial;

    private void Start()
    {
        // 전면 광고를 보여줄 준비를 합니다. 광고를 노출시키기 전에 먼저 아래 함수를 호출해둬야 하기 때문에 `Start` 함수에서 실행합니다.
        MobileAds.Initialize(initStatus =>
        {
            RequestInterstitial();
        });
    }

    private static void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-4994702334256187/5638255435";
#elif UNITY_IOS
        string adUnitId = "ca-app-pub-4994702334256187/5638255435";
#else
        string adUnitId = "unexpected_platform";
#endif

        // 광고를 보여줄 준비를 합니다.
        interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);
    }

    // 외부 컴포넌트가 호출하는 메소드
    public void Show()
    {
        // 만약 광고를 보여줄 준비가 되었다면...
        if (interstitial.IsLoaded())
        {
            // 광고를 노출시킵니다
            interstitial.Show();
        }
    }
}