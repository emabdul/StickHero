using System;

namespace UnityEngine.UI.Extensions
{
	[Serializable]
	public struct Vector3_Array2D
	{
		[SerializeField]
		public Vector3[] array;

		public Vector3 this[int _idx]
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}
	}
}
