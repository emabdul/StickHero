using System;
using UnityEngine;

namespace Unicorn
{
	[Serializable]
	public class HotGirlSpawner
	{
		public GameObject brothelPrefab;

		public int Position;

		public bool IsOccupied;

		public HotGirlSpawner(GameObject brothelPrefab, int position, bool isOccupied)
			: base()
		{
		}
	}
}
