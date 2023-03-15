using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab;
using PlayFab.EconomyModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	public class RedeemEpicEntitlements
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		public class Request
		{
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public static readonly string DefaultSandboxId = "7e2ec8a47b8d41528eb6dd2efd2b1abc";

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public string SandboxId
			{
				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
				[CompilerGenerated]
				get
				{
					return _003CSandboxId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002C9")]
				[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
				[CompilerGenerated]
				set
				{
					_003CSandboxId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = DefaultSandboxId;


			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public string AccountId
			{
				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
				[CompilerGenerated]
				get
				{
					return _003CAccountId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
				[CompilerGenerated]
				set
				{
					_003CAccountId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			public string ClientId
			{
				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
				[CompilerGenerated]
				get
				{
					return _003CClientId_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
				[CompilerGenerated]
				set
				{
					_003CClientId_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			public string AccessToken
			{
				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CAccessToken_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002CF")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CAccessToken_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x392F410", Offset = "0x392DE10", VA = "0x18392F410")]
			public Request()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x392F350", Offset = "0x392DD50", VA = "0x18392F350")]
			static Request()
			{
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			GetTitleDataError,
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			VerifyTokenError,
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			GetEntitlementsError,
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			UpdateTitleDataError,
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			FailedToRetrieveBundles,
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			BundlesNotFound,
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			UnknownError
		}

		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		public enum RedeemStatus
		{
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			Pending,
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			AlreadyRedeemByOldPurchaseFlow,
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			AlreadyRedeemByTitleData,
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			BundleNotFound,
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			GrantFailed
		}

		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		public class EventExtraData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			public string GrantedBundleId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			public GrantInventoryItemsResult GrantInventoryItemsResult;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B9")]
			public AddVirtualCurrenciesResult AddVirtualCurrenciesResult;

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public EventExtraData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		public class RedeemedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004BA")]
			public RedeemStatus Status;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004BB")]
			public string entitlementId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004BC")]
			public string catalogId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			public string grantDate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			public string redeemDate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			public bool ReceiptEventFailed;

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			public bool NeedsRedeeming
			{
				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0xE606E0", Offset = "0xE5F0E0", VA = "0x180E606E0")]
				get
				{
					return Status == RedeemStatus.Pending;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			public bool IsSuccess
			{
				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x392F340", Offset = "0x392DD40", VA = "0x18392F340")]
				get
				{
					RedeemStatus status = Status;
					if (status == RedeemStatus.Success)
					{
					}
					return status == RedeemStatus.AlreadyRedeemByTitleData;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x763FC0", Offset = "0x7629C0", VA = "0x180763FC0")]
			public RedeemedData WithStatus(RedeemStatus status)
			{
				Status = status;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x392F2C0", Offset = "0x392DCC0", VA = "0x18392F2C0")]
			public RedeemedData WithSuccess()
			{
				//IL_0009: Expected I4, but got I8
				Status = RedeemStatus.Success;
				int num = 0;
				DateTime utcNow = DateTime.UtcNow;
				string text = default(string);
				redeemDate = text;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RedeemedData()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		public class Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public RedeemMarketplaceAssetsResult PlayfabRedeemResult = new RedeemMarketplaceAssetsResult
			{
				Failed = (List<RedeemFailureLegacy>)(object)new List<T>(),
				Succeeded = (List<RedeemSuccessLegacy>)(object)new List<T>()
			};

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public List<RedeemedData> RedeemedData = (List<RedeemedData>)(object)new List<T>();

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x20"), Cpp2IlInjected.Token(Token = "0x40004C2")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			public List<string> RedeemedToEOSEntitlements
			{
				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
				[CompilerGenerated]
				get
				{
					return _003CRedeemedToEOSEntitlements_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x52CA00", Offset = "0x52B400", VA = "0x18052CA00")]
				[CompilerGenerated]
				set
				{
					_003CRedeemedToEOSEntitlements_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			} = (List<string>)(object)new List<T>();


			[Cpp2IlInjected.Token(Token = "0x17000067")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x30"), Cpp2IlInjected.Token(Token = "0x40004C4")]
			public bool IsRedeemedToEOSSuccess
			{
				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x724940", Offset = "0x723340", VA = "0x180724940")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x7252C0", Offset = "0x723CC0", VA = "0x1807252C0")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x34"), Cpp2IlInjected.Token(Token = "0x40004C5")]
			public PlayFabErrorCode PlayFabErrorCode
			{
				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
				get;
				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			public VerifyEpicTokenError VerifyTokenError
			{
				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
				[CompilerGenerated]
				get
				{
					return _003CVerifyTokenError_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
				[CompilerGenerated]
				set
				{
					_003CVerifyTokenError_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x392F670", Offset = "0x392E070", VA = "0x18392F670")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x392FA20", Offset = "0x392E420", VA = "0x18392FA20")]
			public Result WithPlayFabError(Error error, PlayFabErrorCode playfabError)
			{
				Error = error;
				PlayFabErrorCode = playfabError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x392F5A0", Offset = "0x392DFA0", VA = "0x18392F5A0")]
			public Result WithEpicHttpError(Error error, VerifyEpicTokenError verifyError)
			{
				Error = error;
				VerifyTokenError = verifyError;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x392FF80", Offset = "0x392E980", VA = "0x18392FF80")]
			public Result()
			{
			}//Discarded unreachable code: IL_004a

		}

		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public static string UserTitleDataRedeemedDataKey = "EpicRedeemedEntitlements";

		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public static DateTime OldRedeemFakeRedeemTime = (DateTime)0;

		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public static DateTime NotRedeemed = DateTime.MinValue;

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RedeemEpicEntitlements()
		{
		}
	}
}
