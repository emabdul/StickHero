using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public class BrothelTower : MonoBehaviour
	{
		[SerializeField]
		private List<BrothelRoom> listBrothelRoom;

		[SerializeField]
		private List<GameObject> hotGirlPrefab;

		[SerializeField]
		private List<GameObject> customerPrefab;

		[SerializeField]
		private List<Transform> originGirlSpawn;

		[SerializeField]
		private List<Transform> originCustomerSpawn;

		[SerializeField]
		private Transform originPlayerSpawn;

		[SerializeField]
		private Transform disappearTransform;

		[SerializeField]
		private Transform topTransform;

		[SerializeField]
		private List<Transform> customerCoinTransform;

		public List<Transform> CustomerCoinTransform
		{
			get
			{
				return null;
			}
		}

		public Transform TopTransform
		{
			get
			{
				return null;
			}
		}

		public Transform DisappearTransform
		{
			get
			{
				return null;
			}
		}

		public List<Transform> OriginGirlSpawn
		{
			get
			{
				return null;
			}
		}

		public List<Transform> OriginCustomerSpawn
		{
			get
			{
				return null;
			}
		}

		public Transform OriginPlayerSpawn
		{
			get
			{
				return null;
			}
		}

		public int TowerId { get; set; }

		public List<BrothelRoom> ListBrothelRoom
		{
			get
			{
				return null;
			}
		}

		public void FirstTimeInit(List<BrothelRoomInfo> listBrothelRoomInfo, int towerId)
		{
		}

		public void Init(int towerId)
		{
		}

		public BrothelTower()
			: base()
		{
		}
	}
}
