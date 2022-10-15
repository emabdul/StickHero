using System;
using UnityEngine.Purchasing;

[Serializable]
public class InAppProduct
{
	public string name;

	public string productId;

	public ProductType productType;

	public string iosAppStoreId;

	public InAppProduct()
		: base()
	{
	}
}
