using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("Layout/Extensions/Horizontal Scroll Snap")]
	public class HorizontalScrollSnap : ScrollSnapBase
	{
		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool IsRectMovingSlowerThanThreshold(float startingSpeed)
		{
			return default(bool);
		}

		public void DistributePages()
		{
		}

		public void AddChild(GameObject GO)
		{
		}

		public void AddChild(GameObject GO, bool WorldPositionStays)
		{
		}

		public void RemoveChild(int index, out GameObject ChildRemoved)
		{
			ChildRemoved = default(GameObject);
		}

		public void RemoveChild(int index, bool WorldPositionStays, out GameObject ChildRemoved)
		{
			ChildRemoved = default(GameObject);
		}

		public void RemoveAllChildren(out GameObject[] ChildrenRemoved)
		{
			ChildrenRemoved = default(GameObject[]);
		}

		public void RemoveAllChildren(bool WorldPositionStays, out GameObject[] ChildrenRemoved)
		{
			ChildrenRemoved = default(GameObject[]);
		}

		private void SetScrollContainerPosition()
		{
		}

		public void UpdateLayout()
		{
		}

		private void OnRectTransformDimensionsChange()
		{
		}

		private void OnEnable()
		{
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		public HorizontalScrollSnap()
			: base()
		{
		}
	}
}
