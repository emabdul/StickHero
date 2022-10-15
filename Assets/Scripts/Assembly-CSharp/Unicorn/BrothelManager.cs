using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class BrothelManager : MonoBehaviour
	{
		[SerializeField]
		private Camera camera;

		[SerializeField]
		private List<D_BrothelRoom> brothelRoomData;

		[SerializeField]
		private List<BrothelTower> listBrothelTower;

		[SerializeField]
		private PlayerBrothel playerController;

		[SerializeField]
		private List<GameObject> hotGirlPrefab;

		[SerializeField]
		private List<GameObject> customerPrefab;

		[SerializeField]
		private float cameraSize;

		[SerializeField]
		private float inputTimer;

		[SerializeField]
		private float lerpFactor;

		[SerializeField]
		private Vector3 cameraOffset;

		private float currentTime;

		private float currentTimeCheckFull;

		private float inputTimerCheckFull;

		private float deltaTime;

		private PlayerDataManager PlayerDataManager;

		public static BrothelManager Instance;

		private Camera mainCam;

		public PlayerBrothel PlayerController
		{
			get
			{
				return null;
			}
		}

		public List<D_BrothelRoom> BrothelRoomData
		{
			get
			{
				return null;
			}
		}

		public List<BrothelTower> ListBrothelTower
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> CurrentHotGirlWaiting { get; set; }

		public List<GameObject> CurrentCustomerWaiting { get; set; }

		public int CurrentTowerIndex { get; set; }

		public int PreviousTowerIndex { get; set; }

		private void Awake()
		{
		}

		private void SetUpCamera()
		{
		}

		private void Start()
		{
		}

		private void InitOriginGirlSpawn(List<Transform> listTransform)
		{
		}

		private void InitOriginCustomer(List<Transform> listTransform, bool isHundredsPercent = true)
		{
		}

		public void InitAfterSwitchTower(BrothelTower brothelTower)
		{
		}

		private void Update()
		{
		}

		public void MoveCamToTower()
		{
		}

		private bool CheckCurrentBrothelFull(BrothelTower brothelTower)
		{
			return default(bool);
		}

		public BrothelManager()
			: base()
		{
		}
	}
}
