using UnityEngine;

namespace Unicorn.Utilities
{
	public class Spinner : MonoBehaviour
	{
		[SerializeField]
		private Vector3 rotationSpeed;

		private Vector3 lastEulerAngles;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public Spinner()
			: base()
		{
		}
	}
}
