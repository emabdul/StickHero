using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class UiWin : UICanvas
	{
		[SerializeField]
		private Button btnCollectGold;

		[SerializeField]
		private Button btnX3Coin;

		[SerializeField]
		private Image iconRewardBg;

		[SerializeField]
		private Image iconReward;

		[SerializeField]
		private Image imgProcessReward;

		[SerializeField]
		private TextMeshProUGUI txtProcessReward;

		[SerializeField]
		private TextMeshProUGUI txtCoin;

		[SerializeField]
		private TextMeshProUGUI txtCoinBonus;

		[SerializeField]
		private TextMeshProUGUI txtCoinBonusFree;

		[SerializeField]
		private TextMeshProUGUI txtCoinReward;

		[SerializeField]
		private LuckyWheelEndgame forceBar;

		[SerializeField]
		private DataRewardEndGame dataRewards;

		[SerializeField]
		private GameObject objFx;

		private int percentReward;

		private int _gold;

		private bool isShowAd;

		private Tweener tweenCoin;

		private int tmpPercent;

		public int _Gem { get; set; }

		public int Gold
		{
			get
			{
				return default(int);
			}
			protected set
			{
			}
		}

		private void Start()
		{
		}

		public virtual void Init(int gold, int gem)
		{
		}

		protected virtual void CalculateGold(int gold)
		{
		}

		private void Update()
		{
		}

		private void SetupRewardEndGame()
		{
		}

		private void SetPercentReward(int percent)
		{
		}

		private void OnClickBtnNoThank()
		{
		}

		private void OnClickBtnX3Coin()
		{
		}

		private void OnRewardVideo(int x)
		{
		}

		private IEnumerator IEWaitShowRewardEndGame(RewardEndGame reward)
		{
			return null;
		}

		private IEnumerator IEWaitShowFx()
		{
			return null;
		}

		private IEnumerator IEShowRateGame()
		{
			return null;
		}

		private IEnumerator IEGoLobby(bool isShowInter)
		{
			return null;
		}

		public UiWin()
			: base()
		{
		}
	}
}
