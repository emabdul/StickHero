using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI.Shop
{
	public class ShopTab : MonoBehaviour
	{
		[SerializeField]
		private Button btnTab;

		[SerializeField]
		private List<Sprite> listSprStateTabs;

		[SerializeField]
		private Image imgButton;

		private ShopCharacter shopController;

		public bool IsActive { get; private set; }

		private void Start()
		{
		}

		public void Init(ShopCharacter _shopController)
		{
		}

		public void ActiveTab()
		{
		}

		public void DisableTab()
		{
		}

		private void OnClickBtnTab()
		{
		}

		public ShopTab()
			: base()
		{
		}
	}
}
