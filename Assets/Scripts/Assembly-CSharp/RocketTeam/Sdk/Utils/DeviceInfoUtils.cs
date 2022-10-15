using System;

namespace RocketTeam.Sdk.Utils
{
	public class DeviceInfoUtils
	{
		private static string adsId;

		private static Action<string> onGetAdsId;

		private static void AdvertisingIdentifierCallback(string advertisingId, bool trackingEnabled, string errorMsg)
		{
		}

		public DeviceInfoUtils()
			: base()
		{
		}
	}
}
