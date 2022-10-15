using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class Princess : MonoBehaviour, IInteractable
	{
		[SerializeField]
		private Animator anim;

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

		public bool IsEndgame { get; set; }

		public void Start()
		{
		}

		private void Update()
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

		private IEnumerator DelayedEndgame(float time)
		{
			return null;
		}

		public Princess()
			: base()
		{
		}
	}
}
