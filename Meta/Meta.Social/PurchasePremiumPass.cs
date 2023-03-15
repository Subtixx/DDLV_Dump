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
	[Cpp2IlInjected.Token(Token = "0x2000CC5")]
	public sealed class PurchasePremiumPass : IMessage<PurchasePremiumPass>, IMessage, IEquatable<PurchasePremiumPass>, IDeepCloneable<PurchasePremiumPass>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000CC6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000CC7")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40031C3")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x40031C4")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x40031C5")]
				[OriginalName("SearchConfigError")]
				SearchConfigError = 2,
				[Cpp2IlInjected.Token(Token = "0x40031C6")]
				[OriginalName("InvalidStartOrEndDate")]
				InvalidStartOrEndDate = 3,
				[Cpp2IlInjected.Token(Token = "0x40031C7")]
				[OriginalName("InvalidConfig")]
				InvalidConfig = 4,
				[Cpp2IlInjected.Token(Token = "0x40031C8")]
				[OriginalName("EventEnded")]
				EventEnded = 5,
				[Cpp2IlInjected.Token(Token = "0x40031C9")]
				[OriginalName("SearchCurrencyError")]
				SearchCurrencyError = 6,
				[Cpp2IlInjected.Token(Token = "0x40031CA")]
				[OriginalName("PriceItemNotFound")]
				PriceItemNotFound = 7,
				[Cpp2IlInjected.Token(Token = "0x40031CB")]
				[OriginalName("GetInventoryProgressError")]
				GetInventoryProgressError = 8,
				[Cpp2IlInjected.Token(Token = "0x40031CC")]
				[OriginalName("AlreadyPurchased")]
				AlreadyPurchased = 9,
				[Cpp2IlInjected.Token(Token = "0x40031CD")]
				[OriginalName("NotEnoughCurrency")]
				NotEnoughCurrency = 10,
				[Cpp2IlInjected.Token(Token = "0x40031CE")]
				[OriginalName("PurchasePremiumPassFailed")]
				PurchasePremiumPassFailed = 11,
				[Cpp2IlInjected.Token(Token = "0x40031CF")]
				[OriginalName("UnknownError")]
				UnknownError = 20
			}

			[Cpp2IlInjected.Token(Token = "0x2000CC8")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x40031D0")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40031D1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40031D2")]
				public const int BattlePassOnlineIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40031D3")]
				private string battlePassOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x40031D4")]
				public const int PurchaseBundleFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40031D5")]
				private bool purchaseBundle_;

				[Cpp2IlInjected.Token(Token = "0x40031D6")]
				public const int CurrencyOnlineIdFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40031D7")]
				private string currencyOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x40031D8")]
				public const int CurrencyOnlineTypeFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40031D9")]
				private string currencyOnlineType_;

				[Cpp2IlInjected.Token(Token = "0x1700131A")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006D26")]
					[Cpp2IlInjected.Address(RVA = "0x2C12AF0", Offset = "0x2C114F0", VA = "0x182C12AF0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700131B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006D27")]
					[Cpp2IlInjected.Address(RVA = "0x2C12890", Offset = "0x2C11290", VA = "0x182C12890")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700131C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006D28")]
					[Cpp2IlInjected.Address(RVA = "0x2C131B0", Offset = "0x2C11BB0", VA = "0x182C131B0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700131D")]
				[DebuggerNonUserCode]
				public string BattlePassOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006D2C")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006D2D")]
					[Cpp2IlInjected.Address(RVA = "0x2C134B0", Offset = "0x2C11EB0", VA = "0x182C134B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700131E")]
				[DebuggerNonUserCode]
				public bool PurchaseBundle
				{
					[Cpp2IlInjected.Token(Token = "0x6006D2E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D2F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700131F")]
				[DebuggerNonUserCode]
				public string CurrencyOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006D30")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006D31")]
					[Cpp2IlInjected.Address(RVA = "0x2C13600", Offset = "0x2C12000", VA = "0x182C13600")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001320")]
				[DebuggerNonUserCode]
				public string CurrencyOnlineType
				{
					[Cpp2IlInjected.Token(Token = "0x6006D32")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006D33")]
					[Cpp2IlInjected.Address(RVA = "0x2C136E0", Offset = "0x2C120E0", VA = "0x182C136E0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006D29")]
				[Cpp2IlInjected.Address(RVA = "0x2C11BC0", Offset = "0x2C105C0", VA = "0x182C11BC0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D2A")]
				[Cpp2IlInjected.Address(RVA = "0x2C11AC0", Offset = "0x2C104C0", VA = "0x182C11AC0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D2B")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C5C0", Offset = "0x2C0AFC0", VA = "0x182C0C5C0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D34")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C9D0", Offset = "0x2C0B3D0", VA = "0x182C0C9D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D35")]
				[Cpp2IlInjected.Address(RVA = "0x2C0D090", Offset = "0x2C0BA90", VA = "0x182C0D090", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D36")]
				[Cpp2IlInjected.Address(RVA = "0x2C0DAB0", Offset = "0x2C0C4B0", VA = "0x182C0DAB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D37")]
				[Cpp2IlInjected.Address(RVA = "0x2C0F340", Offset = "0x2C0DD40", VA = "0x182C0F340", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D38")]
				[Cpp2IlInjected.Address(RVA = "0x2C108E0", Offset = "0x2C0F2E0", VA = "0x182C108E0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D39")]
				[Cpp2IlInjected.Address(RVA = "0x2C0B9E0", Offset = "0x2C0A3E0", VA = "0x182C0B9E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D3A")]
				[Cpp2IlInjected.Address(RVA = "0x2C0E780", Offset = "0x2C0D180", VA = "0x182C0E780", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D3B")]
				[Cpp2IlInjected.Address(RVA = "0x2C0E370", Offset = "0x2C0CD70", VA = "0x182C0E370", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D3C")]
				[Cpp2IlInjected.Address(RVA = "0x2C0D520", Offset = "0x2C0BF20", VA = "0x182C0D520", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D3D")]
				[Cpp2IlInjected.Address(RVA = "0x2C0F110", Offset = "0x2C0DB10", VA = "0x182C0F110", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D3E")]
				[Cpp2IlInjected.Address(RVA = "0x2C0BB60", Offset = "0x2C0A560", VA = "0x182C0BB60", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CCA")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x40031DB")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40031DC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40031DD")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40031DE")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40031DF")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40031E0")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40031E1")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40031E2")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x40031E3")]
				public const int SpendResultDataFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40031E4")]
				private SpendOnlineCurrency.Types.ReturnedData spendResultData_;

				[Cpp2IlInjected.Token(Token = "0x40031E5")]
				public const int CurrencyBalanceFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40031E6")]
				private int currencyBalance_;

				[Cpp2IlInjected.Token(Token = "0x17001321")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006D43")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E750", Offset = "0x2C1D150", VA = "0x182C1E750")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001322")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006D44")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E130", Offset = "0x2C1CB30", VA = "0x182C1E130")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001323")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006D45")]
					[Cpp2IlInjected.Address(RVA = "0x2C1ECF0", Offset = "0x2C1D6F0", VA = "0x182C1ECF0", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001324")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006D49")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D4A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001325")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006D4B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006D4C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001326")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006D4D")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D4E")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001327")]
				[DebuggerNonUserCode]
				public SpendOnlineCurrency.Types.ReturnedData SpendResultData
				{
					[Cpp2IlInjected.Token(Token = "0x6006D4F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006D50")]
					[Cpp2IlInjected.Address(RVA = "0x52CA10", Offset = "0x52B410", VA = "0x18052CA10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001328")]
				[DebuggerNonUserCode]
				public int CurrencyBalance
				{
					[Cpp2IlInjected.Token(Token = "0x6006D51")]
					[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D52")]
					[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001329")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6006D5E")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700132A")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006D5F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D60")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700132B")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006D61")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006D62")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006D46")]
				[Cpp2IlInjected.Address(RVA = "0x2C1D390", Offset = "0x2C1BD90", VA = "0x182C1D390")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D47")]
				[Cpp2IlInjected.Address(RVA = "0x2C1D810", Offset = "0x2C1C210", VA = "0x182C1D810")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D48")]
				[Cpp2IlInjected.Address(RVA = "0x2C17950", Offset = "0x2C16350", VA = "0x182C17950", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D53")]
				[Cpp2IlInjected.Address(RVA = "0x2C18170", Offset = "0x2C16B70", VA = "0x182C18170", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D54")]
				[Cpp2IlInjected.Address(RVA = "0x1DC9310", Offset = "0x1DC7D10", VA = "0x181DC9310", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D55")]
				[Cpp2IlInjected.Address(RVA = "0x1DCA540", Offset = "0x1DC8F40", VA = "0x181DCA540", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D56")]
				[Cpp2IlInjected.Address(RVA = "0x2C1C000", Offset = "0x2C1AA00", VA = "0x182C1C000", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D57")]
				[Cpp2IlInjected.Address(RVA = "0x1DCCF50", Offset = "0x1DCB950", VA = "0x181DCCF50", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D58")]
				[Cpp2IlInjected.Address(RVA = "0x2C17110", Offset = "0x2C15B10", VA = "0x182C17110", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006D59")]
				[Cpp2IlInjected.Address(RVA = "0x2C1AB90", Offset = "0x2C19590", VA = "0x182C1AB90", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D5A")]
				[Cpp2IlInjected.Address(RVA = "0x2C1AA10", Offset = "0x2C19410", VA = "0x182C1AA10", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D5B")]
				[Cpp2IlInjected.Address(RVA = "0x2C18E90", Offset = "0x2C17890", VA = "0x182C18E90", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D5C")]
				[Cpp2IlInjected.Address(RVA = "0x2C1B7E0", Offset = "0x2C1A1E0", VA = "0x182C1B7E0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D5D")]
				[Cpp2IlInjected.Address(RVA = "0x1DC85A0", Offset = "0x1DC6FA0", VA = "0x181DC85A0", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006D63")]
				[Cpp2IlInjected.Address(RVA = "0x2C18AE0", Offset = "0x2C174E0", VA = "0x182C18AE0", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__56))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006D64")]
				[Cpp2IlInjected.Address(RVA = "0x2C13800", Offset = "0x2C12200", VA = "0x182C13800", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40031C0")]
		private static readonly MessageParser<PurchasePremiumPass> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40031C1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001317")]
		[DebuggerNonUserCode]
		public static MessageParser<PurchasePremiumPass> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006D14")]
			[Cpp2IlInjected.Address(RVA = "0x148C0C0", Offset = "0x148AAC0", VA = "0x18148C0C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001318")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006D15")]
			[Cpp2IlInjected.Address(RVA = "0x148BFF0", Offset = "0x148A9F0", VA = "0x18148BFF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001319")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006D16")]
			[Cpp2IlInjected.Address(RVA = "0x148C120", Offset = "0x148AB20", VA = "0x18148C120", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006D17")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public PurchasePremiumPass()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006D18")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public PurchasePremiumPass(PurchasePremiumPass other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006D19")]
		[Cpp2IlInjected.Address(RVA = "0x148BD10", Offset = "0x148A710", VA = "0x18148BD10", Slot = "10")]
		[DebuggerNonUserCode]
		public PurchasePremiumPass Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			PurchasePremiumPass purchasePremiumPass = default(PurchasePremiumPass);
			purchasePremiumPass.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (purchasePremiumPass._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return purchasePremiumPass;
		}

		[Cpp2IlInjected.Token(Token = "0x6006D1A")]
		[Cpp2IlInjected.Address(RVA = "0x148BD90", Offset = "0x148A790", VA = "0x18148BD90", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006D1B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(PurchasePremiumPass other)
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

		[Cpp2IlInjected.Token(Token = "0x6006D1C")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006D1D")]
		[Cpp2IlInjected.Address(RVA = "0x148BE80", Offset = "0x148A880", VA = "0x18148BE80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006D1E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006D1F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006D20")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(PurchasePremiumPass other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006D21")]
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

		[Cpp2IlInjected.Token(Token = "0x6006D22")]
		[Cpp2IlInjected.Address(RVA = "0x148BE10", Offset = "0x148A810", VA = "0x18148BE10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006D23")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006D24")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006D25")]
		[Cpp2IlInjected.Address(RVA = "0x148BEE0", Offset = "0x148A8E0", VA = "0x18148BEE0")]
		static PurchasePremiumPass()
		{
			Func<PurchasePremiumPass> func = default(Func<PurchasePremiumPass>);
			_parser = (MessageParser<PurchasePremiumPass>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
