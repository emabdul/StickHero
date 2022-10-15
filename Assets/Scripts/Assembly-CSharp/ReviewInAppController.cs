using System.Runtime.CompilerServices;
using Google.Play.Common;
using Google.Play.Review;
using UnityEngine;
using UnityEngine.Events;

public class ReviewInAppController : MonoBehaviour
{
	private ReviewManager _reviewManager;

	private PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> playReviewInfoAsyncOperation;

	public void ShowReview(UnityAction actionErorr)
	{
	}

	private void Complete(PlayAsyncOperation<PlayReviewInfo, ReviewErrorCode> playReviewInfoAsync, UnityAction actionErorr)
	{
	}

	public ReviewInAppController()
		: base()
	{
	}
}
