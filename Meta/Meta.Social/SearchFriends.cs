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
	[Cpp2IlInjected.Token(Token = "0x2000BC5")]
	public sealed class SearchFriends : IMessage<SearchFriends>, IMessage, IEquatable<SearchFriends>, IDeepCloneable<SearchFriends>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000BC6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000BC7")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002D89")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4002D8A")]
				[OriginalName("PlayFabError")]
				PlayFabError = 1,
				[Cpp2IlInjected.Token(Token = "0x4002D8B")]
				[OriginalName("InvalidSearchParam")]
				InvalidSearchParam = 2,
				[Cpp2IlInjected.Token(Token = "0x4002D8C")]
				[OriginalName("InvalidSearch")]
				InvalidSearch = 3,
				[Cpp2IlInjected.Token(Token = "0x4002D8D")]
				[OriginalName("InvalidSearchedItems")]
				InvalidSearchedItems = 4,
				[Cpp2IlInjected.Token(Token = "0x4002D8E")]
				[OriginalName("UnknownError")]
				UnknownError = 10
			}

			[Cpp2IlInjected.Token(Token = "0x2000BC8")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002D8F")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002D90")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002D91")]
				public const int SearchFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002D92")]
				private string search_;

				[Cpp2IlInjected.Token(Token = "0x17001136")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60063E9")]
					[Cpp2IlInjected.Address(RVA = "0x200C4F0", Offset = "0x200AEF0", VA = "0x18200C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001137")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60063EA")]
					[Cpp2IlInjected.Address(RVA = "0x200BD30", Offset = "0x200A730", VA = "0x18200BD30")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001138")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60063EB")]
					[Cpp2IlInjected.Address(RVA = "0x200C970", Offset = "0x200B370", VA = "0x18200C970", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001139")]
				[DebuggerNonUserCode]
				public string Search
				{
					[Cpp2IlInjected.Token(Token = "0x60063EF")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60063F0")]
					[Cpp2IlInjected.Address(RVA = "0x200CEB0", Offset = "0x200B8B0", VA = "0x18200CEB0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60063EC")]
				[Cpp2IlInjected.Address(RVA = "0x200B770", Offset = "0x200A170", VA = "0x18200B770")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60063ED")]
				[Cpp2IlInjected.Address(RVA = "0x200B7C0", Offset = "0x200A1C0", VA = "0x18200B7C0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60063EE")]
				[Cpp2IlInjected.Address(RVA = "0x2005CE0", Offset = "0x20046E0", VA = "0x182005CE0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60063F1")]
				[Cpp2IlInjected.Address(RVA = "0x2005FA0", Offset = "0x20049A0", VA = "0x182005FA0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60063F2")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60063F3")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60063F4")]
				[Cpp2IlInjected.Address(RVA = "0x20094B0", Offset = "0x2007EB0", VA = "0x1820094B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60063F5")]
				[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60063F6")]
				[Cpp2IlInjected.Address(RVA = "0x2005100", Offset = "0x2003B00", VA = "0x182005100", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60063F7")]
				[Cpp2IlInjected.Address(RVA = "0x20087B0", Offset = "0x20071B0", VA = "0x1820087B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60063F8")]
				[Cpp2IlInjected.Address(RVA = "0x2007D00", Offset = "0x2006700", VA = "0x182007D00", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60063F9")]
				[Cpp2IlInjected.Address(RVA = "0x20073B0", Offset = "0x2005DB0", VA = "0x1820073B0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60063FA")]
				[Cpp2IlInjected.Address(RVA = "0x2009370", Offset = "0x2007D70", VA = "0x182009370", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60063FB")]
				[Cpp2IlInjected.Address(RVA = "0x20054A0", Offset = "0x2003EA0", VA = "0x1820054A0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000BCA")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002D94")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002D95")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002D96")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002D97")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002D98")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002D99")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002D9A")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002D9B")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002D9C")]
				public const int SearchResultFieldNumber = 4;

				[Cpp2IlInjected.Token(Token = "0x4002D9D")]
				private static readonly FieldCodec<FollowData> _repeated_searchResult_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4002D9E")]
				private readonly RepeatedField<FollowData> searchResult_;

				[Cpp2IlInjected.Token(Token = "0x1700113A")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006400")]
					[Cpp2IlInjected.Address(RVA = "0x20198E0", Offset = "0x20182E0", VA = "0x1820198E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700113B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006401")]
					[Cpp2IlInjected.Address(RVA = "0x20196E0", Offset = "0x20180E0", VA = "0x1820196E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700113C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006402")]
					[Cpp2IlInjected.Address(RVA = "0x201A120", Offset = "0x2018B20", VA = "0x18201A120", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700113D")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006406")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006407")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700113E")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006408")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006409")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700113F")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x600640A")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600640B")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001140")]
				[DebuggerNonUserCode]
				public RepeatedField<FollowData> SearchResult
				{
					[Cpp2IlInjected.Token(Token = "0x600640C")]
					[Cpp2IlInjected.Address(RVA = "0x52C9D0", Offset = "0x52B3D0", VA = "0x18052C9D0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001141")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006418")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006419")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006403")]
				[Cpp2IlInjected.Address(RVA = "0x20184D0", Offset = "0x2016ED0", VA = "0x1820184D0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006404")]
				[Cpp2IlInjected.Address(RVA = "0x20181C0", Offset = "0x2016BC0", VA = "0x1820181C0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006405")]
				[Cpp2IlInjected.Address(RVA = "0x2010DF0", Offset = "0x200F7F0", VA = "0x182010DF0", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600640D")]
				[Cpp2IlInjected.Address(RVA = "0x2012710", Offset = "0x2011110", VA = "0x182012710", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600640E")]
				[Cpp2IlInjected.Address(RVA = "0x2012420", Offset = "0x2010E20", VA = "0x182012420", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600640F")]
				[Cpp2IlInjected.Address(RVA = "0x1C05FB0", Offset = "0x1C049B0", VA = "0x181C05FB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006410")]
				[Cpp2IlInjected.Address(RVA = "0x2016510", Offset = "0x2014F10", VA = "0x182016510", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006411")]
				[Cpp2IlInjected.Address(RVA = "0x2016F10", Offset = "0x2015910", VA = "0x182016F10", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006412")]
				[Cpp2IlInjected.Address(RVA = "0x2010070", Offset = "0x200EA70", VA = "0x182010070", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006413")]
				[Cpp2IlInjected.Address(RVA = "0x2014450", Offset = "0x2012E50", VA = "0x182014450", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006414")]
				[Cpp2IlInjected.Address(RVA = "0x2014C90", Offset = "0x2013690", VA = "0x182014C90", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006415")]
				[Cpp2IlInjected.Address(RVA = "0x2013160", Offset = "0x2011B60", VA = "0x182013160", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006416")]
				[Cpp2IlInjected.Address(RVA = "0x20160D0", Offset = "0x2014AD0", VA = "0x1820160D0", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006417")]
				[Cpp2IlInjected.Address(RVA = "0x2010590", Offset = "0x200EF90", VA = "0x182010590", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600641A")]
				[Cpp2IlInjected.Address(RVA = "0x20129B0", Offset = "0x20113B0", VA = "0x1820129B0", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__46))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002D86")]
		private static readonly MessageParser<SearchFriends> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002D87")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001133")]
		[DebuggerNonUserCode]
		public static MessageParser<SearchFriends> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60063D7")]
			[Cpp2IlInjected.Address(RVA = "0x176D330", Offset = "0x176BD30", VA = "0x18176D330")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001134")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60063D8")]
			[Cpp2IlInjected.Address(RVA = "0x176D260", Offset = "0x176BC60", VA = "0x18176D260")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001135")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60063D9")]
			[Cpp2IlInjected.Address(RVA = "0x176D390", Offset = "0x176BD90", VA = "0x18176D390", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60063DA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public SearchFriends()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60063DB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public SearchFriends(SearchFriends other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60063DC")]
		[Cpp2IlInjected.Address(RVA = "0x176CF80", Offset = "0x176B980", VA = "0x18176CF80", Slot = "10")]
		[DebuggerNonUserCode]
		public SearchFriends Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			SearchFriends searchFriends = default(SearchFriends);
			searchFriends.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (searchFriends._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return searchFriends;
		}

		[Cpp2IlInjected.Token(Token = "0x60063DD")]
		[Cpp2IlInjected.Address(RVA = "0x176D000", Offset = "0x176BA00", VA = "0x18176D000", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60063DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(SearchFriends other)
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

		[Cpp2IlInjected.Token(Token = "0x60063DF")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60063E0")]
		[Cpp2IlInjected.Address(RVA = "0x176D0F0", Offset = "0x176BAF0", VA = "0x18176D0F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60063E1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60063E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60063E3")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(SearchFriends other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60063E4")]
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

		[Cpp2IlInjected.Token(Token = "0x60063E5")]
		[Cpp2IlInjected.Address(RVA = "0x176D080", Offset = "0x176BA80", VA = "0x18176D080", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60063E6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60063E7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60063E8")]
		[Cpp2IlInjected.Address(RVA = "0x176D150", Offset = "0x176BB50", VA = "0x18176D150")]
		static SearchFriends()
		{
			Func<SearchFriends> func = default(Func<SearchFriends>);
			_parser = (MessageParser<SearchFriends>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
