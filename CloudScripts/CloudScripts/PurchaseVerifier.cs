using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	public class PurchaseVerifier
	{
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			public string MarketplaceName
			{
				[Cpp2IlInjected.Token(Token = "0x600044B")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CMarketplaceName_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600044C")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CMarketplaceName_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D1")]
			public string UserId
			{
				[Cpp2IlInjected.Token(Token = "0x600044D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CUserId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600044E")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CUserId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D2")]
			public string UserAuthToken
			{
				[Cpp2IlInjected.Token(Token = "0x600044F")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CUserAuthToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000450")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CUserAuthToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D3")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x28"), Cpp2IlInjected.Token(Token = "0x400062D")]
			public int IssuerId
			{
				[Cpp2IlInjected.Token(Token = "0x6000451")]
				[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000452")]
				[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000150")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000630")]
			GetObjectsFailed,
			[Cpp2IlInjected.Token(Token = "0x4000631")]
			GetObjectsDeserializeFailed
		}

		[Cpp2IlInjected.Token(Token = "0x2000151")]
		public enum Status
		{
			[Cpp2IlInjected.Token(Token = "0x4000633")]
			Unknown,
			[Cpp2IlInjected.Token(Token = "0x4000634")]
			KeyNotFound,
			[Cpp2IlInjected.Token(Token = "0x4000635")]
			VerifyTurnedOff,
			[Cpp2IlInjected.Token(Token = "0x4000636")]
			MarketPlaceToVerifyEmpty
		}

		[Cpp2IlInjected.Token(Token = "0x2000152")]
		public class Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000639")]
			public PurchaseVerifierData Data;

			[Cpp2IlInjected.Token(Token = "0x170000D4")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x4000637")]
			public Status Status
			{
				[Cpp2IlInjected.Token(Token = "0x6000454")]
				[Cpp2IlInjected.Address(RVA = "0x5B5670", Offset = "0x5B4070", VA = "0x1805B5670")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000455")]
				[Cpp2IlInjected.Address(RVA = "0x6E0790", Offset = "0x6DF190", VA = "0x1806E0790")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000D5")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x14"), Cpp2IlInjected.Token(Token = "0x4000638")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000456")]
				[Cpp2IlInjected.Address(RVA = "0x6EF6A0", Offset = "0x6EE0A0", VA = "0x1806EF6A0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000457")]
				[Cpp2IlInjected.Address(RVA = "0x6EF740", Offset = "0x6EE140", VA = "0x1806EF740")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x392F6C0", Offset = "0x392E0C0", VA = "0x18392F6C0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public Result WithStatus(Status status)
			{
				Status = status;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000153")]
		public class PurchaseVerifierData
		{
			[Cpp2IlInjected.Token(Token = "0x2000154")]
			public enum VerifyStatus
			{
				[Cpp2IlInjected.Token(Token = "0x400063F")]
				NotImpl
			}

			[Cpp2IlInjected.Token(Token = "0x2000155")]
			public class VerifyResult
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000640")]
				public DateTime VerifiedTime;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000641")]
				public VerifyStatus Status;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000642")]
				public string GrantedItem;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000643")]
				public string GrantedInstance;

				[Cpp2IlInjected.Token(Token = "0x6000461")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				public VerifyResult()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400063A")]
			public static readonly string PlayfabObjectKey = "CustomerCareVerifyPurchase";

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400063D")]
			public List<VerifyResult> results = (List<VerifyResult>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x170000D6")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x400063B")]
			public bool VerifyOnNextLogin
			{
				[Cpp2IlInjected.Token(Token = "0x600045B")]
				[Cpp2IlInjected.Address(RVA = "0x5706E0", Offset = "0x56F0E0", VA = "0x1805706E0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600045C")]
				[Cpp2IlInjected.Address(RVA = "0x570710", Offset = "0x56F110", VA = "0x180570710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000D7")]
			public string MarketPlaceToVerify
			{
				[Cpp2IlInjected.Token(Token = "0x600045D")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CMarketPlaceToVerify_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x600045E")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CMarketPlaceToVerify_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x392F240", Offset = "0x392DC40", VA = "0x18392F240")]
			public PurchaseVerifierData()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0x392F1F0", Offset = "0x392DBF0", VA = "0x18392F1F0")]
			static PurchaseVerifierData()
			{
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public PurchaseVerifier()
		{
		}
	}
}
