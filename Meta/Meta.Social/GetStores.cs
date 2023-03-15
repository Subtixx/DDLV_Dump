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
	[Cpp2IlInjected.Token(Token = "0x2000C9D")]
	public sealed class GetStores : IMessage<GetStores>, IMessage, IEquatable<GetStores>, IDeepCloneable<GetStores>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C9E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C9F")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40030E5")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x40030E6")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x40030E7")]
				[OriginalName("CurrencyNotFound")]
				CurrencyNotFound = 2,
				[Cpp2IlInjected.Token(Token = "0x40030E8")]
				[OriginalName("SearchConfigError")]
				SearchConfigError = 3,
				[Cpp2IlInjected.Token(Token = "0x40030E9")]
				[OriginalName("InvalidCloudScriptResult")]
				InvalidCloudScriptResult = 4,
				[Cpp2IlInjected.Token(Token = "0x40030EA")]
				[OriginalName("InvalidConfig")]
				InvalidConfig = 5,
				[Cpp2IlInjected.Token(Token = "0x40030EB")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000CA0")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, ILiveopsRequestBase, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x40030EC")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40030ED")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40030EE")]
				public const int KnownItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40030EF")]
				private static readonly FieldCodec<KnownLiveopsItem> _repeated_knownItems_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40030F0")]
				private readonly RepeatedField<KnownLiveopsItem> knownItems_;

				[Cpp2IlInjected.Token(Token = "0x40030F1")]
				public const int IncludeScheduledFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40030F2")]
				private bool includeScheduled_;

				[Cpp2IlInjected.Token(Token = "0x170012C6")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006BAF")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE6B0", Offset = "0x1BFD0B0", VA = "0x181BFE6B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012C7")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006BB0")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE3D0", Offset = "0x1BFCDD0", VA = "0x181BFE3D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012C8")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006BB1")]
					[Cpp2IlInjected.Address(RVA = "0x1BFEA10", Offset = "0x1BFD410", VA = "0x181BFEA10", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012C9")]
				[DebuggerNonUserCode]
				public RepeatedField<KnownLiveopsItem> KnownItems
				{
					[Cpp2IlInjected.Token(Token = "0x6006BB5")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012CA")]
				[DebuggerNonUserCode]
				public bool IncludeScheduled
				{
					[Cpp2IlInjected.Token(Token = "0x6006BB6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "15")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006BB7")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006BB2")]
				[Cpp2IlInjected.Address(RVA = "0x1BFE080", Offset = "0x1BFCA80", VA = "0x181BFE080")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BB3")]
				[Cpp2IlInjected.Address(RVA = "0x1BFDEF0", Offset = "0x1BFC8F0", VA = "0x181BFDEF0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BB4")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9720", Offset = "0x1BF8120", VA = "0x181BF9720", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006BB8")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9EC0", Offset = "0x1BF88C0", VA = "0x181BF9EC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006BB9")]
				[Cpp2IlInjected.Address(RVA = "0x1BF99E0", Offset = "0x1BF83E0", VA = "0x181BF99E0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006BBA")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA7F0", Offset = "0x1BF91F0", VA = "0x181BFA7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006BBB")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB850", Offset = "0x1BFA250", VA = "0x181BFB850", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006BBC")]
				[Cpp2IlInjected.Address(RVA = "0x1BFD040", Offset = "0x1BFBA40", VA = "0x181BFD040", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BBD")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9070", Offset = "0x1BF7A70", VA = "0x181BF9070", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006BBE")]
				[Cpp2IlInjected.Address(RVA = "0x1BFABB0", Offset = "0x1BF95B0", VA = "0x181BFABB0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BBF")]
				[Cpp2IlInjected.Address(RVA = "0x1BFAD60", Offset = "0x1BF9760", VA = "0x181BFAD60", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BC0")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA1F0", Offset = "0x1BF8BF0", VA = "0x181BFA1F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006BC1")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB3C0", Offset = "0x1BF9DC0", VA = "0x181BFB3C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BC2")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9300", Offset = "0x1BF7D00", VA = "0x181BF9300", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000CA2")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x40030F4")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40030F5")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40030F6")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40030F7")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40030F8")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40030F9")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40030FA")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40030FB")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x40030FC")]
				public const int StoresUpdatedFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x40030FD")]
				private static readonly MapField<string, OnlineStoreData>.Codec _map_storesUpdated_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40030FE")]
				private readonly MapField<string, OnlineStoreData> storesUpdated_;

				[Cpp2IlInjected.Token(Token = "0x40030FF")]
				public const int StoresIdsNotFoundFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x4003100")]
				private static readonly FieldCodec<string> _repeated_storesIdsNotFound_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4003101")]
				private readonly RepeatedField<string> storesIdsNotFound_;

				[Cpp2IlInjected.Token(Token = "0x170012CB")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006BC7")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A8E0", Offset = "0x1C092E0", VA = "0x181C0A8E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012CC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006BC8")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A540", Offset = "0x1C08F40", VA = "0x181C0A540")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012CD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006BC9")]
					[Cpp2IlInjected.Address(RVA = "0x1C0AC40", Offset = "0x1C09640", VA = "0x181C0AC40", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012CE")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006BCD")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006BCE")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012CF")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006BCF")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006BD0")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012D0")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006BD1")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006BD2")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012D1")]
				[DebuggerNonUserCode]
				public MapField<string, OnlineStoreData> StoresUpdated
				{
					[Cpp2IlInjected.Token(Token = "0x6006BD3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012D2")]
				[DebuggerNonUserCode]
				public RepeatedField<string> StoresIdsNotFound
				{
					[Cpp2IlInjected.Token(Token = "0x6006BD4")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012D3")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006BE0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006BE1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012D4")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006BE2")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006BE3")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006BCA")]
				[Cpp2IlInjected.Address(RVA = "0x1C0A110", Offset = "0x1C08B10", VA = "0x181C0A110")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BCB")]
				[Cpp2IlInjected.Address(RVA = "0x1C09EC0", Offset = "0x1C088C0", VA = "0x181C09EC0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BCC")]
				[Cpp2IlInjected.Address(RVA = "0x1C04E90", Offset = "0x1C03890", VA = "0x181C04E90", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006BD5")]
				[Cpp2IlInjected.Address(RVA = "0x1C051C0", Offset = "0x1C03BC0", VA = "0x181C051C0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006BD6")]
				[Cpp2IlInjected.Address(RVA = "0x1C050E0", Offset = "0x1C03AE0", VA = "0x181C050E0", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006BD7")]
				[Cpp2IlInjected.Address(RVA = "0xD0A9A0", Offset = "0xD093A0", VA = "0x180D0A9A0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006BD8")]
				[Cpp2IlInjected.Address(RVA = "0x1C07CB0", Offset = "0x1C066B0", VA = "0x181C07CB0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006BD9")]
				[Cpp2IlInjected.Address(RVA = "0x1C08DC0", Offset = "0x1C077C0", VA = "0x181C08DC0", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BDA")]
				[Cpp2IlInjected.Address(RVA = "0x1C03F50", Offset = "0x1C02950", VA = "0x181C03F50", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006BDB")]
				[Cpp2IlInjected.Address(RVA = "0x1C070B0", Offset = "0x1C05AB0", VA = "0x181C070B0", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BDC")]
				[Cpp2IlInjected.Address(RVA = "0x1C06CE0", Offset = "0x1C056E0", VA = "0x181C06CE0", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BDD")]
				[Cpp2IlInjected.Address(RVA = "0x1C05CD0", Offset = "0x1C046D0", VA = "0x181C05CD0", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006BDE")]
				[Cpp2IlInjected.Address(RVA = "0x1C078D0", Offset = "0x1C062D0", VA = "0x181C078D0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BDF")]
				[Cpp2IlInjected.Address(RVA = "0x1C04930", Offset = "0x1C03330", VA = "0x181C04930", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006BE4")]
				[Cpp2IlInjected.Address(RVA = "0x1C05840", Offset = "0x1C04240", VA = "0x181C05840", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__54))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006BE5")]
				[Cpp2IlInjected.Address(RVA = "0x1C00620", Offset = "0x1BFF020", VA = "0x181C00620", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40030E2")]
		private static readonly MessageParser<GetStores> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40030E3")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170012C3")]
		[DebuggerNonUserCode]
		public static MessageParser<GetStores> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006B9D")]
			[Cpp2IlInjected.Address(RVA = "0x1D04EC0", Offset = "0x1D038C0", VA = "0x181D04EC0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006B9E")]
			[Cpp2IlInjected.Address(RVA = "0x1D04DF0", Offset = "0x1D037F0", VA = "0x181D04DF0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012C5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006B9F")]
			[Cpp2IlInjected.Address(RVA = "0x1D04F20", Offset = "0x1D03920", VA = "0x181D04F20", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006BA0")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GetStores()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006BA1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GetStores(GetStores other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006BA2")]
		[Cpp2IlInjected.Address(RVA = "0x1D04B10", Offset = "0x1D03510", VA = "0x181D04B10", Slot = "10")]
		[DebuggerNonUserCode]
		public GetStores Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GetStores getStores = default(GetStores);
			getStores.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (getStores._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return getStores;
		}

		[Cpp2IlInjected.Token(Token = "0x6006BA3")]
		[Cpp2IlInjected.Address(RVA = "0x1D04B90", Offset = "0x1D03590", VA = "0x181D04B90", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006BA4")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GetStores other)
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

		[Cpp2IlInjected.Token(Token = "0x6006BA5")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006BA6")]
		[Cpp2IlInjected.Address(RVA = "0x1D04C80", Offset = "0x1D03680", VA = "0x181D04C80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006BA7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006BA8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006BA9")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GetStores other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006BAA")]
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

		[Cpp2IlInjected.Token(Token = "0x6006BAB")]
		[Cpp2IlInjected.Address(RVA = "0x1D04C10", Offset = "0x1D03610", VA = "0x181D04C10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006BAC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006BAD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006BAE")]
		[Cpp2IlInjected.Address(RVA = "0x1D04CE0", Offset = "0x1D036E0", VA = "0x181D04CE0")]
		static GetStores()
		{
			Func<GetStores> func = default(Func<GetStores>);
			_parser = (MessageParser<GetStores>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
