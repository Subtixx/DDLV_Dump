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
	[Cpp2IlInjected.Token(Token = "0x2000C3D")]
	public sealed class ClaimInboxMessages : IMessage<ClaimInboxMessages>, IMessage, IEquatable<ClaimInboxMessages>, IDeepCloneable<ClaimInboxMessages>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C3E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C3F")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002F44")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002F45")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002F46")]
				[OriginalName("InvalidParameter")]
				InvalidParameter = 2,
				[Cpp2IlInjected.Token(Token = "0x4002F47")]
				[OriginalName("AlreadyClaimed")]
				AlreadyClaimed = 3,
				[Cpp2IlInjected.Token(Token = "0x4002F48")]
				[OriginalName("NoClaimableItems")]
				NoClaimableItems = 4,
				[Cpp2IlInjected.Token(Token = "0x4002F49")]
				[OriginalName("InventoryFull")]
				InventoryFull = 5,
				[Cpp2IlInjected.Token(Token = "0x4002F4A")]
				[OriginalName("Expired")]
				Expired = 6,
				[Cpp2IlInjected.Token(Token = "0x4002F4B")]
				[OriginalName("InvalidMessage")]
				InvalidMessage = 7,
				[Cpp2IlInjected.Token(Token = "0x4002F4C")]
				[OriginalName("OnlineCannotGetInventory")]
				OnlineCannotGetInventory = 8,
				[Cpp2IlInjected.Token(Token = "0x4002F4D")]
				[OriginalName("OnlineMailboxKeyNotFound")]
				OnlineMailboxKeyNotFound = 9,
				[Cpp2IlInjected.Token(Token = "0x4002F4E")]
				[OriginalName("OnlineMissingRecipeLinkId")]
				OnlineMissingRecipeLinkId = 10,
				[Cpp2IlInjected.Token(Token = "0x4002F4F")]
				[OriginalName("OnlineRewardsFailedToApply")]
				OnlineRewardsFailedToApply = 11,
				[Cpp2IlInjected.Token(Token = "0x4002F50")]
				[OriginalName("OnlineUnknownError")]
				OnlineUnknownError = 12,
				[Cpp2IlInjected.Token(Token = "0x4002F51")]
				[OriginalName("UnknownError")]
				UnknownError = 15
			}

			[Cpp2IlInjected.Token(Token = "0x2000C40")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002F52")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002F53")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002F54")]
				public const int KeysFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002F55")]
				private static readonly FieldCodec<InboxMessageKey> _repeated_keys_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002F56")]
				private readonly RepeatedField<InboxMessageKey> keys_;

				[Cpp2IlInjected.Token(Token = "0x4002F57")]
				public const int AutoClaimFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002F58")]
				private bool autoClaim_;

				[Cpp2IlInjected.Token(Token = "0x1700121C")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600685D")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC0F0", Offset = "0x1DFAAF0", VA = "0x181DFC0F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700121D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600685E")]
					[Cpp2IlInjected.Address(RVA = "0x1DFBC00", Offset = "0x1DFA600", VA = "0x181DFBC00")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700121E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600685F")]
					[Cpp2IlInjected.Address(RVA = "0x1DFC820", Offset = "0x1DFB220", VA = "0x181DFC820", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700121F")]
				[DebuggerNonUserCode]
				public RepeatedField<InboxMessageKey> Keys
				{
					[Cpp2IlInjected.Token(Token = "0x6006863")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001220")]
				[DebuggerNonUserCode]
				public bool AutoClaim
				{
					[Cpp2IlInjected.Token(Token = "0x6006864")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006865")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006860")]
				[Cpp2IlInjected.Address(RVA = "0x1DFB7E0", Offset = "0x1DFA1E0", VA = "0x181DFB7E0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006861")]
				[Cpp2IlInjected.Address(RVA = "0x1DFB590", Offset = "0x1DF9F90", VA = "0x181DFB590")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006862")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6D30", Offset = "0x1DF5730", VA = "0x181DF6D30", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006866")]
				[Cpp2IlInjected.Address(RVA = "0x1DF78F0", Offset = "0x1DF62F0", VA = "0x181DF78F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006867")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7210", Offset = "0x1DF5C10", VA = "0x181DF7210", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006868")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA7F0", Offset = "0x1BF91F0", VA = "0x181BFA7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006869")]
				[Cpp2IlInjected.Address(RVA = "0x1DF98C0", Offset = "0x1DF82C0", VA = "0x181DF98C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600686A")]
				[Cpp2IlInjected.Address(RVA = "0x1DFA340", Offset = "0x1DF8D40", VA = "0x181DFA340", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600686B")]
				[Cpp2IlInjected.Address(RVA = "0x1DF63B0", Offset = "0x1DF4DB0", VA = "0x181DF63B0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600686C")]
				[Cpp2IlInjected.Address(RVA = "0x1DF86B0", Offset = "0x1DF70B0", VA = "0x181DF86B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600686D")]
				[Cpp2IlInjected.Address(RVA = "0x1DF8950", Offset = "0x1DF7350", VA = "0x181DF8950", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600686E")]
				[Cpp2IlInjected.Address(RVA = "0x1DF7F50", Offset = "0x1DF6950", VA = "0x181DF7F50", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600686F")]
				[Cpp2IlInjected.Address(RVA = "0x1DF9130", Offset = "0x1DF7B30", VA = "0x181DF9130", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006870")]
				[Cpp2IlInjected.Address(RVA = "0x1DF6530", Offset = "0x1DF4F30", VA = "0x181DF6530", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C42")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002F5A")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002F5B")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002F5C")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002F5D")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002F5E")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002F5F")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002F60")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002F61")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002F62")]
				public const int RewardsFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4002F63")]
				private static readonly FieldCodec<RewardData> _repeated_rewards_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002F64")]
				private readonly RepeatedField<RewardData> rewards_;

				[Cpp2IlInjected.Token(Token = "0x4002F65")]
				public const int UpdatedInboxFieldNumber = 5;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4002F66")]
				private Inbox updatedInbox_;

				[Cpp2IlInjected.Token(Token = "0x4002F67")]
				public const int OnlineMessagesToClaimFieldNumber = 6;

				[Cpp2IlInjected.Token(Token = "0x4002F68")]
				private static readonly FieldCodec<InboxMessage> _repeated_onlineMessagesToClaim_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4002F69")]
				private readonly RepeatedField<InboxMessage> onlineMessagesToClaim_;

				[Cpp2IlInjected.Token(Token = "0x17001221")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006875")]
					[Cpp2IlInjected.Address(RVA = "0x1E0A150", Offset = "0x1E08B50", VA = "0x181E0A150")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001222")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006876")]
					[Cpp2IlInjected.Address(RVA = "0x1E09CB0", Offset = "0x1E086B0", VA = "0x181E09CB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001223")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006877")]
					[Cpp2IlInjected.Address(RVA = "0x1E0AB10", Offset = "0x1E09510", VA = "0x181E0AB10", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001224")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x600687B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600687C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001225")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600687D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600687E")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001226")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x600687F")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006880")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001227")]
				[DebuggerNonUserCode]
				public RepeatedField<RewardData> Rewards
				{
					[Cpp2IlInjected.Token(Token = "0x6006881")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001228")]
				[DebuggerNonUserCode]
				public Inbox UpdatedInbox
				{
					[Cpp2IlInjected.Token(Token = "0x6006882")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006883")]
					[Cpp2IlInjected.Address(RVA = "0x70BFC0", Offset = "0x70A9C0", VA = "0x18070BFC0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001229")]
				[DebuggerNonUserCode]
				public RepeatedField<InboxMessage> OnlineMessagesToClaim
				{
					[Cpp2IlInjected.Token(Token = "0x6006884")]
					[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700122A")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6006890")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700122B")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006891")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006892")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700122C")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006893")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006894")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006878")]
				[Cpp2IlInjected.Address(RVA = "0x1E09120", Offset = "0x1E07B20", VA = "0x181E09120")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006879")]
				[Cpp2IlInjected.Address(RVA = "0x1E089B0", Offset = "0x1E073B0", VA = "0x181E089B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600687A")]
				[Cpp2IlInjected.Address(RVA = "0x1E01CB0", Offset = "0x1E006B0", VA = "0x181E01CB0", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006885")]
				[Cpp2IlInjected.Address(RVA = "0x1E02900", Offset = "0x1E01300", VA = "0x181E02900", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006886")]
				[Cpp2IlInjected.Address(RVA = "0x1E032D0", Offset = "0x1E01CD0", VA = "0x181E032D0", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006887")]
				[Cpp2IlInjected.Address(RVA = "0x1E04100", Offset = "0x1E02B00", VA = "0x181E04100", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006888")]
				[Cpp2IlInjected.Address(RVA = "0x1E06EC0", Offset = "0x1E058C0", VA = "0x181E06EC0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006889")]
				[Cpp2IlInjected.Address(RVA = "0x1E07100", Offset = "0x1E05B00", VA = "0x181E07100", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600688A")]
				[Cpp2IlInjected.Address(RVA = "0x1E01030", Offset = "0x1DFFA30", VA = "0x181E01030", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600688B")]
				[Cpp2IlInjected.Address(RVA = "0x1E05C60", Offset = "0x1E04660", VA = "0x181E05C60", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600688C")]
				[Cpp2IlInjected.Address(RVA = "0x1E042B0", Offset = "0x1E02CB0", VA = "0x181E042B0", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600688D")]
				[Cpp2IlInjected.Address(RVA = "0x1E03DF0", Offset = "0x1E027F0", VA = "0x181E03DF0", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600688E")]
				[Cpp2IlInjected.Address(RVA = "0x1E064D0", Offset = "0x1E04ED0", VA = "0x181E064D0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600688F")]
				[Cpp2IlInjected.Address(RVA = "0x1E013C0", Offset = "0x1DFFDC0", VA = "0x181E013C0", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006895")]
				[Cpp2IlInjected.Address(RVA = "0x1E03530", Offset = "0x1E01F30", VA = "0x181E03530", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__61))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006896")]
				[Cpp2IlInjected.Address(RVA = "0x1DFFD50", Offset = "0x1DFE750", VA = "0x181DFFD50", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002F41")]
		private static readonly MessageParser<ClaimInboxMessages> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002F42")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001219")]
		[DebuggerNonUserCode]
		public static MessageParser<ClaimInboxMessages> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600684B")]
			[Cpp2IlInjected.Address(RVA = "0x7277C0", Offset = "0x7261C0", VA = "0x1807277C0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700121A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600684C")]
			[Cpp2IlInjected.Address(RVA = "0x7276F0", Offset = "0x7260F0", VA = "0x1807276F0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700121B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600684D")]
			[Cpp2IlInjected.Address(RVA = "0x727820", Offset = "0x726220", VA = "0x180727820", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600684E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ClaimInboxMessages()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600684F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ClaimInboxMessages(ClaimInboxMessages other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006850")]
		[Cpp2IlInjected.Address(RVA = "0x727410", Offset = "0x725E10", VA = "0x180727410", Slot = "10")]
		[DebuggerNonUserCode]
		public ClaimInboxMessages Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ClaimInboxMessages claimInboxMessages = default(ClaimInboxMessages);
			claimInboxMessages.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (claimInboxMessages._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return claimInboxMessages;
		}

		[Cpp2IlInjected.Token(Token = "0x6006851")]
		[Cpp2IlInjected.Address(RVA = "0x727490", Offset = "0x725E90", VA = "0x180727490", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006852")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ClaimInboxMessages other)
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

		[Cpp2IlInjected.Token(Token = "0x6006853")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006854")]
		[Cpp2IlInjected.Address(RVA = "0x727580", Offset = "0x725F80", VA = "0x180727580", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006855")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006856")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006857")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ClaimInboxMessages other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006858")]
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

		[Cpp2IlInjected.Token(Token = "0x6006859")]
		[Cpp2IlInjected.Address(RVA = "0x727510", Offset = "0x725F10", VA = "0x180727510", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600685A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600685B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600685C")]
		[Cpp2IlInjected.Address(RVA = "0x7275E0", Offset = "0x725FE0", VA = "0x1807275E0")]
		static ClaimInboxMessages()
		{
			Func<ClaimInboxMessages> func = default(Func<ClaimInboxMessages>);
			_parser = (MessageParser<ClaimInboxMessages>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
