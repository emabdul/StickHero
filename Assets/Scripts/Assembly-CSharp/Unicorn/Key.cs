using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Unicorn
{
	public class Key : MonoBehaviour, IInteractable
	{
		[SerializeField]
		private Transform key;

		private int power;

		private MathOperator arithmeticOperator;

		private InteractableType interactableType;

		private Floor floor;

		private LobbyManager lobbyManager;

		public Floor LockFloor { get; set; }

		public Animator Anim { get; set; }

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

		public void Init()
		{
		}

		public Key()
			: base()
		{
		}
	}
}
