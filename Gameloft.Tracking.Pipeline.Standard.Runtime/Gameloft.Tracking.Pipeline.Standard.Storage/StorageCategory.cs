using Cpp2IlInjected;

namespace Gameloft.Tracking.Pipeline.Standard.Storage
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal enum StorageCategory
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		Prioritized,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Batchable
	}
}
