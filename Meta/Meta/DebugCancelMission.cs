using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Meta.Missions;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200041F")]
	public sealed class DebugCancelMission : IMessage<DebugCancelMission>, IMessage, IEquatable<DebugCancelMission>, IDeepCloneable<DebugCancelMission>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000420")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000421")]
			public enum Result
			{
				[Cpp2IlInjected.Token(Token = "0x4000CE3")]
				[OriginalName("Success")]
				Success,
				[Cpp2IlInjected.Token(Token = "0x4000CE4")]
				[OriginalName("Error")]
				Error,
				[Cpp2IlInjected.Token(Token = "0x4000CE5")]
				[OriginalName("Expired")]
				Expired
			}

			[Cpp2IlInjected.Token(Token = "0x2000422")]
			public sealed class Request : IMessage<Request>, IMessage, IEquatable<Request>, IDeepCloneable<Request>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000CE6")]
				private static readonly MessageParser<Request> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000CE7")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000CE8")]
				public const int SlotIdFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000CE9")]
				private int slotId_;

				[Cpp2IlInjected.Token(Token = "0x4000CEA")]
				public const int SlotClassFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
				[Cpp2IlInjected.Token(Token = "0x4000CEB")]
				private MissionSlotClass slotClass_;

				[Cpp2IlInjected.Token(Token = "0x1700075E")]
				[DebuggerNonUserCode]
				public static MessageParser<Request> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6002862")]
					[Cpp2IlInjected.Address(RVA = "0x26486A0", Offset = "0x26470A0", VA = "0x1826486A0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700075F")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002863")]
					[Cpp2IlInjected.Address(RVA = "0x26482E0", Offset = "0x2646CE0", VA = "0x1826482E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000760")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6002864")]
					[Cpp2IlInjected.Address(RVA = "0x2648AC0", Offset = "0x26474C0", VA = "0x182648AC0", Slot = "8")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000761")]
				[DebuggerNonUserCode]
				public int SlotId
				{
					[Cpp2IlInjected.Token(Token = "0x6002868")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6002869")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000762")]
				[DebuggerNonUserCode]
				public MissionSlotClass SlotClass
				{
					[Cpp2IlInjected.Token(Token = "0x600286A")]
					[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
					get
					{
						return default(MissionSlotClass);
					}
					[Cpp2IlInjected.Token(Token = "0x600286B")]
					[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6002865")]
				[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
				[DebuggerNonUserCode]
				public Request()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002866")]
				[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
				[DebuggerNonUserCode]
				public Request(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002867")]
				[Cpp2IlInjected.Address(RVA = "0x26446A0", Offset = "0x26430A0", VA = "0x1826446A0", Slot = "10")]
				[DebuggerNonUserCode]
				public Request Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600286C")]
				[Cpp2IlInjected.Address(RVA = "0x2644B30", Offset = "0x2643530", VA = "0x182644B30", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600286D")]
				[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
				[DebuggerNonUserCode]
				public bool Equals(Request other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600286E")]
				[Cpp2IlInjected.Address(RVA = "0x71B7F0", Offset = "0x71A1F0", VA = "0x18071B7F0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600286F")]
				[Cpp2IlInjected.Address(RVA = "0x26462E0", Offset = "0x2644CE0", VA = "0x1826462E0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002870")]
				[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002871")]
				[Cpp2IlInjected.Address(RVA = "0x2643B70", Offset = "0x2642570", VA = "0x182643B70", Slot = "7")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002872")]
				[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
				[DebuggerNonUserCode]
				public void MergeFrom(Request other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002873")]
				[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002874")]
				[Cpp2IlInjected.Address(RVA = "0x2645480", Offset = "0x2643E80", VA = "0x182645480", Slot = "11")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002875")]
				[Cpp2IlInjected.Address(RVA = "0x2645D80", Offset = "0x2644780", VA = "0x182645D80", Slot = "12")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002876")]
				[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000424")]
			public sealed class Response : TransactionAction<Result>, IMessage<Response>, IMessage, IEquatable<Response>, IDeepCloneable<Response>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x4000CED")]
				private static readonly MessageParser<Response> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000CEE")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x4000CEF")]
				public const int ResultFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000CF0")]
				private Result result_;

				[Cpp2IlInjected.Token(Token = "0x4000CF1")]
				public const int RequestFieldNumber = 2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000CF2")]
				private Request request_;

				[Cpp2IlInjected.Token(Token = "0x17000763")]
				[DebuggerNonUserCode]
				public static MessageParser<Response> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x600287B")]
					[Cpp2IlInjected.Address(RVA = "0x26542E0", Offset = "0x2652CE0", VA = "0x1826542E0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000764")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600287C")]
					[Cpp2IlInjected.Address(RVA = "0x2653DE0", Offset = "0x26527E0", VA = "0x182653DE0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000765")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x600287D")]
					[Cpp2IlInjected.Address(RVA = "0x2654A00", Offset = "0x2653400", VA = "0x182654A00", Slot = "17")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000766")]
				[DebuggerNonUserCode]
				public Result Result
				{
					[Cpp2IlInjected.Token(Token = "0x6002881")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002882")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000767")]
				[DebuggerNonUserCode]
				public Request Request
				{
					[Cpp2IlInjected.Token(Token = "0x6002883")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
					[Cpp2IlInjected.Token(Token = "0x6002884")]
					[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000768")]
				protected override Result MyResult
				{
					[Cpp2IlInjected.Token(Token = "0x6002890")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0", Slot = "10")]
					get
					{
						return default(Result);
					}
					[Cpp2IlInjected.Token(Token = "0x6002891")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0", Slot = "11")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600287E")]
				[Cpp2IlInjected.Address(RVA = "0x2652D80", Offset = "0x2651780", VA = "0x182652D80")]
				[DebuggerNonUserCode]
				public Response()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600287F")]
				[Cpp2IlInjected.Address(RVA = "0x2652F40", Offset = "0x2651940", VA = "0x182652F40")]
				[DebuggerNonUserCode]
				public Response(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002880")]
				[Cpp2IlInjected.Address(RVA = "0x264CC60", Offset = "0x264B660", VA = "0x18264CC60", Slot = "19")]
				[DebuggerNonUserCode]
				public Response Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002885")]
				[Cpp2IlInjected.Address(RVA = "0x264D7A0", Offset = "0x264C1A0", VA = "0x18264D7A0", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002886")]
				[Cpp2IlInjected.Address(RVA = "0x648C60", Offset = "0x647660", VA = "0x180648C60", Slot = "18")]
				[DebuggerNonUserCode]
				public bool Equals(Response other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6002887")]
				[Cpp2IlInjected.Address(RVA = "0x6492B0", Offset = "0x647CB0", VA = "0x1806492B0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6002888")]
				[Cpp2IlInjected.Address(RVA = "0x26517B0", Offset = "0x26501B0", VA = "0x1826517B0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6002889")]
				[Cpp2IlInjected.Address(RVA = "0x649B20", Offset = "0x648520", VA = "0x180649B20", Slot = "15")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600288A")]
				[Cpp2IlInjected.Address(RVA = "0x264B980", Offset = "0x264A380", VA = "0x18264B980", Slot = "16")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x600288B")]
				[Cpp2IlInjected.Address(RVA = "0x264F180", Offset = "0x264DB80", VA = "0x18264F180", Slot = "13")]
				[DebuggerNonUserCode]
				public void MergeFrom(Response other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600288C")]
				[Cpp2IlInjected.Address(RVA = "0x264F290", Offset = "0x264DC90", VA = "0x18264F290", Slot = "14")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600288D")]
				[Cpp2IlInjected.Address(RVA = "0x264EBB0", Offset = "0x264D5B0", VA = "0x18264EBB0", Slot = "20")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600288E")]
				[Cpp2IlInjected.Address(RVA = "0x2650C80", Offset = "0x264F680", VA = "0x182650C80", Slot = "21")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600288F")]
				[Cpp2IlInjected.Address(RVA = "0x648A20", Offset = "0x647420", VA = "0x180648A20", Slot = "22")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6002892")]
				[Cpp2IlInjected.Address(RVA = "0x264AE20", Offset = "0x2649820", VA = "0x18264AE20", Slot = "9")]
				protected override bool ApplyThis(in Player player, in World world, ITransactionContext transactionContext)
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000CE0")]
		private static readonly MessageParser<DebugCancelMission> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000CE1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x1700075B")]
		[DebuggerNonUserCode]
		public static MessageParser<DebugCancelMission> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6002850")]
			[Cpp2IlInjected.Address(RVA = "0x18C8F40", Offset = "0x18C7940", VA = "0x1818C8F40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002851")]
			[Cpp2IlInjected.Address(RVA = "0x18C8E70", Offset = "0x18C7870", VA = "0x1818C8E70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700075D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6002852")]
			[Cpp2IlInjected.Address(RVA = "0x18C8FA0", Offset = "0x18C79A0", VA = "0x1818C8FA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6002853")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public DebugCancelMission()
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
		}

		[Cpp2IlInjected.Token(Token = "0x6002854")]
		[Cpp2IlInjected.Address(RVA = "0x5C0A60", Offset = "0x5BF460", VA = "0x1805C0A60")]
		[DebuggerNonUserCode]
		public DebugCancelMission(DebugCancelMission other)
		{
			int fieldNumber = 0;
			ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6002855")]
		[Cpp2IlInjected.Address(RVA = "0x18C8B90", Offset = "0x18C7590", VA = "0x1818C8B90", Slot = "10")]
		[DebuggerNonUserCode]
		public DebugCancelMission Clone()
		{
			//Discarded unreachable code: IL_001e
			int fieldNumber = 0;
			DebugCancelMission debugCancelMission = default(DebugCancelMission);
			debugCancelMission.ClearFieldValue(fieldNumber);
			UnknownFieldSet unknownFieldSet = (debugCancelMission._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return debugCancelMission;
		}

		[Cpp2IlInjected.Token(Token = "0x6002856")]
		[Cpp2IlInjected.Address(RVA = "0x18C8C10", Offset = "0x18C7610", VA = "0x1818C8C10", Slot = "0")]
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

		[Cpp2IlInjected.Token(Token = "0x6002857")]
		[Cpp2IlInjected.Address(RVA = "0x5C0750", Offset = "0x5BF150", VA = "0x1805C0750", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(DebugCancelMission other)
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

		[Cpp2IlInjected.Token(Token = "0x6002858")]
		[Cpp2IlInjected.Address(RVA = "0x5C07E0", Offset = "0x5BF1E0", VA = "0x1805C07E0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return _unknownFields?.GetHashCode() ?? 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6002859")]
		[Cpp2IlInjected.Address(RVA = "0x18C8D00", Offset = "0x18C7700", VA = "0x1818C8D00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600285A")]
		[Cpp2IlInjected.Address(RVA = "0x5C0930", Offset = "0x5BF330", VA = "0x1805C0930", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600285B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0620", Offset = "0x5BF020", VA = "0x1805C0620", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return _unknownFields?.CalculateSize() ?? 0;
		}

		[Cpp2IlInjected.Token(Token = "0x600285C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0880", Offset = "0x5BF280", VA = "0x1805C0880", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(DebugCancelMission other)
		{
			if (other != null)
			{
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600285D")]
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

		[Cpp2IlInjected.Token(Token = "0x600285E")]
		[Cpp2IlInjected.Address(RVA = "0x18C8C90", Offset = "0x18C7690", VA = "0x1818C8C90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600285F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002860")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6002861")]
		[Cpp2IlInjected.Address(RVA = "0x18C8D60", Offset = "0x18C7760", VA = "0x1818C8D60")]
		static DebugCancelMission()
		{
			Func<DebugCancelMission> func = default(Func<DebugCancelMission>);
			_parser = (MessageParser<DebugCancelMission>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
