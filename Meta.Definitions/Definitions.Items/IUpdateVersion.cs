using Cpp2IlInjected;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000650")]
	public interface IUpdateVersion
	{
		[Cpp2IlInjected.Token(Token = "0x17001315")]
		string UpdateVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6004A3B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6004A3C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
