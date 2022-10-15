using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class GirlBrothel : MonoBehaviour
	{
		[SerializeField]
		private float scaleFactor;

		[SerializeField]
		private Animator animator;

		[SerializeField]
		private LayerMask whatIsBlock;

		[SerializeField]
		private Vector3 offset;

		[SerializeField]
		private Transform girl;

		private GameObject selectedGameObject;

		private GameObject selectedBlock;

		private Camera mainCam;

		public Animator Animator
		{
			get
			{
				return null;
			}
		}

		public Transform CurrentPos { get; set; }

		public bool Controllable { get; set; }

		public bool IsLookingRight { get; set; }

		public BrothelRoom PreviousBlock { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseDrag()
		{
		}

		private void OnMouseUp()
		{
		}

		private void SetPositionAfterRelease()
		{
		}

		public RaycastHit[] CastRayAll()
		{
			return null;
		}

		public void TriggerAnimDance()
		{
		}

		private void OnEnable()
		{
		}

		public void Flip()
		{
		}

		public GirlBrothel()
			: base()
		{
		}
	}
}
