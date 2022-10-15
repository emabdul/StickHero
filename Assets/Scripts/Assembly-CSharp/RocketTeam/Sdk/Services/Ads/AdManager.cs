using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using RocketTeam.Sdk.Services.Interfaces;
using UnityEngine;

namespace RocketTeam.Sdk.Services.Ads
{
	public class AdManager : MonoBehaviour, IAdsManager, IG2Service
	{
		public MaxMediationController MaxMediation;

		public static AdManager Instance { get; set; }

		public Action onLoaded { get; set; }

		public Action<string> onFailedToLoad { get; set; }

		public Action onOpening { get; set; }

		public Action onClosed { get; set; }

		public Action onLeavingApplication { get; set; }

		public Action<int> onGetReward { get; set; }

		private void Awake()
		{
		}

		public void Init()
		{
		}

		private void OnDestroy()
		{
		}

		public void RegisterInterstitialListener(Action onOpened, Action onClosed, Action onLeavingApplication, Action<int> onGetReward)
		{
		}

		public bool IsInterstitialLoaded(int id)
		{
			return default(bool);
		}

		public bool ShowInterstitial(string _placement, int id = 1)
		{
			return default(bool);
		}

		public bool ShowInterstitial(string _placement, int id = 1, Action onOpened = default(Action), Action onClosed = default(Action), Action onLeavingApplication = default(Action), Action<int> onGetReward = default(Action<int>))
		{
			return default(bool);
		}

		internal bool IsReady()
		{
			return default(bool);
		}

		public RewardAdStatus ShowAdsReward(Action<int> OnRewarded, string _placement, bool isAutoLog = true)
		{
			return default(RewardAdStatus);
		}

		public bool HideInterstitial(int id = 1)
		{
			return default(bool);
		}

		public void RegisterBannerListener(Action onOpened, Action onClosed, Action onLeavingApplication)
		{
		}

		public bool ShowBanner(int bannerId = 1)
		{
			return default(bool);
		}

		public bool HideBanner(int bannerId = 1)
		{
			return default(bool);
		}

		public int GetBannerHeight()
		{
			return default(int);
		}

		public int GetBannerWidth()
		{
			return default(int);
		}

		public void LoadInterstitial(int adsId = 1, bool isRefresh = false)
		{
		}

		public bool OnBack()
		{
			return default(bool);
		}

		public AdManager()
			: base()
		{
		}
	}
}
