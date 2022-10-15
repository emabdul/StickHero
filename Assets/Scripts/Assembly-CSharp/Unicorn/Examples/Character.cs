using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unicorn.Examples
{
	public class Character : MonoBehaviour
	{
		private SkinChangerRoblox skinCharacter;

		public SkinChangerRoblox SkinCharacter
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool IsPlayer { get; set; }

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public Character()
			: base()
		{
		}
	}
}
