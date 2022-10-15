using DG.Tweening;
using UnityEngine;

namespace Unicorn.UI
{
	public class ForceBar : MonoBehaviour
	{
		public DOTweenAnimation handleAnimation;

		public RectTransform handle;

		public float MaxPosition;

		public float MinPosition;

		public int[] values;

		public float positionLocal;

		public void StopRunning()
		{
		}

		public int GetValue()
		{
			return default(int);
		}

		public ForceBar()
			: base()
		{
		}
	}
}
