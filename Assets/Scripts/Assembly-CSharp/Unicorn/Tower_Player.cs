using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class Tower_Player : MonoBehaviour
	{
		[SerializeField]
		private List<Vector3> listSpawnPos;

		[SerializeField]
		private List<GameObject> listFloors;

		private GameObject floorPrefab;

		private float offsetY;

		private int lastIndex;

		public List<Vector3> ListSpawnPos
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> ListFloors
		{
			get
			{
				return null;
			}
		}

		public GameObject Summit { get; set; }

		public bool IsSpawned { get; set; }

		private void Awake()
		{
		}

		public Transform Init(GameObject floorPrefab, GameObject summitPrefab)
		{
			return null;
		}

		public Transform Init(GameObject floorPrefab)
		{
			return null;
		}

		public void SpawnFloor()
		{
		}

		public Tower_Player()
			: base()
		{
		}
	}
}
