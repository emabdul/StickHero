using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unicorn
{
	[Serializable]
	public class LevelConstraint
	{
		[SerializeField]
		private int[] bonusStep;

		[SerializeField]
		private List<int> startIndexes;

		private int startIndex;

		public int GetStartIndex()
		{
			return default(int);
		}

		public int GetStartIndex(LevelType levelType)
		{
			return default(int);
		}

		public int GetLevelCount()
		{
			return default(int);
		}

		public int GetLevelCount(LevelType levelType)
		{
			return default(int);
		}

		public LevelType GetLevelTypeFromBuildIndex(int buildIndex)
		{
			return default(LevelType);
		}

		public int GetLevelIndexFromBuildIndex(int buildIndex)
		{
			return default(int);
		}

		public LevelConstraint()
			: base()
		{
		}
	}
}
