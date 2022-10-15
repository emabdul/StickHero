using System.Collections;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/ScrollRectTweener")]
	public class ScrollRectTweener : MonoBehaviour, IDragHandler, IEventSystemHandler
	{
		private ScrollRect scrollRect;

		private Vector2 startPos;

		private Vector2 targetPos;

		private bool wasHorizontal;

		private bool wasVertical;

		public float moveSpeed;

		public bool disableDragWhileTweening;

		private void Awake()
		{
		}

		public void ScrollHorizontal(float normalizedX)
		{
		}

		public void ScrollHorizontal(float normalizedX, float duration)
		{
		}

		public void ScrollVertical(float normalizedY)
		{
		}

		public void ScrollVertical(float normalizedY, float duration)
		{
		}

		public void Scroll(Vector2 normalizedPos)
		{
		}

		private float GetScrollDuration(Vector2 normalizedPos)
		{
			return default(float);
		}

		private Vector2 DeNormalize(Vector2 normalizedPos)
		{
			return default(Vector2);
		}

		private Vector2 GetCurrentPos()
		{
			return default(Vector2);
		}

		public void Scroll(Vector2 normalizedPos, float duration)
		{
		}

		private IEnumerator DoMove(float duration)
		{
			return null;
		}

		public Vector2 EaseVector(float currentTime, Vector2 startValue, Vector2 changeInValue, float duration)
		{
			return default(Vector2);
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		private void StopScroll()
		{
		}

		private void LockScrollability()
		{
		}

		private void RestoreScrollability()
		{
		}

		public ScrollRectTweener()
			: base()
		{
		}
	}
}
