using System;
using Newtonsoft.Json;

namespace Unicorn
{
	[Serializable]
	public class LevelTypeInfo
	{
		[JsonProperty]
		private LevelType levelType;

		[JsonProperty]
		private int currentLevel;

		[JsonProperty]
		private int maxLevel;

		[JsonIgnore]
		public LevelType LevelType
		{
			get
			{
				return default(LevelType);
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int CurrentLevel
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int MaxLevel
		{
			get
			{
				return default(int);
			}
		}

		public LevelTypeInfo(LevelType levelType)
			: base()
		{
		}

		public int IncreaseLevel(LevelConstraint levelConstraint)
		{
			return default(int);
		}

		public void SetLevel(int level, LevelConstraint levelConstraint)
		{
		}
	}
}
