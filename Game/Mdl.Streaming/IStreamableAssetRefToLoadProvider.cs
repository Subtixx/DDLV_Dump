using Cpp2IlInjected;

namespace Mdl.Streaming
{
	[Cpp2IlInjected.Token(Token = "0x2000809")]
	public interface IStreamableAssetRefToLoadProvider
	{
		[Cpp2IlInjected.Token(Token = "0x60023F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object GetStreamableAssetToLoadKey();
	}
}
