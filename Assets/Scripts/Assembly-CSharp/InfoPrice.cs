using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Purchasing;

public class InfoPrice
{
	[SerializeField]
	private string priceDefault;

	public string localizedPrice
	{
		get
		{
			return null;
		}
	}

	public ProductMetadata Metadata { get; set; }

	public InfoPrice()
		: base()
	{
	}
}
