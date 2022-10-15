using System.Collections;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Tooltip/Tooltip Trigger")]
	public class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
	{
		public enum TooltipPositioningType
		{
			mousePosition = 0,
			mousePositionAndFollow = 1,
			transformPosition = 2
		}

		[TextArea]
		public string text;

		[Tooltip("Defines where the tooltip will be placed and how that placement will occur. Transform position will always be used if this element wasn't selected via mouse")]
		public TooltipPositioningType tooltipPositioningType;

		private bool isChildOfOverlayCanvas;

		private bool hovered;

		public Vector3 offset;

		public bool WorldToScreenIsRequired
		{
			get
			{
				return default(bool);
			}
		}

		private void Start()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		private IEnumerator HoveredMouseFollowingLoop()
		{
			return null;
		}

		public void OnSelect(BaseEventData eventData)
		{
		}

		public void OnPointerExit(PointerEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}

		private void StartHover(Vector3 position, bool shouldCanvasUpdate = false)
		{
		}

		private void StopHover()
		{
		}

		public TooltipTrigger()
			: base()
		{
		}
	}
}
