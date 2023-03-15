using System;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000190")]
	public interface IOnlineLiveopsConfig : IServerDataConfig
	{
		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		string OnlineId
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600078D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		int Version
		{
			[Cpp2IlInjected.Token(Token = "0x600078E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600078F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		DateTime StartDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		DateTime? EndDate
		{
			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		bool IsHidden
		{
			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}
	}
}
