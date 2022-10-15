using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class IapSingleItem : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI gemText;

		[SerializeField]
		private TextMeshProUGUI priceText;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private Button btnPurchase;

		[SerializeField]
		private List<Sprite> listIcons;

		public TextMeshProUGUI PriceText
		{
			get
			{
				return null;
			}
		}

		public float Price { get; set; }

		public int Gem { get; set; }

		public IdPack IdPack { get; set; }

		private void Start()
		{
		}

		public void Init()
		{
		}

		private void OnClickBtnPurchase()
		{
		}

		public IapSingleItem()
			: base()
		{
		}
	}
}
