using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI.Extensions;

namespace Unicorn.UI.Shop
{
	public class ShopContent : MonoBehaviour
	{
		[SerializeField]
		[Space]
		private int pageSize;

		[SerializeField]
		private RectTransform pagePrefab;

		[SerializeField]
		private ItemSkinShop itemSkinShopPrefab;

		[SerializeField]
		private RectTransform rectTransParent;

		[SerializeField]
		private HorizontalScrollSnap_Lobby scrollViewController;

		private readonly List<RectTransform> pages;

		private readonly List<ItemSkinShop> itemSkins;

		private int currentIndex;

		private int maxIndex;

		public TypeEquipment TypeEquipment
		{
			get
			{
				return default(TypeEquipment);
			}
		}

		public ShopCharacter ShopCharacter { get; set; }

		protected virtual void Start()
		{
		}

		public virtual void InitContent(List<DataShop> listData, bool isRestPosTab = true)
		{
		}

		private void InitializeItems(List<DataShop> shopData)
		{
		}

		private void CreateItems(int itemCount)
		{
		}

		private void CreatePages(int itemCount)
		{
		}

		private void ClearAllPages()
		{
		}

		private int GetPageIndex(int itemCount)
		{
			return default(int);
		}

		private int GetTotalPage(int itemCount)
		{
			return default(int);
		}

		public void Reset()
		{
		}

		private void ChangeTab(int index)
		{
		}

		public void Change(int id)
		{
		}

		public ShopContent()
			: base()
		{
		}
	}
}
