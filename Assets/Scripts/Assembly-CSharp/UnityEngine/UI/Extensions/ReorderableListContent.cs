using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	public class ReorderableListContent : MonoBehaviour
	{
		private List<Transform> _cachedChildren;

		private List<ReorderableListElement> _cachedListElement;

		private ReorderableListElement _ele;

		private ReorderableList _extList;

		private RectTransform _rect;

		private void OnEnable()
		{
		}

		public void OnTransformChildrenChanged()
		{
		}

		public void Init(ReorderableList extList)
		{
		}

		private IEnumerator RefreshChildren()
		{
			return null;
		}

		public ReorderableListContent()
			: base()
		{
		}
	}
}
