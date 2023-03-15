using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class PostLogin
	{
		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			InboxGrantedFailure,
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000411")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000252")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000253")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PostLogin()
		{
		}
	}
}
