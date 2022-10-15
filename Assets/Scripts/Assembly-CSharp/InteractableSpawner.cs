using System;
using UnityEngine;

[Serializable]
public class InteractableSpawner
{
	public GameObject InteractablePrefabs;

	public int Position;

	public int Power;

	public MathOperator ArithmeticOperator;

	public InteractableType Type;

	public InteractableSpawner()
		: base()
	{
	}
}
