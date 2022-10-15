using System.Collections.Generic;
using UnityEngine;

namespace Unicorn
{
	public static class Yielders
	{
		private static Dictionary<float, WaitForSeconds> _timeInterval;

		private static WaitForEndOfFrame endOfFrame;

		public static WaitForEndOfFrame EndOfFrame
		{
			get
			{
				return null;
			}
		}

		public static WaitForSeconds Get(float seconds)
		{
			return null;
		}
	}
}
