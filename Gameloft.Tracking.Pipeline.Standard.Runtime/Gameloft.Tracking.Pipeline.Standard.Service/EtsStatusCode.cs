using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Service
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public enum EtsStatusCode
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		PackageVersionRejected = 600,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		UploadBlocked = 701,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		BlockUploadAndErase = 702,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		StopTracking = 703,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		PackageVersionRejectedV2 = 900,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		UploadBlockedV2 = 901,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		BlockUploadAndEraseV2 = 902,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		StopTrackingV2 = 903,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		EventsRejected = 996,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		HeadersRejected = 997,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		PackageRejected = 998,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		TimeExpired = 999
	}
}
