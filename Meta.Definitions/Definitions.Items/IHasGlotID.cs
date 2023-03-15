using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000658")]
	public interface IHasGlotID
	{
		[Cpp2IlInjected.Token(Token = "0x17001321")]
		uint GlotID
		{
			[Cpp2IlInjected.Token(Token = "0x6004A4E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004A4F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
