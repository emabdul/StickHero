using System;
using System.Runtime.InteropServices;

namespace RocketTeam.Sdk.Services.Interfaces
{
	public interface IAdsManager : IG2Service
	{
		void RegisterInterstitialListener(Action onOpened, Action onClosed, Action onLeavingApplication, Action<int> onGetReward);

		void LoadInterstitial(int adsId = 1, bool isRefresh = false);

		bool ShowInterstitial(string _placement, int adsId = 1);

		bool ShowInterstitial(string _placement, int adsId = 1, Action onOpened = default(Action), Action onClosed = default(Action), Action onLeavingApplication = default(Action), Action<int> onGetReward = default(Action<int>));

		bool HideInterstitial(int adsId = 1);

		bool IsInterstitialLoaded(int adsId = 1);

		bool OnBack();

		RewardAdStatus ShowAdsReward(Action<int> OnRewarded, string _placement, bool isAutoLog = true);

		void RegisterBannerListener(Action onOpened, Action onClosed, Action onLeavingApplication);

		bool ShowBanner(int bannerId = 1);

		bool HideBanner(int bannerId = 1);

		int GetBannerWidth();

		int GetBannerHeight();
	}
}
