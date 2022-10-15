using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class RewardLuckyWheel : MonoBehaviour
	{
		[SerializeField]
		private Image iconReward;

		[SerializeField]
		private TextMeshProUGUI txtNumberCoin;

		private Transform transIcon;

		private Transform tranNumberCoin;

		private void Start()
		{
		}

		public void Init(DataRewardLuckyWheel dataLuckyWheel)
		{
		}

		private void Update()
		{
		}

		public RewardLuckyWheel()
			: base()
		{
		}
	}
}
