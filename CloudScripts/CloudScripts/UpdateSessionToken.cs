using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	public class UpdateSessionToken
	{
		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public string DeviceName
			{
				[Cpp2IlInjected.Token(Token = "0x6000276")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CDeviceName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000277")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CDeviceName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public string ForceToken
			{
				[Cpp2IlInjected.Token(Token = "0x6000278")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CForceToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000279")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CForceToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			Failed
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000045")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000462")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x600027B")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600027C")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UpdateSessionToken()
		{
		}
	}
}
