using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Events
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum ConnectivityType
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Wifi = 152142,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Wimax = 152144,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Mobile2G = 152145,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Mobile3G = 152146,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Mobile4G = 152147,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Bluetooth = 152150,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Ethernet = 152143,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		LocalAccess = 353606,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		LocalAndInternet = 386946,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Mobile = 160040,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		NoConnection = 152141,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Unknown = 152148
	}
}
