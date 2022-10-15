using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/UIScrollToSelection")]
	public class UIScrollToSelection : MonoBehaviour
	{
		public enum ScrollType
		{
			VERTICAL = 0,
			HORIZONTAL = 1,
			BOTH = 2
		}

		[SerializeField]
		[Header("[ Settings ]")]
		private ScrollType scrollDirection;

		[SerializeField]
		private float scrollSpeed;

		[SerializeField]
		[Header("[ Input ]")]
		private bool cancelScrollOnInput;

		[SerializeField]
		private List<KeyCode> cancelScrollKeycodes;

		protected RectTransform LayoutListGroup
		{
			get
			{
				return null;
			}
		}

		protected ScrollType ScrollDirection
		{
			get
			{
				return default(ScrollType);
			}
		}

		protected float ScrollSpeed
		{
			get
			{
				return default(float);
			}
		}

		protected bool CancelScrollOnInput
		{
			get
			{
				return default(bool);
			}
		}

		protected List<KeyCode> CancelScrollKeycodes
		{
			get
			{
				return null;
			}
		}

		protected RectTransform ScrollWindow { get; set; }

		protected ScrollRect TargetScrollRect { get; set; }

		protected EventSystem CurrentEventSystem
		{
			get
			{
				return null;
			}
		}

		protected GameObject LastCheckedGameObject { get; set; }

		protected GameObject CurrentSelectedGameObject
		{
			get
			{
				return null;
			}
		}

		protected RectTransform CurrentTargetRectTransform { get; set; }

		protected bool IsManualScrollingAvailable { get; set; }

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateReferences()
		{
		}

		private void CheckIfScrollingShouldBeLocked()
		{
		}

		private void ScrollRectToLevelSelection()
		{
		}

		private void UpdateVerticalScrollPosition(RectTransform selection)
		{
		}

		private void UpdateHorizontalScrollPosition(RectTransform selection)
		{
		}

		private float GetScrollOffset(float position, float listAnchorPosition, float targetLength, float maskLength)
		{
			return default(float);
		}

		public UIScrollToSelection()
			: base()
		{
		}
	}
}
