using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn.UI.Shop
{
	public class ShopCharacter : UICanvas
	{
		[SerializeField]
		private List<ShopContent> contents;

		[SerializeField]
		private List<ShopTab> tabs;

		[SerializeField]
		private List<PageIndicator> listObjTabBottom;

		[SerializeField]
		private SkinChanger skinChanger;

		[SerializeField]
		private DataShopSkin dataShopSkin;

		[SerializeField]
		private CanvasGroup notEnoughGold;

		[SerializeField]
		private CanvasGroup notEnoughGem;

		private Dictionary<TypeEquipment, ShopContent> shopContentsDictionary;

		public IDataSkin DataSkin { get; private set; }

		public SkinChanger SkinChanger
		{
			get
			{
				return null;
			}
		}

		public DataShopSkin DataShopSkin
		{
			get
			{
				return null;
			}
		}

		public DataTextureSkin DataTextureSkin { get; private set; }

		public void Configure(IDataSkin dataSkin, DataTextureSkin dataTextureSkin)
		{
		}

		private void InitContents()
		{
		}

		private void InitContent(ShopContent shopContent)
		{
		}

		private void Init()
		{
		}

		public void ReloadLayout(TypeEquipment typeEquipment)
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		public void ActiveContentTab(int idTab)
		{
		}

		public void SetupTabBottom(int currentTab, int countTab)
		{
		}

		public override void OnBackPressed()
		{
		}

		public void NotifyNotEnoughGold(Transform trans)
		{
		}

		private void SetParentNotiNotEnoughGold(Transform trans)
		{
		}

		public void NotifyNotEnoughGem(Transform trans)
		{
		}

		private void SetParentNotiNotEnoughGem(Transform trans)
		{
		}

		public ShopCharacter()
			: base()
		{
		}
	}
}
