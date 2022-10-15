namespace UnityEngine.UI.Extensions
{
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Extensions/UI Line Connector")]
	public class UILineConnector : MonoBehaviour
	{
		public RectTransform[] transforms;

		private Vector2[] previousPositions;

		private RectTransform canvas;

		private RectTransform rt;

		private UILineRenderer lr;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public UILineConnector()
			: base()
		{
		}
	}
}
