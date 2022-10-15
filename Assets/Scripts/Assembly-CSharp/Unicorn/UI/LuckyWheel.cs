using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class LuckyWheel : UICanvas
	{
		public Transform wheel;

		[SerializeField]
		private Button btnBack;

		[SerializeField]
		private Button btnFreeSpin;

		[SerializeField]
		private Button btnVideoSpin;

		private int slotWheel;

		private Vector3 angleTarget;

		private const int NUMBER_ROTATE_AROUND = 5;

		private const int NUMBER_PIECE_OF_WHEEL = 8;

		private const float TIME_ROTATE = 3f;

		[SerializeField]
		private List<RewardLuckyWheel> listItemRewards;

		[SerializeField]
		private List<ItemFreeReward> listItemFreeSpin;

		[SerializeField]
		private TextMeshProUGUI txtNumberDaily;

		[SerializeField]
		private RectTransform rectPointNumberWatchVideoSpin;

		[SerializeField]
		private TextMeshProUGUI txtNumberWatchVideo;

		[SerializeField]
		private Image imgBarProcessWatchVideo;

		[SerializeField]
		private GameObject objClockFreeSpin;

		[SerializeField]
		private TextMeshProUGUI txtClockFreeSpin;

		private float WidthBar;

		private float totalTimeReset;

		private bool isCoutdown;

		private bool isRotating;

		private float _time;

		private void Start()
		{
		}

		private void OnClickBtnBack()
		{
		}

		private void Update()
		{
		}

		public override void Show(bool _isShown, bool isHideMain = true)
		{
		}

		public void Init()
		{
		}

		private void SetupTimeWaitFreeSpin()
		{
		}

		private void SetLayoutBtnVideoSpin()
		{
		}

		private void SetupFreeRewards()
		{
		}

		public void StartRotateWheel(bool isFree = true)
		{
		}

		private Vector3 CalculateAngle(int indexPrize)
		{
			return default(Vector3);
		}

		private void OnCompleteRotate()
		{
		}

		private void OnClickBtnFreeSpin()
		{
		}

		private void OnClickBtnVideoSpin()
		{
		}

		private IEnumerator ActionWatchVideo()
		{
			return null;
		}

		private void OnRewardVideo(int x)
		{
		}

		public override void OnBackPressed()
		{
		}

		public LuckyWheel()
			: base()
		{
		}
	}
}
