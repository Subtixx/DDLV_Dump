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
	[Cpp2IlInjected.Token(Token = "0x2000C01")]
	public sealed class LikeNewsFeed : IMessage<LikeNewsFeed>, IMessage, IEquatable<LikeNewsFeed>, IDeepCloneable<LikeNewsFeed>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C02")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C03")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002EA1")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4002EA2")]
				[OriginalName("PlayFabError")]
				PlayFabError,
				[Cpp2IlInjected.Token(Token = "0x4002EA3")]
				[OriginalName("ProfileNotFound")]
				ProfileNotFound,
				[Cpp2IlInjected.Token(Token = "0x4002EA4")]
				[OriginalName("UgcProfileNotFound")]
				UgcProfileNotFound,
				[Cpp2IlInjected.Token(Token = "0x4002EA5")]
				[OriginalName("ItemNotFound")]
				ItemNotFound,
				[Cpp2IlInjected.Token(Token = "0x4002EA6")]
				[OriginalName("AlreadyLiked")]
				AlreadyLiked,
				[Cpp2IlInjected.Token(Token = "0x4002EA7")]
				[OriginalName("CannotLikeSelf")]
				CannotLikeSelf,
				[Cpp2IlInjected.Token(Token = "0x4002EA8")]
				[OriginalName("UpdateStatsFailed")]
				UpdateStatsFailed,
				[Cpp2IlInjected.Token(Token = "0x4002EA9")]
				[OriginalName("UnknownError")]
				UnknownError
			}

			[Cpp2IlInjected.Token(Token = "0x2000C04")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4002EAA")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002EAB")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002EAC")]
				public const int UgcItemIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002EAD")]
				private string ugcItemId_;

				[Cpp2IlInjected.Token(Token = "0x170011BB")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006647")]
					[Cpp2IlInjected.Address(RVA = "0x1E43090", Offset = "0x1E41A90", VA = "0x181E43090")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011BC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006648")]
					[Cpp2IlInjected.Address(RVA = "0x1E42F10", Offset = "0x1E41910", VA = "0x181E42F10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011BD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006649")]
					[Cpp2IlInjected.Address(RVA = "0x1E434B0", Offset = "0x1E41EB0", VA = "0x181E434B0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011BE")]
				[DebuggerNonUserCode]
				public string UgcItemId
				{
					[Cpp2IlInjected.Token(Token = "0x600664D")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x600664E")]
					[Cpp2IlInjected.Address(RVA = "0x1E43950", Offset = "0x1E42350", VA = "0x181E43950")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600664A")]
				[Cpp2IlInjected.Address(RVA = "0x1E423D0", Offset = "0x1E40DD0", VA = "0x181E423D0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600664B")]
				[Cpp2IlInjected.Address(RVA = "0x1E428E0", Offset = "0x1E412E0", VA = "0x181E428E0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600664C")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D700", Offset = "0x1E3C100", VA = "0x181E3D700", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600664F")]
				[Cpp2IlInjected.Address(RVA = "0x1E3DEF0", Offset = "0x1E3C8F0", VA = "0x181E3DEF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006650")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006651")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006652")]
				[Cpp2IlInjected.Address(RVA = "0x1E40BD0", Offset = "0x1E3F5D0", VA = "0x181E40BD0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006653")]
				[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006654")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D0E0", Offset = "0x1E3BAE0", VA = "0x181E3D0E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006655")]
				[Cpp2IlInjected.Address(RVA = "0x1E400B0", Offset = "0x1E3EAB0", VA = "0x181E400B0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006656")]
				[Cpp2IlInjected.Address(RVA = "0x1E401E0", Offset = "0x1E3EBE0", VA = "0x181E401E0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006657")]
				[Cpp2IlInjected.Address(RVA = "0x1E3E9F0", Offset = "0x1E3D3F0", VA = "0x181E3E9F0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006658")]
				[Cpp2IlInjected.Address(RVA = "0x1E40300", Offset = "0x1E3ED00", VA = "0x181E40300", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006659")]
				[Cpp2IlInjected.Address(RVA = "0x1E3D430", Offset = "0x1E3BE30", VA = "0x181E3D430", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C06")]
			public sealed class Response : OnlineAndTransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x4002EAF")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002EB0")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002EB1")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002EB2")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002EB3")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002EB4")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4002EB5")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4002EB6")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x4002EB7")]
				public const int BonusSocialRewardsFieldNumber = 4;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4002EB8")]
				private int bonusSocialRewards_;

				[Cpp2IlInjected.Token(Token = "0x170011BF")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600665E")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C310", Offset = "0x1E4AD10", VA = "0x181E4C310")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C0")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600665F")]
					[Cpp2IlInjected.Address(RVA = "0x1E4BF70", Offset = "0x1E4A970", VA = "0x181E4BF70")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C1")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006660")]
					[Cpp2IlInjected.Address(RVA = "0x1E4C690", Offset = "0x1E4B090", VA = "0x181E4C690", Slot = "26")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C2")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006664")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006665")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C3")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006666")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006667")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C4")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006668")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "32")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006669")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "33")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C5")]
				[DebuggerNonUserCode]
				public int BonusSocialRewards
				{
					[Cpp2IlInjected.Token(Token = "0x600666A")]
					[Cpp2IlInjected.Address(RVA = "0x7251A0", Offset = "0x723BA0", VA = "0x1807251A0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600666B")]
					[Cpp2IlInjected.Address(RVA = "0x725380", Offset = "0x723D80", VA = "0x180725380")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C6")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006677")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "18")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006678")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "19")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170011C7")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006679")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "15")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x600667A")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "16")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006661")]
				[Cpp2IlInjected.Address(RVA = "0x1E4BA10", Offset = "0x1E4A410", VA = "0x181E4BA10")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006662")]
				[Cpp2IlInjected.Address(RVA = "0x1E4B4B0", Offset = "0x1E49EB0", VA = "0x181E4B4B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006663")]
				[Cpp2IlInjected.Address(RVA = "0x1E46D40", Offset = "0x1E45740", VA = "0x181E46D40", Slot = "28")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600666C")]
				[Cpp2IlInjected.Address(RVA = "0x1E47610", Offset = "0x1E46010", VA = "0x181E47610", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600666D")]
				[Cpp2IlInjected.Address(RVA = "0x1E02D60", Offset = "0x1E01760", VA = "0x181E02D60", Slot = "27")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600666E")]
				[Cpp2IlInjected.Address(RVA = "0x1E041F0", Offset = "0x1E02BF0", VA = "0x181E041F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600666F")]
				[Cpp2IlInjected.Address(RVA = "0x1E49B50", Offset = "0x1E48550", VA = "0x181E49B50", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006670")]
				[Cpp2IlInjected.Address(RVA = "0x1E072D0", Offset = "0x1E05CD0", VA = "0x181E072D0", Slot = "24")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006671")]
				[Cpp2IlInjected.Address(RVA = "0x1E461C0", Offset = "0x1E44BC0", VA = "0x181E461C0", Slot = "25")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006672")]
				[Cpp2IlInjected.Address(RVA = "0x1E48E00", Offset = "0x1E47800", VA = "0x181E48E00", Slot = "22")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006673")]
				[Cpp2IlInjected.Address(RVA = "0x1E48380", Offset = "0x1E46D80", VA = "0x181E48380", Slot = "23")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006674")]
				[Cpp2IlInjected.Address(RVA = "0x1E47940", Offset = "0x1E46340", VA = "0x181E47940", Slot = "29")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006675")]
				[Cpp2IlInjected.Address(RVA = "0x1E498B0", Offset = "0x1E482B0", VA = "0x181E498B0", Slot = "30")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006676")]
				[Cpp2IlInjected.Address(RVA = "0x1E01540", Offset = "0x1DFFF40", VA = "0x181E01540", Slot = "31")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600667B")]
				[Cpp2IlInjected.Address(RVA = "0x1E47800", Offset = "0x1E46200", VA = "0x181E47800", Slot = "14")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__49))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600667C")]
				[Cpp2IlInjected.Address(RVA = "0x1E440E0", Offset = "0x1E42AE0", VA = "0x181E440E0", Slot = "17")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002E9E")]
		private static readonly MessageParser<LikeNewsFeed> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002E9F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170011B8")]
		[DebuggerNonUserCode]
		public static MessageParser<LikeNewsFeed> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006635")]
			[Cpp2IlInjected.Address(RVA = "0x18A25E0", Offset = "0x18A0FE0", VA = "0x1818A25E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011B9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006636")]
			[Cpp2IlInjected.Address(RVA = "0x18A2510", Offset = "0x18A0F10", VA = "0x1818A2510")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170011BA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006637")]
			[Cpp2IlInjected.Address(RVA = "0x18A2640", Offset = "0x18A1040", VA = "0x1818A2640", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006638")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LikeNewsFeed()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006639")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public LikeNewsFeed(LikeNewsFeed other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600663A")]
		[Cpp2IlInjected.Address(RVA = "0x18A2230", Offset = "0x18A0C30", VA = "0x1818A2230", Slot = "10")]
		[DebuggerNonUserCode]
		public LikeNewsFeed Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			LikeNewsFeed likeNewsFeed = default(LikeNewsFeed);
			likeNewsFeed.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (likeNewsFeed._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return likeNewsFeed;
		}

		[Cpp2IlInjected.Token(Token = "0x600663B")]
		[Cpp2IlInjected.Address(RVA = "0x18A22B0", Offset = "0x18A0CB0", VA = "0x1818A22B0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x600663C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LikeNewsFeed other)
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

		[Cpp2IlInjected.Token(Token = "0x600663D")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600663E")]
		[Cpp2IlInjected.Address(RVA = "0x18A23A0", Offset = "0x18A0DA0", VA = "0x1818A23A0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600663F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006640")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006641")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LikeNewsFeed other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006642")]
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

		[Cpp2IlInjected.Token(Token = "0x6006643")]
		[Cpp2IlInjected.Address(RVA = "0x18A2330", Offset = "0x18A0D30", VA = "0x1818A2330", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006644")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006645")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006646")]
		[Cpp2IlInjected.Address(RVA = "0x18A2400", Offset = "0x18A0E00", VA = "0x1818A2400")]
		static LikeNewsFeed()
		{
			Func<LikeNewsFeed> func = default(Func<LikeNewsFeed>);
			_parser = (MessageParser<LikeNewsFeed>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
