using System;

namespace Unicorn
{
	[Serializable]
	public class ChallengeLevelInfo
	{
		public int buildIndex;

		public int numberOfTowers;

		public ChallengeReward challengeReward;

		public EnemyType enemyType;

		public D_LevelManager levelData;

		public ChallengeLevelInfo()
			: base()
		{
		}
	}
}
