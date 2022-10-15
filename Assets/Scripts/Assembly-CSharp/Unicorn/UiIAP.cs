using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unicorn.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class UiIAP : UICanvas
	{
		[SerializeField]
		private Button btnBack;

		[SerializeField]
		private IapSingleItem singleItemPrefab;

		[SerializeField]
		private IapPackItem packItemPrefab;

		[SerializeField]
		private Transform horizontalContent;

		[SerializeField]
		private Transform verticalContent;

		[SerializeField]
		private HorizontalLayoutGroup horizontalLayoutGroup;

		[SerializeField]
		private VerticalLayoutGroup verticalLayoutGroup;

		[SerializeField]
		private DataShopIap dataShopIap;

		public DataShopIap DataShopIap
		{
			get
			{
				return null;
			}
		}

		public List<IapSingleItem> IapSingleItems { get; set; }

		public List<IapPackItem> IapPackItems { get; set; }

		private new void Awake()
		{
		}

		private void Start()
		{
		}

		private void Init()
		{
		}

		private void InitHorizontalItem(List<IdPack> keys)
		{
		}

		private void InitVerticalItem(List<IdPack> keys)
		{
		}

		public void Refresh()
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		private void OnClickBtnBack()
		{
		}

		private bool CheckUnlockAllWeapons()
		{
			return default(bool);
		}

		public UiIAP()
			: base()
		{
		}
	}
}
