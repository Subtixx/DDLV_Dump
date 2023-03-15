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
	[Cpp2IlInjected.Token(Token = "0x2000CB1")]
	public sealed class CollectBattlePassTaskCurrency : IMessage<CollectBattlePassTaskCurrency>, IMessage, IEquatable<CollectBattlePassTaskCurrency>, IDeepCloneable<CollectBattlePassTaskCurrency>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000CB2")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000CB3")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x400314D")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x400314E")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x400314F")]
				[OriginalName("InvalidParam")]
				InvalidParam = 2,
				[Cpp2IlInjected.Token(Token = "0x4003150")]
				[OriginalName("SearchConfigError")]
				SearchConfigError = 3,
				[Cpp2IlInjected.Token(Token = "0x4003151")]
				[OriginalName("InvalidStartOrEndDate")]
				InvalidStartOrEndDate = 4,
				[Cpp2IlInjected.Token(Token = "0x4003152")]
				[OriginalName("InvalidConfig")]
				InvalidConfig = 5,
				[Cpp2IlInjected.Token(Token = "0x4003153")]
				[OriginalName("InvalidTaskIndex")]
				InvalidTaskIndex = 6,
				[Cpp2IlInjected.Token(Token = "0x4003154")]
				[OriginalName("TaskUnavailable")]
				TaskUnavailable = 7,
				[Cpp2IlInjected.Token(Token = "0x4003155")]
				[OriginalName("EventEnded")]
				EventEnded = 8,
				[Cpp2IlInjected.Token(Token = "0x4003156")]
				[OriginalName("SearchCurrencyError")]
				SearchCurrencyError = 9,
				[Cpp2IlInjected.Token(Token = "0x4003157")]
				[OriginalName("GetCurrencyProgressError")]
				GetCurrencyProgressError = 10,
				[Cpp2IlInjected.Token(Token = "0x4003158")]
				[OriginalName("PremiumPassInactive")]
				PremiumPassInactive = 11,
				[Cpp2IlInjected.Token(Token = "0x4003159")]
				[OriginalName("AlreadyCollected")]
				AlreadyCollected = 12,
				[Cpp2IlInjected.Token(Token = "0x400315A")]
				[OriginalName("CollectCurrencyFailed")]
				CollectCurrencyFailed = 13,
				[Cpp2IlInjected.Token(Token = "0x400315B")]
				[OriginalName("UnknownError")]
				UnknownError = 20
			}

			[Cpp2IlInjected.Token(Token = "0x2000CB4")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x400315C")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400315D")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400315E")]
				public const int BattlePassOnlineIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400315F")]
				private string battlePassOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x4003160")]
				public const int TaskIdxFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003161")]
				private int taskIdx_;

				[Cpp2IlInjected.Token(Token = "0x4003162")]
				public const int CurrencyOnlineIdFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003163")]
				private string currencyOnlineId_;

				[Cpp2IlInjected.Token(Token = "0x4003164")]
				public const int CurrencyOnlineTypeFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4003165")]
				private string currencyOnlineType_;

				[Cpp2IlInjected.Token(Token = "0x170012EE")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006C66")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC2D0", Offset = "0x1DFACD0", VA = "0x181DFC2D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012EF")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006C67")]
					[Cpp2IlInjected.Address(RVA = "0x1DFBB80", Offset = "0x1DFA580", VA = "0x181DFBB80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F0")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006C68")]
					[Cpp2IlInjected.Address(RVA = "0x1DFCA60", Offset = "0x1DFB460", VA = "0x181DFCA60", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F1")]
				[DebuggerNonUserCode]
				public string BattlePassOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006C6C")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C6D")]
					[Cpp2IlInjected.Address(RVA = "0x1DFCEE0", Offset = "0x1DFB8E0", VA = "0x181DFCEE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F2")]
				[DebuggerNonUserCode]
				public int TaskIdx
				{
					[Cpp2IlInjected.Token(Token = "0x6006C6E")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C6F")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F3")]
				[DebuggerNonUserCode]
				public string CurrencyOnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006C70")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C71")]
					[Cpp2IlInjected.Address(RVA = "0x1DFCF50", Offset = "0x1DFB950", VA = "0x181DFCF50")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F4")]
				[DebuggerNonUserCode]
				public string CurrencyOnlineType
				{
					[Cpp2IlInjected.Token(Token = "0x6006C72")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C73")]
					[Cpp2IlInjected.Address(RVA = "0x1DFCFC0", Offset = "0x1DFB9C0", VA = "0x181DFCFC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006C69")]
				[Cpp2IlInjected.Address(RVA = "0x1DFB520", Offset = "0x1DF9F20", VA = "0x181DFB520")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C6A")]
				[Cpp2IlInjected.Address(RVA = "0x1DFB620", Offset = "0x1DFA020", VA = "0x181DFB620")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C6B")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6990", Offset = "0x1DF5390", VA = "0x181DF6990", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C74")]
				[Cpp2IlInjected.Address(RVA = "0x1DF74A0", Offset = "0x1DF5EA0", VA = "0x181DF74A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C75")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7580", Offset = "0x1DF5F80", VA = "0x181DF7580", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C76")]
				[Cpp2IlInjected.Address(RVA = "0x1DF82F0", Offset = "0x1DF6CF0", VA = "0x181DF82F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C77")]
				[Cpp2IlInjected.Address(RVA = "0x1DF96E0", Offset = "0x1DF80E0", VA = "0x181DF96E0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C78")]
				[Cpp2IlInjected.Address(RVA = "0x1DFA420", Offset = "0x1DF8E20", VA = "0x181DFA420", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C79")]
				[Cpp2IlInjected.Address(RVA = "0x1DF5E60", Offset = "0x1DF4860", VA = "0x181DF5E60", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C7A")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8610", Offset = "0x1DF7010", VA = "0x181DF8610", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C7B")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8860", Offset = "0x1DF7260", VA = "0x181DF8860", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C7C")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7B40", Offset = "0x1DF6540", VA = "0x181DF7B40", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C7D")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8EA0", Offset = "0x1DF78A0", VA = "0x181DF8EA0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C7E")]
				[Cpp2IlInjected.Address(RVA = "0x1DF65A0", Offset = "0x1DF4FA0", VA = "0x181DF65A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CB6")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4003167")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003168")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003169")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400316A")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400316B")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400316C")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x400316D")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400316E")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x400316F")]
				public const int CurrencyBalanceFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4003170")]
				private int currencyBalance_;

				[Cpp2IlInjected.Token(Token = "0x170012F5")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006C83")]
					[Cpp2IlInjected.Address(RVA = "0x1E09FD0", Offset = "0x1E089D0", VA = "0x181E09FD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F6")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006C84")]
					[Cpp2IlInjected.Address(RVA = "0x1E09A30", Offset = "0x1E08430", VA = "0x181E09A30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F7")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006C85")]
					[Cpp2IlInjected.Address(RVA = "0x1E0A5D0", Offset = "0x1E08FD0", VA = "0x181E0A5D0", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F8")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006C89")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C8A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012F9")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006C8B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006C8C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012FA")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006C8D")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C8E")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012FB")]
				[DebuggerNonUserCode]
				public int CurrencyBalance
				{
					[Cpp2IlInjected.Token(Token = "0x6006C8F")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C90")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012FC")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6006C9C")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012FD")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006C9D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006C9E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012FE")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006C9F")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006CA0")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012FF")]
				public override bool IsValid
				{
					[Cpp2IlInjected.Token(Token = "0x6006CA1")]
					[Cpp2IlInjected.Address(RVA = "0x1E09E30", Offset = "0x1E08830", VA = "0x181E09E30", Slot = "21")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006C86")]
				[Cpp2IlInjected.Address(RVA = "0x1E091F0", Offset = "0x1E07BF0", VA = "0x181E091F0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C87")]
				[Cpp2IlInjected.Address(RVA = "0x1E08570", Offset = "0x1E06F70", VA = "0x181E08570")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C88")]
				[Cpp2IlInjected.Address(RVA = "0x1E02160", Offset = "0x1E00B60", VA = "0x181E02160", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C91")]
				[Cpp2IlInjected.Address(RVA = "0x1E02BF0", Offset = "0x1E015F0", VA = "0x181E02BF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C92")]
				[Cpp2IlInjected.Address(RVA = "0x1E02D60", Offset = "0x1E01760", VA = "0x181E02D60", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C93")]
				[Cpp2IlInjected.Address(RVA = "0x1E041F0", Offset = "0x1E02BF0", VA = "0x181E041F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C94")]
				[Cpp2IlInjected.Address(RVA = "0x1E06E00", Offset = "0x1E05800", VA = "0x181E06E00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C95")]
				[Cpp2IlInjected.Address(RVA = "0x1E072D0", Offset = "0x1E05CD0", VA = "0x181E072D0", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C96")]
				[Cpp2IlInjected.Address(RVA = "0x1E00E30", Offset = "0x1DFF830", VA = "0x181E00E30", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006C97")]
				[Cpp2IlInjected.Address(RVA = "0x1E04FF0", Offset = "0x1E039F0", VA = "0x181E04FF0", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C98")]
				[Cpp2IlInjected.Address(RVA = "0x1E057F0", Offset = "0x1E041F0", VA = "0x181E057F0", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C99")]
				[Cpp2IlInjected.Address(RVA = "0x1E03C20", Offset = "0x1E02620", VA = "0x181E03C20", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006C9A")]
				[Cpp2IlInjected.Address(RVA = "0x1E06150", Offset = "0x1E04B50", VA = "0x181E06150", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006C9B")]
				[Cpp2IlInjected.Address(RVA = "0x1E01540", Offset = "0x1DFFF40", VA = "0x181E01540", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006CA2")]
				[Cpp2IlInjected.Address(RVA = "0x1E033D0", Offset = "0x1E01DD0", VA = "0x181E033D0", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__53))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006CA3")]
				[Cpp2IlInjected.Address(RVA = "0x1E025A0", Offset = "0x1E00FA0", VA = "0x181E025A0")]
				[AsyncStateMachine(typeof(_003CCollectAllBPTaskCurrency_003Ed__54))]
				private Task<bool> CollectAllBPTaskCurrency(ClientSession clientSession, BattlePassStatesData battlePassStates)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006CA4")]
				[Cpp2IlInjected.Address(RVA = "0x1E02700", Offset = "0x1E01100", VA = "0x181E02700")]
				[AsyncStateMachine(typeof(_003CCollectBPTaskCurrency_003Ed__55))]
				private Task<bool> CollectBPTaskCurrency(ClientSession clientSession, int taskIdx)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006CA5")]
				[Cpp2IlInjected.Address(RVA = "0x1E00280", Offset = "0x1DFEC80", VA = "0x181E00280", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400314A")]
		private static readonly MessageParser<CollectBattlePassTaskCurrency> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400314B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170012EB")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectBattlePassTaskCurrency> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006C54")]
			[Cpp2IlInjected.Address(RVA = "0x1675300", Offset = "0x1673D00", VA = "0x181675300")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012EC")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006C55")]
			[Cpp2IlInjected.Address(RVA = "0x1675230", Offset = "0x1673C30", VA = "0x181675230")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012ED")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006C56")]
			[Cpp2IlInjected.Address(RVA = "0x1675360", Offset = "0x1673D60", VA = "0x181675360", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006C57")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectBattlePassTaskCurrency()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006C58")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public CollectBattlePassTaskCurrency(CollectBattlePassTaskCurrency other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006C59")]
		[Cpp2IlInjected.Address(RVA = "0x1674F50", Offset = "0x1673950", VA = "0x181674F50", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectBattlePassTaskCurrency Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			CollectBattlePassTaskCurrency collectBattlePassTaskCurrency = default(CollectBattlePassTaskCurrency);
			collectBattlePassTaskCurrency.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (collectBattlePassTaskCurrency._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectBattlePassTaskCurrency;
		}

		[Cpp2IlInjected.Token(Token = "0x6006C5A")]
		[Cpp2IlInjected.Address(RVA = "0x1674FD0", Offset = "0x16739D0", VA = "0x181674FD0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006C5B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectBattlePassTaskCurrency other)
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

		[Cpp2IlInjected.Token(Token = "0x6006C5C")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006C5D")]
		[Cpp2IlInjected.Address(RVA = "0x16750C0", Offset = "0x1673AC0", VA = "0x1816750C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006C5E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006C5F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006C60")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectBattlePassTaskCurrency other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006C61")]
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

		[Cpp2IlInjected.Token(Token = "0x6006C62")]
		[Cpp2IlInjected.Address(RVA = "0x1675050", Offset = "0x1673A50", VA = "0x181675050", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006C63")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006C64")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006C65")]
		[Cpp2IlInjected.Address(RVA = "0x1675120", Offset = "0x1673B20", VA = "0x181675120")]
		static CollectBattlePassTaskCurrency()
		{
			Func<CollectBattlePassTaskCurrency> func = default(Func<CollectBattlePassTaskCurrency>);
			_parser = (MessageParser<CollectBattlePassTaskCurrency>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
