using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using Unicorn;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private float scaleFactor;

	[SerializeField]
	private LayerMask whatIsBlock;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private AnimatorOverrider animatorOverrider;

	[SerializeField]
	private SkinChangerStick skinChanger;

	[SerializeField]
	private TextMeshProUGUI powerText;

	[SerializeField]
	private RagdollTrigger ragdollTrigger;

	[SerializeField]
	private List<GameObject> listWeapons;

	[SerializeField]
	private List<AnimatorOverrideController> listOverrideAnimator;

	[SerializeField]
	private List<AnimatorOverrideController> listFinishOverrideAnimator;

	[SerializeField]
	private Transform fxBloodTransform;

	[SerializeField]
	private GameObject fxBlood;

	[SerializeField]
	private Transform fxLandingTransform;

	[SerializeField]
	private GameObject fxLanding;

	[SerializeField]
	private Transform fxHammerTransform;

	[SerializeField]
	private GameObject fxHammer;

	[SerializeField]
	private GameObject fxGiantCharge;

	[SerializeField]
	private GameObject fxGiantExplode;

	[SerializeField]
	private Transform fxGianTransform;

	[SerializeField]
	private List<Transform> listFxGunTransform;

	[SerializeField]
	private List<GameObject> listFxGun;

	[SerializeField]
	private List<GameObject> listFxGunGiant;

	private Camera mainCam;

	private GameObject currentWeapon;

	private GameObject selectedGameObject;

	private GameObject selectedBlock;

	private GameObject cancelBlock;

	private Floor previousBlock;

	private float deltaTime;

	private bool controllable;

	private int lastIndexAttack;

	private int lastIndexDamage;

	private float currentTime;

	private float inputTimer;

	private Tweener tweenCoin;

	private int tmpCoin;

	public WeaponType currentWeaponType { get; set; }

	public List<GameObject> ListFxGun
	{
		get
		{
			return null;
		}
	}

	public List<GameObject> ListFxGunGiant
	{
		get
		{
			return null;
		}
	}

	public List<Transform> ListFxGunTransform
	{
		get
		{
			return null;
		}
	}

	public SkinChangerStick SkinChanger
	{
		get
		{
			return null;
		}
	}

	public List<GameObject> ListWeapons
	{
		get
		{
			return null;
		}
	}

	public TextMeshProUGUI PowerText
	{
		get
		{
			return null;
		}
	}

	public LobbyManager LobbyManager { get; set; }

	public bool IsIngame { get; set; }

	public bool IsFinishMove { get; set; }

	public bool IsDead { get; set; }

	public bool IsVidX2 { get; set; }

	public bool IsDragging { get; set; }

	public Transform CurrentPos { get; set; }

	public Animator Animator
	{
		get
		{
			return null;
		}
	}

	public int CurrentPower { get; set; }

	public IInteractable CurrentInteractable { get; set; }

	private GameObject giantChargeGO { get; set; }

	public bool IsGianting { get; set; }

	public VibrationController VibrationController { get; set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ChangeWeapon(WeaponType type, int id)
	{
	}

	public void InitWeapon()
	{
	}

	private void InitWeaponTypeAnim()
	{
	}

	public void InitFinishAnim()
	{
	}

	public void InitNormalAnim()
	{
	}

	private void InitVars()
	{
	}

	public void DoMath(MathOperator arithmeticOperator, int number)
	{
	}

	private int GetRandomInt(int minInclusive, int maxExclusive)
	{
		return default(int);
	}

	private int GetRandomIntDamage(int minInclusive, int maxExclusive)
	{
		return default(int);
	}

	public WeaponType GetWeaponType(int index)
	{
		return default(WeaponType);
	}

	public void TriggerAnimChangeSize()
	{
	}

	public void TriggerAnimAttack()
	{
	}

	public void TriggerAnimDamage()
	{
	}

	public void TriggerChangeSize(bool isWin)
	{
	}

	public void TriggerAnimWin()
	{
	}

	public void TriggerAnimOpenChest()
	{
	}

	public void TriggerAnimSlashBonus()
	{
	}

	public void TriggerAnimGetItem()
	{
	}

	public void TriggerRagdoll(bool isAddForce)
	{
	}

	public RaycastHit[] CastRayAll()
	{
		return null;
	}

	private void CheckSelectSprite()
	{
	}

	private void CheckDetectNothing()
	{
	}

	public void SpawnFxLanding()
	{
	}

	public void SpawnFxHammer()
	{
	}

	public void SpawnFxHandgun()
	{
	}

	public void SpawnFxMinigun()
	{
	}

	public void SpawnFxRifle()
	{
	}

	public void SpawnFxShotgun()
	{
	}

	public void SetPowerText()
	{
	}

	private IEnumerator LoseGame()
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

	private IEnumerator DelayControllable(bool controllable)
	{
		return null;
	}

	private void SetPositionAfterRelease()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void SetControllable(bool controllable)
	{
	}

	public void SetCurrentInteractable(IInteractable interactable)
	{
	}

	public PlayerController()
		: base()
	{
	}
}
