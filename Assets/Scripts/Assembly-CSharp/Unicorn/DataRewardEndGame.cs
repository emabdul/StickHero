using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class DataRewardEndGame : SerializedScriptableObject
	{
		public List<RewardEndGame> Datas;

		public DataRewardEndGame()
			: base()
		{
		}
	}
}
