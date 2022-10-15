using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class ItemFreeReward : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private TextMeshProUGUI txtNumberSpin;

		[SerializeField]
		private Image imgBg;

		[SerializeField]
		private List<Sprite> listSprBg;

		private float WidthBar;

		public void Init(RewardEndGame data)
		{
		}

		public ItemFreeReward()
			: base()
		{
		}
	}
}
