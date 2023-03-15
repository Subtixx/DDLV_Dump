using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public enum DeviceType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[OriginalName("DeviceType_Unknown")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[OriginalName("DeviceType_Windows")]
		Windows,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[OriginalName("DeviceType_Android")]
		Android,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[OriginalName("DeviceType_IOS")]
		Ios,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[OriginalName("DeviceType_Switch")]
		Switch,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[OriginalName("DeviceType_Xbox")]
		Xbox
	}
}
