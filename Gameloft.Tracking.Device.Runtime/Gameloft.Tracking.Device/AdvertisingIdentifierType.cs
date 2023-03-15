using Cpp2IlInjected;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum AdvertisingIdentifierType
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Undefined,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		IDFA,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		GAID
	}
}
