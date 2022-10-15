using System;

namespace RocketTeam.Sdk.Services.Interfaces
{
	public interface IMoreGamesManager : IG2Service
	{
		void RegisterListener(Action onLoaded, Action<int, string> onFailedToLoad, Action onOpened, Action onClosed, Action onLeavingApplication, Action<int> onGetReward);

		void LoadMoreGames(int offset = 0, int limit = 0, bool isRefresh = false);

		bool ShowMoreGames();

		bool HideMoreGames();

		bool IsMoreGamesShowing();

		bool IsMoreGamesLoading();

		bool OnBack();
	}
}
