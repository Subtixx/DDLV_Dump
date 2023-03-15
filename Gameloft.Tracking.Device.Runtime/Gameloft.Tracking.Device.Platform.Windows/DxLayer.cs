using Cpp2IlInjected;

namespace Gameloft.Tracking.Device.Platform.Windows
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class DxLayer
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x402CB30", Offset = "0x402B530", VA = "0x18402CB30")]
		public static extern string GetVersion();
	}
}
