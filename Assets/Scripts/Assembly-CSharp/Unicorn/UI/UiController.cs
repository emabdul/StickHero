using Unicorn.UI.Shop;
using UnityEngine;

namespace Unicorn.UI
{
	public class UiController : MonoBehaviour
	{
		public UiIngame UiIngame;

		public UISetting UiSetting;

		public UiBonusLevel UiBonusLevel;

		public UiTop uiTop;

		public UiPickingWeapon UiPickingWeapon;

		public UiTutorial UiTutorial;

		public UiCastle UiCastle;

		public UiChallengeSwipe UiChallenge;

		public UiGem UiGem;

		public UiIAP UiIAP;

		public UiMainLobby UiMainLobby;

		public UiLose UiLose;

		public UiWin UiWin;

		public ShopCharacter ShopCharacter;

		public PopupRewardEndGame PopupRewardEndGame;

		public PopupChestKey PopupChestKey;

		public LuckyWheel LuckyWheel;

		public GameObject Loading;

		public void Init()
		{
		}

		public void OpenUiLose()
		{
		}

		public void OpenUiWin(int gold, int gem)
		{
		}

		public void OpenShopCharacter()
		{
		}

		public void OpenPopupReward(RewardEndGame reward, TypeDialogReward type)
		{
		}

		public void OpenPopupChestKey(RewardEndGame reward)
		{
		}

		public void OpenLuckyWheel()
		{
		}

		public void OpenLoading(bool isLoading)
		{
		}

		public UiController()
			: base()
		{
		}
	}
}
