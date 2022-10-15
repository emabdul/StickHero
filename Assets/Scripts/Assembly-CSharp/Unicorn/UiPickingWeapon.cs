using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unicorn.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class UiPickingWeapon : UICanvas
	{
		[SerializeField]
		private TextMeshProUGUI powerText1;

		[SerializeField]
		private TextMeshProUGUI powerText2;

		[SerializeField]
		private Image weaponImage1;

		[SerializeField]
		private Image weaponImage2;

		[SerializeField]
		private Image imageBackground_1;

		[SerializeField]
		private Image imageBackground_2;

		[SerializeField]
		private List<Sprite> listSprite;

		[SerializeField]
		private List<Sprite> listSpriteBg;

		[SerializeField]
		private Button btnWeapon1;

		[SerializeField]
		private Button btnWeapon2;

		[SerializeField]
		private Button btnNoThanks;

		[SerializeField]
		private int divFactor;

		private int axeMin;

		private int axeMax;

		private int knifeMin;

		private int knifeMax;

		private int hammerMin;

		private int hammerMax;

		private int swordMin;

		private int swordMax;

		private int handGunMin;

		private int handGunMax;

		private int miniGunMin;

		private int miniGunMax;

		private int rifleMin;

		private int rifleMax;

		private int shotgunMin;

		private int shotgunMax;

		private bool isShowAd;

		private int weapon1;

		private int weapon2;

		private int lastIndex;

		public int Buff { get; set; }

		public bool isWatch_1 { get; set; }

		public bool isWatch_2 { get; set; }

		private void Start()
		{
		}

		private void OnClickBtnWeapon1()
		{
		}

		private void OnClickBtnWeapon2()
		{
		}

		private void OnClickBtnNoThanks()
		{
		}

		private void OnRewardWeapon1(int x)
		{
		}

		private void OnRewardWeapon2(int x)
		{
		}

		private void Init()
		{
		}

		private void InitPower()
		{
		}

		private void RandomWeapons()
		{
		}

		private void InitIAPWeapon()
		{
		}

		private int GetRandomInt(WeaponType weaponType)
		{
			return default(int);
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		public UiPickingWeapon()
			: base()
		{
		}
	}
}
