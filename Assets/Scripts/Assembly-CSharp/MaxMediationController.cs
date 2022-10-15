using System.Runtime.CompilerServices;
using RocketTeam.Sdk.Services.Ads;
using UnityEngine;

public class MaxMediationController : MonoBehaviour
{
	public AdManager adsManager;

	private const string MaxSdkKey = "7PspscCcbGd6ohttmPcZTwGmZCihCW-Jwr7nSJN2a_9Mg0ERPs0tmGdKTK1gs__nr6XHQvK0vTNaTb1uR1mCIN";

	private const string InterstitialAdUnitId = "fa3b8af67836924a";

	private const string RewardedAdUnitId = "1b098c8a115affc3";

	private const string RewardedInterstitialAdUnitId = "ENTER_REWARD_INTER_AD_UNIT_ID_HERE";

	private const string BannerAdUnitId = "f38a4c4d6a7e714b";

	private const string MRecAdUnitId = "";

	private bool isBannerShowing;

	private bool isMRecShowing;

	private int interstitialRetryAttempt;

	private int rewardedRetryAttempt;

	private int rewardedInterstitialRetryAttempt;

	public TypeAdsMax TypeAdsUse;

	public void Init()
	{
	}

	private void InitializeInterstitialAds()
	{
	}

	public void LoadInterstitial()
	{
	}

	public void ShowInterstitial(string placement)
	{
	}

	public bool IsLoadInterstitial()
	{
		return default(bool);
	}

	private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnInterstitialFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void InitializeRewardedAds()
	{
	}

	public void LoadRewardedAd()
	{
	}

	public bool IsLoadRewardedAd()
	{
		return default(bool);
	}

	public void ShowRewardedAd(string placeId)
	{
	}

	private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void InitializeRewardedInterstitialAds()
	{
	}

	public void LoadRewardedInterstitialAd()
	{
	}

	public bool IsRewardedInterstitialAdReady()
	{
		return default(bool);
	}

	public void ShowRewardedInterstitialAd(string placeId)
	{
	}

	private void OnRewardedInterstitialAdLoadedEvent(string adUnitId)
	{
	}

	private void OnRewardedInterstitialAdFailedEvent(string adUnitId, int errorCode)
	{
	}

	private void OnRewardedInterstitialAdFailedToDisplayEvent(string adUnitId, int errorCode)
	{
	}

	private void OnRewardedInterstitialAdDisplayedEvent(string adUnitId)
	{
	}

	private void OnRewardedInterstitialAdClickedEvent(string adUnitId)
	{
	}

	private void OnRewardedInterstitialAdDismissedEvent(string adUnitId)
	{
	}

	private void OnRewardedInterstitialAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward)
	{
	}

	private void InitializeBannerAds()
	{
	}

	private void ToggleBannerVisibility()
	{
	}

	public bool ShowBanner()
	{
		return default(bool);
	}

	public void HideBanner()
	{
	}

	private void OnBannerAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnBannerAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void InitializeMRecAds()
	{
	}

	private void ToggleMRecVisibility()
	{
	}

	public MaxMediationController()
		: base()
	{
	}
}
