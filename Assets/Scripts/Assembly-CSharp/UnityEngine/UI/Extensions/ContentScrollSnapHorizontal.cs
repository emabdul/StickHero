using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Extensions/ContentSnapScrollHorizontal")]
	public class ContentScrollSnapHorizontal : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
	{
		[Serializable]
		public class StartMovementEvent : UnityEvent
		{
			public StartMovementEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class CurrentItemChangeEvent : UnityEvent<int>
		{
			public CurrentItemChangeEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class FoundItemToSnapToEvent : UnityEvent<int>
		{
			public FoundItemToSnapToEvent()
				: base()
			{
			}
		}

		[Serializable]
		public class SnappedToItemEvent : UnityEvent<int>
		{
			public SnappedToItemEvent()
				: base()
			{
			}
		}

		[Serializable]
		public struct MoveInfo
		{
			public enum IndexType
			{
				childIndex = 0,
				positionIndex = 1
			}

			[Tooltip("Child Index means the Index corresponds to the content item at that index in the hierarchy.\nPosition Index means the Index corresponds to the content item in that snap position.\nA higher Position Index in a Horizontal Scroll Snap means it would be further to the right.")]
			public IndexType indexType;

			[Tooltip("Zero based")]
			public int index;

			[Tooltip("If this is true the snap scroll will jump to the index, otherwise it will lerp there.")]
			public bool jump;

			[Tooltip("If jump is false this is the time it will take to lerp to the index")]
			public float duration;

			public MoveInfo(IndexType _indexType, int _index)
			{
				this.duration = default(float);
				this.jump = default(bool);
				this.index = default(int);
				this.indexType = default(IndexType);
			}

			public MoveInfo(IndexType _indexType, int _index, bool _jump, float _duration)
			{
				this.duration = default(float);
				this.jump = default(bool);
				this.index = default(int);
				this.indexType = default(IndexType);
			}
		}

		public bool ignoreInactiveItems;

		public MoveInfo startInfo;

		public GameObject prevButton;

		public GameObject nextButton;

		public GameObject pagination;

		[Tooltip("The velocity below which the scroll rect will start to snap")]
		public int snappingVelocityThreshold;

		[Header("Paging Info")]
		[Tooltip("Should the pagination & buttons jump or lerp to the items")]
		public bool jumpToItem;

		[Tooltip("The time it will take for the pagination or buttons to move between items")]
		public float lerpTime;

		[SerializeField]
		[Header("Events")]
		[Tooltip("Event is triggered whenever the scroll rect starts to move, even when triggered programmatically")]
		private StartMovementEvent m_StartMovementEvent;

		[SerializeField]
		[Tooltip("Event is triggered whenever the closest item to the center of the scrollrect changes")]
		private CurrentItemChangeEvent m_CurrentItemChangeEvent;

		[SerializeField]
		[Tooltip("Event is triggered when the ContentSnapScroll decides which item it is going to snap to. Returns the index of the closest position.")]
		private FoundItemToSnapToEvent m_FoundItemToSnapToEvent;

		[SerializeField]
		[Tooltip("Event is triggered when we finally settle on an element. Returns the index of the item's position.")]
		private SnappedToItemEvent m_SnappedToItemEvent;

		private ScrollRect scrollRect;

		private RectTransform scrollRectTransform;

		private RectTransform contentTransform;

		private List<Vector3> contentPositions;

		private Vector3 lerpTarget;

		private float totalScrollableWidth;

		private DrivenRectTransformTracker tracker;

		private float mLerpTime;

		private int _closestItem;

		private bool mSliding;

		private bool mLerping;

		public StartMovementEvent MovementStarted
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurrentItemChangeEvent CurrentItemChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FoundItemToSnapToEvent ItemFoundToSnap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SnappedToItemEvent ItemSnappedTo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool ContentIsHorizonalLayoutGroup
		{
			get
			{
				return default(bool);
			}
		}

		public bool Moving
		{
			get
			{
				return default(bool);
			}
		}

		public bool Sliding
		{
			get
			{
				return default(bool);
			}
		}

		public bool Lerping
		{
			get
			{
				return default(bool);
			}
		}

		public int ClosestItemIndex
		{
			get
			{
				return default(int);
			}
		}

		public int LerpTargetIndex
		{
			get
			{
				return default(int);
			}
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupDrivenTransforms()
		{
		}

		private void SetupSnapScroll()
		{
		}

		private void SetupWithHorizontalLayoutGroup()
		{
		}

		private void SetupWithCalculatedSpacing()
		{
		}

		public void GoTo(MoveInfo info)
		{
		}

		private void GoToChild(int index, bool jump)
		{
		}

		private void GoToContentPos(int index, bool jump)
		{
		}

		public void NextItem()
		{
		}

		public void PreviousItem()
		{
		}

		public void UpdateLayout()
		{
		}

		public void UpdateLayoutAndMoveTo(MoveInfo info)
		{
		}

		public void OnBeginDrag(PointerEventData ped)
		{
		}

		public void OnEndDrag(PointerEventData ped)
		{
		}

		private void Update()
		{
		}

		private IEnumerator SlideAndLerp()
		{
			return null;
		}

		private IEnumerator LerpToContent()
		{
			return null;
		}

		private void StopMovement()
		{
		}

		private void ChangePaginationInfo(int targetScreen)
		{
		}

		private Vector2 DstFromTopLeftOfTransformToTopLeftOfParent(RectTransform rt)
		{
			return default(Vector2);
		}

		private Vector3 FindClosestFrom(Vector3 start)
		{
			return default(Vector3);
		}

		public ContentScrollSnapHorizontal()
			: base()
		{
		}
	}
}
