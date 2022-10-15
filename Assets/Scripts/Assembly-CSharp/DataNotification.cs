using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class DataNotification : SerializedScriptableObject
{
	public Dictionary<TypeNoti, DataNoti> DictDataNoti;

	public DataNotification()
		: base()
	{
	}
}
