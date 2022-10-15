using System;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Segmented Control/Segmented Control")]
	public class SegmentedControl : UIBehaviour
	{
		[Serializable]
		public class SegmentSelectedEvent : UnityEvent<int>
		{
			public SegmentSelectedEvent()
				: base()
			{
			}
		}

		private Selectable[] m_segments;

		[SerializeField]
		[Tooltip("A GameObject with an Image to use as a separator between segments. Size of the RectTransform will determine the size of the separator used.\nNote, make sure to disable the separator GO so that it does not affect the scene")]
		private Graphic m_separator;

		private float m_separatorWidth;

		[SerializeField]
		[Tooltip("When True, it allows each button to be toggled on/off")]
		private bool m_allowSwitchingOff;

		[SerializeField]
		[Tooltip("The selected default for the control (zero indexed array)")]
		private int m_selectedSegmentIndex;

		[SerializeField]
		[Tooltip("Event to fire once the selection has been changed")]
		private SegmentSelectedEvent m_onValueChanged;

		internal Selectable selectedSegment;

		protected float SeparatorWidth
		{
			get
			{
				return default(float);
			}
		}

		public Selectable[] segments
		{
			get
			{
				return null;
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

		public bool allowSwitchingOff
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int selectedSegmentIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public SegmentSelectedEvent onValueChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected SegmentedControl()
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

		private Selectable[] GetChildSegments()
		{
			return null;
		}

		private void RecreateSprites()
		{
		}

		internal static Sprite CutSprite(Sprite sprite, bool leftmost, bool rightmost)
		{
			return null;
		}

		public void LayoutSegments()
		{
		}
	}
}
