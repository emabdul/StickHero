using System;
using Newtonsoft.Json;

[Serializable]
public class PromotionConfig
{
	[JsonProperty]
	public int Version;

	[JsonProperty]
	public int Id;

	[JsonProperty]
	public string PackageName;

	[JsonProperty]
	public string Name;

	[JsonProperty]
	public string Description;

	[JsonProperty]
	public string Icon;

	[JsonProperty]
	public string Bonus;

	[JsonProperty]
	public long Platform;

	[JsonProperty]
	public string Url;

	[JsonProperty]
	public string Creative;

	[JsonProperty]
	public CreativeType Type;

	public string OpenURL
	{
		get
		{
			return null;
		}
	}

	public PromotionConfig()
		: base()
	{
	}
}
