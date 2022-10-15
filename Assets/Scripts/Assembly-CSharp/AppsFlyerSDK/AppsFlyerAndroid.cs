using System.Collections.Generic;
using UnityEngine;

namespace AppsFlyerSDK
{
	public class AppsFlyerAndroid
	{
		private static AndroidJavaClass appsFlyerAndroid;

		public static void initSDK(string devkey, MonoBehaviour gameObject)
		{
		}

		public static void startSDK()
		{
		}

		public static void startSDK(bool shouldCallback, string callBackObjectName)
		{
		}

		public static void stopSDK(bool isSDKStopped)
		{
		}

		public static string getSdkVersion()
		{
			return null;
		}

		public static void updateServerUninstallToken(string token)
		{
		}

		public static void setIsDebug(bool shouldEnable)
		{
		}

		public static void setImeiData(string aImei)
		{
		}

		public static void setAndroidIdData(string aAndroidId)
		{
		}

		public static void setCustomerUserId(string id)
		{
		}

		public static void waitForCustomerUserId(bool wait)
		{
		}

		public static void setCustomerIdAndStartSDK(string id)
		{
		}

		public static string getOutOfStore()
		{
			return null;
		}

		public static void setOutOfStore(string sourceName)
		{
		}

		public static void setAppInviteOneLinkID(string oneLinkId)
		{
		}

		public static void setAdditionalData(Dictionary<string, string> customData)
		{
		}

		public static void setUserEmails(params string[] emails)
		{
			emails = default(string[]);
		}

		public static void setPhoneNumber(string phoneNumber)
		{
		}

		public static void setUserEmails(EmailCryptType cryptMethod, params string[] emails)
		{
			emails = default(string[]);
		}

		public static void setCollectAndroidID(bool isCollect)
		{
		}

		public static void setCollectIMEI(bool isCollect)
		{
		}

		public static void setResolveDeepLinkURLs(params string[] urls)
		{
			urls = default(string[]);
		}

		public static void setOneLinkCustomDomain(params string[] domains)
		{
			domains = default(string[]);
		}

		public static void setIsUpdate(bool isUpdate)
		{
		}

		public static void setCurrencyCode(string currencyCode)
		{
		}

		public static void recordLocation(double latitude, double longitude)
		{
		}

		public static void sendEvent(string eventName, Dictionary<string, string> eventValues)
		{
		}

		public static void sendEvent(string eventName, Dictionary<string, string> eventValues, bool shouldCallback, string callBackObjectName)
		{
		}

		public static void anonymizeUser(bool isDisabled)
		{
		}

		public static void enableFacebookDeferredApplinks(bool isEnabled)
		{
		}

		public static void setConsumeAFDeepLinks(bool doConsume)
		{
		}

		public static void setPreinstallAttribution(string mediaSource, string campaign, string siteId)
		{
		}

		public static bool isPreInstalledApp()
		{
			return default(bool);
		}

		public static string getAttributionId()
		{
			return null;
		}

		public static string getAppsFlyerId()
		{
			return null;
		}

		public static void validateAndSendInAppPurchase(string publicKey, string signature, string purchaseData, string price, string currency, Dictionary<string, string> additionalParameters, MonoBehaviour gameObject)
		{
		}

		public static bool isSDKStopped()
		{
			return default(bool);
		}

		public static void setMinTimeBetweenSessions(int seconds)
		{
		}

		public static void setHost(string hostPrefixName, string hostName)
		{
		}

		public static string getHostName()
		{
			return null;
		}

		public static string getHostPrefix()
		{
			return null;
		}

		public static void setSharingFilterForAllPartners()
		{
		}

		public static void setSharingFilter(params string[] partners)
		{
			partners = default(string[]);
		}

		public static void getConversionData(string objectName)
		{
		}

		public static void initInAppPurchaseValidatorListener(MonoBehaviour gameObject)
		{
		}

		public static void setCollectOaid(bool isCollect)
		{
		}

		public static void attributeAndOpenStore(string promoted_app_id, string campaign, Dictionary<string, string> userParams)
		{
		}

		public static void recordCrossPromoteImpression(string appID, string campaign, Dictionary<string, string> parameters)
		{
		}

		public static void generateUserInviteLink(Dictionary<string, string> parameters, MonoBehaviour gameObject)
		{
		}

		public static void handlePushNotifications()
		{
		}

		public static void addPushNotificationDeepLinkPath(params string[] paths)
		{
			paths = default(string[]);
		}

		public static void subscribeForDeepLink(string objectName)
		{
		}

		private static AndroidJavaObject getEmailType(EmailCryptType cryptType)
		{
			return null;
		}

		private static AndroidJavaObject convertDictionaryToJavaMap(Dictionary<string, string> dictionary)
		{
			return null;
		}

		public AppsFlyerAndroid()
			: base()
		{
		}
	}
}
