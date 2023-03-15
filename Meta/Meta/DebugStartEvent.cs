using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
	public sealed class DebugStartEvent : IMessage<DebugStartEvent>, IMessage, IEquatable<DebugStartEvent>, IDeepCloneable<DebugStartEvent>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20001FE")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20001FF")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40006AD")]
				[OriginalName("Success")]
				Success
			}

			[Cpp2IlInjected.Token(Token = "0x2000200")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40006AE")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40006AF")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40006B0")]
				public const int IdsFieldNumber = 1;

				[Cpp2IlInjected.Token(Token = "0x40006B1")]
				private static readonly FieldCodec<int> _repeated_ids_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40006B2")]
				private readonly RepeatedField<int> ids_;

				[Cpp2IlInjected.Token(Token = "0x170003B7")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60014E8")]
					[Cpp2IlInjected.Address(RVA = "0x211BA20", Offset = "0x211A420", VA = "0x18211BA20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003B8")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60014E9")]
					[Cpp2IlInjected.Address(RVA = "0x211B480", Offset = "0x2119E80", VA = "0x18211B480")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003B9")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60014EA")]
					[Cpp2IlInjected.Address(RVA = "0x211BD80", Offset = "0x211A780", VA = "0x18211BD80", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003BA")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Ids
				{
					[Cpp2IlInjected.Token(Token = "0x60014EE")]
					[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60014EB")]
				[Cpp2IlInjected.Address(RVA = "0x211AA20", Offset = "0x2119420", VA = "0x18211AA20")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60014EC")]
				[Cpp2IlInjected.Address(RVA = "0x211ACF0", Offset = "0x21196F0", VA = "0x18211ACF0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60014ED")]
				[Cpp2IlInjected.Address(RVA = "0x2115AD0", Offset = "0x21144D0", VA = "0x182115AD0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60014EF")]
				[Cpp2IlInjected.Address(RVA = "0x2116510", Offset = "0x2114F10", VA = "0x182116510", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60014F0")]
				[Cpp2IlInjected.Address(RVA = "0x21168C0", Offset = "0x21152C0", VA = "0x1821168C0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60014F1")]
				[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60014F2")]
				[Cpp2IlInjected.Address(RVA = "0x2118F00", Offset = "0x2117900", VA = "0x182118F00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60014F3")]
				[Cpp2IlInjected.Address(RVA = "0x2119790", Offset = "0x2118190", VA = "0x182119790", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60014F4")]
				[Cpp2IlInjected.Address(RVA = "0x21157E0", Offset = "0x21141E0", VA = "0x1821157E0", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60014F5")]
				[Cpp2IlInjected.Address(RVA = "0x21180E0", Offset = "0x2116AE0", VA = "0x1821180E0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60014F6")]
				[Cpp2IlInjected.Address(RVA = "0x2117FF0", Offset = "0x21169F0", VA = "0x182117FF0", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60014F7")]
				[Cpp2IlInjected.Address(RVA = "0x2116F50", Offset = "0x2115950", VA = "0x182116F50", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60014F8")]
				[Cpp2IlInjected.Address(RVA = "0x2118AE0", Offset = "0x21174E0", VA = "0x182118AE0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60014F9")]
				[Cpp2IlInjected.Address(RVA = "0x2115A40", Offset = "0x2114440", VA = "0x182115A40", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000202")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40006B4")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40006B5")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40006B6")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40006B7")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40006B8")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40006B9")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170003BB")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x60014FE")]
					[Cpp2IlInjected.Address(RVA = "0x21298E0", Offset = "0x21282E0", VA = "0x1821298E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003BC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x60014FF")]
					[Cpp2IlInjected.Address(RVA = "0x21290A0", Offset = "0x2127AA0", VA = "0x1821290A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003BD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001500")]
					[Cpp2IlInjected.Address(RVA = "0x212A3C0", Offset = "0x2128DC0", VA = "0x18212A3C0", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003BE")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001504")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001505")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003BF")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001506")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001507")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170003C0")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001513")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001514")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001501")]
				[Cpp2IlInjected.Address(RVA = "0x2127EB0", Offset = "0x21268B0", VA = "0x182127EB0")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001502")]
				[Cpp2IlInjected.Address(RVA = "0x2128DE0", Offset = "0x21277E0", VA = "0x182128DE0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001503")]
				[Cpp2IlInjected.Address(RVA = "0x21211E0", Offset = "0x211FBE0", VA = "0x1821211E0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001508")]
				[Cpp2IlInjected.Address(RVA = "0x2121F10", Offset = "0x2120910", VA = "0x182121F10", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001509")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600150A")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600150B")]
				[Cpp2IlInjected.Address(RVA = "0x21268E0", Offset = "0x21252E0", VA = "0x1821268E0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600150C")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600150D")]
				[Cpp2IlInjected.Address(RVA = "0x21207C0", Offset = "0x211F1C0", VA = "0x1821207C0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600150E")]
				[Cpp2IlInjected.Address(RVA = "0x2124550", Offset = "0x2122F50", VA = "0x182124550", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600150F")]
				[Cpp2IlInjected.Address(RVA = "0x2124170", Offset = "0x2122B70", VA = "0x182124170", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001510")]
				[Cpp2IlInjected.Address(RVA = "0x21234E0", Offset = "0x2121EE0", VA = "0x1821234E0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001511")]
				[Cpp2IlInjected.Address(RVA = "0x2125970", Offset = "0x2124370", VA = "0x182125970", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001512")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001515")]
				[Cpp2IlInjected.Address(RVA = "0x211C980", Offset = "0x211B380", VA = "0x18211C980", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private static readonly MessageParser<DebugStartEvent> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170003B4")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugStartEvent> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60014D6")]
			[Cpp2IlInjected.Address(RVA = "0x1A17190", Offset = "0x1A15B90", VA = "0x181A17190")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B5")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60014D7")]
			[Cpp2IlInjected.Address(RVA = "0x1A170C0", Offset = "0x1A15AC0", VA = "0x181A170C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003B6")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60014D8")]
			[Cpp2IlInjected.Address(RVA = "0x1A171F0", Offset = "0x1A15BF0", VA = "0x181A171F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014D9")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugStartEvent()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x60014DA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugStartEvent(DebugStartEvent other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60014DB")]
		[Cpp2IlInjected.Address(RVA = "0x1A16DE0", Offset = "0x1A157E0", VA = "0x181A16DE0", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugStartEvent Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugStartEvent debugStartEvent = default(DebugStartEvent);
			debugStartEvent.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugStartEvent._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugStartEvent;
		}

		[Cpp2IlInjected.Token(Token = "0x60014DC")]
		[Cpp2IlInjected.Address(RVA = "0x1A16E60", Offset = "0x1A15860", VA = "0x181A16E60", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x60014DD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugStartEvent other)
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

		[Cpp2IlInjected.Token(Token = "0x60014DE")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x60014DF")]
		[Cpp2IlInjected.Address(RVA = "0x1A16F50", Offset = "0x1A15950", VA = "0x181A16F50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60014E0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60014E1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60014E2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugStartEvent other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60014E3")]
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

		[Cpp2IlInjected.Token(Token = "0x60014E4")]
		[Cpp2IlInjected.Address(RVA = "0x1A16EE0", Offset = "0x1A158E0", VA = "0x181A16EE0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60014E5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60014E6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x60014E7")]
		[Cpp2IlInjected.Address(RVA = "0x1A16FB0", Offset = "0x1A159B0", VA = "0x181A16FB0")]
		static DebugStartEvent()
		{
			Func<DebugStartEvent> func = default(Func<DebugStartEvent>);
			_parser = (MessageParser<DebugStartEvent>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
