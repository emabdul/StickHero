using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unicorn
{
	public class LobbyManager : LevelManager
	{
		[SerializeField]
		private Camera camera;

		[SerializeField]
		private Camera cameraVertical;

		[SerializeField]
		private float offset;

		[SerializeField]
		private float lerpFactor;

		[SerializeField]
		private float cameraSize;

		[SerializeField]
		private float verticalCameraSize;

		[SerializeField]
		private float verticalOffsetY;

		[SerializeField]
		private float verticalOffsetX;

		[SerializeField]
		private float breakableFirst;

		[SerializeField]
		private float breakableRegular;

		[SerializeField]
		private D_LevelManager levelManagerData;

		[SerializeField]
		private Vector3 cameraOffsetHorizontal;

		[SerializeField]
		private Vector3 cameraOffsetVertical;

		[SerializeField]
		private GameObject playerPrefab;

		[SerializeField]
		private GameObject floorPrefab;

		[SerializeField]
		private GameObject playerFloorPrefab;

		[SerializeField]
		private GameObject summitPrefab;

		[SerializeField]
		private GameObject lastBreakableTowerPrefab;

		[SerializeField]
		private List<GameObject> listBreakableTowerPrefab;

		[SerializeField]
		private Transform originalTower;

		[SerializeField]
		private List<Tower> listTower;

		[SerializeField]
		private List<D_Tower> listTowerData;

		[SerializeField]
		private List<GameObject> listBuffPrefabs;

		public static LobbyManager instance;

		public List<GameObject> ListBuffPrefabs
		{
			get
			{
				return null;
			}
		}

		public int OriginListTowerCount { get; set; }

		public int RewardCounter { get; set; }

		public D_LevelManager LevelManagerData
		{
			get
			{
				return null;
			}
		}

		public List<D_Tower> ListTowerData
		{
			get
			{
				return null;
			}
		}

		public GameplayType GameplayType { get; set; }

		public TowerType TowerType { get; set; }

		public UnlockType UnlockType { get; set; }

		public Camera Camera { get; set; }

		public Vector3 CameraOffset { get; set; }

		public float LerpFactor
		{
			get
			{
				return default(float);
			}
		}

		public float VerticalOffsetX
		{
			get
			{
				return default(float);
			}
		}

		public float VerticalOffsetY
		{
			get
			{
				return default(float);
			}
		}

		public int DefaultPlayerPower { get; set; }

		public GameObject FloorPrefab
		{
			get
			{
				return null;
			}
		}

		public GameObject PlayerFloorPrefab
		{
			get
			{
				return null;
			}
		}

		public GameObject SummitPrefab
		{
			get
			{
				return null;
			}
		}

		public List<Tower> ListTower
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> ListBreakableTower { get; set; }

		public PlayerController PlayerController { get; set; }

		public Tower_Player CurrentTowerPlayer { get; set; }

		public Tower CurrentTower { get; set; }

		public BossController Boss { get; set; }

		protected override void Awake()
		{
		}

		public void SetUnlockTypeData(UnlockType unlockType)
		{
		}

		protected override void SetUpLevelEnvironment()
		{
		}

		private void SetUpCamera()
		{
		}

		private void SetUpCameraVertical()
		{
		}

		private void InitTowersHorizontal()
		{
		}

		private void InitBreakableTowers()
		{
		}

		private void InitPlayerTowerHorizontal()
		{
		}

		private void InitTowersVertical()
		{
		}

		private void InitPlayerTowerVertical()
		{
		}

		public void MoveToThisScene(GameObject gameObject, Scene scene)
		{
		}

		public override void StartLevel()
		{
		}

		public void Endgame(LevelResult levelResult)
		{
		}

		public void ChangeToPlayerFloor(Floor floor)
		{
		}

		public IEnumerator CameraIntroduceMap()
		{
			return null;
		}

		public IEnumerator VerticalCameraIntroduceMap()
		{
			return null;
		}

		private IEnumerator DelayEndgame(LevelResult levelResult)
		{
			return null;
		}

		public LobbyManager()
			: base()
		{
		}
	}
}
