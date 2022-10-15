using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Unicorn
{
	public class BonusChest : MonoBehaviour, IInteractable
	{
		[SerializeField]
		private Transform chestLid;

		[SerializeField]
		private Transform chestLid1;

		[SerializeField]
		private Transform chestLid2;

		[SerializeField]
		private Transform coin;

		[SerializeField]
		private Transform coin1;

		[SerializeField]
		private Transform coin2;

		[SerializeField]
		private Transform fxOpenChestTransform;

		[SerializeField]
		private Transform fxOpenChestTransform1;

		[SerializeField]
		private Transform fxOpenChestTransform2;

		[SerializeField]
		private GameObject fxOpenChest;

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

		private IEnumerator DelayCoin(Transform coin)
		{
			return null;
		}

		public void TriggerPlayerAnim()
		{
		}

		public void TriggerRagdoll()
		{
		}

		public BonusChest()
			: base()
		{
		}
	}
}
