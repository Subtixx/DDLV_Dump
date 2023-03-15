using System.Collections.Generic;
using Cpp2IlInjected;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	public interface IStoreContentType
	{
		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		List<StoreContent.ItemReward> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E2")]
		List<ContentPrice> Prices
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCC")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E3")]
		int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCD")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170002E4")]
		bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000BCE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
}
