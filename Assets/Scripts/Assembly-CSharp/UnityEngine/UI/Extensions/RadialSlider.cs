using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Radial Slider")]
	public class RadialSlider : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		[Serializable]
		public class RadialSliderValueChangedEvent : UnityEvent<int>
		{
			public RadialSliderValueChangedEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class RadialSliderTextValueChangedEvent : UnityEvent<string>
		{
			public RadialSliderTextValueChangedEvent()
				: base()
			{
			}
		}

		private bool isPointerDown;

		private bool isPointerReleased;

		private bool lerpInProgress;

		private Vector2 m_localPos;

		private Vector2 m_screenPos;

		private float m_targetAngle;

		private float m_lerpTargetAngle;

		private float m_startAngle;

		private float m_currentLerpTime;

		private float m_lerpTime;

		private Camera m_eventCamera;

		private Image m_image;

		[SerializeField]
		[Tooltip("Radial Gradient Start Color")]
		private Color m_startColor;

		[SerializeField]
		[Tooltip("Radial Gradient End Color")]
		private Color m_endColor;

		[SerializeField]
		[Tooltip("Move slider absolute or use Lerping?\nDragging only supported with absolute")]
		private bool m_lerpToTarget;

		[SerializeField]
		[Tooltip("Curve to apply to the Lerp\nMust be set to enable Lerp")]
		private AnimationCurve m_lerpCurve;

		[SerializeField]
		[Tooltip("Event fired when value of control changes, outputs an INT angle value")]
		private RadialSliderValueChangedEvent _onValueChanged;

		[SerializeField]
		[Tooltip("Event fired when value of control changes, outputs a TEXT angle value")]
		private RadialSliderTextValueChangedEvent _onTextValueChanged;

		public float Angle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float Value
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Color EndColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color StartColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool LerpToTarget
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public AnimationCurve LerpCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool LerpInProgress
		{
			get
			{
				return default(bool);
			}
		}

		public Image RadialImage
		{
			get
			{
				return null;
			}
		}

		public RadialSliderValueChangedEvent onValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RadialSliderTextValueChangedEvent onTextValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void StartLerp(float targetAngle)
		{
		}

		private float GetAngleFromMousePoint()
		{
			return default(float);
		}

		private void UpdateRadialImage(float targetAngle)
		{
		}

		private void NotifyValueChanged()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public void OnDrag(PointerEventData eventData)
		{
		}

		public RadialSlider()
			: base()
		{
		}
	}
}
