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
	[Cpp2IlInjected.Token(Token = "0x2000C87")]
	public sealed class GetBattlePasses : IMessage<GetBattlePasses>, IMessage, IEquatable<GetBattlePasses>, IDeepCloneable<GetBattlePasses>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C88")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C89")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4003081")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4003082")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4003083")]
				[OriginalName("CurrencyNotFound")]
				CurrencyNotFound = 2,
				[Cpp2IlInjected.Token(Token = "0x4003084")]
				[OriginalName("SearchConfigError")]
				SearchConfigError = 3,
				[Cpp2IlInjected.Token(Token = "0x4003085")]
				[OriginalName("InvalidCloudScriptResult")]
				InvalidCloudScriptResult = 4,
				[Cpp2IlInjected.Token(Token = "0x4003086")]
				[OriginalName("InvalidConfig")]
				InvalidConfig = 5,
				[Cpp2IlInjected.Token(Token = "0x4003087")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000C8A")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, ILiveopsRequestBase, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4003088")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003089")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400308A")]
				public const int KnownItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x400308B")]
				private static readonly FieldCodec<KnownLiveopsItem> _repeated_knownItems_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400308C")]
				private readonly RepeatedField<KnownLiveopsItem> knownItems_;

				[Cpp2IlInjected.Token(Token = "0x400308D")]
				public const int IncludeScheduledFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400308E")]
				private bool includeScheduled_;

				[Cpp2IlInjected.Token(Token = "0x170012A1")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006AF9")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FFD0", Offset = "0x1E7E9D0", VA = "0x181E7FFD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012A2")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006AFA")]
					[Cpp2IlInjected.Address(RVA = "0x1E7FA90", Offset = "0x1E7E490", VA = "0x181E7FA90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012A3")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006AFB")]
					[Cpp2IlInjected.Address(RVA = "0x1E80210", Offset = "0x1E7EC10", VA = "0x181E80210", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012A4")]
				[DebuggerNonUserCode]
				public RepeatedField<KnownLiveopsItem> KnownItems
				{
					[Cpp2IlInjected.Token(Token = "0x6006AFF")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012A5")]
				[DebuggerNonUserCode]
				public bool IncludeScheduled
				{
					[Cpp2IlInjected.Token(Token = "0x6006B00")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "15")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B01")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006AFC")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F710", Offset = "0x1E7E110", VA = "0x181E7F710")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006AFD")]
				[Cpp2IlInjected.Address(RVA = "0x1E7EEA0", Offset = "0x1E7D8A0", VA = "0x181E7EEA0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006AFE")]
				[Cpp2IlInjected.Address(RVA = "0x1E792F0", Offset = "0x1E77CF0", VA = "0x181E792F0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B02")]
				[Cpp2IlInjected.Address(RVA = "0x1E79D80", Offset = "0x1E78780", VA = "0x181E79D80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B03")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A6D0", Offset = "0x1E790D0", VA = "0x181E7A6D0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B04")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA7F0", Offset = "0x1BF91F0", VA = "0x181BFA7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B05")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C870", Offset = "0x1E7B270", VA = "0x181E7C870", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B06")]
				[Cpp2IlInjected.Address(RVA = "0x1E7DA80", Offset = "0x1E7C480", VA = "0x181E7DA80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B07")]
				[Cpp2IlInjected.Address(RVA = "0x1E78B50", Offset = "0x1E77550", VA = "0x181E78B50", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B08")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BBD0", Offset = "0x1E7A5D0", VA = "0x181E7BBD0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B09")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B980", Offset = "0x1E7A380", VA = "0x181E7B980", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B0A")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A770", Offset = "0x1E79170", VA = "0x181E7A770", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B0B")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C550", Offset = "0x1E7AF50", VA = "0x181E7C550", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B0C")]
				[Cpp2IlInjected.Address(RVA = "0x1E79080", Offset = "0x1E77A80", VA = "0x181E79080", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C8C")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4003090")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4003091")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003092")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003093")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4003094")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003095")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4003096")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003097")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4003098")]
				public const int BattlePassesUpdatedFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4003099")]
				private static readonly MapField<string, BattlePassSeasonData>.Codec _map_battlePassesUpdated_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400309A")]
				private readonly MapField<string, BattlePassSeasonData> battlePassesUpdated_;

				[Cpp2IlInjected.Token(Token = "0x400309B")]
				public const int BattlePassIdsNotFoundFieldNumber = 6;

				[Cpp2IlInjected.Token(Token = "0x400309C")]
				private static readonly FieldCodec<string> _repeated_battlePassIdsNotFound_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400309D")]
				private readonly RepeatedField<string> battlePassIdsNotFound_;

				[Cpp2IlInjected.Token(Token = "0x400309E")]
				public const int OnlineIdsRemappingFieldNumber = 7;

				[Cpp2IlInjected.Token(Token = "0x400309F")]
				private static readonly MapField<string, string>.Codec _map_onlineIdsRemapping_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40030A0")]
				private readonly MapField<string, string> onlineIdsRemapping_;

				[Cpp2IlInjected.Token(Token = "0x170012A6")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006B11")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F340", Offset = "0x1E8DD40", VA = "0x181E8F340")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012A7")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006B12")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F060", Offset = "0x1E8DA60", VA = "0x181E8F060")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012A8")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006B13")]
					[Cpp2IlInjected.Address(RVA = "0x1E8FD00", Offset = "0x1E8E700", VA = "0x181E8FD00", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012A9")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006B17")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B18")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012AA")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006B19")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006B1A")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012AB")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006B1B")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B1C")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012AC")]
				[DebuggerNonUserCode]
				public MapField<string, BattlePassSeasonData> BattlePassesUpdated
				{
					[Cpp2IlInjected.Token(Token = "0x6006B1D")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012AD")]
				[DebuggerNonUserCode]
				public RepeatedField<string> BattlePassIdsNotFound
				{
					[Cpp2IlInjected.Token(Token = "0x6006B1E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012AE")]
				[DebuggerNonUserCode]
				public MapField<string, string> OnlineIdsRemapping
				{
					[Cpp2IlInjected.Token(Token = "0x6006B1F")]
					[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012AF")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006B2B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B2C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012B0")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006B2D")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B2E")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006B14")]
				[Cpp2IlInjected.Address(RVA = "0x1E8E6B0", Offset = "0x1E8D0B0", VA = "0x181E8E6B0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B15")]
				[Cpp2IlInjected.Address(RVA = "0x1E8DCA0", Offset = "0x1E8C6A0", VA = "0x181E8DCA0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B16")]
				[Cpp2IlInjected.Address(RVA = "0x1E85750", Offset = "0x1E84150", VA = "0x181E85750", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B20")]
				[Cpp2IlInjected.Address(RVA = "0x1E85FA0", Offset = "0x1E849A0", VA = "0x181E85FA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B21")]
				[Cpp2IlInjected.Address(RVA = "0x1E85D50", Offset = "0x1E84750", VA = "0x181E85D50", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B22")]
				[Cpp2IlInjected.Address(RVA = "0x1E87FF0", Offset = "0x1E869F0", VA = "0x181E87FF0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B23")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B790", Offset = "0x1E8A190", VA = "0x181E8B790", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B24")]
				[Cpp2IlInjected.Address(RVA = "0x1E8BBD0", Offset = "0x1E8A5D0", VA = "0x181E8BBD0", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B25")]
				[Cpp2IlInjected.Address(RVA = "0x1E84030", Offset = "0x1E82A30", VA = "0x181E84030", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B26")]
				[Cpp2IlInjected.Address(RVA = "0x1E897F0", Offset = "0x1E881F0", VA = "0x181E897F0", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B27")]
				[Cpp2IlInjected.Address(RVA = "0x1E89BC0", Offset = "0x1E885C0", VA = "0x181E89BC0", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B28")]
				[Cpp2IlInjected.Address(RVA = "0x1E879E0", Offset = "0x1E863E0", VA = "0x181E879E0", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B29")]
				[Cpp2IlInjected.Address(RVA = "0x1E8AFF0", Offset = "0x1E899F0", VA = "0x181E8AFF0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B2A")]
				[Cpp2IlInjected.Address(RVA = "0x1E84B10", Offset = "0x1E83510", VA = "0x181E84B10", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B2F")]
				[Cpp2IlInjected.Address(RVA = "0x1E86CB0", Offset = "0x1E856B0", VA = "0x181E86CB0", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__59))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B30")]
				[Cpp2IlInjected.Address(RVA = "0x1E83260", Offset = "0x1E81C60", VA = "0x181E83260", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400307E")]
		private static readonly MessageParser<GetBattlePasses> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400307F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700129E")]
		[DebuggerNonUserCode]
		public static MessageParser<GetBattlePasses> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006AE7")]
			[Cpp2IlInjected.Address(RVA = "0x1D03000", Offset = "0x1D01A00", VA = "0x181D03000")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700129F")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006AE8")]
			[Cpp2IlInjected.Address(RVA = "0x1D02F30", Offset = "0x1D01930", VA = "0x181D02F30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012A0")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006AE9")]
			[Cpp2IlInjected.Address(RVA = "0x1D03060", Offset = "0x1D01A60", VA = "0x181D03060", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006AEA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GetBattlePasses()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006AEB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GetBattlePasses(GetBattlePasses other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006AEC")]
		[Cpp2IlInjected.Address(RVA = "0x1D02C50", Offset = "0x1D01650", VA = "0x181D02C50", Slot = "10")]
		[DebuggerNonUserCode]
		public GetBattlePasses Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GetBattlePasses getBattlePasses = default(GetBattlePasses);
			getBattlePasses.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (getBattlePasses._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return getBattlePasses;
		}

		[Cpp2IlInjected.Token(Token = "0x6006AED")]
		[Cpp2IlInjected.Address(RVA = "0x1D02CD0", Offset = "0x1D016D0", VA = "0x181D02CD0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006AEE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GetBattlePasses other)
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

		[Cpp2IlInjected.Token(Token = "0x6006AEF")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006AF0")]
		[Cpp2IlInjected.Address(RVA = "0x1D02DC0", Offset = "0x1D017C0", VA = "0x181D02DC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006AF1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006AF2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006AF3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GetBattlePasses other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006AF4")]
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

		[Cpp2IlInjected.Token(Token = "0x6006AF5")]
		[Cpp2IlInjected.Address(RVA = "0x1D02D50", Offset = "0x1D01750", VA = "0x181D02D50", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006AF6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006AF7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006AF8")]
		[Cpp2IlInjected.Address(RVA = "0x1D02E20", Offset = "0x1D01820", VA = "0x181D02E20")]
		static GetBattlePasses()
		{
			Func<GetBattlePasses> func = default(Func<GetBattlePasses>);
			_parser = (MessageParser<GetBattlePasses>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
