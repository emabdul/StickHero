using System;
using UnityEngine;

namespace Unicorn
{
	[Serializable]
	public class CustomerSpawner
	{
		public GameObject customerPrefab;

		public int Position;

		public bool IsOccupied;

		public CustomerSpawner(GameObject customerPrefab, int position, bool isOccupied)
			: base()
		{
		}
	}
}
