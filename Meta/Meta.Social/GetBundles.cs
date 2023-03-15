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
	[Cpp2IlInjected.Token(Token = "0x2000C92")]
	public sealed class GetBundles : IMessage<GetBundles>, IMessage, IEquatable<GetBundles>, IDeepCloneable<GetBundles>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C93")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C94")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40030B7")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x40030B8")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x40030B9")]
				[OriginalName("CurrencyNotFound")]
				CurrencyNotFound = 2,
				[Cpp2IlInjected.Token(Token = "0x40030BA")]
				[OriginalName("SearchConfigError")]
				SearchConfigError = 3,
				[Cpp2IlInjected.Token(Token = "0x40030BB")]
				[OriginalName("InvalidCloudScriptResult")]
				InvalidCloudScriptResult = 4,
				[Cpp2IlInjected.Token(Token = "0x40030BC")]
				[OriginalName("InvalidConfig")]
				InvalidConfig = 5,
				[Cpp2IlInjected.Token(Token = "0x40030BD")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000C95")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, ILiveopsRequestBase, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x40030BE")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40030BF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40030C0")]
				public const int KnownItemsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40030C1")]
				private static readonly FieldCodec<KnownLiveopsItem> _repeated_knownItems_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40030C2")]
				private readonly RepeatedField<KnownLiveopsItem> knownItems_;

				[Cpp2IlInjected.Token(Token = "0x40030C3")]
				public const int IncludeScheduledFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40030C4")]
				private bool includeScheduled_;

				[Cpp2IlInjected.Token(Token = "0x170012B4")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006B55")]
					[Cpp2IlInjected.Address(RVA = "0x1E80030", Offset = "0x1E7EA30", VA = "0x181E80030")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012B5")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006B56")]
					[Cpp2IlInjected.Address(RVA = "0x1E7F910", Offset = "0x1E7E310", VA = "0x181E7F910")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012B6")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006B57")]
					[Cpp2IlInjected.Address(RVA = "0x1E80750", Offset = "0x1E7F150", VA = "0x181E80750", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012B7")]
				[DebuggerNonUserCode]
				public RepeatedField<KnownLiveopsItem> KnownItems
				{
					[Cpp2IlInjected.Token(Token = "0x6006B5B")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0", Slot = "14")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012B8")]
				[DebuggerNonUserCode]
				public bool IncludeScheduled
				{
					[Cpp2IlInjected.Token(Token = "0x6006B5C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2380", Offset = "0x5C0D80", VA = "0x1805C2380", Slot = "15")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B5D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2510", Offset = "0x5C0F10", VA = "0x1805C2510")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006B58")]
				[Cpp2IlInjected.Address(RVA = "0x1E7EE20", Offset = "0x1E7D820", VA = "0x181E7EE20")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B59")]
				[Cpp2IlInjected.Address(RVA = "0x1E7F680", Offset = "0x1E7E080", VA = "0x181E7F680")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B5A")]
				[Cpp2IlInjected.Address(RVA = "0x1E793B0", Offset = "0x1E77DB0", VA = "0x181E793B0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B5E")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A5F0", Offset = "0x1E78FF0", VA = "0x181E7A5F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B5F")]
				[Cpp2IlInjected.Address(RVA = "0x1E7A150", Offset = "0x1E78B50", VA = "0x181E7A150", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B60")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA7F0", Offset = "0x1BF91F0", VA = "0x181BFA7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B61")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C9F0", Offset = "0x1E7B3F0", VA = "0x181E7C9F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B62")]
				[Cpp2IlInjected.Address(RVA = "0x1E7DCC0", Offset = "0x1E7C6C0", VA = "0x181E7DCC0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B63")]
				[Cpp2IlInjected.Address(RVA = "0x1E789C0", Offset = "0x1E773C0", VA = "0x181E789C0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B64")]
				[Cpp2IlInjected.Address(RVA = "0x1E7BDE0", Offset = "0x1E7A7E0", VA = "0x181E7BDE0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B65")]
				[Cpp2IlInjected.Address(RVA = "0x1E7B500", Offset = "0x1E79F00", VA = "0x181E7B500", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B66")]
				[Cpp2IlInjected.Address(RVA = "0x1E7AC90", Offset = "0x1E79690", VA = "0x181E7AC90", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B67")]
				[Cpp2IlInjected.Address(RVA = "0x1E7C620", Offset = "0x1E7B020", VA = "0x181E7C620", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B68")]
				[Cpp2IlInjected.Address(RVA = "0x1E79150", Offset = "0x1E77B50", VA = "0x181E79150", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C97")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x40030C6")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40030C7")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40030C8")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40030C9")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40030CA")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40030CB")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x40030CC")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40030CD")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x40030CE")]
				public const int BundlesUpdatedFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x40030CF")]
				private static readonly MapField<string, OnlineBundleData>.Codec _map_bundlesUpdated_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40030D0")]
				private readonly MapField<string, OnlineBundleData> bundlesUpdated_;

				[Cpp2IlInjected.Token(Token = "0x40030D1")]
				public const int BundlesIdsNotFoundFieldNumber = 5;

				[Cpp2IlInjected.Token(Token = "0x40030D2")]
				private static readonly FieldCodec<string> _repeated_bundlesIdsNotFound_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40030D3")]
				private readonly RepeatedField<string> bundlesIdsNotFound_;

				[Cpp2IlInjected.Token(Token = "0x170012B9")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006B6D")]
					[Cpp2IlInjected.Address(RVA = "0x1E8F3A0", Offset = "0x1E8DDA0", VA = "0x181E8F3A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012BA")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006B6E")]
					[Cpp2IlInjected.Address(RVA = "0x1E8EE60", Offset = "0x1E8D860", VA = "0x181E8EE60")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012BB")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006B6F")]
					[Cpp2IlInjected.Address(RVA = "0x1E8FE80", Offset = "0x1E8E880", VA = "0x181E8FE80", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012BC")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006B73")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B74")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012BD")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006B75")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006B76")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012BE")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006B77")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B78")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012BF")]
				[DebuggerNonUserCode]
				public MapField<string, OnlineBundleData> BundlesUpdated
				{
					[Cpp2IlInjected.Token(Token = "0x6006B79")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012C0")]
				[DebuggerNonUserCode]
				public RepeatedField<string> BundlesIdsNotFound
				{
					[Cpp2IlInjected.Token(Token = "0x6006B7A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012C1")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006B86")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B87")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170012C2")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006B88")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006B89")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006B70")]
				[Cpp2IlInjected.Address(RVA = "0x1E8D9E0", Offset = "0x1E8C3E0", VA = "0x181E8D9E0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B71")]
				[Cpp2IlInjected.Address(RVA = "0x1E8E240", Offset = "0x1E8CC40", VA = "0x181E8E240")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B72")]
				[Cpp2IlInjected.Address(RVA = "0x1E84FD0", Offset = "0x1E839D0", VA = "0x181E84FD0", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B7B")]
				[Cpp2IlInjected.Address(RVA = "0x1E85E70", Offset = "0x1E84870", VA = "0x181E85E70", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B7C")]
				[Cpp2IlInjected.Address(RVA = "0x1E86240", Offset = "0x1E84C40", VA = "0x181E86240", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B7D")]
				[Cpp2IlInjected.Address(RVA = "0xD0A9A0", Offset = "0xD093A0", VA = "0x180D0A9A0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B7E")]
				[Cpp2IlInjected.Address(RVA = "0x1E8B6D0", Offset = "0x1E8A0D0", VA = "0x181E8B6D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B7F")]
				[Cpp2IlInjected.Address(RVA = "0x1E8BF50", Offset = "0x1E8A950", VA = "0x181E8BF50", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B80")]
				[Cpp2IlInjected.Address(RVA = "0x1E83CE0", Offset = "0x1E826E0", VA = "0x181E83CE0", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006B81")]
				[Cpp2IlInjected.Address(RVA = "0x1E89190", Offset = "0x1E87B90", VA = "0x181E89190", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B82")]
				[Cpp2IlInjected.Address(RVA = "0x1E8A0A0", Offset = "0x1E88AA0", VA = "0x181E8A0A0", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B83")]
				[Cpp2IlInjected.Address(RVA = "0x1E871F0", Offset = "0x1E85BF0", VA = "0x181E871F0", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B84")]
				[Cpp2IlInjected.Address(RVA = "0x1E8A640", Offset = "0x1E89040", VA = "0x181E8A640", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B85")]
				[Cpp2IlInjected.Address(RVA = "0x1E84C20", Offset = "0x1E83620", VA = "0x181E84C20", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006B8A")]
				[Cpp2IlInjected.Address(RVA = "0x1E870A0", Offset = "0x1E85AA0", VA = "0x181E870A0", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__54))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006B8B")]
				[Cpp2IlInjected.Address(RVA = "0x1E836F0", Offset = "0x1E820F0", VA = "0x181E836F0", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40030B4")]
		private static readonly MessageParser<GetBundles> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40030B5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170012B1")]
		[DebuggerNonUserCode]
		public static MessageParser<GetBundles> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006B43")]
			[Cpp2IlInjected.Address(RVA = "0x1D03520", Offset = "0x1D01F20", VA = "0x181D03520")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B2")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006B44")]
			[Cpp2IlInjected.Address(RVA = "0x1D03450", Offset = "0x1D01E50", VA = "0x181D03450")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B3")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006B45")]
			[Cpp2IlInjected.Address(RVA = "0x1D03580", Offset = "0x1D01F80", VA = "0x181D03580", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006B46")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GetBundles()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006B47")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GetBundles(GetBundles other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006B48")]
		[Cpp2IlInjected.Address(RVA = "0x1D03170", Offset = "0x1D01B70", VA = "0x181D03170", Slot = "10")]
		[DebuggerNonUserCode]
		public GetBundles Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GetBundles getBundles = default(GetBundles);
			getBundles.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (getBundles._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return getBundles;
		}

		[Cpp2IlInjected.Token(Token = "0x6006B49")]
		[Cpp2IlInjected.Address(RVA = "0x1D031F0", Offset = "0x1D01BF0", VA = "0x181D031F0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006B4A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GetBundles other)
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

		[Cpp2IlInjected.Token(Token = "0x6006B4B")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006B4C")]
		[Cpp2IlInjected.Address(RVA = "0x1D032E0", Offset = "0x1D01CE0", VA = "0x181D032E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006B4D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006B4E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006B4F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GetBundles other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006B50")]
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

		[Cpp2IlInjected.Token(Token = "0x6006B51")]
		[Cpp2IlInjected.Address(RVA = "0x1D03270", Offset = "0x1D01C70", VA = "0x181D03270", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006B52")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006B53")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006B54")]
		[Cpp2IlInjected.Address(RVA = "0x1D03340", Offset = "0x1D01D40", VA = "0x181D03340")]
		static GetBundles()
		{
			Func<GetBundles> func = default(Func<GetBundles>);
			_parser = (MessageParser<GetBundles>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
