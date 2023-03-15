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
	[Cpp2IlInjected.Token(Token = "0x2000CCE")]
	public sealed class PurchaseBattlePassCurrency : IMessage<PurchaseBattlePassCurrency>, IMessage, IEquatable<PurchaseBattlePassCurrency>, IDeepCloneable<PurchaseBattlePassCurrency>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000CCF")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000CD0")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40031F1")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x40031F2")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x40031F3")]
				[OriginalName("SearchConfigError")]
				SearchConfigError = 2,
				[Cpp2IlInjected.Token(Token = "0x40031F4")]
				[OriginalName("InvalidStartOrEndDate")]
				InvalidStartOrEndDate = 3,
				[Cpp2IlInjected.Token(Token = "0x40031F5")]
				[OriginalName("InvalidConfig")]
				InvalidConfig = 4,
				[Cpp2IlInjected.Token(Token = "0x40031F6")]
				[OriginalName("EventEnded")]
				EventEnded = 5,
				[Cpp2IlInjected.Token(Token = "0x40031F7")]
				[OriginalName("SearchCurrencyError")]
				SearchCurrencyError = 6,
				[Cpp2IlInjected.Token(Token = "0x40031F8")]
				[OriginalName("PriceItemNotFound")]
				PriceItemNotFound = 7,
				[Cpp2IlInjected.Token(Token = "0x40031F9")]
				[OriginalName("GetInventoryProgressError")]
				GetInventoryProgressError = 8,
				[Cpp2IlInjected.Token(Token = "0x40031FA")]
				[OriginalName("PremiumPassInactive")]
				PremiumPassInactive = 9,
				[Cpp2IlInjected.Token(Token = "0x40031FB")]
				[OriginalName("BundleAlreadyPurchased")]
				BundleAlreadyPurchased = 10,
				[Cpp2IlInjected.Token(Token = "0x40031FC")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency = 11,
				[Cpp2IlInjected.Token(Token = "0x40031FD")]
				[OriginalName("PurchaseCurrencyFailed")]
				PurchaseCurrencyFailed = 12,
				[Cpp2IlInjected.Token(Token = "0x40031FE")]
				[OriginalName("UnknownError")]
				UnknownError = 20
			}

			[Cpp2IlInjected.Token(Token = "0x2000CD1")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x40031FF")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003200")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003201")]
				public const int BattlePassOnlineIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003202")]
				private string battlePassOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x4003203")]
				public const int CurrencyOnlineIdFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003204")]
				private string currencyOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x4003205")]
				public const int CurrencyOnlineTypeFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003206")]
				private string currencyOnlineType_;

				[Cpp2IlInjected.Token(Token = "0x4003207")]
				public const int AmountToBuyFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4003208")]
				private int amountToBuy_;

				[Cpp2IlInjected.Token(Token = "0x4003209")]
				public const int UseBundlePromoFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
				[Cpp2IlInjected.Token(Token = "0x400320A")]
				private bool useBundlePromo_;

				[Cpp2IlInjected.Token(Token = "0x1700132F")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006D80")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4340", Offset = "0x1DC2D40", VA = "0x181DC4340")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001330")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006D81")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4050", Offset = "0x1DC2A50", VA = "0x181DC4050")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001331")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006D82")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4890", Offset = "0x1DC3290", VA = "0x181DC4890", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001332")]
				[DebuggerNonUserCode]
				public string BattlePassOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006D86")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006D87")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4B90", Offset = "0x1DC3590", VA = "0x181DC4B90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001333")]
				[DebuggerNonUserCode]
				public string CurrencyOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006D88")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006D89")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4C00", Offset = "0x1DC3600", VA = "0x181DC4C00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001334")]
				[DebuggerNonUserCode]
				public string CurrencyOnlineType
				{
					[Cpp2IlInjected.Token(Token = "0x6006D8A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006D8B")]
					[Cpp2IlInjected.Address(RVA = "0x1DC4C70", Offset = "0x1DC3670", VA = "0x181DC4C70")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001335")]
				[DebuggerNonUserCode]
				public int AmountToBuy
				{
					[Cpp2IlInjected.Token(Token = "0x6006D8C")]
					[Cpp2IlInjected.Address(RVA = "0x6ECC40", Offset = "0x6EB640", VA = "0x1806ECC40")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D8D")]
					[Cpp2IlInjected.Address(RVA = "0x6ED730", Offset = "0x6EC130", VA = "0x1806ED730")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001336")]
				[DebuggerNonUserCode]
				public bool UseBundlePromo
				{
					[Cpp2IlInjected.Token(Token = "0x6006D8E")]
					[Cpp2IlInjected.Address(RVA = "0xCCE8B0", Offset = "0xCCD2B0", VA = "0x180CCE8B0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D8F")]
					[Cpp2IlInjected.Address(RVA = "0xCCE8C0", Offset = "0xCCD2C0", VA = "0x180CCE8C0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006D83")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3CC0", Offset = "0x1DC26C0", VA = "0x181DC3CC0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D84")]
				[Cpp2IlInjected.Address(RVA = "0x1DC3A50", Offset = "0x1DC2450", VA = "0x181DC3A50")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D85")]
				[Cpp2IlInjected.Address(RVA = "0x1DBFDC0", Offset = "0x1DBE7C0", VA = "0x181DBFDC0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D90")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0350", Offset = "0x1DBED50", VA = "0x181DC0350", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D91")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0210", Offset = "0x1DBEC10", VA = "0x181DC0210", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D92")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0EC0", Offset = "0x1DBF8C0", VA = "0x181DC0EC0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D93")]
				[Cpp2IlInjected.Address(RVA = "0x1DC23F0", Offset = "0x1DC0DF0", VA = "0x181DC23F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D94")]
				[Cpp2IlInjected.Address(RVA = "0x1DC31B0", Offset = "0x1DC1BB0", VA = "0x181DC31B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D95")]
				[Cpp2IlInjected.Address(RVA = "0x1DBF1C0", Offset = "0x1DBDBC0", VA = "0x181DBF1C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D96")]
				[Cpp2IlInjected.Address(RVA = "0x1DC17F0", Offset = "0x1DC01F0", VA = "0x181DC17F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D97")]
				[Cpp2IlInjected.Address(RVA = "0x1DC1410", Offset = "0x1DBFE10", VA = "0x181DC1410", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D98")]
				[Cpp2IlInjected.Address(RVA = "0x1DC0740", Offset = "0x1DBF140", VA = "0x181DC0740", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D99")]
				[Cpp2IlInjected.Address(RVA = "0x1DC1E10", Offset = "0x1DC0810", VA = "0x181DC1E10", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D9A")]
				[Cpp2IlInjected.Address(RVA = "0x1DBF820", Offset = "0x1DBE220", VA = "0x181DBF820", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CD3")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x400320C")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400320D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400320E")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400320F")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4003210")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003211")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4003212")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003213")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4003214")]
				public const int SpendResultDataFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4003215")]
				private SpendOnlineCurrency.Types.ReturnedData spendResultData_;

				[Cpp2IlInjected.Token(Token = "0x4003216")]
				public const int CurrencyBalanceFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4003217")]
				private int currencyBalance_;

				[Cpp2IlInjected.Token(Token = "0x17001337")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006D9F")]
					[Cpp2IlInjected.Address(RVA = "0x1DCF030", Offset = "0x1DCDA30", VA = "0x181DCF030")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001338")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006DA0")]
					[Cpp2IlInjected.Address(RVA = "0x1DCECF0", Offset = "0x1DCD6F0", VA = "0x181DCECF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001339")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006DA1")]
					[Cpp2IlInjected.Address(RVA = "0x1DCF1B0", Offset = "0x1DCDBB0", VA = "0x181DCF1B0", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700133A")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006DA5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006DA6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700133B")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006DA7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006DA8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700133C")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006DA9")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006DAA")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700133D")]
				[DebuggerNonUserCode]
				public SpendOnlineCurrency.Types.ReturnedData SpendResultData
				{
					[Cpp2IlInjected.Token(Token = "0x6006DAB")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006DAC")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700133E")]
				[DebuggerNonUserCode]
				public int CurrencyBalance
				{
					[Cpp2IlInjected.Token(Token = "0x6006DAD")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006DAE")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700133F")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6006DBA")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001340")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006DBB")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006DBC")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001341")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006DBD")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006DBE")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006DA2")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE5F0", Offset = "0x1DCCFF0", VA = "0x181DCE5F0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006DA3")]
				[Cpp2IlInjected.Address(RVA = "0x1DCE800", Offset = "0x1DCD200", VA = "0x181DCE800")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006DA4")]
				[Cpp2IlInjected.Address(RVA = "0x1DC8BD0", Offset = "0x1DC75D0", VA = "0x181DC8BD0", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006DAF")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9180", Offset = "0x1DC7B80", VA = "0x181DC9180", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB0")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9310", Offset = "0x1DC7D10", VA = "0x181DC9310", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB1")]
				[Cpp2IlInjected.Address(RVA = "0x1DCA540", Offset = "0x1DC8F40", VA = "0x181DCA540", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB2")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCCC0", Offset = "0x1DCB6C0", VA = "0x181DCCCC0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB3")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCF50", Offset = "0x1DCB950", VA = "0x181DCCF50", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB4")]
				[Cpp2IlInjected.Address(RVA = "0x1DC8430", Offset = "0x1DC6E30", VA = "0x181DC8430", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB5")]
				[Cpp2IlInjected.Address(RVA = "0x1DCA8C0", Offset = "0x1DC92C0", VA = "0x181DCA8C0", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB6")]
				[Cpp2IlInjected.Address(RVA = "0x1DCAF50", Offset = "0x1DC9950", VA = "0x181DCAF50", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB7")]
				[Cpp2IlInjected.Address(RVA = "0x1DCA140", Offset = "0x1DC8B40", VA = "0x181DCA140", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB8")]
				[Cpp2IlInjected.Address(RVA = "0x1DCC9E0", Offset = "0x1DCB3E0", VA = "0x181DCC9E0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006DB9")]
				[Cpp2IlInjected.Address(RVA = "0x1DC85A0", Offset = "0x1DC6FA0", VA = "0x181DC85A0", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006DBF")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9AE0", Offset = "0x1DC84E0", VA = "0x181DC9AE0", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__56))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006DC0")]
				[Cpp2IlInjected.Address(RVA = "0x1DC4E20", Offset = "0x1DC3820", VA = "0x181DC4E20", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40031EE")]
		private static readonly MessageParser<PurchaseBattlePassCurrency> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40031EF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700132C")]
		[DebuggerNonUserCode]
		public static MessageParser<PurchaseBattlePassCurrency> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006D6E")]
			[Cpp2IlInjected.Address(RVA = "0x148B680", Offset = "0x148A080", VA = "0x18148B680")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700132D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006D6F")]
			[Cpp2IlInjected.Address(RVA = "0x148B5B0", Offset = "0x1489FB0", VA = "0x18148B5B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700132E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006D70")]
			[Cpp2IlInjected.Address(RVA = "0x148B6E0", Offset = "0x148A0E0", VA = "0x18148B6E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006D71")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PurchaseBattlePassCurrency()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006D72")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PurchaseBattlePassCurrency(PurchaseBattlePassCurrency other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006D73")]
		[Cpp2IlInjected.Address(RVA = "0x148B2D0", Offset = "0x1489CD0", VA = "0x18148B2D0", Slot = "10")]
		[DebuggerNonUserCode]
		public PurchaseBattlePassCurrency Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PurchaseBattlePassCurrency purchaseBattlePassCurrency = default(PurchaseBattlePassCurrency);
			purchaseBattlePassCurrency.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (purchaseBattlePassCurrency._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return purchaseBattlePassCurrency;
		}

		[Cpp2IlInjected.Token(Token = "0x6006D74")]
		[Cpp2IlInjected.Address(RVA = "0x148B350", Offset = "0x1489D50", VA = "0x18148B350", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006D75")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PurchaseBattlePassCurrency other)
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

		[Cpp2IlInjected.Token(Token = "0x6006D76")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006D77")]
		[Cpp2IlInjected.Address(RVA = "0x148B440", Offset = "0x1489E40", VA = "0x18148B440", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006D78")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006D79")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006D7A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PurchaseBattlePassCurrency other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006D7B")]
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

		[Cpp2IlInjected.Token(Token = "0x6006D7C")]
		[Cpp2IlInjected.Address(RVA = "0x148B3D0", Offset = "0x1489DD0", VA = "0x18148B3D0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006D7D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006D7E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006D7F")]
		[Cpp2IlInjected.Address(RVA = "0x148B4A0", Offset = "0x1489EA0", VA = "0x18148B4A0")]
		static PurchaseBattlePassCurrency()
		{
			Func<PurchaseBattlePassCurrency> func = default(Func<PurchaseBattlePassCurrency>);
			_parser = (MessageParser<PurchaseBattlePassCurrency>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
