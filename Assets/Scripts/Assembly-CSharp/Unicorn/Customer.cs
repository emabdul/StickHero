using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class Customer : MonoBehaviour
	{
		[SerializeField]
		private Animator animator;

		[SerializeField]
		private LayerMask whatIsBlock;

		[SerializeField]
		private Vector3 offset;

		[SerializeField]
		private GameObject coinPrefab;

		[SerializeField]
		private Transform coinSpawn;

		[SerializeField]
		private Transform targetCoin;

		[SerializeField]
		private Transform stickMan;

		[SerializeField]
		private GameObject coin2Prefab;

		private Vector3 coinSpawnPos;

		private Camera mainCam;

		private int lastDanceIndex;

		private float currentTime;

		private float inputTimer;

		[SerializeField]
		private float totalTime;

		[SerializeField]
		private float scaleFactor;

		private BrothelManager brothelManager;

		private PlayerDataManager playerDataManager;

		public GameObject selectedGameObject { get; set; }

		public GameObject selectedBlock { get; set; }

		public GameObject cancelBlock { get; set; }

		public BrothelRoom PreviousBlock { get; set; }

		public BrothelRoom ParentRoom { get; set; }

		public Transform CurrentPos { get; set; }

		public bool isDragging { get; set; }

		public bool isLookingRight { get; set; }

		public bool isAddingGold { get; set; }

		public bool Controllable { get; set; }

		public float countTime { get; set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void SpawnCoin()
		{
		}

		private IEnumerator GoHome()
		{
			return null;
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

		public void TriggerAnimPartyDance()
		{
		}

		private void SetPositionAfterRelease()
		{
		}

		private void OnEnable()
		{
		}

		public RaycastHit[] CastRayAll()
		{
			return null;
		}

		public void Flip()
		{
		}

		public Customer()
			: base()
		{
		}
	}
}
