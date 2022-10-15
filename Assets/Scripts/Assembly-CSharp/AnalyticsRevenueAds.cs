using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class AnalyticsRevenueAds
{
	public static string AppsflyerID;

	public static string FirebaseID;

	public static void Init()
	{
	}

	public static void SendEvent(ImpressionData data, AdFormat type)
	{
	}

	private static void SendEventRealtime(ImpressionData data, AdFormat type)
	{
	}

	private static void SendEventThreshold(ImpressionData data, AdFormat type)
	{
	}

	private static void SendEventServer(ImpressionData data, AdFormat type)
	{
	}

	private static double GetRevenueCache(AdFormat type)
	{
		return default(double);
	}

	private static void SetRevenueCache(AdFormat type, double rev)
	{
	}

	private static bool CheckConditionDay(string stringTimeCheck, int maxDays)
	{
		return default(bool);
	}

	private static string GetTimeLogin(AdFormat type)
	{
		return null;
	}

	private static void SetTimeLogin(AdFormat type, string time)
	{
	}

	public static Task<string> GetAnalyticsInstanceId()
	{
		return null;
	}

	public AnalyticsRevenueAds()
		: base()
	{
	}
}
