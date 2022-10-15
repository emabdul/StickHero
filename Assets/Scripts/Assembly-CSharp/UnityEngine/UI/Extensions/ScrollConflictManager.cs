using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Scrollrect Conflict Manager")]
	public class ScrollConflictManager : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Tooltip("The parent ScrollRect control hosting this ScrollSnap")]
		public ScrollRect ParentScrollRect;

		[Tooltip("The parent ScrollSnap control hosting this Scroll Snap.\nIf left empty, it will use the ScrollSnap of the ParentScrollRect")]
		public ScrollSnapBase ParentScrollSnap;

		private ScrollRect _myScrollRect;

		private IBeginDragHandler[] _beginDragHandlers;

		private IEndDragHandler[] _endDragHandlers;

		private IDragHandler[] _dragHandlers;

		private bool scrollOther;

		private bool scrollOtherHorizontally;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		public void OnEndDrag(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public ScrollConflictManager()
			: base()
		{
		}
	}
}
