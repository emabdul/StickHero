namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Accordion/Accordion Group")]
	public class Accordion : MonoBehaviour
	{
		public enum Transition
		{
			Instant = 0,
			Tween = 1
		}

		[SerializeField]
		private Transition m_Transition;

		[SerializeField]
		private float m_TransitionDuration;

		public Transition transition
		{
			get
			{
				return default(Transition);
			}
			set
			{
			}
		}

		public float transitionDuration
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Accordion()
			: base()
		{
		}
	}
}
