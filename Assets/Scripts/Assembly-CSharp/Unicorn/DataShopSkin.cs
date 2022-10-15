using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Unicorn
{
	[CreateAssetMenu]
	public class DataShopSkin : SerializedScriptableObject
	{
		[SerializeField]
		private Dictionary<TypeEquipment, List<DataShop>> dataShop;

		public List<DataShop> GetDataShop(TypeEquipment typeEquipment)
		{
			return null;
		}

		public DataShopSkin()
			: base()
		{
		}
	}
}
