using Cpp2IlInjected;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200098D")]
	public class NetworkSettings
	{
		[Cpp2IlInjected.Token(Token = "0x40027B1")]
		public const int MaxNumPlayers = 4;

		[Cpp2IlInjected.Token(Token = "0x40027B2")]
		public const int DefaultPlayerId = 0;

		[Cpp2IlInjected.Token(Token = "0x40027B3")]
		public const string RpcIdKey = "networkrpcid";

		[Cpp2IlInjected.Token(Token = "0x40027B4")]
		public const string PlayerIdKey = "networkplayerid";

		[Cpp2IlInjected.Token(Token = "0x60053EA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public NetworkSettings()
		{
		}
	}
}
