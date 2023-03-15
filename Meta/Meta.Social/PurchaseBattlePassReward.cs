using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000CBC")]
	public sealed class PurchaseBattlePassReward : IMessage<PurchaseBattlePassReward>, IMessage, IEquatable<PurchaseBattlePassReward>, IDeepCloneable<PurchaseBattlePassReward>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000CBD")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000CBE")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400318B")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x400318C")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x400318D")]
				[OriginalName("InvalidParam")]
				InvalidParam = 2,
				[Cpp2IlInjected.Token(Token = "0x400318E")]
				[OriginalName("SearchConfigError")]
				SearchConfigError = 3,
				[Cpp2IlInjected.Token(Token = "0x400318F")]
				[OriginalName("InvalidStartOrEndDate")]
				InvalidStartOrEndDate = 4,
				[Cpp2IlInjected.Token(Token = "0x4003190")]
				[OriginalName("InvalidConfig")]
				InvalidConfig = 5,
				[Cpp2IlInjected.Token(Token = "0x4003191")]
				[OriginalName("InvalidRewardIndex")]
				InvalidRewardIndex = 6,
				[Cpp2IlInjected.Token(Token = "0x4003192")]
				[OriginalName("EventEnded")]
				EventEnded = 7,
				[Cpp2IlInjected.Token(Token = "0x4003193")]
				[OriginalName("SearchCurrencyError")]
				SearchCurrencyError = 8,
				[Cpp2IlInjected.Token(Token = "0x4003194")]
				[OriginalName("GetInventoryProgressError")]
				GetInventoryProgressError = 9,
				[Cpp2IlInjected.Token(Token = "0x4003195")]
				[OriginalName("ProgressionNotFound")]
				ProgressionNotFound = 10,
				[Cpp2IlInjected.Token(Token = "0x4003196")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency = 11,
				[Cpp2IlInjected.Token(Token = "0x4003197")]
				[OriginalName("PremiumPassInactive")]
				PremiumPassInactive = 12,
				[Cpp2IlInjected.Token(Token = "0x4003198")]
				[OriginalName("AlreadyPurchased")]
				AlreadyPurchased = 13,
				[Cpp2IlInjected.Token(Token = "0x4003199")]
				[OriginalName("TaskRequirementFailed")]
				TaskRequirementFailed = 14,
				[Cpp2IlInjected.Token(Token = "0x400319A")]
				[OriginalName("RewardRequirementFailed")]
				RewardRequirementFailed = 15,
				[Cpp2IlInjected.Token(Token = "0x400319B")]
				[OriginalName("RewardItemNotFound")]
				RewardItemNotFound = 16,
				[Cpp2IlInjected.Token(Token = "0x400319C")]
				[OriginalName("PurchaseRewardFailed")]
				PurchaseRewardFailed = 17,
				[Cpp2IlInjected.Token(Token = "0x400319D")]
				[OriginalName("UnknownError")]
				UnknownError = 20
			}

			[Cpp2IlInjected.Token(Token = "0x2000CBF")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x400319E")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400319F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40031A0")]
				public const int BattlePassOnlineIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40031A1")]
				private string battlePassOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x40031A2")]
				public const int RewardIdxFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40031A3")]
				private int rewardIdx_;

				[Cpp2IlInjected.Token(Token = "0x40031A4")]
				public const int CurrencyOnlineIdFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40031A5")]
				private string currencyOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x40031A6")]
				public const int CurrencyOnlineTypeFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40031A7")]
				private string currencyOnlineType_;

				[Cpp2IlInjected.Token(Token = "0x17001303")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006CC8")]
					[Cpp2IlInjected.Address(RVA = "0x2C12CD0", Offset = "0x2C116D0", VA = "0x182C12CD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001304")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006CC9")]
					[Cpp2IlInjected.Address(RVA = "0x2C12510", Offset = "0x2C10F10", VA = "0x182C12510")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001305")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006CCA")]
					[Cpp2IlInjected.Address(RVA = "0x2C13270", Offset = "0x2C11C70", VA = "0x182C13270", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001306")]
				[DebuggerNonUserCode]
				public string BattlePassOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006CCE")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006CCF")]
					[Cpp2IlInjected.Address(RVA = "0x2C13520", Offset = "0x2C11F20", VA = "0x182C13520")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001307")]
				[DebuggerNonUserCode]
				public int RewardIdx
				{
					[Cpp2IlInjected.Token(Token = "0x6006CD0")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006CD1")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001308")]
				[DebuggerNonUserCode]
				public string CurrencyOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006CD2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006CD3")]
					[Cpp2IlInjected.Address(RVA = "0x2C13670", Offset = "0x2C12070", VA = "0x182C13670")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001309")]
				[DebuggerNonUserCode]
				public string CurrencyOnlineType
				{
					[Cpp2IlInjected.Token(Token = "0x6006CD4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006CD5")]
					[Cpp2IlInjected.Address(RVA = "0x2C13750", Offset = "0x2C12150", VA = "0x182C13750")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006CCB")]
				[Cpp2IlInjected.Address(RVA = "0x2C122A0", Offset = "0x2C10CA0", VA = "0x182C122A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CCC")]
				[Cpp2IlInjected.Address(RVA = "0x2C11CF0", Offset = "0x2C106F0", VA = "0x182C11CF0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CCD")]
				[Cpp2IlInjected.Address(RVA = "0x2C0BF10", Offset = "0x2C0A910", VA = "0x182C0BF10", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006CD6")]
				[Cpp2IlInjected.Address(RVA = "0x2C0CC60", Offset = "0x2C0B660", VA = "0x182C0CC60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006CD7")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7580", Offset = "0x1DF5F80", VA = "0x181DF7580", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006CD8")]
				[Cpp2IlInjected.Address(RVA = "0x1DF82F0", Offset = "0x1DF6CF0", VA = "0x181DF82F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006CD9")]
				[Cpp2IlInjected.Address(RVA = "0x2C0F4C0", Offset = "0x2C0DEC0", VA = "0x182C0F4C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006CDA")]
				[Cpp2IlInjected.Address(RVA = "0x1DFA420", Offset = "0x1DF8E20", VA = "0x181DFA420", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CDB")]
				[Cpp2IlInjected.Address(RVA = "0x2C0B2F0", Offset = "0x2C09CF0", VA = "0x182C0B2F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006CDC")]
				[Cpp2IlInjected.Address(RVA = "0x2C0E460", Offset = "0x2C0CE60", VA = "0x182C0E460", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CDD")]
				[Cpp2IlInjected.Address(RVA = "0x2C0DEF0", Offset = "0x2C0C8F0", VA = "0x182C0DEF0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CDE")]
				[Cpp2IlInjected.Address(RVA = "0x2C0D130", Offset = "0x2C0BB30", VA = "0x182C0D130", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006CDF")]
				[Cpp2IlInjected.Address(RVA = "0x2C0EC70", Offset = "0x2C0D670", VA = "0x182C0EC70", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CE0")]
				[Cpp2IlInjected.Address(RVA = "0x2C0BC70", Offset = "0x2C0A670", VA = "0x182C0BC70", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CC1")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x40031A9")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40031AA")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40031AB")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40031AC")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40031AD")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40031AE")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40031AF")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40031B0")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x40031B1")]
				public const int RewardItemIdFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x40031B2")]
				private int rewardItemId_;

				[Cpp2IlInjected.Token(Token = "0x40031B3")]
				public const int TotalAmountFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40031B4")]
				private int totalAmount_;

				[Cpp2IlInjected.Token(Token = "0x40031B5")]
				public const int ChangedAmountFieldNumber = 6;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x40031B6")]
				private int changedAmount_;

				[Cpp2IlInjected.Token(Token = "0x40031B7")]
				public const int BattlePassCurrencyBalanceFieldNumber = 7;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40031B8")]
				private int battlePassCurrencyBalance_;

				[Cpp2IlInjected.Token(Token = "0x1700130A")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006CE5")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E4B0", Offset = "0x2C1CEB0", VA = "0x182C1E4B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700130B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006CE6")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E1B0", Offset = "0x2C1CBB0", VA = "0x182C1E1B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700130C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006CE7")]
					[Cpp2IlInjected.Address(RVA = "0x2C1EE70", Offset = "0x2C1D870", VA = "0x182C1EE70", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700130D")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006CEB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006CEC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700130E")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006CED")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006CEE")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700130F")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006CEF")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006CF0")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001310")]
				[DebuggerNonUserCode]
				public int RewardItemId
				{
					[Cpp2IlInjected.Token(Token = "0x6006CF1")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006CF2")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001311")]
				[DebuggerNonUserCode]
				public int TotalAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6006CF3")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006CF4")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001312")]
				[DebuggerNonUserCode]
				public int ChangedAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6006CF5")]
					[Cpp2IlInjected.Address(RVA = "0x7FA500", Offset = "0x7F8F00", VA = "0x1807FA500")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006CF6")]
					[Cpp2IlInjected.Address(RVA = "0x7FA710", Offset = "0x7F9110", VA = "0x1807FA710")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001313")]
				[DebuggerNonUserCode]
				public int BattlePassCurrencyBalance
				{
					[Cpp2IlInjected.Token(Token = "0x6006CF7")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006CF8")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001314")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6006D04")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001315")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006D05")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D06")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001316")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006D07")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D08")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006CE8")]
				[Cpp2IlInjected.Address(RVA = "0x2C1D490", Offset = "0x2C1BE90", VA = "0x182C1D490")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CE9")]
				[Cpp2IlInjected.Address(RVA = "0x2C1DDE0", Offset = "0x2C1C7E0", VA = "0x182C1DDE0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CEA")]
				[Cpp2IlInjected.Address(RVA = "0x2C17BA0", Offset = "0x2C165A0", VA = "0x182C17BA0", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006CF9")]
				[Cpp2IlInjected.Address(RVA = "0x2C183A0", Offset = "0x2C16DA0", VA = "0x182C183A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006CFA")]
				[Cpp2IlInjected.Address(RVA = "0x2C18250", Offset = "0x2C16C50", VA = "0x182C18250", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006CFB")]
				[Cpp2IlInjected.Address(RVA = "0x2C19640", Offset = "0x2C18040", VA = "0x182C19640", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006CFC")]
				[Cpp2IlInjected.Address(RVA = "0x2C1BF40", Offset = "0x2C1A940", VA = "0x182C1BF40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006CFD")]
				[Cpp2IlInjected.Address(RVA = "0x2C1C090", Offset = "0x2C1AA90", VA = "0x182C1C090", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CFE")]
				[Cpp2IlInjected.Address(RVA = "0x2C16C70", Offset = "0x2C15670", VA = "0x182C16C70", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006CFF")]
				[Cpp2IlInjected.Address(RVA = "0x2C19860", Offset = "0x2C18260", VA = "0x182C19860", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D00")]
				[Cpp2IlInjected.Address(RVA = "0x2C19CF0", Offset = "0x2C186F0", VA = "0x182C19CF0", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D01")]
				[Cpp2IlInjected.Address(RVA = "0x2C19360", Offset = "0x2C17D60", VA = "0x182C19360", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D02")]
				[Cpp2IlInjected.Address(RVA = "0x2C1B110", Offset = "0x2C19B10", VA = "0x182C1B110", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D03")]
				[Cpp2IlInjected.Address(RVA = "0x2C175B0", Offset = "0x2C15FB0", VA = "0x182C175B0", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D09")]
				[Cpp2IlInjected.Address(RVA = "0x2C189A0", Offset = "0x2C173A0", VA = "0x182C189A0", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__66))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D0A")]
				[Cpp2IlInjected.Address(RVA = "0x2C139E0", Offset = "0x2C123E0", VA = "0x182C139E0", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4003188")]
		private static readonly MessageParser<PurchaseBattlePassReward> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003189")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001300")]
		[DebuggerNonUserCode]
		public static MessageParser<PurchaseBattlePassReward> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006CB6")]
			[Cpp2IlInjected.Address(RVA = "0x148BBA0", Offset = "0x148A5A0", VA = "0x18148BBA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001301")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006CB7")]
			[Cpp2IlInjected.Address(RVA = "0x148BAD0", Offset = "0x148A4D0", VA = "0x18148BAD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001302")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006CB8")]
			[Cpp2IlInjected.Address(RVA = "0x148BC00", Offset = "0x148A600", VA = "0x18148BC00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006CB9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PurchaseBattlePassReward()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006CBA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PurchaseBattlePassReward(PurchaseBattlePassReward other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006CBB")]
		[Cpp2IlInjected.Address(RVA = "0x148B7F0", Offset = "0x148A1F0", VA = "0x18148B7F0", Slot = "10")]
		[DebuggerNonUserCode]
		public PurchaseBattlePassReward Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PurchaseBattlePassReward purchaseBattlePassReward = default(PurchaseBattlePassReward);
			purchaseBattlePassReward.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (purchaseBattlePassReward._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return purchaseBattlePassReward;
		}

		[Cpp2IlInjected.Token(Token = "0x6006CBC")]
		[Cpp2IlInjected.Address(RVA = "0x148B870", Offset = "0x148A270", VA = "0x18148B870", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006CBD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PurchaseBattlePassReward other)
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

		[Cpp2IlInjected.Token(Token = "0x6006CBE")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006CBF")]
		[Cpp2IlInjected.Address(RVA = "0x148B960", Offset = "0x148A360", VA = "0x18148B960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006CC0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006CC1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006CC2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PurchaseBattlePassReward other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006CC3")]
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

		[Cpp2IlInjected.Token(Token = "0x6006CC4")]
		[Cpp2IlInjected.Address(RVA = "0x148B8F0", Offset = "0x148A2F0", VA = "0x18148B8F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006CC5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006CC6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006CC7")]
		[Cpp2IlInjected.Address(RVA = "0x148B9C0", Offset = "0x148A3C0", VA = "0x18148B9C0")]
		static PurchaseBattlePassReward()
		{
			Func<PurchaseBattlePassReward> func = default(Func<PurchaseBattlePassReward>);
			_parser = (MessageParser<PurchaseBattlePassReward>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
