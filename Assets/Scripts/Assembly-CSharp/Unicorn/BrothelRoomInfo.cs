using System;

namespace Unicorn
{
	[Serializable]
	public class BrothelRoomInfo
	{
		public BrothelRoomUnlockType UnlockType;

		public bool IsUnlocked;

		public float CoinToUnlock;

		public float GemToUnlock;

		public BrothelRoomInfo()
			: base()
		{
		}
	}
}
