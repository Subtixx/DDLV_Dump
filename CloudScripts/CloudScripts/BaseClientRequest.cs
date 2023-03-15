using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	public class BaseClientRequest
	{
		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000672")]
		public bool ReturnStatistics
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
			set;
		} = true;


		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x11"), Cpp2IlInjected.Token(Token = "0x4000673")]
		public bool ReturnCurrencies
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x5706D0", Offset = "0x56F0D0", VA = "0x1805706D0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x570700", Offset = "0x56F100", VA = "0x180570700")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x12"), Cpp2IlInjected.Token(Token = "0x4000674")]
		public bool ReturnItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0x5706F0", Offset = "0x56F0F0", VA = "0x1805706F0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0x570720", Offset = "0x56F120", VA = "0x180570720")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x1165570", Offset = "0x1163F70", VA = "0x181165570")]
		public BaseClientRequest()
		{
		}
	}
}
