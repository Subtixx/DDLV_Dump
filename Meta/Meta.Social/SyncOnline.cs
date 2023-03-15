using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Definitions.Util;
using glPlayFab;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000CE0")]
	public sealed class SyncOnline : IMessage<SyncOnline>, IMessage, IEquatable<SyncOnline>, IDeepCloneable<SyncOnline>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000CE1")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000CE2")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4003242")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4003243")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4003244")]
				[OriginalName("NoBattlePassCached")]
				NoBattlePassCached = 2,
				[Cpp2IlInjected.Token(Token = "0x4003245")]
				[OriginalName("OnlineItemNotFound")]
				OnlineItemNotFound = 3,
				[Cpp2IlInjected.Token(Token = "0x4003246")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000CE3")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4003247")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003248")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003249")]
				public const int BattlePassIdsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400324A")]
				private static readonly MapField<string, string>.Codec _map_battlePassIds_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400324B")]
				private readonly MapField<string, string> battlePassIds_;

				[Cpp2IlInjected.Token(Token = "0x17001356")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006E2F")]
					[Cpp2IlInjected.Address(RVA = "0x25FB9D0", Offset = "0x25FA3D0", VA = "0x1825FB9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001357")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006E30")]
					[Cpp2IlInjected.Address(RVA = "0x25FB770", Offset = "0x25FA170", VA = "0x1825FB770")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001358")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006E31")]
					[Cpp2IlInjected.Address(RVA = "0x25FBFD0", Offset = "0x25FA9D0", VA = "0x1825FBFD0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001359")]
				[DebuggerNonUserCode]
				public MapField<string, string> BattlePassIds
				{
					[Cpp2IlInjected.Token(Token = "0x6006E35")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006E32")]
				[Cpp2IlInjected.Address(RVA = "0x25FAB40", Offset = "0x25F9540", VA = "0x1825FAB40")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E33")]
				[Cpp2IlInjected.Address(RVA = "0x25FB0A0", Offset = "0x25F9AA0", VA = "0x1825FB0A0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E34")]
				[Cpp2IlInjected.Address(RVA = "0x25F4E20", Offset = "0x25F3820", VA = "0x1825F4E20", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E36")]
				[Cpp2IlInjected.Address(RVA = "0x25F5A30", Offset = "0x25F4430", VA = "0x1825F5A30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E37")]
				[Cpp2IlInjected.Address(RVA = "0x25F5B10", Offset = "0x25F4510", VA = "0x1825F5B10", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E38")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E39")]
				[Cpp2IlInjected.Address(RVA = "0x25F8320", Offset = "0x25F6D20", VA = "0x1825F8320", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E3A")]
				[Cpp2IlInjected.Address(RVA = "0x25F9720", Offset = "0x25F8120", VA = "0x1825F9720", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E3B")]
				[Cpp2IlInjected.Address(RVA = "0x25F44C0", Offset = "0x25F2EC0", VA = "0x1825F44C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E3C")]
				[Cpp2IlInjected.Address(RVA = "0x25F73A0", Offset = "0x25F5DA0", VA = "0x1825F73A0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E3D")]
				[Cpp2IlInjected.Address(RVA = "0x25F71C0", Offset = "0x25F5BC0", VA = "0x1825F71C0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E3E")]
				[Cpp2IlInjected.Address(RVA = "0x25F6030", Offset = "0x25F4A30", VA = "0x1825F6030", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E3F")]
				[Cpp2IlInjected.Address(RVA = "0x25F82C0", Offset = "0x25F6CC0", VA = "0x1825F82C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E40")]
				[Cpp2IlInjected.Address(RVA = "0x25F4820", Offset = "0x25F3220", VA = "0x1825F4820", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CE5")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x400324D")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400324E")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400324F")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003250")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4003251")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003252")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4003253")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003254")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4003255")]
				public const int BattlePassItemsFieldNumber = 6;

				[Cpp2IlInjected.Token(Token = "0x4003256")]
				private static readonly FieldCodec<BattlePassItem> _repeated_battlePassItems_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4003257")]
				private readonly RepeatedField<BattlePassItem> battlePassItems_;

				[Cpp2IlInjected.Token(Token = "0x1700135A")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006E45")]
					[Cpp2IlInjected.Address(RVA = "0x26065C0", Offset = "0x2604FC0", VA = "0x1826065C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700135B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006E46")]
					[Cpp2IlInjected.Address(RVA = "0x2605E40", Offset = "0x2604840", VA = "0x182605E40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700135C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006E47")]
					[Cpp2IlInjected.Address(RVA = "0x2606980", Offset = "0x2605380", VA = "0x182606980", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700135D")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006E4B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006E4C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700135E")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006E4D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006E4E")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700135F")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006E4F")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006E50")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001360")]
				[DebuggerNonUserCode]
				public RepeatedField<BattlePassItem> BattlePassItems
				{
					[Cpp2IlInjected.Token(Token = "0x6006E51")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001361")]
				protected override bool IsTriggeringSave
				{
					[Cpp2IlInjected.Token(Token = "0x6006E5D")]
					[Cpp2IlInjected.Address(RVA = "0x9A5620", Offset = "0x9A4020", VA = "0x1809A5620", Slot = "20")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001362")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006E5E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006E5F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001363")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006E60")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006E61")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006E48")]
				[Cpp2IlInjected.Address(RVA = "0x2605BD0", Offset = "0x26045D0", VA = "0x182605BD0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E49")]
				[Cpp2IlInjected.Address(RVA = "0x2605430", Offset = "0x2603E30", VA = "0x182605430")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E4A")]
				[Cpp2IlInjected.Address(RVA = "0x25FEFA0", Offset = "0x25FD9A0", VA = "0x1825FEFA0", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E52")]
				[Cpp2IlInjected.Address(RVA = "0x26000D0", Offset = "0x25FEAD0", VA = "0x1826000D0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E53")]
				[Cpp2IlInjected.Address(RVA = "0x26001D0", Offset = "0x25FEBD0", VA = "0x1826001D0", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E54")]
				[Cpp2IlInjected.Address(RVA = "0x1C05FB0", Offset = "0x1C049B0", VA = "0x181C05FB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E55")]
				[Cpp2IlInjected.Address(RVA = "0x2603B30", Offset = "0x2602530", VA = "0x182603B30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E56")]
				[Cpp2IlInjected.Address(RVA = "0x2603E80", Offset = "0x2602880", VA = "0x182603E80", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E57")]
				[Cpp2IlInjected.Address(RVA = "0x25FE680", Offset = "0x25FD080", VA = "0x1825FE680", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E58")]
				[Cpp2IlInjected.Address(RVA = "0x26024A0", Offset = "0x2600EA0", VA = "0x1826024A0", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E59")]
				[Cpp2IlInjected.Address(RVA = "0x2601890", Offset = "0x2600290", VA = "0x182601890", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E5A")]
				[Cpp2IlInjected.Address(RVA = "0x26012D0", Offset = "0x25FFCD0", VA = "0x1826012D0", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E5B")]
				[Cpp2IlInjected.Address(RVA = "0x26035D0", Offset = "0x2601FD0", VA = "0x1826035D0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E5C")]
				[Cpp2IlInjected.Address(RVA = "0x25FEE20", Offset = "0x25FD820", VA = "0x1825FEE20", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E62")]
				[Cpp2IlInjected.Address(RVA = "0x2600850", Offset = "0x25FF250", VA = "0x182600850", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__51))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E63")]
				[Cpp2IlInjected.Address(RVA = "0x25FDC60", Offset = "0x25FC660", VA = "0x1825FDC60", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CE8")]
			public sealed class BattlePassItem : IMessage<BattlePassItem>, IMessage, IEquatable<BattlePassItem>, IDeepCloneable<BattlePassItem>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4003261")]
				private static readonly MessageParser<BattlePassItem> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003262")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003263")]
				public const int OnlineIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003264")]
				private string onlineId_;

				[Cpp2IlInjected.Token(Token = "0x4003265")]
				public const int CurrencyAmountFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003266")]
				private int currencyAmount_;

				[Cpp2IlInjected.Token(Token = "0x4003267")]
				public const int IsPremiumActiveFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
				[Cpp2IlInjected.Token(Token = "0x4003268")]
				private bool isPremiumActive_;

				[Cpp2IlInjected.Token(Token = "0x4003269")]
				public const int IsBundleBoughtFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
				[Cpp2IlInjected.Token(Token = "0x400326A")]
				private bool isBundleBought_;

				[Cpp2IlInjected.Token(Token = "0x400326B")]
				public const int TaskCollectedFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x400326C")]
				private static readonly FieldCodec<bool> _repeated_taskCollected_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400326D")]
				private readonly RepeatedField<bool> taskCollected_;

				[Cpp2IlInjected.Token(Token = "0x400326E")]
				public const int RewardPurchasedFieldNumber = 6;

				[Cpp2IlInjected.Token(Token = "0x400326F")]
				private static readonly FieldCodec<bool> _repeated_rewardPurchased_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4003270")]
				private readonly RepeatedField<bool> rewardPurchased_;

				[Cpp2IlInjected.Token(Token = "0x17001364")]
				[DebuggerNonUserCode]
				public static MessageParser<BattlePassItem> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006E6C")]
					[Cpp2IlInjected.Address(RVA = "0x25F29B0", Offset = "0x25F13B0", VA = "0x1825F29B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001365")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006E6D")]
					[Cpp2IlInjected.Address(RVA = "0x25F2930", Offset = "0x25F1330", VA = "0x1825F2930")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001366")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006E6E")]
					[Cpp2IlInjected.Address(RVA = "0x25F2A10", Offset = "0x25F1410", VA = "0x1825F2A10", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001367")]
				[DebuggerNonUserCode]
				public string OnlineId
				{
					[Cpp2IlInjected.Token(Token = "0x6006E72")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006E73")]
					[Cpp2IlInjected.Address(RVA = "0x25F2AD0", Offset = "0x25F14D0", VA = "0x1825F2AD0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001368")]
				[DebuggerNonUserCode]
				public int CurrencyAmount
				{
					[Cpp2IlInjected.Token(Token = "0x6006E74")]
					[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006E75")]
					[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001369")]
				[DebuggerNonUserCode]
				public bool IsPremiumActive
				{
					[Cpp2IlInjected.Token(Token = "0x6006E76")]
					[Cpp2IlInjected.Address(RVA = "0x1703600", Offset = "0x1702000", VA = "0x181703600")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006E77")]
					[Cpp2IlInjected.Address(RVA = "0x1703720", Offset = "0x1702120", VA = "0x181703720")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700136A")]
				[DebuggerNonUserCode]
				public bool IsBundleBought
				{
					[Cpp2IlInjected.Token(Token = "0x6006E78")]
					[Cpp2IlInjected.Address(RVA = "0x1811940", Offset = "0x1810340", VA = "0x181811940")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006E79")]
					[Cpp2IlInjected.Address(RVA = "0x1811AF0", Offset = "0x18104F0", VA = "0x181811AF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700136B")]
				[DebuggerNonUserCode]
				public RepeatedField<bool> TaskCollected
				{
					[Cpp2IlInjected.Token(Token = "0x6006E7A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700136C")]
				[DebuggerNonUserCode]
				public RepeatedField<bool> RewardPurchased
				{
					[Cpp2IlInjected.Token(Token = "0x6006E7B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006E6F")]
				[Cpp2IlInjected.Address(RVA = "0x25F2860", Offset = "0x25F1260", VA = "0x1825F2860")]
				[DebuggerNonUserCode]
				public BattlePassItem()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E70")]
				[Cpp2IlInjected.Address(RVA = "0x25F26C0", Offset = "0x25F10C0", VA = "0x1825F26C0")]
				[DebuggerNonUserCode]
				public BattlePassItem(BattlePassItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E71")]
				[Cpp2IlInjected.Address(RVA = "0x25F1830", Offset = "0x25F0230", VA = "0x1825F1830", Slot = "10")]
				[DebuggerNonUserCode]
				public BattlePassItem Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E7C")]
				[Cpp2IlInjected.Address(RVA = "0x25F1AE0", Offset = "0x25F04E0", VA = "0x1825F1AE0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E7D")]
				[Cpp2IlInjected.Address(RVA = "0x25F1A00", Offset = "0x25F0400", VA = "0x1825F1A00", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(BattlePassItem other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E7E")]
				[Cpp2IlInjected.Address(RVA = "0x25F1D60", Offset = "0x25F0760", VA = "0x1825F1D60", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E7F")]
				[Cpp2IlInjected.Address(RVA = "0x25F2360", Offset = "0x25F0D60", VA = "0x1825F2360", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E80")]
				[Cpp2IlInjected.Address(RVA = "0x25F23C0", Offset = "0x25F0DC0", VA = "0x1825F23C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E81")]
				[Cpp2IlInjected.Address(RVA = "0x25F15C0", Offset = "0x25EFFC0", VA = "0x1825F15C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006E82")]
				[Cpp2IlInjected.Address(RVA = "0x25F1E70", Offset = "0x25F0870", VA = "0x1825F1E70", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(BattlePassItem other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E83")]
				[Cpp2IlInjected.Address(RVA = "0x25F1F50", Offset = "0x25F0950", VA = "0x1825F1F50", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E84")]
				[Cpp2IlInjected.Address(RVA = "0x25F1C10", Offset = "0x25F0610", VA = "0x1825F1C10", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006E85")]
				[Cpp2IlInjected.Address(RVA = "0x25F2130", Offset = "0x25F0B30", VA = "0x1825F2130", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006E86")]
				[Cpp2IlInjected.Address(RVA = "0x25F1740", Offset = "0x25F0140", VA = "0x1825F1740", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400323F")]
		private static readonly MessageParser<SyncOnline> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003240")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001353")]
		[DebuggerNonUserCode]
		public static MessageParser<SyncOnline> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006E1D")]
			[Cpp2IlInjected.Address(RVA = "0x789390", Offset = "0x787D90", VA = "0x180789390")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001354")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006E1E")]
			[Cpp2IlInjected.Address(RVA = "0x7892C0", Offset = "0x787CC0", VA = "0x1807892C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001355")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006E1F")]
			[Cpp2IlInjected.Address(RVA = "0x7893F0", Offset = "0x787DF0", VA = "0x1807893F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006E20")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SyncOnline()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006E21")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SyncOnline(SyncOnline other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006E22")]
		[Cpp2IlInjected.Address(RVA = "0x788FE0", Offset = "0x7879E0", VA = "0x180788FE0", Slot = "10")]
		[DebuggerNonUserCode]
		public SyncOnline Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SyncOnline syncOnline = default(SyncOnline);
			syncOnline.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (syncOnline._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return syncOnline;
		}

		[Cpp2IlInjected.Token(Token = "0x6006E23")]
		[Cpp2IlInjected.Address(RVA = "0x789060", Offset = "0x787A60", VA = "0x180789060", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006E24")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SyncOnline other)
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

		[Cpp2IlInjected.Token(Token = "0x6006E25")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006E26")]
		[Cpp2IlInjected.Address(RVA = "0x789150", Offset = "0x787B50", VA = "0x180789150", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006E27")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006E28")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006E29")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SyncOnline other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006E2A")]
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

		[Cpp2IlInjected.Token(Token = "0x6006E2B")]
		[Cpp2IlInjected.Address(RVA = "0x7890E0", Offset = "0x787AE0", VA = "0x1807890E0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006E2C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006E2D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006E2E")]
		[Cpp2IlInjected.Address(RVA = "0x7891B0", Offset = "0x787BB0", VA = "0x1807891B0")]
		static SyncOnline()
		{
			Func<SyncOnline> func = default(Func<SyncOnline>);
			_parser = (MessageParser<SyncOnline>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
