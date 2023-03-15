using System;
using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface IFatigueHolder
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		DateTime LastRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		int BoughtQuantity
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
}
