using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class DataLuckyWheel : SerializedScriptableObject
	{
		public int NumberSpinDaily;

		public List<DataRewardLuckyWheel> ListDataRewrds;

		public List<RewardEndGame> ListDataReceiveFrees;

		public int GetIdLuckyWheel()
		{
			return default(int);
		}

		public DataLuckyWheel()
			: base()
		{
		}
	}
}
