using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class ResetDisplayNameChangeCooldown
	{
		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public string PlayFabId
			{
				[Cpp2IlInjected.Token(Token = "0x600028A")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600028B")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			AlreadyAvailable,
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			Failed
		}

		[Cpp2IlInjected.Token(Token = "0x20000D8")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000471")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x600028D")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600028E")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ResetDisplayNameChangeCooldown()
		{
		}
	}
}
