using UnityEngine;

namespace Unicorn.Utilities
{
	public class AutoDestructor : MonoBehaviour
	{
		private enum TypeDestroy
		{
			Disable = 0,
			PutToPool = 1,
			Destroy = 2
		}

		[SerializeField]
		private float timeDestroy;

		[SerializeField]
		private TypeDestroy typeDestroy;

		private void OnEnable()
		{
		}

		private void AutoDestroy()
		{
		}

		private void OnDisable()
		{
		}

		public AutoDestructor()
			: base()
		{
		}
	}
}
