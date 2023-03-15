using Cpp2IlInjected;

namespace Mdl.Platform
{
	[Cpp2IlInjected.Token(Token = "0x20002AA")]
	public interface IProfanityFilterer
	{
		[Cpp2IlInjected.Token(Token = "0x6000BB0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Filter(string inText, out string filteredText);
	}
}
