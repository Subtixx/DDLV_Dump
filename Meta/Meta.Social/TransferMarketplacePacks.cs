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
	[Cpp2IlInjected.Token(Token = "0x2000B78")]
	public sealed class TransferMarketplacePacks : IMessage<TransferMarketplacePacks>, IMessage, IEquatable<TransferMarketplacePacks>, IDeepCloneable<TransferMarketplacePacks>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000B79")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000B7A")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002C7D")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002C7E")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002C7F")]
				[OriginalName("InvalidSourceEntityToken")]
				InvalidSourceEntityToken = 2,
				[Cpp2IlInjected.Token(Token = "0x4002C80")]
				[OriginalName("MissingGameloftIdLink")]
				MissingGameloftIdLink = 3,
				[Cpp2IlInjected.Token(Token = "0x4002C81")]
				[OriginalName("GetUserAccountInfoFailed")]
				GetUserAccountInfoFailed = 4,
				[Cpp2IlInjected.Token(Token = "0x4002C82")]
				[OriginalName("GameloftIdMismatch")]
				GameloftIdMismatch = 5,
				[Cpp2IlInjected.Token(Token = "0x4002C83")]
				[OriginalName("GetInventoryMarketplacePurchasesFailed")]
				GetInventoryMarketplacePurchasesFailed = 6,
				[Cpp2IlInjected.Token(Token = "0x4002C84")]
				[OriginalName("NoPacksFound")]
				NoPacksFound = 7,
				[Cpp2IlInjected.Token(Token = "0x4002C85")]
				[OriginalName("TransferFailed")]
				TransferFailed = 8,
				[Cpp2IlInjected.Token(Token = "0x4002C86")]
				[OriginalName("ResetFailed")]
				ResetFailed = 9,
				[Cpp2IlInjected.Token(Token = "0x4002C87")]
				[OriginalName("UnknownError")]
				UnknownError = 15
			}

			[Cpp2IlInjected.Token(Token = "0x2000B7B")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002C88")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002C89")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002C8A")]
				public const int SourceEntityTokenFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002C8B")]
				private string sourceEntityToken_;

				[Cpp2IlInjected.Token(Token = "0x4002C8C")]
				public const int GameloftIdLinkFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002C8D")]
				private string gameloftIdLink_;

				[Cpp2IlInjected.Token(Token = "0x170010B6")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600614A")]
					[Cpp2IlInjected.Address(RVA = "0x899E90", Offset = "0x898890", VA = "0x180899E90")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010B7")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600614B")]
					[Cpp2IlInjected.Address(RVA = "0x899E10", Offset = "0x898810", VA = "0x180899E10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010B8")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600614C")]
					[Cpp2IlInjected.Address(RVA = "0x89A010", Offset = "0x898A10", VA = "0x18089A010", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010B9")]
				[DebuggerNonUserCode]
				public string SourceEntityToken
				{
					[Cpp2IlInjected.Token(Token = "0x6006150")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006151")]
					[Cpp2IlInjected.Address(RVA = "0x89A140", Offset = "0x898B40", VA = "0x18089A140")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010BA")]
				[DebuggerNonUserCode]
				public string GameloftIdLink
				{
					[Cpp2IlInjected.Token(Token = "0x6006152")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006153")]
					[Cpp2IlInjected.Address(RVA = "0x89A0D0", Offset = "0x898AD0", VA = "0x18089A0D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600614D")]
				[Cpp2IlInjected.Address(RVA = "0x899B40", Offset = "0x898540", VA = "0x180899B40")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600614E")]
				[Cpp2IlInjected.Address(RVA = "0x899CC0", Offset = "0x8986C0", VA = "0x180899CC0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600614F")]
				[Cpp2IlInjected.Address(RVA = "0x898CE0", Offset = "0x8976E0", VA = "0x180898CE0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006154")]
				[Cpp2IlInjected.Address(RVA = "0x898E80", Offset = "0x897880", VA = "0x180898E80", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006155")]
				[Cpp2IlInjected.Address(RVA = "0x7BCC20", Offset = "0x7BB620", VA = "0x1807BCC20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006156")]
				[Cpp2IlInjected.Address(RVA = "0x7BCD30", Offset = "0x7BB730", VA = "0x1807BCD30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006157")]
				[Cpp2IlInjected.Address(RVA = "0x899680", Offset = "0x898080", VA = "0x180899680", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006158")]
				[Cpp2IlInjected.Address(RVA = "0x7BD060", Offset = "0x7BBA60", VA = "0x1807BD060", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006159")]
				[Cpp2IlInjected.Address(RVA = "0x8988D0", Offset = "0x8972D0", VA = "0x1808988D0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600615A")]
				[Cpp2IlInjected.Address(RVA = "0x899210", Offset = "0x897C10", VA = "0x180899210", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600615B")]
				[Cpp2IlInjected.Address(RVA = "0x899390", Offset = "0x897D90", VA = "0x180899390", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600615C")]
				[Cpp2IlInjected.Address(RVA = "0x8990F0", Offset = "0x897AF0", VA = "0x1808990F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600615D")]
				[Cpp2IlInjected.Address(RVA = "0x899510", Offset = "0x897F10", VA = "0x180899510", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600615E")]
				[Cpp2IlInjected.Address(RVA = "0x898B70", Offset = "0x897570", VA = "0x180898B70", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000B7D")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002C8F")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002C90")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002C91")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002C92")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002C93")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002C94")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002C95")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002C96")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x170010BB")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006163")]
					[Cpp2IlInjected.Address(RVA = "0x89BDD0", Offset = "0x89A7D0", VA = "0x18089BDD0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010BC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006164")]
					[Cpp2IlInjected.Address(RVA = "0x89BD50", Offset = "0x89A750", VA = "0x18089BD50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010BD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006165")]
					[Cpp2IlInjected.Address(RVA = "0x89BF50", Offset = "0x89A950", VA = "0x18089BF50", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010BE")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006169")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x600616A")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010BF")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x600616B")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600616C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010C0")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x600616D")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600616E")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170010C1")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x600617A")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600617B")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006166")]
				[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006167")]
				[Cpp2IlInjected.Address(RVA = "0x89BB80", Offset = "0x89A580", VA = "0x18089BB80")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006168")]
				[Cpp2IlInjected.Address(RVA = "0x89A8C0", Offset = "0x8992C0", VA = "0x18089A8C0", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600616F")]
				[Cpp2IlInjected.Address(RVA = "0x89AA40", Offset = "0x899440", VA = "0x18089AA40", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006170")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006171")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006172")]
				[Cpp2IlInjected.Address(RVA = "0x89B670", Offset = "0x89A070", VA = "0x18089B670", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006173")]
				[Cpp2IlInjected.Address(RVA = "0x89B730", Offset = "0x89A130", VA = "0x18089B730", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006174")]
				[Cpp2IlInjected.Address(RVA = "0x89A540", Offset = "0x898F40", VA = "0x18089A540", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006175")]
				[Cpp2IlInjected.Address(RVA = "0x89B1D0", Offset = "0x899BD0", VA = "0x18089B1D0", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006176")]
				[Cpp2IlInjected.Address(RVA = "0x89B0C0", Offset = "0x899AC0", VA = "0x18089B0C0", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006177")]
				[Cpp2IlInjected.Address(RVA = "0x89AD70", Offset = "0x899770", VA = "0x18089AD70", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006178")]
				[Cpp2IlInjected.Address(RVA = "0x89B470", Offset = "0x899E70", VA = "0x18089B470", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006179")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600617C")]
				[Cpp2IlInjected.Address(RVA = "0x89AC30", Offset = "0x899630", VA = "0x18089AC30", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__41))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002C7A")]
		private static readonly MessageParser<TransferMarketplacePacks> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002C7B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170010B3")]
		[DebuggerNonUserCode]
		public static MessageParser<TransferMarketplacePacks> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006138")]
			[Cpp2IlInjected.Address(RVA = "0x15D0FB0", Offset = "0x15CF9B0", VA = "0x1815D0FB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B4")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006139")]
			[Cpp2IlInjected.Address(RVA = "0x15D0EE0", Offset = "0x15CF8E0", VA = "0x1815D0EE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170010B5")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600613A")]
			[Cpp2IlInjected.Address(RVA = "0x15D1010", Offset = "0x15CFA10", VA = "0x1815D1010", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600613B")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public TransferMarketplacePacks()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600613C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public TransferMarketplacePacks(TransferMarketplacePacks other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600613D")]
		[Cpp2IlInjected.Address(RVA = "0x15D0C00", Offset = "0x15CF600", VA = "0x1815D0C00", Slot = "10")]
		[DebuggerNonUserCode]
		public TransferMarketplacePacks Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			TransferMarketplacePacks transferMarketplacePacks = default(TransferMarketplacePacks);
			transferMarketplacePacks.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (transferMarketplacePacks._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return transferMarketplacePacks;
		}

		[Cpp2IlInjected.Token(Token = "0x600613E")]
		[Cpp2IlInjected.Address(RVA = "0x15D0C80", Offset = "0x15CF680", VA = "0x1815D0C80", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600613F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(TransferMarketplacePacks other)
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

		[Cpp2IlInjected.Token(Token = "0x6006140")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006141")]
		[Cpp2IlInjected.Address(RVA = "0x15D0D70", Offset = "0x15CF770", VA = "0x1815D0D70", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006142")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006143")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006144")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(TransferMarketplacePacks other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006145")]
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

		[Cpp2IlInjected.Token(Token = "0x6006146")]
		[Cpp2IlInjected.Address(RVA = "0x15D0D00", Offset = "0x15CF700", VA = "0x1815D0D00", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006147")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006148")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006149")]
		[Cpp2IlInjected.Address(RVA = "0x15D0DD0", Offset = "0x15CF7D0", VA = "0x1815D0DD0")]
		static TransferMarketplacePacks()
		{
			Func<TransferMarketplacePacks> func = default(Func<TransferMarketplacePacks>);
			_parser = (MessageParser<TransferMarketplacePacks>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
