using UnityEngine;

namespace Unicorn
{
	public class EndgameWinController : MonoBehaviour
	{
		[SerializeField]
		private GameObject PlayerLeft;

		[SerializeField]
		private GameObject PlayerMiddle;

		[SerializeField]
		private GameObject Princess;

		[SerializeField]
		private GameObject ThreeSome1;

		[SerializeField]
		private GameObject ThreeSome2;

		[SerializeField]
		private Animator playerAnimatormiddle;

		[SerializeField]
		private Animator playerAnimatorleft;

		[SerializeField]
		private Animator princessAnimator;

		[SerializeField]
		private Animator ThreeSome1Anim;

		[SerializeField]
		private Animator ThreeSome2Anim;

		[SerializeField]
		private SkinChangerStick skinChangerMiddle;

		[SerializeField]
		private SkinChangerStick skinChanger;

		private int lastIndex;

		public Animator PlayerAnimator
		{
			get
			{
				return null;
			}
		}

		public Animator PrincessAnimator
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void Init()
		{
		}

		public void Disable()
		{
		}

		private void TriggerPrincessDance()
		{
		}

		public EndgameWinController()
			: base()
		{
		}
	}
}
