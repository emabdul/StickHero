using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Floor : MonoBehaviour
{
	[SerializeField]
	private Transform middleTransform;

	[SerializeField]
	private List<Interactable> interactables;

	[SerializeField]
	private List<Position> listSpawnPos;

	[SerializeField]
	private List<GameObject> listMesh;

	[SerializeField]
	private SpriteRenderer selectSprite;

	[SerializeField]
	private SpriteRenderer selectSpriteOutline;

	[SerializeField]
	private Color targetColor;

	[SerializeField]
	private Color targetColorOutline;

	[SerializeField]
	private GameObject theLock;

	[SerializeField]
	private GameObject lockDown;

	[SerializeField]
	private GameObject lockUp;

	[SerializeField]
	private Transform lockGateLeft;

	[SerializeField]
	private Transform lockGateRight;

	public Transform MiddleTransform
	{
		get
		{
			return null;
		}
	}

	public SpriteRenderer SelectSprite
	{
		get
		{
			return null;
		}
	}

	public List<GameObject> ListMesh
	{
		get
		{
			return null;
		}
	}

	public List<Position> ListSpawnPos
	{
		get
		{
			return null;
		}
	}

	public List<Interactable> Interactables
	{
		get
		{
			return null;
		}
	}

	public Tower ParentTower { get; set; }

	public bool IsLock { get; set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Init(List<InteractableSpawner> list, bool topActive = false)
	{
	}

	public Transform CalculatePlayerSpawnPos()
	{
		return null;
	}

	public void OnBlockEnter()
	{
	}

	public void OnBlockExit()
	{
	}

	public void TurnOnSelectSprite()
	{
	}

	public void TurnOffSelectSprite()
	{
	}

	public void TurnOnOutline()
	{
	}

	public void TurnOffOutline()
	{
	}

	public void RemoveFromList(IInteractable interactable)
	{
	}

	public void Lock()
	{
	}

	public void Unlock()
	{
	}

	public void Destroy()
	{
	}

	public Floor()
		: base()
	{
	}
}
