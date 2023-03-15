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
	[Cpp2IlInjected.Token(Token = "0x2000C2D")]
	public sealed class RemoveInboxMessage : IMessage<RemoveInboxMessage>, IMessage, IEquatable<RemoveInboxMessage>, IDeepCloneable<RemoveInboxMessage>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000C2E")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000C2F")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4002F1D")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4002F1E")]
				[OriginalName("UnknownError")]
				UnknownError
			}

			[Cpp2IlInjected.Token(Token = "0x2000C30")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002F1F")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002F20")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002F21")]
				public const int MessagesToRemoveFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x4002F22")]
				private static readonly FieldCodec<InboxMessageKey> _repeated_messagesToRemove_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002F23")]
				private readonly RepeatedField<InboxMessageKey> messagesToRemove_;

				[Cpp2IlInjected.Token(Token = "0x17001202")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60067CD")]
					[Cpp2IlInjected.Address(RVA = "0x200C250", Offset = "0x200AC50", VA = "0x18200C250")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001203")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60067CE")]
					[Cpp2IlInjected.Address(RVA = "0x200BBB0", Offset = "0x200A5B0", VA = "0x18200BBB0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001204")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60067CF")]
					[Cpp2IlInjected.Address(RVA = "0x200C5B0", Offset = "0x200AFB0", VA = "0x18200C5B0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001205")]
				[DebuggerNonUserCode]
				public RepeatedField<InboxMessageKey> MessagesToRemove
				{
					[Cpp2IlInjected.Token(Token = "0x60067D3")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60067D0")]
				[Cpp2IlInjected.Address(RVA = "0x200B860", Offset = "0x200A260", VA = "0x18200B860")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067D1")]
				[Cpp2IlInjected.Address(RVA = "0x200BA90", Offset = "0x200A490", VA = "0x18200BA90")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067D2")]
				[Cpp2IlInjected.Address(RVA = "0x20057D0", Offset = "0x20041D0", VA = "0x1820057D0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60067D4")]
				[Cpp2IlInjected.Address(RVA = "0x2006AC0", Offset = "0x20054C0", VA = "0x182006AC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60067D5")]
				[Cpp2IlInjected.Address(RVA = "0x2006820", Offset = "0x2005220", VA = "0x182006820", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60067D6")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60067D7")]
				[Cpp2IlInjected.Address(RVA = "0x20098D0", Offset = "0x20082D0", VA = "0x1820098D0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60067D8")]
				[Cpp2IlInjected.Address(RVA = "0x200A560", Offset = "0x2008F60", VA = "0x18200A560", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067D9")]
				[Cpp2IlInjected.Address(RVA = "0x20051A0", Offset = "0x2003BA0", VA = "0x1820051A0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60067DA")]
				[Cpp2IlInjected.Address(RVA = "0x2007D90", Offset = "0x2006790", VA = "0x182007D90", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067DB")]
				[Cpp2IlInjected.Address(RVA = "0x20082F0", Offset = "0x2006CF0", VA = "0x1820082F0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067DC")]
				[Cpp2IlInjected.Address(RVA = "0x2006FB0", Offset = "0x20059B0", VA = "0x182006FB0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60067DD")]
				[Cpp2IlInjected.Address(RVA = "0x2008940", Offset = "0x2007340", VA = "0x182008940", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067DE")]
				[Cpp2IlInjected.Address(RVA = "0x2005670", Offset = "0x2004070", VA = "0x182005670", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000C32")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4002F25")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4002F26")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4002F27")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4002F28")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4002F29")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4002F2A")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17001206")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60067E3")]
					[Cpp2IlInjected.Address(RVA = "0x2019940", Offset = "0x2018340", VA = "0x182019940")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001207")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60067E4")]
					[Cpp2IlInjected.Address(RVA = "0x20193E0", Offset = "0x2017DE0", VA = "0x1820193E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001208")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60067E5")]
					[Cpp2IlInjected.Address(RVA = "0x201A2A0", Offset = "0x2018CA0", VA = "0x18201A2A0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17001209")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60067E9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60067EA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700120A")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60067EB")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60067EC")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700120B")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60067F8")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60067F9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60067E6")]
				[Cpp2IlInjected.Address(RVA = "0x2019120", Offset = "0x2017B20", VA = "0x182019120")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067E7")]
				[Cpp2IlInjected.Address(RVA = "0x2018870", Offset = "0x2017270", VA = "0x182018870")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067E8")]
				[Cpp2IlInjected.Address(RVA = "0x2010C80", Offset = "0x200F680", VA = "0x182010C80", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60067ED")]
				[Cpp2IlInjected.Address(RVA = "0x20120A0", Offset = "0x2010AA0", VA = "0x1820120A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60067EE")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60067EF")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60067F0")]
				[Cpp2IlInjected.Address(RVA = "0x20167B0", Offset = "0x20151B0", VA = "0x1820167B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60067F1")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067F2")]
				[Cpp2IlInjected.Address(RVA = "0x200FEA0", Offset = "0x200E8A0", VA = "0x18200FEA0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60067F3")]
				[Cpp2IlInjected.Address(RVA = "0x2015010", Offset = "0x2013A10", VA = "0x182015010", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067F4")]
				[Cpp2IlInjected.Address(RVA = "0x20148F0", Offset = "0x20132F0", VA = "0x1820148F0", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067F5")]
				[Cpp2IlInjected.Address(RVA = "0x2012C40", Offset = "0x2011640", VA = "0x182012C40", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60067F6")]
				[Cpp2IlInjected.Address(RVA = "0x2015800", Offset = "0x2014200", VA = "0x182015800", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067F7")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60067FA")]
				[Cpp2IlInjected.Address(RVA = "0x200F5C0", Offset = "0x200DFC0", VA = "0x18200F5C0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4002F1A")]
		private static readonly MessageParser<RemoveInboxMessage> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002F1B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170011FF")]
		[DebuggerNonUserCode]
		public static MessageParser<RemoveInboxMessage> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60067BB")]
			[Cpp2IlInjected.Address(RVA = "0x5C9440", Offset = "0x5C7E40", VA = "0x1805C9440")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001200")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60067BC")]
			[Cpp2IlInjected.Address(RVA = "0x5C9370", Offset = "0x5C7D70", VA = "0x1805C9370")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001201")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60067BD")]
			[Cpp2IlInjected.Address(RVA = "0x5C94A0", Offset = "0x5C7EA0", VA = "0x1805C94A0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60067BE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public RemoveInboxMessage()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60067BF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public RemoveInboxMessage(RemoveInboxMessage other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60067C0")]
		[Cpp2IlInjected.Address(RVA = "0x5C9090", Offset = "0x5C7A90", VA = "0x1805C9090", Slot = "10")]
		[DebuggerNonUserCode]
		public RemoveInboxMessage Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			RemoveInboxMessage removeInboxMessage = default(RemoveInboxMessage);
			removeInboxMessage.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (removeInboxMessage._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return removeInboxMessage;
		}

		[Cpp2IlInjected.Token(Token = "0x60067C1")]
		[Cpp2IlInjected.Address(RVA = "0x5C9110", Offset = "0x5C7B10", VA = "0x1805C9110", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60067C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(RemoveInboxMessage other)
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

		[Cpp2IlInjected.Token(Token = "0x60067C3")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60067C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C9200", Offset = "0x5C7C00", VA = "0x1805C9200", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60067C5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60067C6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60067C7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(RemoveInboxMessage other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60067C8")]
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

		[Cpp2IlInjected.Token(Token = "0x60067C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C9190", Offset = "0x5C7B90", VA = "0x1805C9190", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60067CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60067CB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60067CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C9260", Offset = "0x5C7C60", VA = "0x1805C9260")]
		static RemoveInboxMessage()
		{
			Func<RemoveInboxMessage> func = default(Func<RemoveInboxMessage>);
			_parser = (MessageParser<RemoveInboxMessage>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
