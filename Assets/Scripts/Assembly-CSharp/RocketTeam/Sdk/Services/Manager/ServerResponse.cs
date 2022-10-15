using Newtonsoft.Json;

namespace RocketTeam.Sdk.Services.Manager
{
	public class ServerResponse<T>
	{
		[JsonProperty]
		public int code;

		[JsonProperty]
		public T data;

		public bool IsSuccess()
		{
			return default(bool);
		}

		public ServerResponse()
			: base()
		{
		}
	}
}
