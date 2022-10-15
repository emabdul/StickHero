using System;
using System.Runtime.CompilerServices;
using GoogleMobileAds.Api;

public class AppOpenAdManager
{
	private const string AD_UNIT_ID_1 = "ca-app-pub-6336405384015455/7777651466";

	private const string AD_UNIT_ID_2 = "ca-app-pub-6336405384015455/3838406459";

	private const string AD_UNIT_ID_3 = "ca-app-pub-6336405384015455/7922504585";

	private static AppOpenAdManager instance;

	private AppOpenAd ad;

	private bool isShowingAd;

	private int numberRequest;

	private bool isFirtShow;

	public bool IsShowAds { get; set; }

	public static AppOpenAdManager Instance
	{
		get
		{
			return null;
		}
	}

	private bool IsAdAvailable
	{
		get
		{
			return default(bool);
		}
	}

	public void LoadAd()
	{
	}

	private void LoadAd(string id)
	{
	}

	public void ShowAdIfAvailable()
	{
	}

	private void HandleAdDidDismissFullScreenContent(object sender, EventArgs args)
	{
	}

	private void HandleAdFailedToPresentFullScreenContent(object sender, AdErrorEventArgs args)
	{
	}

	private void HandleAdDidPresentFullScreenContent(object sender, EventArgs args)
	{
	}

	private void HandleAdDidRecordImpression(object sender, EventArgs args)
	{
	}

	private void HandlePaidEvent(object sender, AdValueEventArgs args)
	{
	}

	public AppOpenAdManager()
		: base()
	{
	}
}
