using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unicorn;
using UnityEngine;

public class Tower : MonoBehaviour
{
	[SerializeField]
	private bool isClickable;

	[SerializeField]
	private List<Floor> listFloors;

	[SerializeField]
	private List<InteractableSpawner> listInteractableSpawners;

	[SerializeField]
	private List<Vector3> listFloorPos;

	[SerializeField]
	private List<IInteractable> listInteractables;

	private float offsetY;

	public LobbyManager lobbyManager;

	public List<Vector3> ListFloorPos
	{
		get
		{
			return null;
		}
	}

	public List<Floor> ListFloors
	{
		get
		{
			return null;
		}
	}

	public List<IInteractable> ListInteractables
	{
		get
		{
			return null;
		}
	}

	public GameObject summit { get; set; }

	private void Awake()
	{
	}

	private void InitLock()
	{
	}

	public void Init(D_Tower towerData, GameObject floorPrefab)
	{
	}

	public void InitVertical(D_Tower towerData, GameObject floorPrefab)
	{
	}

	public void RemoveFromList(Floor floor)
	{
	}

	public void Destroy()
	{
	}

	public Tower()
		: base()
	{
	}
}
