using System;
using System.Runtime.CompilerServices;

namespace AppsFlyerSDK
{
	public class AppsFlyerRequestEventArgs : EventArgs
	{
		public int statusCode { get; }

		public string errorDescription { get; }

		public AppsFlyerRequestEventArgs(int code, string description)
			: base()
		{
		}
	}
}
