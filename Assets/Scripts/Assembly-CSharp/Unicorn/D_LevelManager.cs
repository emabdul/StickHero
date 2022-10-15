using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class D_LevelManager : ScriptableObject
	{
		public int defaultPlayerPower;

		public GameplayType gameplayType;

		public TowerType towerType;

		public GameObject bossPrefab;

		public int bossPower;

		public float orthoSizeNormal;

		public float orthoSizeBoss;

		public UnlockType UnlockType;

		public int additionalBuffMin;

		public int additionalBuffMax;

		public D_LevelManager()
			: base()
		{
		}
	}
}
