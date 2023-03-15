using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	public class ClaimPromoCode
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public string PromoCodeId
			{
				[Cpp2IlInjected.Token(Token = "0x6000369")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CPromoCodeId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600036A")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CPromoCodeId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000117")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000535")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000536")]
			ItemNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000537")]
			NotFound,
			[Cpp2IlInjected.Token(Token = "0x4000538")]
			InvalidConfig,
			[Cpp2IlInjected.Token(Token = "0x4000539")]
			NotStarted,
			[Cpp2IlInjected.Token(Token = "0x400053A")]
			Expired,
			[Cpp2IlInjected.Token(Token = "0x400053B")]
			FriendlyNameNotFound,
			[Cpp2IlInjected.Token(Token = "0x400053C")]
			PlayerAlreadyClaimed,
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			UnknownError,
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			FailedUpdatePlayerStatistic,
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			FailedGetTitleStatistic,
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			FailedUpdateTitleStatistic,
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			FailedGrantKey,
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			AllClaimed
		}

		[Cpp2IlInjected.Token(Token = "0x2000118")]
		public class Result
		{
			[Cpp2IlInjected.Token(Token = "0x17000097")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000543")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x600036C")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600036D")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000544")]
			public PlayFabErrorCode PlayFabErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x600036E")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600036F")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x1170AF0", Offset = "0x116F4F0", VA = "0x181170AF0")]
			public Result WithPlayFabError(Error error, PlayFabErrorCode playfabError)
			{
				Error = error;
				PlayFabErrorCode = playfabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ClaimPromoCode()
		{
		}
	}
}
