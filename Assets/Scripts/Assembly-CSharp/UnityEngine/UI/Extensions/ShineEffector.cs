namespace UnityEngine.UI.Extensions
{
	[ExecuteInEditMode]
	[AddComponentMenu("UI/Effects/Extensions/Shining Effect")]
	public class ShineEffector : MonoBehaviour
	{
		public ShineEffect effector;

		[HideInInspector]
		[SerializeField]
		private GameObject effectRoot;

		public float yOffset;

		public float width;

		private RectTransform effectorRect;

		public float YOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void ChangeVal(float value)
		{
		}

		private void OnDestroy()
		{
		}

		public ShineEffector()
			: base()
		{
		}
	}
}
