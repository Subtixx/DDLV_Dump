using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using PlayFab.EconomyModels;

namespace CloudScripts
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class RedeemProductIds
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public class Request
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000428")]
			public List<CatalogAlternateId> InstalledEntitlements = (List<CatalogAlternateId>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000429")]
			public bool ApplyRefund;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x400042A")]
			public bool IsPS5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public string PS4ServiceLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public string PS5ServiceLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public string AuthCode;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public int IssuerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			public string MarketplaceName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			public string AccessToken;

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x392F490", Offset = "0x392DE90", VA = "0x18392F490")]
			public Request()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		public enum Error
		{
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			Success,
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			PartialSuccess,
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			Failed,
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			CouldNotRetrieveInventoryEntitlements,
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			FailedToObtainAuthorizationToken,
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			FailedToGetWebEntitlementsPS4,
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			FailedToGetWebEntitlementsPS5
		}

		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		public enum RedeemStatus
		{
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			Failed,
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			FailedFindingProductId,
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			FailedGrantingItems,
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			AlreadyGranted,
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			Granted
		}

		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public class RedeemProductIdResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public CatalogAlternateId productId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			public RedeemStatus status;

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RedeemProductIdResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		public class RefundResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public (string Id, string OnlineInstanceId) PackPlayfabId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public RefundOnlineInbox.Result RefundPackResult;

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
			public RefundResult()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000C7")]
		public class Result
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public List<DisneyCloudScript.GetPlaystationEntitlements.PlaystationEntitlementInfo> PS4Entitlements = (List<DisneyCloudScript.GetPlaystationEntitlements.PlaystationEntitlementInfo>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public List<DisneyCloudScript.GetPlaystationEntitlements.PlaystationEntitlementInfo> PS5Entitlements = (List<DisneyCloudScript.GetPlaystationEntitlements.PlaystationEntitlementInfo>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public List<RedeemProductIdResult> RedeemResults = (List<RedeemProductIdResult>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public List<RefundResult> RefundResults = (List<RefundResult>)(object)new List<T>();

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public string AccessToken;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000448")]
			public Error Error
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public string ErrorMessage
			{
				[Cpp2IlInjected.Token(Token = "0x6000264")]
				[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
				[CompilerGenerated]
				get
				{
					return _003CErrorMessage_003Ek__BackingField;
				}
				[Cpp2IlInjected.Token(Token = "0x6000265")]
				[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
				[CompilerGenerated]
				set
				{
					_003CErrorMessage_003Ek__BackingField = value;
					/*Error: Unexpected end of block*/;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x392F5E0", Offset = "0x392DFE0", VA = "0x18392F5E0")]
			public Result WithError(Error error)
			{
				Error = error;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x392F680", Offset = "0x392E080", VA = "0x18392F680")]
			public Result WithError(Error error, string message)
			{
				Error = error;
				ErrorMessage = message;
				return this;
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x3930130", Offset = "0x392EB30", VA = "0x183930130")]
			public Result()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public RedeemProductIds()
		{
		}
	}
}
