using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Unicorn
{
	public abstract class Buff : MonoBehaviour, IInteractable
	{
		protected TextMeshProUGUI PowerText;

		protected LobbyManager lobbyManager;

		private int power;

		private MathOperator arithmeticOperator;

		private InteractableType interactableType;

		private Floor floor;

		private Tweener tweenCoin;

		private int tmpCoin;

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

		public virtual void Start()
		{
		}

		public virtual void DoMath()
		{
		}

		public virtual void TriggerAnim()
		{
		}

		public virtual void TriggerPlayerAnim()
		{
		}

		public virtual void TriggerEnemyAnim()
		{
		}

		public virtual void TriggerAnimDamage()
		{
		}

		public virtual void TriggerRagdoll()
		{
		}

		private void SetPowerText()
		{
		}

		public Buff()
			: base()
		{
		}
	}
}
