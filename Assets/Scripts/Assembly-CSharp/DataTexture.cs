using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class DataTexture : SerializedScriptableObject
{
	public Sprite IconCoin;

	public Sprite IconCoinLuckyWheel;

	public Sprite IconGemLuckyWheel;

	[SerializeField]
	private List<Sprite> ListIconSprKey;

	public Sprite GetIconKey(bool isActive)
	{
		return null;
	}

	public DataTexture()
		: base()
	{
	}
}
