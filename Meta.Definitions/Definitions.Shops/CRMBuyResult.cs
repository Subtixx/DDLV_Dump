using Cpp2IlInjected;
using Google.Protobuf.Reflection;

namespace Definitions.Shops
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	public enum CRMBuyResult
	{
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		[OriginalName("Success")]
		Success,
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		[OriginalName("TimeOut")]
		TimeOut,
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		[OriginalName("InvalidReceipt")]
		InvalidReceipt,
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		[OriginalName("Cancelled")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		[OriginalName("LastBuyOperationNotCompleted")]
		LastBuyOperationNotCompleted,
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		[OriginalName("NotEnoughCurrency")]
		NotEnoughCurrency,
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		[OriginalName("InvalidBundleId")]
		InvalidBundleId,
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		[OriginalName("Error")]
		Error
	}
}
