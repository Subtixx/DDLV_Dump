using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000CA8")]
	public sealed class StorePurchase : IMessage<StorePurchase>, IMessage, IEquatable<StorePurchase>, IDeepCloneable<StorePurchase>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000CA9")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000CAA")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4003113")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4003114")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4003115")]
				[OriginalName("InvalidCloudScriptResult")]
				InvalidCloudScriptResult = 2,
				[Cpp2IlInjected.Token(Token = "0x4003116")]
				[OriginalName("StoreConfigNotFound")]
				StoreConfigNotFound = 3,
				[Cpp2IlInjected.Token(Token = "0x4003117")]
				[OriginalName("StoreExpired")]
				StoreExpired = 4,
				[Cpp2IlInjected.Token(Token = "0x4003118")]
				[OriginalName("ContentConfigNotFound")]
				ContentConfigNotFound = 5,
				[Cpp2IlInjected.Token(Token = "0x4003119")]
				[OriginalName("BundleConfigNotFound")]
				BundleConfigNotFound = 6,
				[Cpp2IlInjected.Token(Token = "0x400311A")]
				[OriginalName("VersionMismatch")]
				VersionMismatch = 7,
				[Cpp2IlInjected.Token(Token = "0x400311B")]
				[OriginalName("BundleExpired")]
				BundleExpired = 8,
				[Cpp2IlInjected.Token(Token = "0x400311C")]
				[OriginalName("SaleNotStarted")]
				SaleNotStarted = 9,
				[Cpp2IlInjected.Token(Token = "0x400311D")]
				[OriginalName("SaleExpired")]
				SaleExpired = 10,
				[Cpp2IlInjected.Token(Token = "0x400311E")]
				[OriginalName("PriceMismatch")]
				PriceMismatch = 11,
				[Cpp2IlInjected.Token(Token = "0x400311F")]
				[OriginalName("SearchCurrencyError")]
				SearchCurrencyError = 12,
				[Cpp2IlInjected.Token(Token = "0x4003120")]
				[OriginalName("InvalidRewardGameId")]
				InvalidRewardGameId = 13,
				[Cpp2IlInjected.Token(Token = "0x4003121")]
				[OriginalName("RewardCountMismatch")]
				RewardCountMismatch = 14,
				[Cpp2IlInjected.Token(Token = "0x4003122")]
				[OriginalName("GetInventoryError")]
				GetInventoryError = 15,
				[Cpp2IlInjected.Token(Token = "0x4003123")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency = 16,
				[Cpp2IlInjected.Token(Token = "0x4003124")]
				[OriginalName("PriceItemNotFound")]
				PriceItemNotFound = 17,
				[Cpp2IlInjected.Token(Token = "0x4003125")]
				[OriginalName("RewardNotFound")]
				RewardNotFound = 18,
				[Cpp2IlInjected.Token(Token = "0x4003126")]
				[OriginalName("AlreadyPurchased")]
				AlreadyPurchased = 19,
				[Cpp2IlInjected.Token(Token = "0x4003127")]
				[OriginalName("PurchaseTransactionFailed")]
				PurchaseTransactionFailed = 20,
				[Cpp2IlInjected.Token(Token = "0x4003128")]
				[OriginalName("UnknownError")]
				UnknownError = 30
			}

			[Cpp2IlInjected.Token(Token = "0x2000CAB")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4003129")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400312A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400312B")]
				public const int StoreIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400312C")]
				private string storeId_;

				[Cpp2IlInjected.Token(Token = "0x400312D")]
				public const int ContentIdFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400312E")]
				private string contentId_;

				[Cpp2IlInjected.Token(Token = "0x400312F")]
				public const int PriceAmountFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003130")]
				private int priceAmount_;

				[Cpp2IlInjected.Token(Token = "0x4003131")]
				public const int CurrencyIdFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4003132")]
				private int currencyId_;

				[Cpp2IlInjected.Token(Token = "0x4003133")]
				public const int ContentVersionFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4003134")]
				private int contentVersion_;

				[Cpp2IlInjected.Token(Token = "0x170012D8")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006C09")]
					[Cpp2IlInjected.Address(RVA = "0x25FB850", Offset = "0x25FA250", VA = "0x1825FB850")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012D9")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006C0A")]
					[Cpp2IlInjected.Address(RVA = "0x25FB5F0", Offset = "0x25F9FF0", VA = "0x1825FB5F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012DA")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006C0B")]
					[Cpp2IlInjected.Address(RVA = "0x25FC390", Offset = "0x25FAD90", VA = "0x1825FC390", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012DB")]
				[DebuggerNonUserCode]
				public string StoreId
				{
					[Cpp2IlInjected.Token(Token = "0x6006C0F")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C10")]
					[Cpp2IlInjected.Address(RVA = "0x25FC6F0", Offset = "0x25FB0F0", VA = "0x1825FC6F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012DC")]
				[DebuggerNonUserCode]
				public string ContentId
				{
					[Cpp2IlInjected.Token(Token = "0x6006C11")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C12")]
					[Cpp2IlInjected.Address(RVA = "0x25FC4C0", Offset = "0x25FAEC0", VA = "0x1825FC4C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012DD")]
				[DebuggerNonUserCode]
				public int PriceAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6006C13")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C14")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012DE")]
				[DebuggerNonUserCode]
				public int CurrencyId
				{
					[Cpp2IlInjected.Token(Token = "0x6006C15")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C16")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012DF")]
				[DebuggerNonUserCode]
				public int ContentVersion
				{
					[Cpp2IlInjected.Token(Token = "0x6006C17")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C18")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006C0C")]
				[Cpp2IlInjected.Address(RVA = "0x25FABC0", Offset = "0x25F95C0", VA = "0x1825FABC0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C0D")]
				[Cpp2IlInjected.Address(RVA = "0x25FA990", Offset = "0x25F9390", VA = "0x1825FA990")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C0E")]
				[Cpp2IlInjected.Address(RVA = "0x25F4EE0", Offset = "0x25F38E0", VA = "0x1825F4EE0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C19")]
				[Cpp2IlInjected.Address(RVA = "0x25F5770", Offset = "0x25F4170", VA = "0x1825F5770", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C1A")]
				[Cpp2IlInjected.Address(RVA = "0x25F59A0", Offset = "0x25F43A0", VA = "0x1825F59A0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C1B")]
				[Cpp2IlInjected.Address(RVA = "0x25F6B70", Offset = "0x25F5570", VA = "0x1825F6B70", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C1C")]
				[Cpp2IlInjected.Address(RVA = "0x25F8620", Offset = "0x25F7020", VA = "0x1825F8620", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C1D")]
				[Cpp2IlInjected.Address(RVA = "0x25F97E0", Offset = "0x25F81E0", VA = "0x1825F97E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C1E")]
				[Cpp2IlInjected.Address(RVA = "0x25F4570", Offset = "0x25F2F70", VA = "0x1825F4570", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C1F")]
				[Cpp2IlInjected.Address(RVA = "0x25F7420", Offset = "0x25F5E20", VA = "0x1825F7420", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C20")]
				[Cpp2IlInjected.Address(RVA = "0x25F72B0", Offset = "0x25F5CB0", VA = "0x1825F72B0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C21")]
				[Cpp2IlInjected.Address(RVA = "0x25F6270", Offset = "0x25F4C70", VA = "0x1825F6270", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C22")]
				[Cpp2IlInjected.Address(RVA = "0x25F7EA0", Offset = "0x25F68A0", VA = "0x1825F7EA0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C23")]
				[Cpp2IlInjected.Address(RVA = "0x25F4880", Offset = "0x25F3280", VA = "0x1825F4880", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CAD")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4003136")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003137")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003138")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003139")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400313A")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400313B")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x400313C")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400313D")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x400313E")]
				public const int RewardsFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400313F")]
				private MultiItemInstance rewards_;

				[Cpp2IlInjected.Token(Token = "0x4003140")]
				public const int SpendResultDataFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4003141")]
				private SpendOnlineCurrency.Types.ReturnedData spendResultData_;

				[Cpp2IlInjected.Token(Token = "0x170012E0")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006C28")]
					[Cpp2IlInjected.Address(RVA = "0x26064A0", Offset = "0x2604EA0", VA = "0x1826064A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E1")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006C29")]
					[Cpp2IlInjected.Address(RVA = "0x2606040", Offset = "0x2604A40", VA = "0x182606040")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E2")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006C2A")]
					[Cpp2IlInjected.Address(RVA = "0x2606740", Offset = "0x2605140", VA = "0x182606740", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E3")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006C2E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C2F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E4")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006C30")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C31")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E5")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006C32")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C33")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E6")]
				[DebuggerNonUserCode]
				public MultiItemInstance Rewards
				{
					[Cpp2IlInjected.Token(Token = "0x6006C34")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C35")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E7")]
				[DebuggerNonUserCode]
				public SpendOnlineCurrency.Types.ReturnedData SpendResultData
				{
					[Cpp2IlInjected.Token(Token = "0x6006C36")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C37")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E8")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6006C43")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012E9")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006C44")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C45")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012EA")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006C46")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C47")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006C2B")]
				[Cpp2IlInjected.Address(RVA = "0x2605B90", Offset = "0x2604590", VA = "0x182605B90")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C2C")]
				[Cpp2IlInjected.Address(RVA = "0x2605210", Offset = "0x2603C10", VA = "0x182605210")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C2D")]
				[Cpp2IlInjected.Address(RVA = "0x25FF4C0", Offset = "0x25FDEC0", VA = "0x1825FF4C0", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C38")]
				[Cpp2IlInjected.Address(RVA = "0x25FFE60", Offset = "0x25FE860", VA = "0x1825FFE60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C39")]
				[Cpp2IlInjected.Address(RVA = "0x26004F0", Offset = "0x25FEEF0", VA = "0x1826004F0", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C3A")]
				[Cpp2IlInjected.Address(RVA = "0x2601400", Offset = "0x25FFE00", VA = "0x182601400", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C3B")]
				[Cpp2IlInjected.Address(RVA = "0x2603C50", Offset = "0x2602650", VA = "0x182603C50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C3C")]
				[Cpp2IlInjected.Address(RVA = "0x2603D70", Offset = "0x2602770", VA = "0x182603D70", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C3D")]
				[Cpp2IlInjected.Address(RVA = "0x25FE8B0", Offset = "0x25FD2B0", VA = "0x1825FE8B0", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C3E")]
				[Cpp2IlInjected.Address(RVA = "0x2601C80", Offset = "0x2600680", VA = "0x182601C80", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C3F")]
				[Cpp2IlInjected.Address(RVA = "0x26020D0", Offset = "0x2600AD0", VA = "0x1826020D0", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C40")]
				[Cpp2IlInjected.Address(RVA = "0x2600AE0", Offset = "0x25FF4E0", VA = "0x182600AE0", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C41")]
				[Cpp2IlInjected.Address(RVA = "0x2602F50", Offset = "0x2601950", VA = "0x182602F50", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C42")]
				[Cpp2IlInjected.Address(RVA = "0x25FEDC0", Offset = "0x25FD7C0", VA = "0x1825FEDC0", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C48")]
				[Cpp2IlInjected.Address(RVA = "0x2600710", Offset = "0x25FF110", VA = "0x182600710", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__56))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C49")]
				[Cpp2IlInjected.Address(RVA = "0x25FD3F0", Offset = "0x25FBDF0", VA = "0x1825FD3F0", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4003110")]
		private static readonly MessageParser<StorePurchase> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003111")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170012D5")]
		[DebuggerNonUserCode]
		public static MessageParser<StorePurchase> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006BF7")]
			[Cpp2IlInjected.Address(RVA = "0xC10F60", Offset = "0xC0F960", VA = "0x180C10F60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012D6")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006BF8")]
			[Cpp2IlInjected.Address(RVA = "0xC10E90", Offset = "0xC0F890", VA = "0x180C10E90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012D7")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006BF9")]
			[Cpp2IlInjected.Address(RVA = "0xC10FC0", Offset = "0xC0F9C0", VA = "0x180C10FC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006BFA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StorePurchase()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006BFB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public StorePurchase(StorePurchase other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006BFC")]
		[Cpp2IlInjected.Address(RVA = "0xC10BB0", Offset = "0xC0F5B0", VA = "0x180C10BB0", Slot = "10")]
		[DebuggerNonUserCode]
		public StorePurchase Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			StorePurchase storePurchase = default(StorePurchase);
			storePurchase.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (storePurchase._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return storePurchase;
		}

		[Cpp2IlInjected.Token(Token = "0x6006BFD")]
		[Cpp2IlInjected.Address(RVA = "0xC10C30", Offset = "0xC0F630", VA = "0x180C10C30", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other != this)
				{
					return object.Equals(_unknownFields, other);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006BFE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StorePurchase other)
		{
			if (other != null)
			{
				if (other != this)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006BFF")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006C00")]
		[Cpp2IlInjected.Address(RVA = "0xC10D20", Offset = "0xC0F720", VA = "0x180C10D20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006C01")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006C02")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006C03")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StorePurchase other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006C04")]
		[Cpp2IlInjected.Address(RVA = "0x5C0810", Offset = "0x5BF210", VA = "0x1805C0810", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_001f
			if (input.ReadTag() != 0)
			{
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006C05")]
		[Cpp2IlInjected.Address(RVA = "0xC10CB0", Offset = "0xC0F6B0", VA = "0x180C10CB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006C06")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006C07")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006C08")]
		[Cpp2IlInjected.Address(RVA = "0xC10D80", Offset = "0xC0F780", VA = "0x180C10D80")]
		static StorePurchase()
		{
			Func<StorePurchase> func = default(Func<StorePurchase>);
			_parser = (MessageParser<StorePurchase>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
