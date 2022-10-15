using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn
{
	public abstract class LevelManager : MonoBehaviour
	{
		private static LevelManager instance;

		public static LevelManager Instance
		{
			get
			{
				return null;
			}
		}

		public LevelResult Result { get; set; }

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void SetUpLevelEnvironment()
		{
		}

		public virtual void ResetLevelState()
		{
		}

		public abstract void StartLevel();

		protected virtual void EndGame(LevelResult levelResult)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public LevelManager()
			: base()
		{
		}
	}
}
