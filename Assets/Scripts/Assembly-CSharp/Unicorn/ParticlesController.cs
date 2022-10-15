using UnityEngine;

namespace Unicorn
{
	public class ParticlesController : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem particleSystem;

		[SerializeField]
		private DataTextureSkin DataTextureSkin;

		private void Awake()
		{
		}

		public ParticlesController()
			: base()
		{
		}
	}
}
