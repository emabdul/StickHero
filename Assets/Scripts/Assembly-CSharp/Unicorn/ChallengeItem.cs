using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class ChallengeItem : MonoBehaviour
	{
		[SerializeField]
		private Transform playerSpawn;

		[SerializeField]
		private Transform enemySpawn;

		[SerializeField]
		private List<GameObject> listEnemyPrefabs;

		[SerializeField]
		private GameObject playerPrefab;

		public SkinChangerStick SkinChanger { get; set; }

		public GameObject PlayerPrefab
		{
			get
			{
				return null;
			}
		}

		public List<GameObject> ListEnemyPrefabs
		{
			get
			{
				return null;
			}
		}

		public void Init(EnemyType enemyType)
		{
		}

		public void Refresh()
		{
		}

		public ChallengeItem()
			: base()
		{
		}
	}
}
