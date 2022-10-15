using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Stepper")]
	public class Stepper : UIBehaviour
	{
		[Serializable]
		public class StepperValueChangedEvent : UnityEvent<int>
		{
			public StepperValueChangedEvent()
				: base()
			{
			}
		}

		private Selectable[] _sides;

		[SerializeField]
		[Tooltip("The current step value of the control")]
		private int _value;

		[SerializeField]
		[Tooltip("The minimum step value allowed by the control. When reached it will disable the '-' button")]
		private int _minimum;

		[SerializeField]
		[Tooltip("The maximum step value allowed by the control. When reached it will disable the '+' button")]
		private int _maximum;

		[SerializeField]
		[Tooltip("The step increment used to increment / decrement the step value")]
		private int _step;

		[SerializeField]
		[Tooltip("Does the step value loop around from end to end")]
		private bool _wrap;

		[SerializeField]
		[Tooltip("A GameObject with an Image to use as a separator between segments. Size of the RectTransform will determine the size of the separator used.\nNote, make sure to disable the separator GO so that it does not affect the scene")]
		private Graphic _separator;

		private float _separatorWidth;

		[SerializeField]
		private StepperValueChangedEvent _onValueChanged;

		private float separatorWidth
		{
			get
			{
				return default(float);
			}
		}

		public Selectable[] sides
		{
			get
			{
				return null;
			}
		}

		public int value
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int minimum
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int maximum
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int step
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool wrap
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public Graphic separator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StepperValueChangedEvent onValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected Stepper()
			: base()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		private IEnumerator DelayedInit()
		{
			return null;
		}

		private Selectable[] GetSides()
		{
			return null;
		}

		public void StepUp()
		{
		}

		public void StepDown()
		{
		}

		private void Step(int amount)
		{
		}

		private void DisableAtExtremes(Selectable[] sides)
		{
		}

		private void RecreateSprites(Selectable[] sides)
		{
		}

		internal static Sprite CutSprite(Sprite sprite, bool leftmost)
		{
			return null;
		}

		public void LayoutSides(Selectable[] sides = default(Selectable[]))
		{
		}
	}
}
