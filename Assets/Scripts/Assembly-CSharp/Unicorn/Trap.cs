using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Unicorn
{
	public abstract class Trap : MonoBehaviour, IInteractable
	{
		protected TextMeshProUGUI PowerText;

		private LobbyManager lobbyManager;

		private int power;

		private MathOperator arithmeticOperator;

		private InteractableType interactableType;

		private Floor floor;

		private Tweener tweenCoin;

		private int tmpCoin;

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

		public virtual void TriggerAnimDamage()
		{
		}

		public virtual void TriggerEnemyAnim()
		{
		}

		public virtual void TriggerPlayerAnim()
		{
		}

		public virtual void TriggerRagdoll()
		{
		}

		private IEnumerator DelayRagdoll()
		{
			return null;
		}

		private void SetPowerText()
		{
		}

		protected bool CheckAutoTarget()
		{
			return default(bool);
		}

		protected bool CheckFloor()
		{
			return default(bool);
		}

		public Trap()
			: base()
		{
		}
	}
}
