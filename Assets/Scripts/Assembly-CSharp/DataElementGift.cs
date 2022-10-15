using System;

[Serializable]
public class DataElementGift
{
	public TypeGift type;

	public int amount;

	public DataElementGift(TypeGift _type, int _amount)
		: this()
	{
	}

	public DataElementGift()
		: base()
	{
	}
}
