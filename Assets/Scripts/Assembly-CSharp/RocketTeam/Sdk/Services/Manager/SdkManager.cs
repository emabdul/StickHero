using System.Runtime.CompilerServices;
using RocketTeam.Sdk.Services.Interfaces;

namespace RocketTeam.Sdk.Services.Manager
{
	public class SdkManager : IServiceManager
	{
		private static SdkManager instance;

		private static string clientKey;

		private static bool isSandbox;

		public static SdkManager Instance
		{
			get
			{
				return null;
			}
		}

		public IAdsManager AdsManager { get; private set; }

		public IMoreGamesManager MoreGamesManager { get; private set; }

		public IBubbleAdManager BubbleAdManager { get; private set; }

		public static void Init(string _clientKey, bool _isSandbox)
		{
		}

		public static bool IsSandbox()
		{
			return default(bool);
		}

		private string GetServerUrl()
		{
			return null;
		}

		public void RegisterService(ServiceType serviceType, object service)
		{
		}

		public void UnregisterService(ServiceType serviceType, object service)
		{
		}

		public SdkManager()
			: base()
		{
		}
	}
}
