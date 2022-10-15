using System.Collections;

namespace UnityEngine.UI.Extensions.Tweens
{
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		protected MonoBehaviour m_CoroutineContainer;

		protected IEnumerator m_Tween;

		private static IEnumerator Start(T tweenInfo)
		{
			return null;
		}

		public void Init(MonoBehaviour coroutineContainer)
		{
		}

		public void StartTween(T info)
		{
		}

		public TweenRunner()
			: base()
		{
		}
	}
}
