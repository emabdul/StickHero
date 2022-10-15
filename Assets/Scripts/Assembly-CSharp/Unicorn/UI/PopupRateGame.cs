using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.Play.Review;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn.UI
{
	[Singleton("Popup/PopupRateGame", true)]
	public class PopupRateGame : Singleton<PopupRateGame>
	{
		[SerializeField]
		private Button btnConfirm;

		[SerializeField]
		private Button btnNoThanks;

		[SerializeField]
		private List<Button> listBtnStar;

		[SerializeField]
		private List<Sprite> listSprStar;

		[SerializeField]
		private List<Image> listImgStar;

		private int star;

		private ReviewManager _reviewManager;

		private PlayReviewInfo _playReviewInfo;

		public bool isShow { get; set; }

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		public void Show()
		{
		}

		public void Confirm()
		{
		}

		public void Hide()
		{
		}

		private void OnClickStar(int index)
		{
		}

		private IEnumerator RequestForReview()
		{
			return null;
		}

		public PopupRateGame()
			: base()
		{
		}
	}
}
