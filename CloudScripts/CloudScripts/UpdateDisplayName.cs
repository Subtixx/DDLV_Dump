using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class UpdateDisplayName
	{
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public string PlayFabId
			{
				[Cpp2IlInjected.Token(Token = "0x6000280")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPlayFabId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000281")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPlayFabId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public string DisplayName
			{
				[Cpp2IlInjected.Token(Token = "0x6000282")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CDisplayName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000283")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CDisplayName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			ChangeOnCooldown,
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			ProfanityDetected,
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			LegacyChangeFailed,
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			EntityChangeFailed
		}

		[Cpp2IlInjected.Token(Token = "0x20000D4")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000048")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400046B")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000285")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000286")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public UpdateDisplayName()
		{
		}
	}
}
