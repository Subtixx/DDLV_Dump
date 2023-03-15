using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class StartEvent
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public string Name
			{
				[Cpp2IlInjected.Token(Token = "0x60001E1")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60001E2")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x18"), Cpp2IlInjected.Token(Token = "0x4000173")]
			public bool ForceStart
			{
				[Cpp2IlInjected.Token(Token = "0x60001E3")]
				[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60001E4")]
				[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x19"), Cpp2IlInjected.Token(Token = "0x4000174")]
			public bool SkipIncrementStatistics
			{
				[Cpp2IlInjected.Token(Token = "0x60001E5")]
				[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60001E6")]
				[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			NotAuthorized,
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			UnknownEventName,
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			AccessDenied,
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			InvalidType,
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			Timeout
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400017C")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x60001E8")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60001E9")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public StartEvent()
		{
		}
	}
}
