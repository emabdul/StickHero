using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unicorn
{
	public class RagdollTrigger : MonoBehaviour
	{
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Collider naturalCollider;

		[SerializeField]
		private List<Collider> limbColliders;

		[SerializeField]
		private List<Rigidbody> limbRigidbodies;

		[SerializeField]
		private List<Rigidbody> weaponRigidbodies;

		private Rigidbody activeWeapon;

		[SerializeField]
		private PlayerController playerController;

		[SerializeField]
		private Joint[] joints;

		private Vector3[] connectedAnchor;

		private Vector3[] anchor;

		private void Awake()
		{
		}

		public void RecoverJoints()
		{
		}

		private void Start()
		{
		}

		public void RagdollOn()
		{
		}

		public void RagdollOff()
		{
		}

		public void AddForce(float force, Vector3 direction, int limb)
		{
		}

		public void SetActiveWeapon(Rigidbody rb)
		{
		}

		private IEnumerator DisableWeapon()
		{
			return null;
		}

		public List<Rigidbody> GetLimbRigidbodies()
		{
			return null;
		}

		public RagdollTrigger()
			: base()
		{
		}
	}
}
