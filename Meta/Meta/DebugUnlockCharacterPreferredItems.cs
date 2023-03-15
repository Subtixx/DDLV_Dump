using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20002DD")]
	public sealed class DebugUnlockCharacterPreferredItems : IMessage<DebugUnlockCharacterPreferredItems>, IMessage, IEquatable<DebugUnlockCharacterPreferredItems>, IDeepCloneable<DebugUnlockCharacterPreferredItems>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20002DE")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20002DF")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40008F0")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40008F1")]
				[OriginalName("NotADeveloper")]
				NotAdeveloper
			}

			[Cpp2IlInjected.Token(Token = "0x20002E0")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40008F2")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40008F3")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40008F4")]
				public const int CharacterIDFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40008F5")]
				private int characterID_;

				[Cpp2IlInjected.Token(Token = "0x40008F6")]
				public const int ResetDiscoveryFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40008F7")]
				private bool resetDiscovery_;

				[Cpp2IlInjected.Token(Token = "0x1700052C")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001CC3")]
					[Cpp2IlInjected.Address(RVA = "0x211B9C0", Offset = "0x211A3C0", VA = "0x18211B9C0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700052D")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001CC4")]
					[Cpp2IlInjected.Address(RVA = "0x211B000", Offset = "0x2119A00", VA = "0x18211B000")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700052E")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001CC5")]
					[Cpp2IlInjected.Address(RVA = "0x211C140", Offset = "0x211AB40", VA = "0x18211C140", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700052F")]
				[DebuggerNonUserCode]
				public int CharacterID
				{
					[Cpp2IlInjected.Token(Token = "0x6001CC9")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001CCA")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000530")]
				[DebuggerNonUserCode]
				public bool ResetDiscovery
				{
					[Cpp2IlInjected.Token(Token = "0x6001CCB")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6001CCC")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001CC6")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CC7")]
				[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CC8")]
				[Cpp2IlInjected.Address(RVA = "0x21163F0", Offset = "0x2114DF0", VA = "0x1821163F0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001CCD")]
				[Cpp2IlInjected.Address(RVA = "0x2116670", Offset = "0x2115070", VA = "0x182116670", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001CCE")]
				[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001CCF")]
				[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001CD0")]
				[Cpp2IlInjected.Address(RVA = "0x2118C00", Offset = "0x2117600", VA = "0x182118C00", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001CD1")]
				[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CD2")]
				[Cpp2IlInjected.Address(RVA = "0x2115610", Offset = "0x2114010", VA = "0x182115610", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001CD3")]
				[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CD4")]
				[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CD5")]
				[Cpp2IlInjected.Address(RVA = "0x2117450", Offset = "0x2115E50", VA = "0x182117450", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001CD6")]
				[Cpp2IlInjected.Address(RVA = "0x21182A0", Offset = "0x2116CA0", VA = "0x1821182A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CD7")]
				[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20002E2")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40008F9")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40008FA")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40008FB")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40008FC")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40008FD")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40008FE")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000531")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001CDC")]
					[Cpp2IlInjected.Address(RVA = "0x2129AC0", Offset = "0x21284C0", VA = "0x182129AC0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000532")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001CDD")]
					[Cpp2IlInjected.Address(RVA = "0x2129320", Offset = "0x2127D20", VA = "0x182129320")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000533")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001CDE")]
					[Cpp2IlInjected.Address(RVA = "0x212A600", Offset = "0x2129000", VA = "0x18212A600", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000534")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001CE2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001CE3")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000535")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001CE4")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001CE5")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000536")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001CF1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001CF2")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001CDF")]
				[Cpp2IlInjected.Address(RVA = "0x2128070", Offset = "0x2126A70", VA = "0x182128070")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CE0")]
				[Cpp2IlInjected.Address(RVA = "0x2127C70", Offset = "0x2126670", VA = "0x182127C70")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CE1")]
				[Cpp2IlInjected.Address(RVA = "0x2121C60", Offset = "0x2120660", VA = "0x182121C60", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001CE6")]
				[Cpp2IlInjected.Address(RVA = "0x2122470", Offset = "0x2120E70", VA = "0x182122470", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001CE7")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001CE8")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001CE9")]
				[Cpp2IlInjected.Address(RVA = "0x2126700", Offset = "0x2125100", VA = "0x182126700", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001CEA")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CEB")]
				[Cpp2IlInjected.Address(RVA = "0x21200E0", Offset = "0x211EAE0", VA = "0x1821200E0", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001CEC")]
				[Cpp2IlInjected.Address(RVA = "0x2123EF0", Offset = "0x21228F0", VA = "0x182123EF0", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CED")]
				[Cpp2IlInjected.Address(RVA = "0x2123E00", Offset = "0x2122800", VA = "0x182123E00", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CEE")]
				[Cpp2IlInjected.Address(RVA = "0x21230A0", Offset = "0x2121AA0", VA = "0x1821230A0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001CEF")]
				[Cpp2IlInjected.Address(RVA = "0x21261F0", Offset = "0x2124BF0", VA = "0x1821261F0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CF0")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001CF3")]
				[Cpp2IlInjected.Address(RVA = "0x211F860", Offset = "0x211E260", VA = "0x18211F860", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40008ED")]
		private static readonly MessageParser<DebugUnlockCharacterPreferredItems> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008EE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000529")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugUnlockCharacterPreferredItems> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB1")]
			[Cpp2IlInjected.Address(RVA = "0x1A1D230", Offset = "0x1A1BC30", VA = "0x181A1D230")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB2")]
			[Cpp2IlInjected.Address(RVA = "0x1A1D160", Offset = "0x1A1BB60", VA = "0x181A1D160")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700052B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001CB3")]
			[Cpp2IlInjected.Address(RVA = "0x1A1D290", Offset = "0x1A1BC90", VA = "0x181A1D290", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB4")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugUnlockCharacterPreferredItems()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugUnlockCharacterPreferredItems(DebugUnlockCharacterPreferredItems other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB6")]
		[Cpp2IlInjected.Address(RVA = "0x1A1CE80", Offset = "0x1A1B880", VA = "0x181A1CE80", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugUnlockCharacterPreferredItems Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugUnlockCharacterPreferredItems debugUnlockCharacterPreferredItems = default(DebugUnlockCharacterPreferredItems);
			debugUnlockCharacterPreferredItems.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugUnlockCharacterPreferredItems._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugUnlockCharacterPreferredItems;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CB7")]
		[Cpp2IlInjected.Address(RVA = "0x1A1CF00", Offset = "0x1A1B900", VA = "0x181A1CF00", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001CB8")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugUnlockCharacterPreferredItems other)
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

		[Cpp2IlInjected.Token(Token = "0x6001CB9")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBA")]
		[Cpp2IlInjected.Address(RVA = "0x1A1CFF0", Offset = "0x1A1B9F0", VA = "0x181A1CFF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBC")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBD")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugUnlockCharacterPreferredItems other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001CBE")]
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

		[Cpp2IlInjected.Token(Token = "0x6001CBF")]
		[Cpp2IlInjected.Address(RVA = "0x1A1CF80", Offset = "0x1A1B980", VA = "0x181A1CF80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC0")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC1")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001CC2")]
		[Cpp2IlInjected.Address(RVA = "0x1A1D050", Offset = "0x1A1BA50", VA = "0x181A1D050")]
		static DebugUnlockCharacterPreferredItems()
		{
			Func<DebugUnlockCharacterPreferredItems> func = default(Func<DebugUnlockCharacterPreferredItems>);
			_parser = (MessageParser<DebugUnlockCharacterPreferredItems>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
