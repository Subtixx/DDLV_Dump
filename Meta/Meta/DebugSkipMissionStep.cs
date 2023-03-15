using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x20003EC")]
	public sealed class DebugSkipMissionStep : IMessage<DebugSkipMissionStep>, IMessage, IEquatable<DebugSkipMissionStep>, IDeepCloneable<DebugSkipMissionStep>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x20003ED")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x20003EE")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000C2D")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000C2E")]
				[OriginalName("Error")]
				Error
			}

			[Cpp2IlInjected.Token(Token = "0x20003EF")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000C2F")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C30")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C31")]
				public const int MissionIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C32")]
				private int missionId_;

				[Cpp2IlInjected.Token(Token = "0x4000C33")]
				public const int AllStepsFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000C34")]
				private bool allSteps_;

				[Cpp2IlInjected.Token(Token = "0x170006FA")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002681")]
					[Cpp2IlInjected.Address(RVA = "0x211BA80", Offset = "0x211A480", VA = "0x18211BA80")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006FB")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002682")]
					[Cpp2IlInjected.Address(RVA = "0x211B200", Offset = "0x2119C00", VA = "0x18211B200")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006FC")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002683")]
					[Cpp2IlInjected.Address(RVA = "0x211C200", Offset = "0x211AC00", VA = "0x18211C200", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006FD")]
				[DebuggerNonUserCode]
				public int MissionId
				{
					[Cpp2IlInjected.Token(Token = "0x6002687")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002688")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170006FE")]
				[DebuggerNonUserCode]
				public bool AllSteps
				{
					[Cpp2IlInjected.Token(Token = "0x6002689")]
					[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
					get
					{
						return default(bool);
					}
					[Cpp2IlInjected.Token(Token = "0x600268A")]
					[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002684")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002685")]
				[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002686")]
				[Cpp2IlInjected.Address(RVA = "0x2115CE0", Offset = "0x21146E0", VA = "0x182115CE0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600268B")]
				[Cpp2IlInjected.Address(RVA = "0x2116790", Offset = "0x2115190", VA = "0x182116790", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600268C")]
				[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600268D")]
				[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600268E")]
				[Cpp2IlInjected.Address(RVA = "0x21191A0", Offset = "0x2117BA0", VA = "0x1821191A0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600268F")]
				[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002690")]
				[Cpp2IlInjected.Address(RVA = "0x2115040", Offset = "0x2113A40", VA = "0x182115040", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002691")]
				[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002692")]
				[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002693")]
				[Cpp2IlInjected.Address(RVA = "0x21171A0", Offset = "0x2115BA0", VA = "0x1821171A0", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002694")]
				[Cpp2IlInjected.Address(RVA = "0x21187D0", Offset = "0x21171D0", VA = "0x1821187D0", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002695")]
				[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x20003F1")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000C36")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000C37")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000C38")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000C39")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000C3A")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000C3B")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x170006FF")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600269A")]
					[Cpp2IlInjected.Address(RVA = "0x21296A0", Offset = "0x21280A0", VA = "0x1821296A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000700")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600269B")]
					[Cpp2IlInjected.Address(RVA = "0x2129520", Offset = "0x2127F20", VA = "0x182129520")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000701")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600269C")]
					[Cpp2IlInjected.Address(RVA = "0x212A000", Offset = "0x2128A00", VA = "0x18212A000", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000702")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x60026A0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60026A1")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000703")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x60026A2")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x60026A3")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000704")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x60026AF")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x60026B0")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600269D")]
				[Cpp2IlInjected.Address(RVA = "0x2128A40", Offset = "0x2127440", VA = "0x182128A40")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600269E")]
				[Cpp2IlInjected.Address(RVA = "0x2127D70", Offset = "0x2126770", VA = "0x182127D70")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600269F")]
				[Cpp2IlInjected.Address(RVA = "0x2121B30", Offset = "0x2120530", VA = "0x182121B30", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026A4")]
				[Cpp2IlInjected.Address(RVA = "0x2121FC0", Offset = "0x21209C0", VA = "0x182121FC0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026A5")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x60026A6")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026A7")]
				[Cpp2IlInjected.Address(RVA = "0x21267C0", Offset = "0x21251C0", VA = "0x1821267C0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026A8")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026A9")]
				[Cpp2IlInjected.Address(RVA = "0x2120010", Offset = "0x211EA10", VA = "0x182120010", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x60026AA")]
				[Cpp2IlInjected.Address(RVA = "0x2124440", Offset = "0x2122E40", VA = "0x182124440", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026AB")]
				[Cpp2IlInjected.Address(RVA = "0x2125310", Offset = "0x2123D10", VA = "0x182125310", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026AC")]
				[Cpp2IlInjected.Address(RVA = "0x2122E00", Offset = "0x2121800", VA = "0x182122E00", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x60026AD")]
				[Cpp2IlInjected.Address(RVA = "0x2126390", Offset = "0x2124D90", VA = "0x182126390", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026AE")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60026B1")]
				[Cpp2IlInjected.Address(RVA = "0x211CB90", Offset = "0x211B590", VA = "0x18211CB90", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000C2A")]
		private static readonly MessageParser<DebugSkipMissionStep> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000C2B")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x170006F7")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugSkipMissionStep> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600266F")]
			[Cpp2IlInjected.Address(RVA = "0x1A16230", Offset = "0x1A14C30", VA = "0x181A16230")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002670")]
			[Cpp2IlInjected.Address(RVA = "0x1A16160", Offset = "0x1A14B60", VA = "0x181A16160")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170006F9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002671")]
			[Cpp2IlInjected.Address(RVA = "0x1A16290", Offset = "0x1A14C90", VA = "0x181A16290", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002672")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugSkipMissionStep()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002673")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugSkipMissionStep(DebugSkipMissionStep other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002674")]
		[Cpp2IlInjected.Address(RVA = "0x1A15E80", Offset = "0x1A14880", VA = "0x181A15E80", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugSkipMissionStep Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugSkipMissionStep debugSkipMissionStep = default(DebugSkipMissionStep);
			debugSkipMissionStep.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugSkipMissionStep._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugSkipMissionStep;
		}

		[Cpp2IlInjected.Token(Token = "0x6002675")]
		[Cpp2IlInjected.Address(RVA = "0x1A15F00", Offset = "0x1A14900", VA = "0x181A15F00", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002676")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugSkipMissionStep other)
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

		[Cpp2IlInjected.Token(Token = "0x6002677")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002678")]
		[Cpp2IlInjected.Address(RVA = "0x1A15FF0", Offset = "0x1A149F0", VA = "0x181A15FF0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6002679")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600267A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600267B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugSkipMissionStep other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600267C")]
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

		[Cpp2IlInjected.Token(Token = "0x600267D")]
		[Cpp2IlInjected.Address(RVA = "0x1A15F80", Offset = "0x1A14980", VA = "0x181A15F80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600267E")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600267F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002680")]
		[Cpp2IlInjected.Address(RVA = "0x1A16050", Offset = "0x1A14A50", VA = "0x181A16050")]
		static DebugSkipMissionStep()
		{
			Func<DebugSkipMissionStep> func = default(Func<DebugSkipMissionStep>);
			_parser = (MessageParser<DebugSkipMissionStep>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
