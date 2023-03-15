using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200069C")]
	public interface IIsCustomizable
	{
		[Cpp2IlInjected.Token(Token = "0x1700137D")]
		bool CanAddDecals
		{
			[Cpp2IlInjected.Token(Token = "0x6004AF1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700137E")]
		bool CanChangeColor
		{
			[Cpp2IlInjected.Token(Token = "0x6004AF2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
