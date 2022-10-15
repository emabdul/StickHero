using System;
using System.Runtime.CompilerServices;

[Serializable]
public class Interactable
{
	public IInteractable interactable { get; set; }

	public int position { get; set; }

	public int power { get; set; }

	public MathOperator arithmeticOperator { get; set; }

	public InteractableType type { get; set; }

	public Interactable(IInteractable interactable, int position)
		: base()
	{
	}
}
