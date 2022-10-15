using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
//using Firebase.RemoteConfig;

public class RocketRemoteConfig
{
	private static bool isInit;

	private static Dictionary<string, string> playfabConfig;

	public static bool InitSuccess;

	public static Task FetchData()
	{
		return null;
	}

	public static string GetStringConfig(string key, string defaultValue)
	{
		return null;
	}

	public static bool GetBoolConfig(string key, bool defaultValue)
	{
		return default(bool);
	}

	public static float GetFloatConfig(string key, float defaultValue)
	{
		return default(float);
	}

	public static int GetIntConfig(string key, int defaultValue)
	{
		return default(int);
	}

	public static string PlayfabStringConfig(string key, string defaultValue)
	{
		return null;
	}

	public static int PlayfabIntConfig(string key, int defaultVal)
	{
		return default(int);
	}

	public static float PlayfabFloatConfig(string key, float defaultVal)
	{
		return default(float);
	}

	public static bool PlayfabBoolConfig(string key, bool defaultVal)
	{
		return default(bool);
	}

	public static void OnLoadConfig(Dictionary<string, string> Data)
	{
	}

	private static void FetchComplete(Task fetchTask)
	{
	}

	public static void RemoteConfigFirebaseInit()
	{
	}

	private static void DebugLog(string s)
	{
	}

	public RocketRemoteConfig()
		: base()
	{
	}
}
