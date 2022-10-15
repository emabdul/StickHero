using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class PlayerBrothel : MonoBehaviour
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
		private Transform fxLandingTransform;

		[SerializeField]
		private GameObject fxLanding;

		[SerializeField]
		private SkinChangerStick skinChanger;

		private GameObject selectedGameObject;

		private GameObject selectedBlock;

		private GameObject cancelBlock;

		private BrothelRoom previousBlock;

		private int lastDanceIndex;

		private Camera mainCam;

		public Animator Animator
		{
			get
			{
				return null;
			}
		}

		public Transform CurrentPos { get; set; }

		public SkinChangerStick SkinChanger
		{
			get
			{
				return null;
			}
		}

		public bool Controllable { get; set; }

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

		public void OnMouseUp()
		{
		}

		public void TriggerAnimPartyDance()
		{
		}

		private void SetPositionAfterRelease()
		{
		}

		public RaycastHit[] CastRayAll()
		{
			return null;
		}

		public void SpawnFxLanding()
		{
		}

		public PlayerBrothel()
			: base()
		{
		}
	}
}
