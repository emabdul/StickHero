using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class UiMainLobby : UICanvas
	{
		[SerializeField]
		private LvlProgressAnimator lvlProgressAnimator;

		[SerializeField]
		private Button btnPlay;

		[SerializeField]
		private Button btnLuckySpin;

		[SerializeField]
		private Button btnSkin;

		[SerializeField]
		private Button btnNoAds;

		[SerializeField]
		private Button btnSetting;

		[SerializeField]
		private Button btnGift;

		[SerializeField]
		private Button btnChallenge;

		[SerializeField]
		private Button btnArena;

		[SerializeField]
		private List<Image> listImgKeys;

		[SerializeField]
		private TextMeshProUGUI txtCurentLevel;

		[SerializeField]
		private TextMeshProUGUI txtLockCastle;

		private bool isFistOpen;

		public Button BtnNoAds
		{
			get
			{
				return null;
			}
		}

		public Button BtnPlay
		{
			get
			{
				return null;
			}
		}

		private void Start()
		{
		}

		private void Init()
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		private void OnClickBtnChallenge()
		{
		}

		private void OnClickBtnArena()
		{
		}

		private void OnClickBtnPlay()
		{
		}

		private void OnClickBtnSpin()
		{
		}

		private void OnClickShopSkin()
		{
		}

		private void OnClickBtnNoAds()
		{
		}

		private void OnClickBtnSetting()
		{
		}

		public void ShowAniHide()
		{
		}

		public void ActiveMainLobby()
		{
		}

		public void Hack()
		{
		}

		private void OnClickBtnGift()
		{
		}

		private IEnumerator ActionWatchVideo()
		{
			return null;
		}

		private void OnRewardGift(int x)
		{
		}

		private int GetIdSkin()
		{
			return default(int);
		}

		private int GetIdHat()
		{
			return default(int);
		}

		private bool IsShowGift()
		{
			return default(bool);
		}

		public UiMainLobby()
			: base()
		{
		}
	}
}
