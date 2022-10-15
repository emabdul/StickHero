using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class D_IapSingleItem : ScriptableObject
	{
		public float Price;

		public IapReward IapReward;

		public D_IapSingleItem()
			: base()
		{
		}
	}
}
