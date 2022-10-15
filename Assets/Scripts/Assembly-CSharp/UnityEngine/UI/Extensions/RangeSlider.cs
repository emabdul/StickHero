using System;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Extensions/Range Slider", 34)]
	public class RangeSlider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		[Serializable]
		public class RangeSliderEvent : UnityEvent<float, float>
		{
			public RangeSliderEvent()
				: base()
			{
			}
		}

		private enum InteractionState
		{
			Low = 0,
			High = 1,
			Bar = 2,
			None = 3
		}

		[SerializeField]
		private RectTransform m_FillRect;

		[SerializeField]
		private RectTransform m_LowHandleRect;

		[SerializeField]
		private RectTransform m_HighHandleRect;

		[Space]
		[SerializeField]
		private float m_MinValue;

		[SerializeField]
		private float m_MaxValue;

		[SerializeField]
		private bool m_WholeNumbers;

		[SerializeField]
		private float m_LowValue;

		[SerializeField]
		private float m_HighValue;

		[SerializeField]
		[Space]
		private RangeSliderEvent m_OnValueChanged;

		private InteractionState interactionState;

		private Image m_FillImage;

		private Transform m_FillTransform;

		private RectTransform m_FillContainerRect;

		private Transform m_HighHandleTransform;

		private RectTransform m_HighHandleContainerRect;

		private Transform m_LowHandleTransform;

		private RectTransform m_LowHandleContainerRect;

		private Vector2 m_LowOffset;

		private Vector2 m_HighOffset;

		private DrivenRectTransformTracker m_Tracker;

		private bool m_DelayedUpdateVisuals;

		public RectTransform FillRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectTransform LowHandleRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RectTransform HighHandleRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float MinValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float MaxValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool WholeNumbers
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual float LowValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NormalizedLowValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public virtual float HighValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NormalizedHighValue
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public RangeSliderEvent OnValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private float StepSize
		{
			get
			{
				return default(float);
			}
		}

		public virtual void SetValueWithoutNotify(float low, float high)
		{
		}

		protected RangeSlider()
			: base()
		{
		}

		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		public virtual void LayoutComplete()
		{
		}

		public virtual void GraphicUpdateComplete()
		{
		}

		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			return default(bool);
		}

		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			return default(bool);
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected override void OnDidApplyAnimationProperties()
		{
		}

		private void UpdateCachedReferences()
		{
		}

		private void SetLow(float input)
		{
		}

		protected virtual void SetLow(float input, bool sendCallback)
		{
		}

		private void SetHigh(float input)
		{
		}

		protected virtual void SetHigh(float input, bool sendCallback)
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		private void UpdateVisuals()
		{
		}

		private void UpdateDrag(PointerEventData eventData, Camera cam)
		{
		}

		private float CalculateDrag(PointerEventData eventData, Camera cam, RectTransform containerRect, Vector2 offset)
		{
			return default(float);
		}

		private void CalculateBarDrag(PointerEventData eventData, Camera cam)
		{
		}

		private bool MayDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		public override void OnMove(AxisEventData eventData)
		{
		}

		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
		}

		Transform ICanvasElement.transform
		{
			get
			{
				return null;
			}
		}
	}
}
