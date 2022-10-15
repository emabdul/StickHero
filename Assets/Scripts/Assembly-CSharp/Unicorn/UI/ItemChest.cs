using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class ItemChest : MonoBehaviour
	{
		[SerializeField]
		private Button btnChest;

		[SerializeField]
		private Image imgIconReward;

		[SerializeField]
		private GameObject objRewardCoin;

		[SerializeField]
		private TextMeshProUGUI txtAmountCoin;

		private PopupChestKey popupChestKey;

		private RewardEndGame _reward;

		private void Start()
		{
		}

		private void lit()
		{
		}

		public void Init(PopupChestKey _popupChestKey, RewardEndGame reward)
		{
		}

		private void OnClickBtnChest()
		{
		}

		public ItemChest()
			: base()
		{
		}
	}
}
