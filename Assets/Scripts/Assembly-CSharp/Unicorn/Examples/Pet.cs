using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn.Examples
{
	public class Pet : MonoBehaviour
	{
		[SerializeField]
		private float minRestTime;

		[SerializeField]
		private float maxRestTime;

		[SerializeField]
		private float actionRatio;

		[SerializeField]
		private float speed;

		[SerializeField]
		private float rotationSpeed;

		[SerializeField]
		private float squaredStoppingDistance;

		[SerializeField]
		private float randomRadius;

		[SerializeField]
		private Animator animator;

		private CharacterController controller;

		private Vector3 target;

		private Quaternion targetRotation;

		private static readonly int RunHashed;

		private float nextMoveTime;

		private Character owner;

		private Vector3 ownerOffset;

		private float maxDistanceFromOwner;

		private float actionFinishTime;

		private static readonly int Action;

		public bool CanMove { get; set; }

		public Animator Animator
		{
			get
			{
				return null;
			}
		}

		public static Pet Spawn(Character character, Vector3 ownerOffset, float maxDistanceFromOwner, int petId = -1)
		{
			return null;
		}

		public static Pet Spawn(int petId = -1)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void RegisterOwner(Character character, Vector3 ownerOffset, float maxDistanceFromOwner)
		{
		}

		public void RemoveOwner()
		{
		}

		private void Update()
		{
		}

		private void UpdateSpeed()
		{
		}

		private void StopMoving()
		{
		}

		private void DoAction()
		{
		}

		private void FindNewPosition()
		{
		}

		private void FindRandomPosition()
		{
		}

		private void FindPositionAroundOwner()
		{
		}

		private void MoveToTarget()
		{
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public Pet()
			: base()
		{
		}
	}
}
