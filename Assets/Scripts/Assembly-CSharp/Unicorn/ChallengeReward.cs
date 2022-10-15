using System;

namespace Unicorn
{
	[Serializable]
	public class ChallengeReward
	{
		public int Gem;

		public int Coin;

		public ChallengeReward()
			: base()
		{
		}

		public ChallengeReward(int gem, int coin)
			: this()
		{
		}
	}
}
