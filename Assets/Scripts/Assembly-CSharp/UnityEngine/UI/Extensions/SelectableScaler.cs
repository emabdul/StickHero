using System.Collections;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Selectable Scalar")]
	public class SelectableScaler : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public AnimationCurve animCurve;

		[Tooltip("Animation speed multiplier")]
		public float speed;

		private Vector3 initScale;

		public Transform target;

		private Selectable selectable;

		public Selectable Target
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		private IEnumerator ScaleIN()
		{
			return null;
		}

		private IEnumerator ScaleOUT()
		{
			return null;
		}

		public SelectableScaler()
			: base()
		{
		}
	}
}
