using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	private static bool _instantiated;

	protected bool isDestroy;

	public static T Instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public static bool Instantiated
	{
		get
		{
			return default(bool);
		}
	}

	public virtual void Awake()
	{
	}

	protected virtual void OnAwake()
	{
	}

	public virtual void Init()
	{
	}

	private void OnDestroy()
	{
	}

	public Singleton()
		: base()
	{
	}
}
