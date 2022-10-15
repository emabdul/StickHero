using UnityEngine;

namespace Unicorn
{
	public class EndgameLoseController : MonoBehaviour
	{
		[SerializeField]
		private GameObject stickMan;

		[SerializeField]
		private GameObject stickGirl;

		[SerializeField]
		private GameObject stickMan1;

		[SerializeField]
		private SkinChangerStick skinChanger;

		[SerializeField]
		private SkinChangerStick skinChanger1;

		public GameObject StickGirl
		{
			get
			{
				return null;
			}
		}

		public void Init()
		{
		}

		public void Disable()
		{
		}

		public EndgameLoseController()
			: base()
		{
		}
	}
}
