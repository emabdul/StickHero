using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AppsFlyerSDK
{
	public class DeepLinkEventsArgs : EventArgs
	{
		public Dictionary<string, object> deepLink;

		public DeepLinkStatus status { get; }

		public DeepLinkError error { get; }

		public string getMatchType()
		{
			return null;
		}

		public string getDeepLinkValue()
		{
			return null;
		}

		public string getClickHttpReferrer()
		{
			return null;
		}

		public string getMediaSource()
		{
			return null;
		}

		public string getCampaign()
		{
			return null;
		}

		public string getCampaignId()
		{
			return null;
		}

		public string getAfSub1()
		{
			return null;
		}

		public string getAfSub2()
		{
			return null;
		}

		public string getAfSub3()
		{
			return null;
		}

		public string getAfSub4()
		{
			return null;
		}

		public string getAfSub5()
		{
			return null;
		}

		public bool isDeferred()
		{
			return default(bool);
		}

		public Dictionary<string, object> getDeepLinkDictionary()
		{
			return null;
		}

		public DeepLinkEventsArgs(string str)
			: base()
		{
		}

		private string getDeepLinkParameter(string name)
		{
			return null;
		}
	}
}
