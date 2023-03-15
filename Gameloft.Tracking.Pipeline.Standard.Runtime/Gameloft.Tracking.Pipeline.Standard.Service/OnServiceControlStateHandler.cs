using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	internal delegate void OnServiceControlStateHandler(EtsStatusCode newBanState);
}
