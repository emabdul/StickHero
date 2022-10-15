using System;
using UnityEngine;

[Serializable]
public class Position
{
	public Transform transform;

	public bool isOccupied;

	public Position()
		: base()
	{
	}
}
