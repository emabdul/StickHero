namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/UI ScrollTo Selection XY")]
	public class UIScrollToSelectionXY : MonoBehaviour
	{
		public float scrollSpeed;

		[SerializeField]
		private RectTransform layoutListGroup;

		private RectTransform targetScrollObject;

		private bool scrollToSelection;

		private RectTransform scrollWindow;

		private ScrollRect targetScrollRect;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void ScrollRectToLevelSelection()
		{
		}

		public UIScrollToSelectionXY()
			: base()
		{
		}
	}
}
