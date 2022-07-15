using System;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleAdsManager : MonoBehaviour
{
    private static InterstitialAd interstitial;

    private void Start()
    {
        // ���� ���� ������ �غ� �մϴ�. ���� �����Ű�� ���� ���� �Ʒ� �Լ��� ȣ���ص־� �ϱ� ������ `Start` �Լ����� �����մϴ�.
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

        // ���� ������ �غ� �մϴ�.
        interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        interstitial.LoadAd(request);
    }

    // �ܺ� ������Ʈ�� ȣ���ϴ� �޼ҵ�
    public void Show()
    {
        // ���� ���� ������ �غ� �Ǿ��ٸ�...
        if (interstitial.IsLoaded())
        {
            // ���� �����ŵ�ϴ�
            interstitial.Show();
        }
    }
}