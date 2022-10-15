using System;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/BoxSlider")]
	public class BoxSlider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement
	{
		public enum Direction
		{
			LeftToRight = 0,
			RightToLeft = 1,
			BottomToTop = 2,
			TopToBottom = 3
		}

		[Serializable]
		public class BoxSliderEvent : UnityEvent<float, float>
		{
			public BoxSliderEvent()
				: base()
			{
			}
		}

		private enum Axis
		{
			Horizontal = 0,
			Vertical = 1
		}

		[SerializeField]
		private RectTransform m_HandleRect;

		[SerializeField]
		[Space]
		private float m_MinValue;

		[SerializeField]
		private float m_MaxValue;

		[SerializeField]
		private bool m_WholeNumbers;

		[SerializeField]
		private float m_ValueX;

		[SerializeField]
		private float m_ValueY;

		[SerializeField]
		[Space]
		private BoxSliderEvent m_OnValueChanged;

		private Transform m_HandleTransform;

		private RectTransform m_HandleContainerRect;

		private Vector2 m_Offset;

		private DrivenRectTransformTracker m_Tracker;

		public RectTransform HandleRect
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

		public float ValueX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NormalizedValueX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ValueY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NormalizedValueY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public BoxSliderEvent OnValueChanged
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

		protected BoxSlider()
			: base()
		{
		}

		public virtual void Rebuild(CanvasUpdate executing)
		{
		}

		public void LayoutComplete()
		{
		}

		public void GraphicUpdateComplete()
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

		private void UpdateCachedReferences()
		{
		}

		private void SetX(float input)
		{
		}

		private void SetX(float input, bool sendCallback)
		{
		}

		private void SetY(float input)
		{
		}

		private void SetY(float input, bool sendCallback)
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

		private bool CanDrag(PointerEventData eventData)
		{
			return default(bool);
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public virtual void OnDrag(PointerEventData eventData)
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
