using System;
using Newtonsoft.Json;

[Serializable]
public class AppPromotion
{
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
	public PromotionConfig[] App;

	public AppPromotion()
		: base()
	{
	}
}
