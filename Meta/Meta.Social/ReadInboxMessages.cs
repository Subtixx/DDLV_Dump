using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000C35")]
	public sealed class ReadInboxMessages : IMessage<ReadInboxMessages>, IMessage, IEquatable<ReadInboxMessages>, IDeepCloneable<ReadInboxMessages>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C36")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C37")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002F30")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4002F31")]
				[OriginalName("UnknownError")]
				UnknownError
			}

			[Cpp2IlInjected.Token(Token = "0x2000C38")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002F32")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002F33")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002F34")]
				public const int KeysFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002F35")]
				private static readonly FieldCodec<InboxMessageKey> _repeated_keys_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002F36")]
				private readonly RepeatedField<InboxMessageKey> keys_;

				[Cpp2IlInjected.Token(Token = "0x1700120F")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6006814")]
					[Cpp2IlInjected.Address(RVA = "0x2C12BB0", Offset = "0x2C115B0", VA = "0x182C12BB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001210")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006815")]
					[Cpp2IlInjected.Address(RVA = "0x2C12410", Offset = "0x2C10E10", VA = "0x182C12410")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001211")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6006816")]
					[Cpp2IlInjected.Address(RVA = "0x2C12F70", Offset = "0x2C11970", VA = "0x182C12F70", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001212")]
				[DebuggerNonUserCode]
				public RepeatedField<InboxMessageKey> Keys
				{
					[Cpp2IlInjected.Token(Token = "0x600681A")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6006817")]
				[Cpp2IlInjected.Address(RVA = "0x2C11ED0", Offset = "0x2C108D0", VA = "0x182C11ED0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006818")]
				[Cpp2IlInjected.Address(RVA = "0x2C120D0", Offset = "0x2C10AD0", VA = "0x182C120D0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006819")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C2F0", Offset = "0x2C0ACF0", VA = "0x182C0C2F0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600681B")]
				[Cpp2IlInjected.Address(RVA = "0x2C0C810", Offset = "0x2C0B210", VA = "0x182C0C810", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600681C")]
				[Cpp2IlInjected.Address(RVA = "0x2C0CD40", Offset = "0x2C0B740", VA = "0x182C0CD40", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600681D")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600681E")]
				[Cpp2IlInjected.Address(RVA = "0x2C0F460", Offset = "0x2C0DE60", VA = "0x182C0F460", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600681F")]
				[Cpp2IlInjected.Address(RVA = "0x2C10DE0", Offset = "0x2C0F7E0", VA = "0x182C10DE0", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006820")]
				[Cpp2IlInjected.Address(RVA = "0x2C0B240", Offset = "0x2C09C40", VA = "0x182C0B240", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006821")]
				[Cpp2IlInjected.Address(RVA = "0x2C0E2F0", Offset = "0x2C0CCF0", VA = "0x182C0E2F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006822")]
				[Cpp2IlInjected.Address(RVA = "0x2C0DE00", Offset = "0x2C0C800", VA = "0x182C0DE00", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006823")]
				[Cpp2IlInjected.Address(RVA = "0x2C0D920", Offset = "0x2C0C320", VA = "0x182C0D920", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006824")]
				[Cpp2IlInjected.Address(RVA = "0x2C0EAF0", Offset = "0x2C0D4F0", VA = "0x182C0EAF0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006825")]
				[Cpp2IlInjected.Address(RVA = "0x2C0BC10", Offset = "0x2C0A610", VA = "0x182C0BC10", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C3A")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002F38")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002F39")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002F3A")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002F3B")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002F3C")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002F3D")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17001213")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600682A")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E690", Offset = "0x2C1D090", VA = "0x182C1E690")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001214")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600682B")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E2B0", Offset = "0x2C1CCB0", VA = "0x182C1E2B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001215")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600682C")]
					[Cpp2IlInjected.Address(RVA = "0x2C1E9F0", Offset = "0x2C1D3F0", VA = "0x182C1E9F0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001216")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6006830")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006831")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001217")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6006832")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6006833")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001218")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x600683F")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6006840")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600682D")]
				[Cpp2IlInjected.Address(RVA = "0x2C1D680", Offset = "0x2C1C080", VA = "0x182C1D680")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600682E")]
				[Cpp2IlInjected.Address(RVA = "0x2C1DA00", Offset = "0x2C1C400", VA = "0x182C1DA00")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600682F")]
				[Cpp2IlInjected.Address(RVA = "0x2C17630", Offset = "0x2C16030", VA = "0x182C17630", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006834")]
				[Cpp2IlInjected.Address(RVA = "0x2C18480", Offset = "0x2C16E80", VA = "0x182C18480", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006835")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6006836")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6006837")]
				[Cpp2IlInjected.Address(RVA = "0x2C1BE20", Offset = "0x2C1A820", VA = "0x182C1BE20", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6006838")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006839")]
				[Cpp2IlInjected.Address(RVA = "0x2C17280", Offset = "0x2C15C80", VA = "0x182C17280", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600683A")]
				[Cpp2IlInjected.Address(RVA = "0x2C1A0C0", Offset = "0x2C18AC0", VA = "0x182C1A0C0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600683B")]
				[Cpp2IlInjected.Address(RVA = "0x2C1AD70", Offset = "0x2C19770", VA = "0x182C1AD70", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600683C")]
				[Cpp2IlInjected.Address(RVA = "0x2C191A0", Offset = "0x2C17BA0", VA = "0x182C191A0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600683D")]
				[Cpp2IlInjected.Address(RVA = "0x2C1B440", Offset = "0x2C19E40", VA = "0x182C1B440", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600683E")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6006841")]
				[Cpp2IlInjected.Address(RVA = "0x2C14F90", Offset = "0x2C13990", VA = "0x182C14F90", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002F2D")]
		private static readonly MessageParser<ReadInboxMessages> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002F2E")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700120C")]
		[DebuggerNonUserCode]
		public static MessageParser<ReadInboxMessages> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6006802")]
			[Cpp2IlInjected.Address(RVA = "0x5C0B80", Offset = "0x5BF580", VA = "0x1805C0B80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700120D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006803")]
			[Cpp2IlInjected.Address(RVA = "0x5C0AB0", Offset = "0x5BF4B0", VA = "0x1805C0AB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700120E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6006804")]
			[Cpp2IlInjected.Address(RVA = "0x5C0BE0", Offset = "0x5BF5E0", VA = "0x1805C0BE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6006805")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ReadInboxMessages()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6006806")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public ReadInboxMessages(ReadInboxMessages other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6006807")]
		[Cpp2IlInjected.Address(RVA = "0x5C0650", Offset = "0x5BF050", VA = "0x1805C0650", Slot = "10")]
		[DebuggerNonUserCode]
		public ReadInboxMessages Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			ReadInboxMessages readInboxMessages = default(ReadInboxMessages);
			readInboxMessages.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (readInboxMessages._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return readInboxMessages;
		}

		[Cpp2IlInjected.Token(Token = "0x6006808")]
		[Cpp2IlInjected.Address(RVA = "0x5C06D0", Offset = "0x5BF0D0", VA = "0x1805C06D0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6006809")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ReadInboxMessages other)
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

		[Cpp2IlInjected.Token(Token = "0x600680A")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x600680B")]
		[Cpp2IlInjected.Address(RVA = "0x5C08D0", Offset = "0x5BF2D0", VA = "0x1805C08D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600680C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600680D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600680E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ReadInboxMessages other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600680F")]
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

		[Cpp2IlInjected.Token(Token = "0x6006810")]
		[Cpp2IlInjected.Address(RVA = "0x5C0770", Offset = "0x5BF170", VA = "0x1805C0770", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6006811")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006812")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6006813")]
		[Cpp2IlInjected.Address(RVA = "0x5C0950", Offset = "0x5BF350", VA = "0x1805C0950")]
		static ReadInboxMessages()
		{
			Func<ReadInboxMessages> func = default(Func<ReadInboxMessages>);
			_parser = (MessageParser<ReadInboxMessages>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
