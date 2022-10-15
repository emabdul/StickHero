using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class D_Floor : ScriptableObject
{
	public List<InteractableSpawner> interactableSpawners;

	public D_Floor()
		: base()
	{
	}
}
