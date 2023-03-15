using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Meta.Online.Fed
{
	[Cpp2IlInjected.Token(Token = "0x2000FE9")]
	public enum DownloadSource
	{
		[Cpp2IlInjected.Token(Token = "0x400415C")]
		[OriginalName("DownloadSource_Appstore")]
		Appstore,
		[Cpp2IlInjected.Token(Token = "0x400415D")]
		[OriginalName("DownloadSource_GooglePlay")]
		GooglePlay,
		[Cpp2IlInjected.Token(Token = "0x400415E")]
		[OriginalName("DownloadSource_Switch")]
		Switch,
		[Cpp2IlInjected.Token(Token = "0x400415F")]
		[OriginalName("DownloadSource_Windows")]
		Windows,
		[Cpp2IlInjected.Token(Token = "0x4004160")]
		[OriginalName("DownloadSource_Steam")]
		Steam
	}
}
