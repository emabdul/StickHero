namespace RocketTeam.Sdk.Services.Ads
{
	public struct BlacklistData
	{
		public string url;

		public int impressions;

		public BlacklistData(string url, int impressions)
		{
			this.impressions = default(int);
			this.url = default(string);
		}
	}
}
