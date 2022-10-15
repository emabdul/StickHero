using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Unicorn
{
	[Serializable]
	public class UnicornDataLevel : IDataLevel, ILevelInfo
	{
		[JsonProperty]
		private LevelType levelType;

		[JsonProperty]
		private int displayLevel;

		[JsonProperty]
		private bool isKeyCollected;

		[JsonProperty]
		private Dictionary<LevelType, LevelTypeInfo> levelTypesIndex;

		private List<int> loopLevels;

		private LevelConstraint levelConstraint;

		public LevelConstraint LevelConstraint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LevelType LevelType
		{
			get
			{
				return default(LevelType);
			}
		}

		public int DisplayLevel
		{
			get
			{
				return default(int);
			}
		}

		[JsonIgnore]
		public bool IsKeyCollected
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[JsonIgnore]
		private Dictionary<LevelType, LevelTypeInfo> LevelTypesIndex
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UnicornDataLevel(LevelConstraint levelConstraint)
			: base()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void SetLevel(LevelType levelType, bool increment = false)
		{
		}

		public void SetLevel(LevelType levelType, int level)
		{
		}

		public void SetLevel(int buildIndex)
		{
		}

		public int GetBuildIndex()
		{
			return default(int);
		}

		public int GetCurrentLevel()
		{
			return default(int);
		}

		public void IncreaseLevel()
		{
		}

		private LevelType GetNextLevelType()
		{
			return default(LevelType);
		}

		public void Save()
		{
		}
	}
}
