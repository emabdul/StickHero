using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class PrincessSlap : MonoBehaviour, IInteractable
	{
		[SerializeField]
		private Transform heart;

		[SerializeField]
		private Transform heart1;

		[SerializeField]
		private Transform heart2;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Animator anim1;

		[SerializeField]
		private Animator anim2;

		private int power;

		private MathOperator arithmeticOperator;

		private InteractableType interactableType;

		private Floor floor;

		private LobbyManager lobbyManager;

		public Animator Anim
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Power
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Floor ParentFloor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MathOperator ArithmeticOperator
		{
			get
			{
				return default(MathOperator);
			}
			set
			{
			}
		}

		public InteractableType InteractableType
		{
			get
			{
				return default(InteractableType);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		public void DoMath()
		{
		}

		public void TriggerAnim()
		{
		}

		public void TriggerAnimDamage()
		{
		}

		public void TriggerEnemyAnim()
		{
		}

		public void TriggerPlayerAnim()
		{
		}

		public void TriggerRagdoll()
		{
		}

		private IEnumerator DelayHeart(Transform heart)
		{
			return null;
		}

		public PrincessSlap()
			: base()
		{
		}
	}
}
