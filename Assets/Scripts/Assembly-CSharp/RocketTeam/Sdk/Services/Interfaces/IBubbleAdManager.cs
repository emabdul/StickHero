using System;

namespace RocketTeam.Sdk.Services.Interfaces
{
	public interface IBubbleAdManager
	{
		void RegisterListener(Action onLoaded, Action<int, string> onFailedToLoad, Action onOpened, Action onClosed, Action onLeavingApplication);

		void LoadBubbleAd(bool isRefresh = false);

		bool ShowBubbleAd();

		bool HideBubbleAd();

		bool IsBubbleAdShowing();

		bool IsBubbleAdLoading();

		bool OnBack();
	}
}
