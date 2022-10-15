using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using Unicorn.UI;
using UnityEngine;

namespace Unicorn
{
	public class GameManager : SerializedMonoBehaviour
	{
		public static GameManager Instance;

		[SerializeField]
		[Space]
		private LevelConstraint levelConstraint;

		[SerializeField]
		private UiController uiController;

		[SerializeField]
		private CameraController mainCamera;

		[SerializeField]
		private PlayerDataManager playerDataManager;

		[SerializeField]
		private IapController iap;

		[SerializeField]
		private VibrationController vibrationController;

		[SerializeField]
		private int lobbySceneIndex;

		[SerializeField]
		private int castleSceneIndex;

		[SerializeField]
		private LevelTransition lvlTransition;

		[SerializeField]
		private Vector3 endgameWinCamPos;

		[SerializeField]
		private Vector3 endgameLoseCamPos;

		[SerializeField]
		private EndgameWinController endgameWinController;

		[SerializeField]
		private EndgameLoseController endgameLoseController;

		[SerializeField]
		private int weaponCount;

		[SerializeField]
		private D_IapWeapon dataWeaponIap;

		[SerializeField]
		private List<int> listLevelNormalIndex;

		[SerializeField]
		private List<int> listLevelVerticalIndex;

		[SerializeField]
		private List<int> listLevelBossIndex;

		[SerializeField]
		private List<int> listLevelBonuslIndex;

		[SerializeField]
		private List<int> listLevelPrincesslIndex;

		[SerializeField]
		private List<int> listLevelTreasureIndex;

		[SerializeField]
		private List<int> listLevelChallenge;

		private LevelManager currentLevelManager;

		private IDataLevel dataLevel;

		public int[] IndexArray;

		public int[] initialIapWeaponIds;

		private int lastBuildIndex;

		public D_IapWeapon DataWeaponIap
		{
			get
			{
				return null;
			}
		}

		public int WeaponCount
		{
			get
			{
				return default(int);
			}
		}

		public VibrationController VibrationController
		{
			get
			{
				return null;
			}
		}

		public int LobbySceneIndex
		{
			get
			{
				return default(int);
			}
		}

		public bool isVideoLevelWatched { get; set; }

		public List<int> ListLevelChallenge
		{
			get
			{
				return null;
			}
		}

		public GameMode GameMode { get; set; }

		public bool IsLevelLoading { get; private set; }

		public Vector3 EndgameWinCamPos
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 EndgameLoseCamPos
		{
			get
			{
				return default(Vector3);
			}
		}

		public EndgameWinController EndgameWinController
		{
			get
			{
				return null;
			}
		}

		public EndgameLoseController EndgameLoseController
		{
			get
			{
				return null;
			}
		}

		public ILevelInfo DataLevel
		{
			get
			{
				return null;
			}
		}

		public int CurrentLevel
		{
			get
			{
				return default(int);
			}
		}

		public int CurrentChallengeLevel { get; set; }

		public int CurrentChallengeLevelText { get; set; }

		public int CurrentChallengeCoin { get; set; }

		public int CurrentChallengeGem { get; set; }

		public int LastRandomShieldIndex { get; set; }

		public GameFSM GameStateController { get; private set; }

		public PlayerDataManager PlayerDataManager
		{
			get
			{
				return null;
			}
		}

		public CameraController MainCamera
		{
			get
			{
				return null;
			}
		}

		public UiController UiController
		{
			get
			{
				return null;
			}
		}

		public LevelTransition LevelTransition
		{
			get
			{
				return null;
			}
		}

		public LevelManager LevelManager
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public IapController IapController
		{
			get
			{
				return null;
			}
		}

		public Profile Profile { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void ResetIapWeaponInfo()
		{
		}

		public void ReturnToMainMenu()
		{
		}

		public void LoadCastle()
		{
		}

		public void SetIsVideoLevelWatched()
		{
		}

		private int RandomBuildIndex()
		{
			return default(int);
		}

		public void LoadBuildIndex(int buildIndex)
		{
		}

		public void LoadLevel()
		{
		}

		public void RegisterLevelManager(LevelManager levelManager)
		{
		}

		public void StartLevel()
		{
		}

		public void DelayedEndgame(LevelResult result, float delayTime = 0.5f)
		{
		}

		private IEnumerator DelayedEndgameCoroutine(LevelResult result, float delayTime)
		{
			return null;
		}

		public void EndLevel(LevelResult result)
		{
		}

		public void IncreaseLevel()
		{
		}

		public void Revive()
		{
		}

		public void Pause()
		{
		}

		public void Resume()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		public GameManager()
			: base()
		{
		}

		public event Action GamePaused;

		public event Action GameResumed;
	}
}
