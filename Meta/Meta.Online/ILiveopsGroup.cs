using System;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace Meta.Online
{
	[Cpp2IlInjected.Token(Token = "0x2000F2A")]
	public interface ILiveopsGroup
	{
		[Cpp2IlInjected.Token(Token = "0x170015A6")]
		string LocalFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6007C95")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6007C96")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170015A7")]
		Type DataType
		{
			[Cpp2IlInjected.Token(Token = "0x6007C97")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170015A8")]
		object RawData
		{
			[Cpp2IlInjected.Token(Token = "0x6007C98")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6007C99")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task Load(string serializedData, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6007C9A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<string> Fetch(bool mustReturnValue, CancellationToken ct);
	}
}
