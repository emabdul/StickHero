using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class UiLose : UICanvas
	{
		[SerializeField]
		private TextMeshProUGUI txtRetry;

		[SerializeField]
		private TextMeshProUGUI txtLevel;

		[SerializeField]
		private Button btnRetry;

		[SerializeField]
		private Button btnSkipLevel;

		[SerializeField]
		private Button btnHome;

		[SerializeField]
		private TextMeshProUGUI txtSkipLevel;

		[SerializeField]
		private Image imgSkipLevelBg;

		private Tween tween;

		private bool isShowAd;

		private void Start()
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		private void OnClickBtnHome()
		{
		}

		private void OnClickBtnRetry()
		{
		}

		private void OnClickBtnRevive()
		{
		}

		private void OnClickBtnSkip()
		{
		}

		private void OnRewardSkip(int x)
		{
		}

		private void OnReward(int x)
		{
		}

		private IEnumerator IEWaitRevive()
		{
			return null;
		}

		public UiLose()
			: base()
		{
		}
	}
}
