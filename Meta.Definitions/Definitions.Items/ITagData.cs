using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000651")]
	public interface ITagData : IItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17001316")]
		string AlternativeIconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6004A3D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17001317")]
		string HtmlColor
		{
			[Cpp2IlInjected.Token(Token = "0x6004A3E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
