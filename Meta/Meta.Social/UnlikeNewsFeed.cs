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
	[Cpp2IlInjected.Token(Token = "0x2000C0A")]
	public sealed class UnlikeNewsFeed : IMessage<UnlikeNewsFeed>, IMessage, IEquatable<UnlikeNewsFeed>, IDeepCloneable<UnlikeNewsFeed>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C0B")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C0C")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002EC7")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4002EC8")]
				[OriginalName("PlayFabError")]
				PlayFabError,
				[Cpp2IlInjected.Token(Token = "0x4002EC9")]
				[OriginalName("ReviewNotFound")]
				ReviewNotFound,
				[Cpp2IlInjected.Token(Token = "0x4002ECA")]
				[OriginalName("UnknownError")]
				UnknownError
			}

			[Cpp2IlInjected.Token(Token = "0x2000C0D")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002ECB")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002ECC")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002ECD")]
				public const int UgcItemIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002ECE")]
				private string ugcItemId_;

				[Cpp2IlInjected.Token(Token = "0x170011CB")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006698")]
					[Cpp2IlInjected.Address(RVA = "0x1D70C40", Offset = "0x1D6F640", VA = "0x181D70C40")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011CC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006699")]
					[Cpp2IlInjected.Address(RVA = "0x1D70660", Offset = "0x1D6F060", VA = "0x181D70660")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011CD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600669A")]
					[Cpp2IlInjected.Address(RVA = "0x1D715A0", Offset = "0x1D6FFA0", VA = "0x181D715A0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011CE")]
				[DebuggerNonUserCode]
				public string UgcItemId
				{
					[Cpp2IlInjected.Token(Token = "0x600669E")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600669F")]
					[Cpp2IlInjected.Address(RVA = "0x1D71BA0", Offset = "0x1D705A0", VA = "0x181D71BA0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600669B")]
				[Cpp2IlInjected.Address(RVA = "0x1D701F0", Offset = "0x1D6EBF0", VA = "0x181D701F0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600669C")]
				[Cpp2IlInjected.Address(RVA = "0x1D6FDF0", Offset = "0x1D6E7F0", VA = "0x181D6FDF0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600669D")]
				[Cpp2IlInjected.Address(RVA = "0x1D6A150", Offset = "0x1D68B50", VA = "0x181D6A150", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60066A0")]
				[Cpp2IlInjected.Address(RVA = "0x1D6B000", Offset = "0x1D69A00", VA = "0x181D6B000", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60066A1")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60066A2")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60066A3")]
				[Cpp2IlInjected.Address(RVA = "0x1D6D4D0", Offset = "0x1D6BED0", VA = "0x181D6D4D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60066A4")]
				[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066A5")]
				[Cpp2IlInjected.Address(RVA = "0x1D69A40", Offset = "0x1D68440", VA = "0x181D69A40", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60066A6")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C5A0", Offset = "0x1D6AFA0", VA = "0x181D6C5A0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066A7")]
				[Cpp2IlInjected.Address(RVA = "0x1D6C180", Offset = "0x1D6AB80", VA = "0x181D6C180", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066A8")]
				[Cpp2IlInjected.Address(RVA = "0x1D6B970", Offset = "0x1D6A370", VA = "0x181D6B970", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60066A9")]
				[Cpp2IlInjected.Address(RVA = "0x1D6CEF0", Offset = "0x1D6B8F0", VA = "0x181D6CEF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066AA")]
				[Cpp2IlInjected.Address(RVA = "0x1D69C00", Offset = "0x1D68600", VA = "0x181D69C00", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C0F")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002ED0")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002ED1")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002ED2")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002ED3")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002ED4")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002ED5")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002ED6")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002ED7")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x170011CF")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60066AF")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F190", Offset = "0x1D7DB90", VA = "0x181D7F190")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D0")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60066B0")]
					[Cpp2IlInjected.Address(RVA = "0x1D7EA50", Offset = "0x1D7D450", VA = "0x181D7EA50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D1")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60066B1")]
					[Cpp2IlInjected.Address(RVA = "0x1D7F6F0", Offset = "0x1D7E0F0", VA = "0x181D7F6F0", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D2")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60066B5")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60066B6")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D3")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60066B7")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60066B8")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D4")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60066B9")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60066BA")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011D5")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x60066C6")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x60066C7")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60066B2")]
				[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066B3")]
				[Cpp2IlInjected.Address(RVA = "0x1D7DE50", Offset = "0x1D7C850", VA = "0x181D7DE50")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066B4")]
				[Cpp2IlInjected.Address(RVA = "0x1D774A0", Offset = "0x1D75EA0", VA = "0x181D774A0", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60066BB")]
				[Cpp2IlInjected.Address(RVA = "0x1D77E50", Offset = "0x1D76850", VA = "0x181D77E50", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60066BC")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60066BD")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60066BE")]
				[Cpp2IlInjected.Address(RVA = "0x1D7C1C0", Offset = "0x1D7ABC0", VA = "0x181D7C1C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60066BF")]
				[Cpp2IlInjected.Address(RVA = "0x89B730", Offset = "0x89A130", VA = "0x18089B730", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066C0")]
				[Cpp2IlInjected.Address(RVA = "0x1D75A70", Offset = "0x1D74470", VA = "0x181D75A70", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60066C1")]
				[Cpp2IlInjected.Address(RVA = "0x1D7A780", Offset = "0x1D79180", VA = "0x181D7A780", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066C2")]
				[Cpp2IlInjected.Address(RVA = "0x1D79FF0", Offset = "0x1D789F0", VA = "0x181D79FF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066C3")]
				[Cpp2IlInjected.Address(RVA = "0x1D784E0", Offset = "0x1D76EE0", VA = "0x181D784E0", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60066C4")]
				[Cpp2IlInjected.Address(RVA = "0x1D7B320", Offset = "0x1D79D20", VA = "0x181D7B320", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066C5")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60066C8")]
				[Cpp2IlInjected.Address(RVA = "0x1D78120", Offset = "0x1D76B20", VA = "0x181D78120", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__41))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002EC4")]
		private static readonly MessageParser<UnlikeNewsFeed> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002EC5")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170011C8")]
		[DebuggerNonUserCode]
		public static MessageParser<UnlikeNewsFeed> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006686")]
			[Cpp2IlInjected.Address(RVA = "0x15D7F60", Offset = "0x15D6960", VA = "0x1815D7F60")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011C9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006687")]
			[Cpp2IlInjected.Address(RVA = "0x15D7E90", Offset = "0x15D6890", VA = "0x1815D7E90")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011CA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006688")]
			[Cpp2IlInjected.Address(RVA = "0x15D7FC0", Offset = "0x15D69C0", VA = "0x1815D7FC0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006689")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public UnlikeNewsFeed()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x600668A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public UnlikeNewsFeed(UnlikeNewsFeed other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600668B")]
		[Cpp2IlInjected.Address(RVA = "0x15D7BB0", Offset = "0x15D65B0", VA = "0x1815D7BB0", Slot = "10")]
		[DebuggerNonUserCode]
		public UnlikeNewsFeed Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			UnlikeNewsFeed unlikeNewsFeed = default(UnlikeNewsFeed);
			unlikeNewsFeed.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (unlikeNewsFeed._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return unlikeNewsFeed;
		}

		[Cpp2IlInjected.Token(Token = "0x600668C")]
		[Cpp2IlInjected.Address(RVA = "0x15D7C30", Offset = "0x15D6630", VA = "0x1815D7C30", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600668D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(UnlikeNewsFeed other)
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

		[Cpp2IlInjected.Token(Token = "0x600668E")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600668F")]
		[Cpp2IlInjected.Address(RVA = "0x15D7D20", Offset = "0x15D6720", VA = "0x1815D7D20", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006690")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006691")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006692")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(UnlikeNewsFeed other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006693")]
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

		[Cpp2IlInjected.Token(Token = "0x6006694")]
		[Cpp2IlInjected.Address(RVA = "0x15D7CB0", Offset = "0x15D66B0", VA = "0x1815D7CB0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006695")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006696")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006697")]
		[Cpp2IlInjected.Address(RVA = "0x15D7D80", Offset = "0x15D6780", VA = "0x1815D7D80")]
		static UnlikeNewsFeed()
		{
			Func<UnlikeNewsFeed> func = default(Func<UnlikeNewsFeed>);
			_parser = (MessageParser<UnlikeNewsFeed>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
