using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;
using UnityEngine.UI.Extensions.EasingCore;

namespace UnityEngine.UI.Extensions
{
	public class Scroller : UIBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler
	{
		[Serializable]
		private class Snap
		{
			public bool Enable;

			public float VelocityThreshold;

			public float Duration;

			public Ease Easing;

			public Snap()
				: base()
			{
			}
		}

		private class AutoScrollState
		{
			public bool Enable;

			public bool Elastic;

			public float Duration;

			public EasingFunction EasingFunction;

			public float StartTime;

			public float EndPosition;

			public Action OnComplete;

			public void Reset()
			{
			}

			public void Complete()
			{
			}

			public AutoScrollState()
				: base()
			{
			}
		}

		[SerializeField]
		private RectTransform viewport;

		[SerializeField]
		private ScrollDirection scrollDirection;

		[SerializeField]
		private MovementType movementType;

		[SerializeField]
		private float elasticity;

		[SerializeField]
		private float scrollSensitivity;

		[SerializeField]
		private bool inertia;

		[SerializeField]
		private float decelerationRate;

		[SerializeField]
		private Snap snap;

		[SerializeField]
		private bool draggable;

		[SerializeField]
		private Scrollbar scrollbar;

		private readonly AutoScrollState autoScrollState;

		private Action<float> onValueChanged;

		private Action<int> onSelectionChanged;

		private Vector2 beginDragPointerPosition;

		private float scrollStartPosition;

		private float prevPosition;

		private float currentPosition;

		private int totalCount;

		private bool hold;

		private bool scrolling;

		private bool dragging;

		private float velocity;

		private static readonly EasingFunction DefaultEasingFunction;

		public float ViewportSize
		{
			get
			{
				return default(float);
			}
		}

		public ScrollDirection ScrollDirection
		{
			get
			{
				return default(ScrollDirection);
			}
		}

		public MovementType MovementType
		{
			get
			{
				return default(MovementType);
			}
			set
			{
			}
		}

		public float Elasticity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ScrollSensitivity
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool Inertia
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float DecelerationRate
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool SnapEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool Draggable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Scrollbar Scrollbar
		{
			get
			{
				return null;
			}
		}

		public float Position
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		public void OnValueChanged(Action<float> callback)
		{
		}

		public void OnSelectionChanged(Action<int> callback)
		{
		}

		public void SetTotalCount(int totalCount)
		{
		}

		public void ScrollTo(float position, float duration, Action onComplete = default(Action))
		{
		}

		public void ScrollTo(float position, float duration, Ease easing, Action onComplete = default(Action))
		{
		}

		public void ScrollTo(float position, float duration, EasingFunction easingFunction, Action onComplete = default(Action))
		{
		}

		public void JumpTo(int index)
		{
		}

		public MovementDirection GetMovementDirection(int sourceIndex, int destIndex)
		{
			return default(MovementDirection);
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		void IScrollHandler.OnScroll(PointerEventData eventData)
		{
		}

		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
		{
		}

		void IDragHandler.OnDrag(PointerEventData eventData)
		{
		}

		void IEndDragHandler.OnEndDrag(PointerEventData eventData)
		{
		}

		private float CalculateOffset(float position)
		{
			return default(float);
		}

		private void UpdatePosition(float position, bool updateScrollbar = true)
		{
		}

		private void UpdateSelection(int index)
		{
		}

		private float RubberDelta(float overStretching, float viewSize)
		{
			return default(float);
		}

		private void Update()
		{
		}

		private float CalculateMovementAmount(float sourcePosition, float destPosition)
		{
			return default(float);
		}

		private float CircularPosition(float p, int size)
		{
			return default(float);
		}

		public Scroller()
			: base()
		{
		}
	}
}
