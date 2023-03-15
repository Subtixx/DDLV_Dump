using Cpp2IlInjected;

namespace Gameloft.Tracking.Device
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum ConnectivityStatus
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		NoConnection = 0,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Wifi = 1,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Bluetooth = 2,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Ethernet = 3,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Mobile = 4,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Unknown = -1
	}
}
