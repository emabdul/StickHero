using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class PlayerFloor : MonoBehaviour
	{
		[SerializeField]
		private Transform spawnTransform;

		[SerializeField]
		private Transform rewardSpawnTransform;

		public IInteractable Interactable { get; set; }

		public bool IsSpawned { get; set; }

		public List<GameObject> ListMesh { get; set; }

		public Transform MiddleTransform { get; set; }

		public Transform SpawnTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform RewardSpawnTransform
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public Transform CalculatePlayerSpawnPos()
		{
			return null;
		}

		public void OnBlockEnter()
		{
		}

		public void SpawnRewards()
		{
		}

		private bool CheckPrincess()
		{
			return default(bool);
		}

		public void ExplodeMeshes()
		{
		}

		public PlayerFloor()
			: base()
		{
		}
	}
}
