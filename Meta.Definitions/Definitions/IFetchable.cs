using Cpp2IlInjected;
using Definitions.Conditions;

namespace Definitions
{
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	public interface IFetchable : ITimeLimited
	{
		[Cpp2IlInjected.Token(Token = "0x170002D6")]
		int Version
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D7")]
		string MinGameVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D8")]
		bool Active
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BB8")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002D9")]
		string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BBA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002DA")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBB")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BBC")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		string IconAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBD")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BBE")]
			[Cpp2IlInjected.Address(Slot = "11")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002DC")]
		string Language
		{
			[Cpp2IlInjected.Token(Token = "0x6000BBF")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BC0")]
			[Cpp2IlInjected.Address(Slot = "13")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		ConditionDate LastUpdateTimestamp
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC1")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000BC2")]
			[Cpp2IlInjected.Address(Slot = "15")]
			set;
		}
	}
}
