using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	public class UiTop : MonoBehaviour
	{
		[SerializeField]
		private Text txtGold;

		[SerializeField]
		private Text txtGem;

		[SerializeField]
		private Transform transCoin;

		[SerializeField]
		private Transform transGem;

		[SerializeField]
		private List<Image> listImgKeys;

		[SerializeField]
		private RectTransform objKey;

		[SerializeField]
		private Transform coinImage;

		[SerializeField]
		private Transform coin;

		[SerializeField]
		private Transform gem;

		private Tweener tweenCoin;

		private int tmpCoin;

		private Tweener tweenCoin1;

		private int tmpCoin1;

		public Transform Coin
		{
			get
			{
				return null;
			}
		}

		public Transform Gem
		{
			get
			{
				return null;
			}
		}

		public Transform CoinImage
		{
			get
			{
				return null;
			}
		}

		public Text TxtGold
		{
			get
			{
				return null;
			}
		}

		public Text TxtGem
		{
			get
			{
				return null;
			}
		}

		public Transform TransCoin
		{
			get
			{
				return null;
			}
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnClickBtnSetting()
		{
		}

		private void UpdateUiGold(int _type)
		{
		}

		private void UpdateUIHaveAnim(TypeItem _type)
		{
		}

		private void UpdateLayoutKey(bool isAni = false)
		{
		}

		private void SetTextCoin(int _coin)
		{
		}

		private void SetTextGem(int _gem)
		{
		}

		private void PlayAnimationScale(Transform transformScale)
		{
		}

		public UiTop()
			: base()
		{
		}
	}
}
