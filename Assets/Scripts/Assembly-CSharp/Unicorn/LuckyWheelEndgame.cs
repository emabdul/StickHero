using DG.Tweening;
using UnityEngine;

namespace Unicorn
{
	public class LuckyWheelEndgame : MonoBehaviour
	{
		[SerializeField]
		private Transform wheel;

		public DOTweenAnimation SpinWheel;

		public int[] values;

		public void StopRunningWheel()
		{
		}

		public int GetValueWheel()
		{
			return default(int);
		}

		public LuckyWheelEndgame()
			: base()
		{
		}
	}
}
