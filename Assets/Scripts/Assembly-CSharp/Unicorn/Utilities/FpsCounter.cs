using TMPro;
using UnityEngine;

namespace Unicorn.Utilities
{
	public class FpsCounter : MonoBehaviour
	{
		public TextMeshProUGUI fpsCounter;

		private int m_frameCounter;

		private float m_timeCounter;

		private float m_lastFramerate;

		public float m_refreshTime;

		private void Update()
		{
		}

		public FpsCounter()
			: base()
		{
		}
	}
}
