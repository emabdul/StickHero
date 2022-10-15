using UnityEngine;

public static class Vibration
{
	public static AndroidJavaClass unityPlayer;

	public static AndroidJavaObject currentActivity;

	public static AndroidJavaObject vibrator;

	public static void Init()
	{
	}

	public static void Vibrate()
	{
	}

	public static void Vibrate(long milliseconds)
	{
	}

	public static void Vibrate(long[] pattern, int repeat)
	{
	}

	public static bool HasVibrator()
	{
		return default(bool);
	}

	public static void Cancel()
	{
	}

	private static bool isAndroid()
	{
		return default(bool);
	}
}
