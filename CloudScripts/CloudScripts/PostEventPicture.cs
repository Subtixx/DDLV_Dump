using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public class PostEventPicture
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public string EventName
			{
				[Cpp2IlInjected.Token(Token = "0x6000339")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CEventName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600033A")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CEventName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public string Version
			{
				[Cpp2IlInjected.Token(Token = "0x600033B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CVersion_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600033C")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CVersion_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000106")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			EventNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000508")]
			EventLimitReached,
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			EventExpired,
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			Failed
		}

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000089")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400050B")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x600033E")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600033F")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x400050C")]
			public int EventTicketRemaining
			{
				[Cpp2IlInjected.Token(Token = "0x6000341")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000342")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PostEventPicture()
		{
		}
	}
}
