using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class PopupRewardEndGame : UICanvas
	{
		[SerializeField]
		private Image imgIcon;

		[SerializeField]
		private Button btnVideo;

		[SerializeField]
		private Button btnClose;

		[SerializeField]
		private Button btnClaim;

		[SerializeField]
		private TextMeshProUGUI txtCoinReplace;

		private RewardEndGame _reward;

		[SerializeField]
		private GameObject objParentRewards;

		private void Start()
		{
		}

		public void Init(RewardEndGame reward, TypeDialogReward type)
		{
		}

		private void OnClickBtnVideo()
		{
		}

		private void OnClickBtnClose()
		{
		}

		private void OnClickBtnClaim()
		{
		}

		private void OnRewardedVideo(int x)
		{
		}

		public void ActiveReward()
		{
		}

		private void SetupNextReward()
		{
		}

		public PopupRewardEndGame()
			: base()
		{
		}
	}
}
