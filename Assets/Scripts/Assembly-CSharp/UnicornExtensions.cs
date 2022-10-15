using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public static class UnicornExtensions
{
	public static T GetRandomAndRemove<T>(this List<T> deck, bool retainOrder = false)
	{
		return (T)default(T);
	}

	public static T GetRandom<T>(this List<T> deck)
	{
		return (T)default(T);
	}

	public static T GetRandom<T>(this T[] deck)
	{
		return (T)default(T);
	}

	public static void Shuffle<T>(this List<T> deck)
	{
	}

	public static void Shuffle<T>(this T[] deck)
	{
	}

	public static Vector3 RandomPoint(this Bounds bounds)
	{
		return default(Vector3);
	}

	public static bool IsPointerOverUIObject()
	{
		return default(bool);
	}

	public static Vector3 GetVectorFromAngle(float angle)
	{
		return default(Vector3);
	}

	public static float GetAngleFromVector(Vector3 dir)
	{
		return default(float);
	}

	public static Vector3 Set(this Vector3 vector3, float? x = default(float?), float? y = default(float?), float? z = default(float?))
	{
		return default(Vector3);
	}

	public static Vector3 Move(this Vector3 vector3, Vector3 direction)
	{
		return default(Vector3);
	}

	public static Vector2 Set(this Vector2 vector2, float? x = default(float?), float? y = default(float?))
	{
		return default(Vector2);
	}

	public static Vector2 ToVectorXZ(this Vector3 vector3)
	{
		return default(Vector2);
	}

	public static Vector3 ToVectorXZ(this Vector2 vector2)
	{
		return default(Vector3);
	}

	public static bool Approximately(this Quaternion quatA, Quaternion value, float acceptableRange = 0.0004f)
	{
		return default(bool);
	}
}
