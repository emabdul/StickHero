using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class IapPackItem : MonoBehaviour
	{
		[SerializeField]
		private Image imageGem;

		[SerializeField]
		private Image imageSkin;

		[SerializeField]
		private Image imageWeapon;

		[SerializeField]
		private List<Image> listImagePlus;

		[SerializeField]
		private Button btnPurchase;

		[SerializeField]
		private TextMeshProUGUI gemText;

		[SerializeField]
		private TextMeshProUGUI priceText;

		[SerializeField]
		private List<Sprite> listHeadIcons;

		[SerializeField]
		private List<Sprite> listSkinIcons;

		[SerializeField]
		private List<Sprite> listArmorIcons;

		[SerializeField]
		private List<Sprite> listWeaponIcons;

		[SerializeField]
		private List<Sprite> listGemIcons;

		public TextMeshProUGUI PriceText
		{
			get
			{
				return null;
			}
		}

		public float Price { get; set; }

		public IapPackReward IapPackReward { get; set; }

		public IdPack IdPack { get; set; }

		public InfoPackage InfoPackage { get; set; }

		private void Start()
		{
		}

		public void Init()
		{
		}

		private void OnClickBtnPurchase()
		{
		}

		public void DisableSkin()
		{
		}

		public void EnableSkin()
		{
		}

		public IapPackItem()
			: base()
		{
		}
	}
}
