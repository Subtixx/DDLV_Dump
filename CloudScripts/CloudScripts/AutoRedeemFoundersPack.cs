using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class AutoRedeemFoundersPack
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public string StoreFrontGroupUniqueName
			{
				[Cpp2IlInjected.Token(Token = "0x6000257")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CStoreFrontGroupUniqueName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000258")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CStoreFrontGroupUniqueName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000414")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000415")]
			CouldNotFetchPacks,
			[Cpp2IlInjected.Token(Token = "0x4000416")]
			NotAllPacksFounds,
			[Cpp2IlInjected.Token(Token = "0x4000417")]
			AutoAwardedPackNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000418")]
			FailedGrantingPack,
			[Cpp2IlInjected.Token(Token = "0x4000419")]
			FailedUpdatingGlobalKey,
			[Cpp2IlInjected.Token(Token = "0x400041A")]
			CouldNotFetchUserKey,
			[Cpp2IlInjected.Token(Token = "0x400041B")]
			CouldNotFetchInventory,
			[Cpp2IlInjected.Token(Token = "0x400041C")]
			CouldNotParseUserKey,
			[Cpp2IlInjected.Token(Token = "0x400041D")]
			CouldNotUpgradeUserKey,
			[Cpp2IlInjected.Token(Token = "0x400041E")]
			InvalidStoreFrontArg,
			[Cpp2IlInjected.Token(Token = "0x400041F")]
			Error
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		public enum RedeemType
		{
			[Cpp2IlInjected.Token(Token = "0x4000421")]
			Undefined,
			[Cpp2IlInjected.Token(Token = "0x4000422")]
			GlobalKeyCachedValue,
			[Cpp2IlInjected.Token(Token = "0x4000423")]
			AutoAwarded,
			[Cpp2IlInjected.Token(Token = "0x4000424")]
			AlreadyInInventory
		}

		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		public class Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000425")]
			public string ActivePack;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000426")]
			public RedeemType RedeemType;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x1C"), Cpp2IlInjected.Token(Token = "0x4000427")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x600025A")]
				[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600025B")]
				[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x1170AE0", Offset = "0x116F4E0", VA = "0x181170AE0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public AutoRedeemFoundersPack()
		{
		}
	}
}
