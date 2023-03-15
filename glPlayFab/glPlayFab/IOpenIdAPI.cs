using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public interface IOpenIdAPI
	{
		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		string ContentType
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		IHttpContent HttpContent
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		bool ApplyFixedParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
}
