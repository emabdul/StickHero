using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class D_Tower : SerializedScriptableObject
{
	public Dictionary<int, List<InteractableSpawner>> dictionary;

	public int LockPos;

	public D_Tower()
		: base()
	{
	}
}
