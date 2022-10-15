using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Unicorn
{
	public class BossController : MonoBehaviour, IInteractable
	{
		[SerializeField]
		private Transform fxBloodTransform;

		[SerializeField]
		private GameObject fxBlood;

		[SerializeField]
		private Transform cameraAnchor;

		[SerializeField]
		private float force;

		[SerializeField]
		private RagdollTrigger ragdollTrigger;

		[SerializeField]
		private TextMeshPro powerText;

		[SerializeField]
		private Animator anim;

		private int power;

		private MathOperator arithmeticOperator;

		private InteractableType interactableType;

		private Floor floor;

		[SerializeField]
		private float distanceTravel;

		private LobbyManager lobbyManager;

		public List<AnimatorOverrideController> animatorOverrideControllers;

		public AnimatorOverrider animatorOverrider;

		public Transform CameraAnchor
		{
			get
			{
				return null;
			}
		}

		public RagdollTrigger RagdollTrigger
		{
			get
			{
				return null;
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

		public bool IsDead { get; set; }

		public bool IsStop { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void InitAnimatorOverrider()
		{
		}

		public void DoMath()
		{
		}

		public void EnterBossFight()
		{
		}

		public void TriggerAnim()
		{
		}

		public void TriggerAnimDamage()
		{
		}

		public void TriggerAnimAttack()
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

		public void RagdollOn()
		{
		}

		private void FlyingAway()
		{
		}

		private void InstantRagdoll()
		{
		}

		private IEnumerator DelayedEndgame(float time)
		{
			return null;
		}

		private IEnumerator DisableGameObject()
		{
			return null;
		}

		public BossController()
			: base()
		{
		}
	}
}
