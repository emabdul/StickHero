using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public static class SimplePool
{
	private class Pool
	{
		private int nextId;

		private readonly Queue<GameObject> inactive;

		private readonly GameObject prefab;

		public int StackCount
		{
			get
			{
				return default(int);
			}
		}

		public Pool(GameObject prefab, int initialQty)
			: base()
		{
		}

		public GameObject Spawn(Vector3 pos, Quaternion rot, bool isActive = true)
		{
			return null;
		}

		public T Spawn<T>(Vector3 pos, Quaternion rot, bool isActive = true)
		{
			return (T)default(T);
		}

		public void Despawn(GameObject obj)
		{
		}

		public void Clear()
		{
		}
	}

	private class PoolMember : MonoBehaviour
	{
		public Pool myPool;

		public PoolMember()
			: base()
		{
		}
	}

	private const int DEFAULT_POOL_SIZE = 3;

	private static Dictionary<GameObject, Pool> pools;

	private static void Init(GameObject prefab = default(GameObject), int qty = 3)
	{
	}

	public static GameObject[] Preload(GameObject prefab, int qty = 1)
	{
		return null;
	}

	public static GameObject Spawn(GameObject prefab, Vector3 pos, Quaternion rot, bool isActive = true)
	{
		return null;
	}

	public static GameObject Spawn(GameObject prefab, bool isActive = true)
	{
		return null;
	}

	public static T Spawn<T>(T prefab, bool isActive = true) where T : Component
	{
		return null;
	}

	public static T Spawn<T>(T prefab, Vector3 pos, Quaternion rot, bool isActive = true) where T : Component
	{
		return null;
	}

	public static void Despawn(GameObject obj)
	{
	}

	public static void ClearAllPoolType<T>(T prefab) where T : Component
	{
	}

	public static int GetStackCount(GameObject prefab)
	{
		return default(int);
	}

	public static void ClearPool()
	{
	}
}
