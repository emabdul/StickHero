using System;

namespace Unicorn
{
	[Serializable]
	public class IapPackReward
	{
		public float Gem;

		public TypeEquipment TypeEquipment;

		public int IdEquipment;

		public int IdWeapon;

		public IapPackReward()
			: base()
		{
		}
	}
}
