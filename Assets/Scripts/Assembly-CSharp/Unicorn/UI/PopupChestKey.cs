using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class PopupChestKey : UICanvas
	{
		[SerializeField]
		private List<GameObject> listObjKeys;

		[SerializeField]
		private List<ItemChest> listChest;

		[SerializeField]
		private Image imgIconReward;

		[SerializeField]
		private Button btnVideo;

		[SerializeField]
		private Button btnClose;

		[SerializeField]
		private Button btnDone;

		private RewardEndGame reward;

		public int NumberWatchVideo;

		public bool IsOpenPrize;

		private void Start()
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		public void Init(RewardEndGame _reward)
		{
		}

		public void SetLayoutKey()
		{
		}

		private void OnClickBtnVideo()
		{
		}

		private void OnRewardedVideo(int x)
		{
		}

		private void OnClickBtnClose()
		{
		}

		private void OnClickBtnDone()
		{
		}

		public PopupChestKey()
			: base()
		{
		}
	}
}
