using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class D_IapPackItem : ScriptableObject
	{
		public float Price;

		public IapPackReward IapPackReward;

		public D_IapPackItem()
			: base()
		{
		}
	}
}
