using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20006A6")]
	public interface IHasSubGridInteraction
	{
		[Cpp2IlInjected.Token(Token = "0x17001382")]
		SubGridInteraction SubGrid
		{
			[Cpp2IlInjected.Token(Token = "0x6004AFC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004AFD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
