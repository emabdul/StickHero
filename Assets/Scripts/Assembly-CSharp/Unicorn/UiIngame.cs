using TMPro;
using Unicorn.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class UiIngame : UICanvas
	{
		[SerializeField]
		private TextMeshProUGUI levelText;

		[SerializeField]
		private TextMeshProUGUI levelDescription;

		[SerializeField]
		private LvlProgressAnimator lvlProgressAnimator;

		[SerializeField]
		private Button btnRestart;

		[SerializeField]
		private Button btnSkip;

		[SerializeField]
		private Button btnHome;

		[SerializeField]
		private Button btnX2;

		private bool isShowAd;

		public Button BtnHome
		{
			get
			{
				return null;
			}
		}

		public Button BtnSkip
		{
			get
			{
				return null;
			}
		}

		public Button BtnRestart
		{
			get
			{
				return null;
			}
		}

		private void Start()
		{
		}

		public void DisableButtonsTut()
		{
		}

		public void EnableButtonsTut()
		{
		}

		public void DisableButtons()
		{
		}

		private void OnClickBtnRestart()
		{
		}

		private void OnClickBtnX2()
		{
		}

		private void OnClickBtnSkip()
		{
		}

		private void OnClickBtnHome()
		{
		}

		public void Init()
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		private void OnRewardSkip(int x)
		{
		}

		private void OnRewardRestart(int x)
		{
		}

		private void OnRewardX2(int x)
		{
		}

		public UiIngame()
			: base()
		{
		}
	}
}
