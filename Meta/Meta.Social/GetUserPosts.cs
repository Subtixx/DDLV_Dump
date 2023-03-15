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
	[Cpp2IlInjected.Token(Token = "0x2000BF1")]
	public sealed class GetUserPosts : IMessage<GetUserPosts>, IMessage, IEquatable<GetUserPosts>, IDeepCloneable<GetUserPosts>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000BF2")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000BF3")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002E5A")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002E5B")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002E5C")]
				[OriginalName("EntityIdNotFound")]
				EntityIdNotFound = 2,
				[Cpp2IlInjected.Token(Token = "0x4002E5D")]
				[OriginalName("SearchFailed")]
				SearchFailed = 3,
				[Cpp2IlInjected.Token(Token = "0x4002E5E")]
				[OriginalName("SearchedItemsInvalid")]
				SearchedItemsInvalid = 4,
				[Cpp2IlInjected.Token(Token = "0x4002E5F")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000BF4")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002E60")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002E61")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002E62")]
				public const int EntityIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002E63")]
				private string entityId_;

				[Cpp2IlInjected.Token(Token = "0x4002E64")]
				public const int PlayfabIdFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002E65")]
				private string playfabId_;

				[Cpp2IlInjected.Token(Token = "0x4002E66")]
				public const int DisplayNameFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002E67")]
				private string displayName_;

				[Cpp2IlInjected.Token(Token = "0x17001196")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600659F")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE530", Offset = "0x1BFCF30", VA = "0x181BFE530")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001197")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60065A0")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE350", Offset = "0x1BFCD50", VA = "0x181BFE350")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001198")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60065A1")]
					[Cpp2IlInjected.Address(RVA = "0x1BFE710", Offset = "0x1BFD110", VA = "0x181BFE710", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001199")]
				[DebuggerNonUserCode]
				public string EntityId
				{
					[Cpp2IlInjected.Token(Token = "0x60065A5")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065A6")]
					[Cpp2IlInjected.Address(RVA = "0x1BFEC00", Offset = "0x1BFD600", VA = "0x181BFEC00")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700119A")]
				[DebuggerNonUserCode]
				public string PlayfabId
				{
					[Cpp2IlInjected.Token(Token = "0x60065A7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065A8")]
					[Cpp2IlInjected.Address(RVA = "0x1BFEC70", Offset = "0x1BFD670", VA = "0x181BFEC70")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700119B")]
				[DebuggerNonUserCode]
				public string DisplayName
				{
					[Cpp2IlInjected.Token(Token = "0x60065A9")]
					[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065AA")]
					[Cpp2IlInjected.Address(RVA = "0x1BFEB90", Offset = "0x1BFD590", VA = "0x181BFEB90")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60065A2")]
				[Cpp2IlInjected.Address(RVA = "0x1BFDC40", Offset = "0x1BFC640", VA = "0x181BFDC40")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065A3")]
				[Cpp2IlInjected.Address(RVA = "0x1BFDF80", Offset = "0x1BFC980", VA = "0x181BFDF80")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065A4")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9500", Offset = "0x1BF7F00", VA = "0x181BF9500", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60065AB")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9FA0", Offset = "0x1BF89A0", VA = "0x181BF9FA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60065AC")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9E30", Offset = "0x1BF8830", VA = "0x181BF9E30", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60065AD")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA590", Offset = "0x1BF8F90", VA = "0x181BFA590", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60065AE")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB7F0", Offset = "0x1BFA1F0", VA = "0x181BFB7F0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60065AF")]
				[Cpp2IlInjected.Address(RVA = "0x1BFD120", Offset = "0x1BFBB20", VA = "0x181BFD120", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065B0")]
				[Cpp2IlInjected.Address(RVA = "0x1BF91F0", Offset = "0x1BF7BF0", VA = "0x181BF91F0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60065B1")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA950", Offset = "0x1BF9350", VA = "0x181BFA950", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065B2")]
				[Cpp2IlInjected.Address(RVA = "0x1BFAAE0", Offset = "0x1BF94E0", VA = "0x181BFAAE0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065B3")]
				[Cpp2IlInjected.Address(RVA = "0x1BFA4F0", Offset = "0x1BF8EF0", VA = "0x181BFA4F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60065B4")]
				[Cpp2IlInjected.Address(RVA = "0x1BFB490", Offset = "0x1BF9E90", VA = "0x181BFB490", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065B5")]
				[Cpp2IlInjected.Address(RVA = "0x1BF9370", Offset = "0x1BF7D70", VA = "0x181BF9370", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000BF6")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002E69")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002E6A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002E6B")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002E6C")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002E6D")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002E6E")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002E6F")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002E70")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002E71")]
				public const int UsersPostFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4002E72")]
				private static readonly FieldCodec<NewsFeedPost> _repeated_usersPost_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002E73")]
				private readonly RepeatedField<NewsFeedPost> usersPost_;

				[Cpp2IlInjected.Token(Token = "0x1700119C")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60065BA")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A9A0", Offset = "0x1C093A0", VA = "0x181C0A9A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700119D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60065BB")]
					[Cpp2IlInjected.Address(RVA = "0x1C0A740", Offset = "0x1C09140", VA = "0x181C0A740")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700119E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60065BC")]
					[Cpp2IlInjected.Address(RVA = "0x1C0AD00", Offset = "0x1C09700", VA = "0x181C0AD00", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700119F")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60065C0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60065C1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011A0")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60065C2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60065C3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011A1")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60065C4")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60065C5")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011A2")]
				[DebuggerNonUserCode]
				public RepeatedField<NewsFeedPost> UsersPost
				{
					[Cpp2IlInjected.Token(Token = "0x60065C6")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011A3")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60065D2")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60065D3")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60065BD")]
				[Cpp2IlInjected.Address(RVA = "0x1C09AD0", Offset = "0x1C084D0", VA = "0x181C09AD0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065BE")]
				[Cpp2IlInjected.Address(RVA = "0x1C098B0", Offset = "0x1C082B0", VA = "0x181C098B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065BF")]
				[Cpp2IlInjected.Address(RVA = "0x1C04A20", Offset = "0x1C03420", VA = "0x181C04A20", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60065C7")]
				[Cpp2IlInjected.Address(RVA = "0x1C05600", Offset = "0x1C04000", VA = "0x181C05600", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60065C8")]
				[Cpp2IlInjected.Address(RVA = "0x1C04EF0", Offset = "0x1C038F0", VA = "0x181C04EF0", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60065C9")]
				[Cpp2IlInjected.Address(RVA = "0x1C05FB0", Offset = "0x1C049B0", VA = "0x181C05FB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60065CA")]
				[Cpp2IlInjected.Address(RVA = "0x1C07DD0", Offset = "0x1C067D0", VA = "0x181C07DD0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60065CB")]
				[Cpp2IlInjected.Address(RVA = "0x1C08AC0", Offset = "0x1C074C0", VA = "0x181C08AC0", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065CC")]
				[Cpp2IlInjected.Address(RVA = "0x1C040E0", Offset = "0x1C02AE0", VA = "0x181C040E0", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60065CD")]
				[Cpp2IlInjected.Address(RVA = "0x1C06270", Offset = "0x1C04C70", VA = "0x181C06270", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065CE")]
				[Cpp2IlInjected.Address(RVA = "0x1C068D0", Offset = "0x1C052D0", VA = "0x181C068D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065CF")]
				[Cpp2IlInjected.Address(RVA = "0x1C05EB0", Offset = "0x1C048B0", VA = "0x181C05EB0", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60065D0")]
				[Cpp2IlInjected.Address(RVA = "0x1C07750", Offset = "0x1C06150", VA = "0x181C07750", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065D1")]
				[Cpp2IlInjected.Address(RVA = "0x1C04780", Offset = "0x1C03180", VA = "0x181C04780", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60065D4")]
				[Cpp2IlInjected.Address(RVA = "0x1C05700", Offset = "0x1C04100", VA = "0x181C05700", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__46))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002E57")]
		private static readonly MessageParser<GetUserPosts> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002E58")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001193")]
		[DebuggerNonUserCode]
		public static MessageParser<GetUserPosts> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600658D")]
			[Cpp2IlInjected.Address(RVA = "0x1D053E0", Offset = "0x1D03DE0", VA = "0x181D053E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001194")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600658E")]
			[Cpp2IlInjected.Address(RVA = "0x1D05310", Offset = "0x1D03D10", VA = "0x181D05310")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001195")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600658F")]
			[Cpp2IlInjected.Address(RVA = "0x1D05440", Offset = "0x1D03E40", VA = "0x181D05440", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006590")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public GetUserPosts()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006591")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public GetUserPosts(GetUserPosts other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006592")]
		[Cpp2IlInjected.Address(RVA = "0x1D05030", Offset = "0x1D03A30", VA = "0x181D05030", Slot = "10")]
		[DebuggerNonUserCode]
		public GetUserPosts Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			GetUserPosts getUserPosts = default(GetUserPosts);
			getUserPosts.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (getUserPosts._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return getUserPosts;
		}

		[Cpp2IlInjected.Token(Token = "0x6006593")]
		[Cpp2IlInjected.Address(RVA = "0x1D050B0", Offset = "0x1D03AB0", VA = "0x181D050B0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006594")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(GetUserPosts other)
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

		[Cpp2IlInjected.Token(Token = "0x6006595")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006596")]
		[Cpp2IlInjected.Address(RVA = "0x1D051A0", Offset = "0x1D03BA0", VA = "0x181D051A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006597")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006598")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006599")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(GetUserPosts other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600659A")]
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

		[Cpp2IlInjected.Token(Token = "0x600659B")]
		[Cpp2IlInjected.Address(RVA = "0x1D05130", Offset = "0x1D03B30", VA = "0x181D05130", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600659C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600659D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600659E")]
		[Cpp2IlInjected.Address(RVA = "0x1D05200", Offset = "0x1D03C00", VA = "0x181D05200")]
		static GetUserPosts()
		{
			Func<GetUserPosts> func = default(Func<GetUserPosts>);
			_parser = (MessageParser<GetUserPosts>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
