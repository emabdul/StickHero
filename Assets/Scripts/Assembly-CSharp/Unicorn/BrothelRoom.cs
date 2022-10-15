using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Unicorn
{
	public class BrothelRoom : MonoBehaviour
	{
		[SerializeField]
		private Transform playerSpawnTransform;

		[SerializeField]
		private List<Transform> listGirlSpawnTransform;

		[SerializeField]
		private List<Transform> listCustomerTransform;

		[SerializeField]
		private List<GameObject> listGirlPrefab;

		[SerializeField]
		private List<GameObject> listCustomerPrefab;

		[SerializeField]
		private GameObject coinObject;

		[SerializeField]
		private GameObject watchObject;

		[SerializeField]
		private GameObject gemObject;

		[SerializeField]
		private GameObject overlayObject;

		[SerializeField]
		private TextMeshProUGUI coinText;

		[SerializeField]
		private TextMeshProUGUI gemText;

		[SerializeField]
		private GameObject coinPrefab;

		[SerializeField]
		private GameObject gemPrefab;

		[SerializeField]
		private Canvas roomCanvas;

		[SerializeField]
		private Image progressImage;

		[SerializeField]
		private Image progressImageVideo;

		[SerializeField]
		private Image progressImageGem;

		[SerializeField]
		private GameObject fxPrefab;

		[SerializeField]
		private Transform fxSpawnPos;

		[SerializeField]
		private GameObject fxPurchasePrefab;

		private float CoinToUnlock;

		private float GemToUnlock;

		private Camera camera;

		private Vector3 coinSpawnPos;

		private Vector3 gemSpawnPos;

		private float currentTimeCoin;

		private float inputTimerCoin;

		private float currentTimeGem;

		private float inputTimerGem;

		private float currentTimeVideo;

		private float inputTimerVideo;

		public Image ProgressImage
		{
			get
			{
				return null;
			}
		}

		public Image ProgressImageVideo
		{
			get
			{
				return null;
			}
		}

		public Image ProgressImageGem
		{
			get
			{
				return null;
			}
		}

		public int TowerID { get; set; }

		public int FloorID { get; set; }

		public List<HotGirlSpawner> ListHotGirl { get; set; }

		public List<CustomerSpawner> ListCustomer { get; set; }

		private TextMeshProUGUI CoinText
		{
			get
			{
				return null;
			}
		}

		private TextMeshProUGUI GemText
		{
			get
			{
				return null;
			}
		}

		public GameObject OverlayObject
		{
			get
			{
				return null;
			}
		}

		public GameObject CoinObject
		{
			get
			{
				return null;
			}
		}

		public GameObject WatchObject
		{
			get
			{
				return null;
			}
		}

		public GameObject GemObject
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> ListGirlPrefab
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> ListCustomerPrefab
		{
			get
			{
				return null;
			}
		}

		public Transform PlayerSpawnTransform
		{
			get
			{
				return null;
			}
		}

		public List<Transform> ListGirlSpawnTransform
		{
			get
			{
				return null;
			}
		}

		public List<Transform> ListCustomerTransform
		{
			get
			{
				return null;
			}
		}

		public BrothelRoomUnlockType UnlockType { get; set; }

		public bool IsUnlocked { get; set; }

		public Profile Profile { get; set; }

		private bool isShowAd { get; set; }

		public int OriginCoin { get; set; }

		public int OriginGem { get; set; }

		public BrothelRoomInfo BrothelRoomInfo { get; set; }

		public VibrationController VibrationController { get; set; }

		public PlayerDataManager PlayerDataManager { get; set; }

		private void Awake()
		{
		}

		public void UpdateInGame()
		{
		}

		public void FirstTimeInit(BrothelRoomInfo brothelRoomInfo, int towerId, int floorId)
		{
		}

		public void Init(int towerID, int floorID)
		{
		}

		public Transform CalculateGirlSpawnPos()
		{
			return null;
		}

		public Transform CalculateCustomerSpawnPos()
		{
			return null;
		}

		public void UpdateCoin()
		{
		}

		private void UnlockGemRoomGradually()
		{
		}

		private void UnlockCoinRoomGradually()
		{
		}

		private void UnlockCoinRoomInstant()
		{
		}

		private void UnlockGemRoomInstant()
		{
		}

		private IEnumerator DelayVibrate()
		{
			return null;
		}

		public void ResetVideo()
		{
		}

		private void OnClickBtnBuild()
		{
		}

		public bool CheckGirl()
		{
			return default(bool);
		}

		private void OnRewardBuild(int x)
		{
		}

		public void OnRoomEnter()
		{
		}

		public void OnRoomExit()
		{
		}

		public void InitUnlockVisual()
		{
		}

		public void GirlEnter(GirlBrothel girl, Transform transForm)
		{
		}

		public void GirlExit(GirlBrothel girl, Transform transForm)
		{
		}

		public void CustomerEnter(Customer customer, Transform transForm)
		{
		}

		public void CustomerExit(Customer customer, Transform transForm)
		{
		}

		public BrothelRoom()
			: base()
		{
		}
	}
}
