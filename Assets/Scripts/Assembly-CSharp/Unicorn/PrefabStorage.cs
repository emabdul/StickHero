using Sirenix.OdinInspector;
using UnityEngine;

namespace Unicorn
{
	public class PrefabStorage : SerializedMonoBehaviour
	{
		private static PrefabStorage instance;

		public GameObject fxWinPrefab;

		public static PrefabStorage Instance
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public PrefabStorage()
			: base()
		{
		}
	}
}
