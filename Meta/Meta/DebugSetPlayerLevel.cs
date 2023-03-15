using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000294")]
	public sealed class DebugSetPlayerLevel : IMessage<DebugSetPlayerLevel>, IMessage, IEquatable<DebugSetPlayerLevel>, IDeepCloneable<DebugSetPlayerLevel>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000295")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000296")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000851")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000852")]
				[OriginalName("NotDeveloper")]
				NotDeveloper
			}

			[Cpp2IlInjected.Token(Token = "0x2000297")]
			public sealed class Request : TransactionValidator<Result>, IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000853")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000854")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000855")]
				public const int AmountFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000856")]
				private int amount_;

				[Cpp2IlInjected.Token(Token = "0x170004BB")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001A3F")]
					[Cpp2IlInjected.Address(RVA = "0x211B7E0", Offset = "0x211A1E0", VA = "0x18211B7E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170004BC")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001A40")]
					[Cpp2IlInjected.Address(RVA = "0x211B400", Offset = "0x2119E00", VA = "0x18211B400")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170004BD")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001A41")]
					[Cpp2IlInjected.Address(RVA = "0x211C2C0", Offset = "0x211ACC0", VA = "0x18211C2C0", Slot = "10")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170004BE")]
				[DebuggerNonUserCode]
				public int Amount
				{
					[Cpp2IlInjected.Token(Token = "0x6001A45")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6001A46")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001A42")]
				[Cpp2IlInjected.Address(RVA = "0x211AF00", Offset = "0x2119900", VA = "0x18211AF00")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A43")]
				[Cpp2IlInjected.Address(RVA = "0x211AE90", Offset = "0x2119890", VA = "0x18211AE90")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A44")]
				[Cpp2IlInjected.Address(RVA = "0x2116230", Offset = "0x2114C30", VA = "0x182116230", Slot = "12")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001A47")]
				[Cpp2IlInjected.Address(RVA = "0x2116700", Offset = "0x2115100", VA = "0x182116700", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001A48")]
				[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "11")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001A49")]
				[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001A4A")]
				[Cpp2IlInjected.Address(RVA = "0x2119020", Offset = "0x2117A20", VA = "0x182119020", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001A4B")]
				[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "8")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A4C")]
				[Cpp2IlInjected.Address(RVA = "0x21156A0", Offset = "0x21140A0", VA = "0x1821156A0", Slot = "9")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001A4D")]
				[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A4E")]
				[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "7")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A4F")]
				[Cpp2IlInjected.Address(RVA = "0x2117290", Offset = "0x2115C90", VA = "0x182117290", Slot = "13")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001A50")]
				[Cpp2IlInjected.Address(RVA = "0x2118160", Offset = "0x2116B60", VA = "0x182118160", Slot = "14")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A51")]
				[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "15")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A52")]
				[Cpp2IlInjected.Address(RVA = "0x2119310", Offset = "0x2117D10", VA = "0x182119310", Slot = "5")]
				protected override Result ValidateThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(Result);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000299")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000858")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000859")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x400085A")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400085B")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x400085C")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400085D")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170004BF")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6001A57")]
					[Cpp2IlInjected.Address(RVA = "0x2129760", Offset = "0x2128160", VA = "0x182129760")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170004C0")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001A58")]
					[Cpp2IlInjected.Address(RVA = "0x2129620", Offset = "0x2128020", VA = "0x182129620")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170004C1")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6001A59")]
					[Cpp2IlInjected.Address(RVA = "0x212A180", Offset = "0x2128B80", VA = "0x18212A180", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170004C2")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6001A5D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001A5E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170004C3")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6001A5F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6001A60")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170004C4")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6001A6C")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6001A6D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6001A5A")]
				[Cpp2IlInjected.Address(RVA = "0x2128270", Offset = "0x2126C70", VA = "0x182128270")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A5B")]
				[Cpp2IlInjected.Address(RVA = "0x21287A0", Offset = "0x21271A0", VA = "0x1821287A0")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A5C")]
				[Cpp2IlInjected.Address(RVA = "0x2120BA0", Offset = "0x211F5A0", VA = "0x182120BA0", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001A61")]
				[Cpp2IlInjected.Address(RVA = "0x2121E60", Offset = "0x2120860", VA = "0x182121E60", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001A62")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6001A63")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001A64")]
				[Cpp2IlInjected.Address(RVA = "0x2126460", Offset = "0x2124E60", VA = "0x182126460", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001A65")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A66")]
				[Cpp2IlInjected.Address(RVA = "0x2120960", Offset = "0x211F360", VA = "0x182120960", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6001A67")]
				[Cpp2IlInjected.Address(RVA = "0x2125100", Offset = "0x2123B00", VA = "0x182125100", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A68")]
				[Cpp2IlInjected.Address(RVA = "0x2123920", Offset = "0x2122320", VA = "0x182123920", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A69")]
				[Cpp2IlInjected.Address(RVA = "0x2122B90", Offset = "0x2121590", VA = "0x182122B90", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6001A6A")]
				[Cpp2IlInjected.Address(RVA = "0x2125D80", Offset = "0x2124780", VA = "0x182125D80", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A6B")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6001A6E")]
				[Cpp2IlInjected.Address(RVA = "0x211F7C0", Offset = "0x211E1C0", VA = "0x18211F7C0", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400084E")]
		private static readonly MessageParser<DebugSetPlayerLevel> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400084F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170004B8")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugSetPlayerLevel> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001A2D")]
			[Cpp2IlInjected.Address(RVA = "0x18CD1E0", Offset = "0x18CBBE0", VA = "0x1818CD1E0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004B9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001A2E")]
			[Cpp2IlInjected.Address(RVA = "0x18CD110", Offset = "0x18CBB10", VA = "0x1818CD110")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004BA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001A2F")]
			[Cpp2IlInjected.Address(RVA = "0x18CD240", Offset = "0x18CBC40", VA = "0x1818CD240", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A30")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugSetPlayerLevel()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A31")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugSetPlayerLevel(DebugSetPlayerLevel other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001A32")]
		[Cpp2IlInjected.Address(RVA = "0x18CCE30", Offset = "0x18CB830", VA = "0x1818CCE30", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugSetPlayerLevel Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugSetPlayerLevel debugSetPlayerLevel = default(DebugSetPlayerLevel);
			debugSetPlayerLevel.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugSetPlayerLevel._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugSetPlayerLevel;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A33")]
		[Cpp2IlInjected.Address(RVA = "0x18CCEB0", Offset = "0x18CB8B0", VA = "0x1818CCEB0", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6001A34")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugSetPlayerLevel other)
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

		[Cpp2IlInjected.Token(Token = "0x6001A35")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A36")]
		[Cpp2IlInjected.Address(RVA = "0x18CCFA0", Offset = "0x18CB9A0", VA = "0x1818CCFA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A37")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6001A38")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A39")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugSetPlayerLevel other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3A")]
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

		[Cpp2IlInjected.Token(Token = "0x6001A3B")]
		[Cpp2IlInjected.Address(RVA = "0x18CCF30", Offset = "0x18CB930", VA = "0x1818CCF30", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6001A3E")]
		[Cpp2IlInjected.Address(RVA = "0x18CD000", Offset = "0x18CBA00", VA = "0x1818CD000")]
		static DebugSetPlayerLevel()
		{
			Func<DebugSetPlayerLevel> func = default(Func<DebugSetPlayerLevel>);
			_parser = (MessageParser<DebugSetPlayerLevel>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
