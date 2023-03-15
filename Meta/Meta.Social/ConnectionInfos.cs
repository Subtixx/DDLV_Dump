using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000B40")]
	public enum ConnectionInfos
	{
		[Cpp2IlInjected.Token(Token = "0x4002BA0")]
		[OriginalName("ConnectionInfos_None")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4002BA1")]
		[OriginalName("ConnectionInfos_Snapshot")]
		Snapshot = 1,
		[Cpp2IlInjected.Token(Token = "0x4002BA2")]
		[OriginalName("ConnectionInfos_Album")]
		Album = 2,
		[Cpp2IlInjected.Token(Token = "0x4002BA3")]
		[OriginalName("ConnectionInfos_Stats")]
		Stats = 4,
		[Cpp2IlInjected.Token(Token = "0x4002BA4")]
		[OriginalName("ConnectionInfos_Guild")]
		Guild = 8,
		[Cpp2IlInjected.Token(Token = "0x4002BA5")]
		[OriginalName("ConnectionInfos_LastOnline")]
		LastOnline = 0x10
	}
}
