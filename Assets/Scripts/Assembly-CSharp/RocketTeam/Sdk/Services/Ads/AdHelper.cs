using UnityEngine;

namespace RocketTeam.Sdk.Services.Ads
{
	public class AdHelper
	{
		private const string pathLogShow = "ads/show/";

		private const string pathLogClick = "ads/click/";

		private const string pathLogClose = "ads/close/";

		private static AndroidJavaClass androidJavaClass;

		private const string LIST_BUNDLE_ID_OF_RECEIVED_REWARD_KEY = "G2.Sdk.Services.Ads_list_bundle_id_of_received_reward";

		private const string LIST_AD_IMPRESSIONS_KEY = "G2.Sdk.Services.Ads_ad_impression";

		private const int MAX_IMPRESSIONS = 3;

		public static void SendLogClickAd(string getId, int isReceivedReward)
		{
		}

		public static void SendLogCloseAd(string groupId)
		{
		}

		public static void SendLogShowAd(string getId, string groupId)
		{
		}

		public static bool CheckInstall(string bundleID)
		{
			return default(bool);
		}

		public static void OpenGame(string bundleID, string urlStore)
		{
		}

		private static AndroidJavaObject GetUnityCurrentActivity()
		{
			return null;
		}

		public static bool IsReceivedReward(string bundleId)
		{
			return default(bool);
		}

		public static void AddNewBundleReceivedReward(string bundleId)
		{
		}

		public static bool IsInBlacklist(string bundleId, string url)
		{
			return default(bool);
		}

		public static void AddToListAdImpressions(string bundleId, string url)
		{
		}

		public AdHelper()
			: base()
		{
		}
	}
}
