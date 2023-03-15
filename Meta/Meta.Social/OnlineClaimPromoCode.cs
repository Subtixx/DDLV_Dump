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
	[Cpp2IlInjected.Token(Token = "0x2000C6E")]
	public sealed class OnlineClaimPromoCode : IMessage<OnlineClaimPromoCode>, IMessage, IEquatable<OnlineClaimPromoCode>, IDeepCloneable<OnlineClaimPromoCode>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C6F")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C70")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4003028")]
				[OriginalName("Success")]
				Success = 0,
				[Cpp2IlInjected.Token(Token = "0x4003029")]
				[OriginalName("InvalidItem")]
				InvalidItem = 1,
				[Cpp2IlInjected.Token(Token = "0x400302A")]
				[OriginalName("PlayFabError")]
				PlayFabError = 2,
				[Cpp2IlInjected.Token(Token = "0x400302B")]
				[OriginalName("ItemNotFound")]
				ItemNotFound = 3,
				[Cpp2IlInjected.Token(Token = "0x400302C")]
				[OriginalName("NotFound")]
				NotFound = 4,
				[Cpp2IlInjected.Token(Token = "0x400302D")]
				[OriginalName("InvalidConfig")]
				InvalidConfig = 5,
				[Cpp2IlInjected.Token(Token = "0x400302E")]
				[OriginalName("NotStarted")]
				NotStarted = 6,
				[Cpp2IlInjected.Token(Token = "0x400302F")]
				[OriginalName("Expired")]
				Expired = 7,
				[Cpp2IlInjected.Token(Token = "0x4003030")]
				[OriginalName("FriendlyNameNotFound")]
				FriendlyNameNotFound = 8,
				[Cpp2IlInjected.Token(Token = "0x4003031")]
				[OriginalName("PlayerAlreadyClaimed")]
				PlayerAlreadyClaimed = 9,
				[Cpp2IlInjected.Token(Token = "0x4003032")]
				[OriginalName("FailedUpdatePlayerStatistic")]
				FailedUpdatePlayerStatistic = 10,
				[Cpp2IlInjected.Token(Token = "0x4003033")]
				[OriginalName("FailedGetTitleStatistic")]
				FailedGetTitleStatistic = 11,
				[Cpp2IlInjected.Token(Token = "0x4003034")]
				[OriginalName("FailedUpdateTitleStatistic")]
				FailedUpdateTitleStatistic = 12,
				[Cpp2IlInjected.Token(Token = "0x4003035")]
				[OriginalName("FailedGrantKey")]
				FailedGrantKey = 13,
				[Cpp2IlInjected.Token(Token = "0x4003036")]
				[OriginalName("AllClaimed")]
				AllClaimed = 14,
				[Cpp2IlInjected.Token(Token = "0x4003037")]
				[OriginalName("UnknownOnlineError")]
				UnknownOnlineError = 20,
				[Cpp2IlInjected.Token(Token = "0x4003038")]
				[OriginalName("UnknownError")]
				UnknownError = 30
			}

			[Cpp2IlInjected.Token(Token = "0x2000C71")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor, IOnlineRequest
			{
				[Cpp2IlInjected.Token(Token = "0x4003039")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400303A")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400303B")]
				public const int PromoCodeIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400303C")]
				private string promoCodeId_;

				[Cpp2IlInjected.Token(Token = "0x17001276")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006A14")]
					[Cpp2IlInjected.Address(RVA = "0x25CC570", Offset = "0x25CAF70", VA = "0x1825CC570")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001277")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006A15")]
					[Cpp2IlInjected.Address(RVA = "0x25CBD50", Offset = "0x25CA750", VA = "0x1825CBD50")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001278")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006A16")]
					[Cpp2IlInjected.Address(RVA = "0x25CCE70", Offset = "0x25CB870", VA = "0x1825CCE70", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001279")]
				[DebuggerNonUserCode]
				public string PromoCodeId
				{
					[Cpp2IlInjected.Token(Token = "0x6006A1A")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006A1B")]
					[Cpp2IlInjected.Address(RVA = "0x25CCFF0", Offset = "0x25CB9F0", VA = "0x1825CCFF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006A17")]
				[Cpp2IlInjected.Address(RVA = "0x25CB6A0", Offset = "0x25CA0A0", VA = "0x1825CB6A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A18")]
				[Cpp2IlInjected.Address(RVA = "0x25CB880", Offset = "0x25CA280", VA = "0x1825CB880")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A19")]
				[Cpp2IlInjected.Address(RVA = "0x25C5830", Offset = "0x25C4230", VA = "0x1825C5830", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A1C")]
				[Cpp2IlInjected.Address(RVA = "0x25C6380", Offset = "0x25C4D80", VA = "0x1825C6380", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A1D")]
				[Cpp2IlInjected.Address(RVA = "0x15B9F20", Offset = "0x15B8920", VA = "0x1815B9F20", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A1E")]
				[Cpp2IlInjected.Address(RVA = "0x15BAF10", Offset = "0x15B9910", VA = "0x1815BAF10", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A1F")]
				[Cpp2IlInjected.Address(RVA = "0x25C8B40", Offset = "0x25C7540", VA = "0x1825C8B40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A20")]
				[Cpp2IlInjected.Address(RVA = "0x15BC7C0", Offset = "0x15BB1C0", VA = "0x1815BC7C0", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A21")]
				[Cpp2IlInjected.Address(RVA = "0x25C4290", Offset = "0x25C2C90", VA = "0x1825C4290", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A22")]
				[Cpp2IlInjected.Address(RVA = "0x25C7640", Offset = "0x25C6040", VA = "0x1825C7640", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A23")]
				[Cpp2IlInjected.Address(RVA = "0x25C7AA0", Offset = "0x25C64A0", VA = "0x1825C7AA0", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A24")]
				[Cpp2IlInjected.Address(RVA = "0x25C65C0", Offset = "0x25C4FC0", VA = "0x1825C65C0", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A25")]
				[Cpp2IlInjected.Address(RVA = "0x25C80F0", Offset = "0x25C6AF0", VA = "0x1825C80F0", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A26")]
				[Cpp2IlInjected.Address(RVA = "0x25C4DE0", Offset = "0x25C37E0", VA = "0x1825C4DE0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A27")]
				[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C73")]
			public sealed class Response : OnlineAction, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor, IOnlineResponse
			{
				[Cpp2IlInjected.Token(Token = "0x400303E")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400303F")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4003040")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4003041")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4003042")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4003043")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x4003044")]
				public const int PlayFabResultFieldNumber = 3;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4003045")]
				private int playFabResult_;

				[Cpp2IlInjected.Token(Token = "0x1700127A")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006A2C")]
					[Cpp2IlInjected.Address(RVA = "0x25D6940", Offset = "0x25D5340", VA = "0x1825D6940")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700127B")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006A2D")]
					[Cpp2IlInjected.Address(RVA = "0x25D6320", Offset = "0x25D4D20", VA = "0x1825D6320")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700127C")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006A2E")]
					[Cpp2IlInjected.Address(RVA = "0x25D6BE0", Offset = "0x25D55E0", VA = "0x1825D6BE0", Slot = "15")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700127D")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006A32")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006A33")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700127E")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006A34")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006A35")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700127F")]
				[DebuggerNonUserCode]
				public int PlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006A36")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "21")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006A37")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "22")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001280")]
				protected override int MyPlayFabResult
				{
					[Cpp2IlInjected.Token(Token = "0x6006A43")]
					[Cpp2IlInjected.Address(RVA = "0x5BB8B0", Offset = "0x5BA2B0", VA = "0x1805BB8B0", Slot = "9")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6006A44")]
					[Cpp2IlInjected.Address(RVA = "0x5BBA20", Offset = "0x5BA420", VA = "0x1805BBA20", Slot = "10")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006A2F")]
				[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A30")]
				[Cpp2IlInjected.Address(RVA = "0x25D57B0", Offset = "0x25D41B0", VA = "0x1825D57B0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A31")]
				[Cpp2IlInjected.Address(RVA = "0x25CF8C0", Offset = "0x25CE2C0", VA = "0x1825CF8C0", Slot = "17")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A38")]
				[Cpp2IlInjected.Address(RVA = "0x25D0CF0", Offset = "0x25CF6F0", VA = "0x1825D0CF0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A39")]
				[Cpp2IlInjected.Address(RVA = "0x89ABB0", Offset = "0x8995B0", VA = "0x18089ABB0", Slot = "16")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A3A")]
				[Cpp2IlInjected.Address(RVA = "0x89AF30", Offset = "0x899930", VA = "0x18089AF30", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A3B")]
				[Cpp2IlInjected.Address(RVA = "0x25D3F30", Offset = "0x25D2930", VA = "0x1825D3F30", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A3C")]
				[Cpp2IlInjected.Address(RVA = "0x89B730", Offset = "0x89A130", VA = "0x18089B730", Slot = "13")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A3D")]
				[Cpp2IlInjected.Address(RVA = "0x25CF250", Offset = "0x25CDC50", VA = "0x1825CF250", Slot = "14")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006A3E")]
				[Cpp2IlInjected.Address(RVA = "0x25D1D80", Offset = "0x25D0780", VA = "0x1825D1D80", Slot = "11")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A3F")]
				[Cpp2IlInjected.Address(RVA = "0x25D24A0", Offset = "0x25D0EA0", VA = "0x1825D24A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A40")]
				[Cpp2IlInjected.Address(RVA = "0x25D13D0", Offset = "0x25CFDD0", VA = "0x1825D13D0", Slot = "18")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006A41")]
				[Cpp2IlInjected.Address(RVA = "0x25D3810", Offset = "0x25D2210", VA = "0x1825D3810", Slot = "19")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A42")]
				[Cpp2IlInjected.Address(RVA = "0x89A710", Offset = "0x899110", VA = "0x18089A710", Slot = "20")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006A45")]
				[Cpp2IlInjected.Address(RVA = "0x25D0DB0", Offset = "0x25CF7B0", VA = "0x1825D0DB0", Slot = "8")]
				[AsyncStateMachine(typeof(_003CExecuteThis_003Ed__41))]
				protected override Task<bool> ExecuteThis(ClientSession clientSession, Player player, World world, ITransactionContext context, CancellationToken ct)
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4003025")]
		private static readonly MessageParser<OnlineClaimPromoCode> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4003026")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17001273")]
		[DebuggerNonUserCode]
		public static MessageParser<OnlineClaimPromoCode> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006A02")]
			[Cpp2IlInjected.Address(RVA = "0x13A2370", Offset = "0x13A0D70", VA = "0x1813A2370")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001274")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006A03")]
			[Cpp2IlInjected.Address(RVA = "0x13A22A0", Offset = "0x13A0CA0", VA = "0x1813A22A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001275")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006A04")]
			[Cpp2IlInjected.Address(RVA = "0x13A23D0", Offset = "0x13A0DD0", VA = "0x1813A23D0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006A05")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public OnlineClaimPromoCode()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006A06")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public OnlineClaimPromoCode(OnlineClaimPromoCode other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006A07")]
		[Cpp2IlInjected.Address(RVA = "0x13A1FC0", Offset = "0x13A09C0", VA = "0x1813A1FC0", Slot = "10")]
		[DebuggerNonUserCode]
		public OnlineClaimPromoCode Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			OnlineClaimPromoCode onlineClaimPromoCode = default(OnlineClaimPromoCode);
			onlineClaimPromoCode.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (onlineClaimPromoCode._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return onlineClaimPromoCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6006A08")]
		[Cpp2IlInjected.Address(RVA = "0x13A2040", Offset = "0x13A0A40", VA = "0x1813A2040", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006A09")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(OnlineClaimPromoCode other)
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

		[Cpp2IlInjected.Token(Token = "0x6006A0A")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6006A0B")]
		[Cpp2IlInjected.Address(RVA = "0x13A2130", Offset = "0x13A0B30", VA = "0x1813A2130", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6006A0C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6006A0D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6006A0E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(OnlineClaimPromoCode other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006A0F")]
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

		[Cpp2IlInjected.Token(Token = "0x6006A10")]
		[Cpp2IlInjected.Address(RVA = "0x13A20C0", Offset = "0x13A0AC0", VA = "0x1813A20C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006A11")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006A12")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006A13")]
		[Cpp2IlInjected.Address(RVA = "0x13A2190", Offset = "0x13A0B90", VA = "0x1813A2190")]
		static OnlineClaimPromoCode()
		{
			Func<OnlineClaimPromoCode> func = default(Func<OnlineClaimPromoCode>);
			_parser = (MessageParser<OnlineClaimPromoCode>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
