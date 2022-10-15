using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class DataShopIap : SerializedScriptableObject
{
	public Dictionary<IdPack, InfoPackage> dictInfoPackage;

	public DataShopIap()
		: base()
	{
	}
}
