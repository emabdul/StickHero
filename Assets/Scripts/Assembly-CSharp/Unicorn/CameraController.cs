using UnityEngine;

namespace Unicorn
{
	public class CameraController : MonoBehaviour
	{
		[SerializeField]
		private Camera camera;

		[SerializeField]
		private AudioListener audioListener;

		public Camera Camera
		{
			get
			{
				return null;
			}
		}

		public AudioListener AudioListener
		{
			get
			{
				return null;
			}
		}

		public CameraController()
			: base()
		{
		}
	}
}
