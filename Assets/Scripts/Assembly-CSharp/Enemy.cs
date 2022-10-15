using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unicorn;
using UnityEngine;

public class Enemy : MonoBehaviour, IInteractable
{
	[SerializeField]
	private List<Renderer> ListRenderer;

	private MaterialPropertyBlock propBlock;

	[SerializeField]
	private Transform fxBloodTransform;

	[SerializeField]
	private GameObject fxBlood;

	[SerializeField]
	private float force;

	[SerializeField]
	private RagdollTrigger ragdollTrigger;

	[SerializeField]
	private TextMeshPro powerText;

	[SerializeField]
	private EnemyType enemyType;

	[SerializeField]
	private Animator anim;

	private int power;

	private MathOperator arithmeticOperator;

	private InteractableType interactableType;

	private Floor floor;

	private LobbyManager testManager;

	public List<AnimatorOverrideController> animatorOverrideControllers;

	public AnimatorOverrider animatorOverrider;

	public EnemyType EnemyType
	{
		get
		{
			return default(EnemyType);
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

	private void Start()
	{
	}

	private void InitAnimatorOverrider()
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

	private IEnumerator DisableGameObject()
	{
		return null;
	}

	private IEnumerator DissolveTimer(float duration)
	{
		return null;
	}

	public Enemy()
		: base()
	{
	}
}
