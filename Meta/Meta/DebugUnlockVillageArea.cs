using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20002C5")]
	public sealed class DebugUnlockVillageArea : IMessage<DebugUnlockVillageArea>, IMessage, IEquatable<DebugUnlockVillageArea>, IDeepCloneable<DebugUnlockVillageArea>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20002C6")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20002C7")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x40008BA")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x40008BB")]
				[OriginalName("NotADeveloper")]
				NotAdeveloper
			}

			[Cpp2IlInjected.Token(Token = "0x20002C8")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40008BC")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40008BD")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40008BE")]
				public const int AllAreasFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40008BF")]
				private bool allAreas_;

				[Cpp2IlInjected.Token(Token = "0x40008C0")]
				public const int AreaFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x40008C1")]
				private VillageAreaType area_;

				[Cpp2IlInjected.Token(Token = "0x17000506")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001BED")]
					[Cpp2IlInjected.Address(RVA = "0x211B780", Offset = "0x211A180", VA = "0x18211B780")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000507")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001BEE")]
					[Cpp2IlInjected.Address(RVA = "0x211B580", Offset = "0x2119F80", VA = "0x18211B580")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000508")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001BEF")]
					[Cpp2IlInjected.Address(RVA = "0x211C740", Offset = "0x211B140", VA = "0x18211C740", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000509")]
				[DebuggerNonUserCode]
				public bool AllAreas
				{
					[Cpp2IlInjected.Token(Token = "0x6001BF3")]
					[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x6001BF4")]
					[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700050A")]
				[DebuggerNonUserCode]
				public VillageAreaType Area
				{
					[Cpp2IlInjected.Token(Token = "0x6001BF5")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(VillageAreaType);
					}
					[Cpp2IlInjected.Token(Token = "0x6001BF6")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001BF0")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001BF1")]
				[Cpp2IlInjected.Address(RVA = "0x7187C0", Offset = "0x7171C0", VA = "0x1807187C0")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001BF2")]
				[Cpp2IlInjected.Address(RVA = "0x2116070", Offset = "0x2114A70", VA = "0x182116070", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001BF7")]
				[Cpp2IlInjected.Address(RVA = "0x2116480", Offset = "0x2114E80", VA = "0x182116480", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001BF8")]
				[Cpp2IlInjected.Address(RVA = "0x718240", Offset = "0x716C40", VA = "0x180718240", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001BF9")]
				[Cpp2IlInjected.Address(RVA = "0x718370", Offset = "0x716D70", VA = "0x180718370", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001BFA")]
				[Cpp2IlInjected.Address(RVA = "0x2118E40", Offset = "0x2117840", VA = "0x182118E40", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001BFB")]
				[Cpp2IlInjected.Address(RVA = "0x718620", Offset = "0x717020", VA = "0x180718620", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001BFC")]
				[Cpp2IlInjected.Address(RVA = "0x2115960", Offset = "0x2114360", VA = "0x182115960", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001BFD")]
				[Cpp2IlInjected.Address(RVA = "0x718490", Offset = "0x716E90", VA = "0x180718490", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001BFE")]
				[Cpp2IlInjected.Address(RVA = "0x718400", Offset = "0x716E00", VA = "0x180718400", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001BFF")]
				[Cpp2IlInjected.Address(RVA = "0x2117A70", Offset = "0x2116470", VA = "0x182117A70", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001C00")]
				[Cpp2IlInjected.Address(RVA = "0x21188A0", Offset = "0x21172A0", VA = "0x1821188A0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C01")]
				[Cpp2IlInjected.Address(RVA = "0x718100", Offset = "0x716B00", VA = "0x180718100", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20002CA")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40008C3")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40008C4")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40008C5")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40008C6")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x40008C7")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40008C8")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x1700050B")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001C06")]
					[Cpp2IlInjected.Address(RVA = "0x2129B20", Offset = "0x2128520", VA = "0x182129B20")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700050C")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001C07")]
					[Cpp2IlInjected.Address(RVA = "0x21295A0", Offset = "0x2127FA0", VA = "0x1821295A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700050D")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001C08")]
					[Cpp2IlInjected.Address(RVA = "0x212A300", Offset = "0x2128D00", VA = "0x18212A300", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700050E")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001C0C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001C0D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700050F")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001C0E")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001C0F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000510")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001C1B")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001C1C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001C09")]
				[Cpp2IlInjected.Address(RVA = "0x2127F30", Offset = "0x2126930", VA = "0x182127F30")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C0A")]
				[Cpp2IlInjected.Address(RVA = "0x21286A0", Offset = "0x21270A0", VA = "0x1821286A0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C0B")]
				[Cpp2IlInjected.Address(RVA = "0x2120F70", Offset = "0x211F970", VA = "0x182120F70", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001C10")]
				[Cpp2IlInjected.Address(RVA = "0x21227F0", Offset = "0x21211F0", VA = "0x1821227F0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001C11")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001C12")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001C13")]
				[Cpp2IlInjected.Address(RVA = "0x2126580", Offset = "0x2124F80", VA = "0x182126580", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001C14")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C15")]
				[Cpp2IlInjected.Address(RVA = "0x211FE60", Offset = "0x211E860", VA = "0x18211FE60", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001C16")]
				[Cpp2IlInjected.Address(RVA = "0x2124E10", Offset = "0x2123810", VA = "0x182124E10", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C17")]
				[Cpp2IlInjected.Address(RVA = "0x2124F20", Offset = "0x2123920", VA = "0x182124F20", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C18")]
				[Cpp2IlInjected.Address(RVA = "0x2123410", Offset = "0x2121E10", VA = "0x182123410", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001C19")]
				[Cpp2IlInjected.Address(RVA = "0x2125BE0", Offset = "0x21245E0", VA = "0x182125BE0", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C1A")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001C1D")]
				[Cpp2IlInjected.Address(RVA = "0x211EA60", Offset = "0x211D460", VA = "0x18211EA60", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40008B7")]
		private static readonly MessageParser<DebugUnlockVillageArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40008B8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x17000503")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugUnlockVillageArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001BDB")]
			[Cpp2IlInjected.Address(RVA = "0x1A1DC70", Offset = "0x1A1C670", VA = "0x181A1DC70")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000504")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001BDC")]
			[Cpp2IlInjected.Address(RVA = "0x1A1DBA0", Offset = "0x1A1C5A0", VA = "0x181A1DBA0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000505")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001BDD")]
			[Cpp2IlInjected.Address(RVA = "0x1A1DCD0", Offset = "0x1A1C6D0", VA = "0x181A1DCD0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDE")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugUnlockVillageArea()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BDF")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugUnlockVillageArea(DebugUnlockVillageArea other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE0")]
		[Cpp2IlInjected.Address(RVA = "0x1A1D8C0", Offset = "0x1A1C2C0", VA = "0x181A1D8C0", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugUnlockVillageArea Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugUnlockVillageArea debugUnlockVillageArea = default(DebugUnlockVillageArea);
			debugUnlockVillageArea.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugUnlockVillageArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugUnlockVillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE1")]
		[Cpp2IlInjected.Address(RVA = "0x1A1D940", Offset = "0x1A1C340", VA = "0x181A1D940", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001BE2")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugUnlockVillageArea other)
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

		[Cpp2IlInjected.Token(Token = "0x6001BE3")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE4")]
		[Cpp2IlInjected.Address(RVA = "0x1A1DA30", Offset = "0x1A1C430", VA = "0x181A1DA30", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE5")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE6")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE7")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugUnlockVillageArea other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE8")]
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

		[Cpp2IlInjected.Token(Token = "0x6001BE9")]
		[Cpp2IlInjected.Address(RVA = "0x1A1D9C0", Offset = "0x1A1C3C0", VA = "0x181A1D9C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BEA")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001BEB")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001BEC")]
		[Cpp2IlInjected.Address(RVA = "0x1A1DA90", Offset = "0x1A1C490", VA = "0x181A1DA90")]
		static DebugUnlockVillageArea()
		{
			Func<DebugUnlockVillageArea> func = default(Func<DebugUnlockVillageArea>);
			_parser = (MessageParser<DebugUnlockVillageArea>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
