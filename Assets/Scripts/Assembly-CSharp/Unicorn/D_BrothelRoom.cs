using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class D_BrothelRoom : SerializedScriptableObject
	{
		public List<BrothelRoomInfo> ListBrothelRoomInfo;

		public Dictionary<int, List<BrothelItem>> dictionary;

		public D_BrothelRoom()
			: base()
		{
		}
	}
}
