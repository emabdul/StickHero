using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class PopupShowRewards : UICanvas
	{
		[SerializeField]
		private Image iconRewardBg;

		[SerializeField]
		private Image iconReward;

		[SerializeField]
		private Image imgProcessReward;

		[SerializeField]
		private Text txtProcessReward;

		[SerializeField]
		private Text txtCoinReward;

		[SerializeField]
		private DataRewardEndGame dataRewards;

		private int percentReward;

		private Tweener tweenCoin;

		private int tmpPercent;

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		private void SetupRewardEndGame()
		{
		}

		private IEnumerator IEWaitShowRewardEndGame(RewardEndGame reward)
		{
			return null;
		}

		private void SetPercentReward(int percent)
		{
		}

		public override void OnBackPressed()
		{
		}

		public PopupShowRewards()
			: base()
		{
		}
	}
}
