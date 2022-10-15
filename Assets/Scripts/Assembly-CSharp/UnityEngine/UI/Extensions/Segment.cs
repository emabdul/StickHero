using System.Collections;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Segmented Control/Segment")]
	public class Segment : UIBehaviour, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, ISelectHandler, IDeselectHandler
	{
		internal int index;

		internal SegmentedControl segmentedControl;

		internal Sprite cutSprite;

		internal bool leftmost
		{
			get
			{
				return default(bool);
			}
		}

		internal bool rightmost
		{
			get
			{
				return default(bool);
			}
		}

		public bool selected
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal Selectable button
		{
			get
			{
				return null;
			}
		}

		protected Segment()
			: base()
		{
		}

		protected override void Start()
		{
		}

		private IEnumerator DelayedInit()
		{
			return null;
		}

		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		public virtual void OnSelect(BaseEventData eventData)
		{
		}

		public virtual void OnDeselect(BaseEventData eventData)
		{
		}

		protected override void OnEnable()
		{
		}

		public virtual void OnSubmit(BaseEventData eventData)
		{
		}

		private void SetSelected(bool value)
		{
		}

		private void Deselect()
		{
		}

		private void MaintainSelection()
		{
		}

		internal void TransitionButton()
		{
		}

		internal void TransitionButton(bool instant)
		{
		}

		private void StartColorTween(Color targetColor, bool instant)
		{
		}

		private void ChangeTextColor(Color targetColor)
		{
		}

		private void DoSpriteSwap(Sprite newSprite)
		{
		}

		private void TriggerAnimation(string triggername)
		{
		}
	}
}
