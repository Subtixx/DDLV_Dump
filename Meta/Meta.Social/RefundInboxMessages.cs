using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000C46")]
	public sealed class RefundInboxMessages : IMessage<RefundInboxMessages>, IMessage, IEquatable<RefundInboxMessages>, IDeepCloneable<RefundInboxMessages>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C47")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C48")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002F75")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002F76")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002F77")]
				[OriginalName("InvalidParameter")]
				InvalidParameter = 2,
				[Cpp2IlInjected.Token(Token = "0x4002F78")]
				[OriginalName("AlreadyRefunded")]
				AlreadyRefunded = 3,
				[Cpp2IlInjected.Token(Token = "0x4002F79")]
				[OriginalName("NoRefundableItems")]
				NoRefundableItems = 4,
				[Cpp2IlInjected.Token(Token = "0x4002F7A")]
				[OriginalName("InventoryFull")]
				InventoryFull = 5,
				[Cpp2IlInjected.Token(Token = "0x4002F7B")]
				[OriginalName("Expired")]
				Expired = 6,
				[Cpp2IlInjected.Token(Token = "0x4002F7C")]
				[OriginalName("InvalidMessage")]
				InvalidMessage = 7,
				[Cpp2IlInjected.Token(Token = "0x4002F7D")]
				[OriginalName("OnlineCannotGetInventory")]
				OnlineCannotGetInventory = 8,
				[Cpp2IlInjected.Token(Token = "0x4002F7E")]
				[OriginalName("OnlineMailboxKeyNotFound")]
				OnlineMailboxKeyNotFound = 9,
				[Cpp2IlInjected.Token(Token = "0x4002F7F")]
				[OriginalName("OnlineMissingRecipeLinkId")]
				OnlineMissingRecipeLinkId = 10,
				[Cpp2IlInjected.Token(Token = "0x4002F80")]
				[OriginalName("OnlineRewardsFailedToApply")]
				OnlineRewardsFailedToApply = 11,
				[Cpp2IlInjected.Token(Token = "0x4002F81")]
				[OriginalName("OnlineCannotGetKeyConfig")]
				OnlineCannotGetKeyConfig = 12,
				[Cpp2IlInjected.Token(Token = "0x4002F82")]
				[OriginalName("OnlineCannotGetRecipeConfig")]
				OnlineCannotGetRecipeConfig = 13,
				[Cpp2IlInjected.Token(Token = "0x4002F83")]
				[OriginalName("OnlineCannotGetRecipeItems")]
				OnlineCannotGetRecipeItems = 14,
				[Cpp2IlInjected.Token(Token = "0x4002F84")]
				[OriginalName("OnlineCannotGetRecipeItemConfigs")]
				OnlineCannotGetRecipeItemConfigs = 15,
				[Cpp2IlInjected.Token(Token = "0x4002F85")]
				[OriginalName("OnlineUnknownError")]
				OnlineUnknownError = 20,
				[Cpp2IlInjected.Token(Token = "0x4002F86")]
				[OriginalName("UnknownError")]
				UnknownError = 30
			}

			[Cpp2IlInjected.Token(Token = "0x2000C49")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002F87")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002F88")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002F89")]
				public const int KeysFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002F8A")]
				private static readonly FieldCodec<InboxMessageKey> _repeated_keys_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002F8B")]
				private readonly RepeatedField<InboxMessageKey> keys_;

				[Cpp2IlInjected.Token(Token = "0x17001230")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60068B3")]
					[Cpp2IlInjected.Address(RVA = "0x2C12C70", Offset = "0x2C11670", VA = "0x182C12C70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001231")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60068B4")]
					[Cpp2IlInjected.Address(RVA = "0x2C12590", Offset = "0x2C10F90", VA = "0x182C12590")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001232")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60068B5")]
					[Cpp2IlInjected.Address(RVA = "0x2C12DF0", Offset = "0x2C117F0", VA = "0x182C12DF0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001233")]
				[DebuggerNonUserCode]
				public RepeatedField<InboxMessageKey> Keys
				{
					[Cpp2IlInjected.Token(Token = "0x60068B9")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60068B6")]
				[Cpp2IlInjected.Address(RVA = "0x2C11F90", Offset = "0x2C10990", VA = "0x182C11F90")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068B7")]
				[Cpp2IlInjected.Address(RVA = "0x2C12310", Offset = "0x2C10D10", VA = "0x182C12310")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068B8")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C1B0", Offset = "0x2C0ABB0", VA = "0x182C0C1B0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60068BA")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C8F0", Offset = "0x2C0B2F0", VA = "0x182C0C8F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60068BB")]
				[Cpp2IlInjected.Address(RVA = "0x2C0CBD0", Offset = "0x2C0B5D0", VA = "0x182C0CBD0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60068BC")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60068BD")]
				[Cpp2IlInjected.Address(RVA = "0x2C0F580", Offset = "0x2C0DF80", VA = "0x182C0F580", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60068BE")]
				[Cpp2IlInjected.Address(RVA = "0x2C10D20", Offset = "0x2C0F720", VA = "0x182C10D20", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068BF")]
				[Cpp2IlInjected.Address(RVA = "0x2C0B440", Offset = "0x2C09E40", VA = "0x182C0B440", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60068C0")]
				[Cpp2IlInjected.Address(RVA = "0x2C0E700", Offset = "0x2C0D100", VA = "0x182C0E700", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068C1")]
				[Cpp2IlInjected.Address(RVA = "0x2C0DFE0", Offset = "0x2C0C9E0", VA = "0x182C0DFE0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068C2")]
				[Cpp2IlInjected.Address(RVA = "0x2C0D680", Offset = "0x2C0C080", VA = "0x182C0D680", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60068C3")]
				[Cpp2IlInjected.Address(RVA = "0x2C0EC10", Offset = "0x2C0D610", VA = "0x182C0EC10", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068C4")]
				[Cpp2IlInjected.Address(RVA = "0x2C0BB00", Offset = "0x2C0A500", VA = "0x182C0BB00", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C4B")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002F8D")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002F8E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002F8F")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002F90")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002F91")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002F92")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002F93")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002F94")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002F95")]
				public const int RefundedItemsFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4002F96")]
				private static readonly FieldCodec<OnlineItem> _repeated_refundedItems_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002F97")]
				private readonly RepeatedField<OnlineItem> refundedItems_;

				[Cpp2IlInjected.Token(Token = "0x4002F98")]
				public const int UpdatedInboxFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4002F99")]
				private Inbox updatedInbox_;

				[Cpp2IlInjected.Token(Token = "0x17001234")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60068C9")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E630", Offset = "0x2C1D030", VA = "0x182C1E630")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001235")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60068CA")]
					[Cpp2IlInjected.Address(RVA = "0x2C1DFB0", Offset = "0x2C1C9B0", VA = "0x182C1DFB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001236")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60068CB")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E930", Offset = "0x2C1D330", VA = "0x182C1E930", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001237")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60068CF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60068D0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001238")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60068D1")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60068D2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001239")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60068D3")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60068D4")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700123A")]
				[DebuggerNonUserCode]
				public RepeatedField<OnlineItem> RefundedItems
				{
					[Cpp2IlInjected.Token(Token = "0x60068D5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700123B")]
				[DebuggerNonUserCode]
				public Inbox UpdatedInbox
				{
					[Cpp2IlInjected.Token(Token = "0x60068D6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60068D7")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700123C")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x60068E3")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700123D")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60068E4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60068E5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700123E")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60068E6")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60068E7")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60068CC")]
				[Cpp2IlInjected.Address(RVA = "0x2C1D5F0", Offset = "0x2C1BFF0", VA = "0x182C1D5F0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068CD")]
				[Cpp2IlInjected.Address(RVA = "0x2C1CEB0", Offset = "0x2C1B8B0", VA = "0x182C1CEB0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068CE")]
				[Cpp2IlInjected.Address(RVA = "0x2C17D50", Offset = "0x2C16750", VA = "0x182C17D50", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60068D8")]
				[Cpp2IlInjected.Address(RVA = "0x2C185E0", Offset = "0x2C16FE0", VA = "0x182C185E0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60068D9")]
				[Cpp2IlInjected.Address(RVA = "0x2C180A0", Offset = "0x2C16AA0", VA = "0x182C180A0", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60068DA")]
				[Cpp2IlInjected.Address(RVA = "0x2C19570", Offset = "0x2C17F70", VA = "0x182C19570", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60068DB")]
				[Cpp2IlInjected.Address(RVA = "0x2C1BCA0", Offset = "0x2C1A6A0", VA = "0x182C1BCA0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60068DC")]
				[Cpp2IlInjected.Address(RVA = "0x2C1C1F0", Offset = "0x2C1ABF0", VA = "0x182C1C1F0", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068DD")]
				[Cpp2IlInjected.Address(RVA = "0x2C17350", Offset = "0x2C15D50", VA = "0x182C17350", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60068DE")]
				[Cpp2IlInjected.Address(RVA = "0x2C1A2F0", Offset = "0x2C18CF0", VA = "0x182C1A2F0", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068DF")]
				[Cpp2IlInjected.Address(RVA = "0x2C1AE60", Offset = "0x2C19860", VA = "0x182C1AE60", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068E0")]
				[Cpp2IlInjected.Address(RVA = "0x2C18FA0", Offset = "0x2C179A0", VA = "0x182C18FA0", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60068E1")]
				[Cpp2IlInjected.Address(RVA = "0x2C1BAD0", Offset = "0x2C1A4D0", VA = "0x182C1BAD0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068E2")]
				[Cpp2IlInjected.Address(RVA = "0x2C174E0", Offset = "0x2C15EE0", VA = "0x182C174E0", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068E8")]
				[Cpp2IlInjected.Address(RVA = "0x2C18860", Offset = "0x2C17260", VA = "0x182C18860", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__56))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60068E9")]
				[Cpp2IlInjected.Address(RVA = "0x2C15A80", Offset = "0x2C14480", VA = "0x182C15A80", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C4E")]
			public sealed class OnlineItem : IMessage<OnlineItem>, IMessage, IEquatable<OnlineItem>, IDeepCloneable<OnlineItem>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002FA2")]
				private static readonly MessageParser<OnlineItem> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002FA3")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002FA4")]
				public const int ItemIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002FA5")]
				private int itemId_;

				[Cpp2IlInjected.Token(Token = "0x4002FA6")]
				public const int AmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4002FA7")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x1700123F")]
				[DebuggerNonUserCode]
				public static MessageParser<OnlineItem> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60068F2")]
					[Cpp2IlInjected.Address(RVA = "0x2C0AF80", Offset = "0x2C09980", VA = "0x182C0AF80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001240")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60068F3")]
					[Cpp2IlInjected.Address(RVA = "0x2C0AF00", Offset = "0x2C09900", VA = "0x182C0AF00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001241")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60068F4")]
					[Cpp2IlInjected.Address(RVA = "0x2C0AFE0", Offset = "0x2C099E0", VA = "0x182C0AFE0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001242")]
				[DebuggerNonUserCode]
				public int ItemId
				{
					[Cpp2IlInjected.Token(Token = "0x60068F8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60068F9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001243")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x60068FA")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60068FB")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60068F5")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public OnlineItem()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068F6")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public OnlineItem(OnlineItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60068F7")]
				[Cpp2IlInjected.Address(RVA = "0x2C0AAF0", Offset = "0x2C094F0", VA = "0x182C0AAF0", Slot = "10")]
				[DebuggerNonUserCode]
				public OnlineItem Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60068FC")]
				[Cpp2IlInjected.Address(RVA = "0x2C0AB80", Offset = "0x2C09580", VA = "0x182C0AB80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60068FD")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(OnlineItem other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60068FE")]
				[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60068FF")]
				[Cpp2IlInjected.Address(RVA = "0x2C0AD90", Offset = "0x2C09790", VA = "0x182C0AD90", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006900")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006901")]
				[Cpp2IlInjected.Address(RVA = "0x2C0AA20", Offset = "0x2C09420", VA = "0x182C0AA20", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006902")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(OnlineItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006903")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006904")]
				[Cpp2IlInjected.Address(RVA = "0x2C0AC10", Offset = "0x2C09610", VA = "0x182C0AC10", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006905")]
				[Cpp2IlInjected.Address(RVA = "0x2C0ACD0", Offset = "0x2C096D0", VA = "0x182C0ACD0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006906")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002F72")]
		private static readonly MessageParser<RefundInboxMessages> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002F73")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700122D")]
		[DebuggerNonUserCode]
		public static MessageParser<RefundInboxMessages> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60068A1")]
			[Cpp2IlInjected.Address(RVA = "0x5C6D70", Offset = "0x5C5770", VA = "0x1805C6D70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700122E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60068A2")]
			[Cpp2IlInjected.Address(RVA = "0x5C6CA0", Offset = "0x5C56A0", VA = "0x1805C6CA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700122F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60068A3")]
			[Cpp2IlInjected.Address(RVA = "0x5C6DD0", Offset = "0x5C57D0", VA = "0x1805C6DD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60068A4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public RefundInboxMessages()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60068A5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public RefundInboxMessages(RefundInboxMessages other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60068A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C69C0", Offset = "0x5C53C0", VA = "0x1805C69C0", Slot = "10")]
		[DebuggerNonUserCode]
		public RefundInboxMessages Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			RefundInboxMessages refundInboxMessages = default(RefundInboxMessages);
			refundInboxMessages.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (refundInboxMessages._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return refundInboxMessages;
		}

		[Cpp2IlInjected.Token(Token = "0x60068A7")]
		[Cpp2IlInjected.Address(RVA = "0x5C6A40", Offset = "0x5C5440", VA = "0x1805C6A40", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60068A8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RefundInboxMessages other)
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

		[Cpp2IlInjected.Token(Token = "0x60068A9")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60068AA")]
		[Cpp2IlInjected.Address(RVA = "0x5C6B30", Offset = "0x5C5530", VA = "0x1805C6B30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60068AB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60068AC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60068AD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RefundInboxMessages other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60068AE")]
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

		[Cpp2IlInjected.Token(Token = "0x60068AF")]
		[Cpp2IlInjected.Address(RVA = "0x5C6AC0", Offset = "0x5C54C0", VA = "0x1805C6AC0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60068B0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60068B1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60068B2")]
		[Cpp2IlInjected.Address(RVA = "0x5C6B90", Offset = "0x5C5590", VA = "0x1805C6B90")]
		static RefundInboxMessages()
		{
			Func<RefundInboxMessages> func = default(Func<RefundInboxMessages>);
			_parser = (MessageParser<RefundInboxMessages>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
