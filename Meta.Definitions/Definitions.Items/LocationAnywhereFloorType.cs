using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Grid;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000444")]
	public sealed class LocationAnywhereFloorType : IMessage<LocationAnywhereFloorType>, IMessage, IEquatable<LocationAnywhereFloorType>, IDeepCloneable<LocationAnywhereFloorType>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001767")]
		private static readonly MessageParser<LocationAnywhereFloorType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001768")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001769")]
		public const int TypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400176A")]
		private GridFloorType type_;

		[Cpp2IlInjected.Token(Token = "0x17000D75")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationAnywhereFloorType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003476")]
			[Cpp2IlInjected.Address(RVA = "0x2751E00", Offset = "0x2750800", VA = "0x182751E00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D76")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003477")]
			[Cpp2IlInjected.Address(RVA = "0x2751D30", Offset = "0x2750730", VA = "0x182751D30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D77")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003478")]
			[Cpp2IlInjected.Address(RVA = "0x2751E60", Offset = "0x2750860", VA = "0x182751E60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D78")]
		[DebuggerNonUserCode]
		public GridFloorType Type
		{
			[Cpp2IlInjected.Token(Token = "0x600347C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return type_;
			}
			[Cpp2IlInjected.Token(Token = "0x600347D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				type_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003479")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LocationAnywhereFloorType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600347A")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public LocationAnywhereFloorType(LocationAnywhereFloorType other)
		{
			GridFloorType gridFloorType = (type_ = other.type_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600347B")]
		[Cpp2IlInjected.Address(RVA = "0x2751980", Offset = "0x2750380", VA = "0x182751980", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationAnywhereFloorType Clone()
		{
			//Discarded unreachable code: IL_0029
			LocationAnywhereFloorType locationAnywhereFloorType = new LocationAnywhereFloorType();
			GridFloorType gridFloorType = (locationAnywhereFloorType.type_ = type_);
			UnknownFieldSet unknownFieldSet = (locationAnywhereFloorType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationAnywhereFloorType;
		}

		[Cpp2IlInjected.Token(Token = "0x600347E")]
		[Cpp2IlInjected.Address(RVA = "0x2751A00", Offset = "0x2750400", VA = "0x182751A00", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)type_ == (IntPtr)typeof(LocationAnywhereFloorType).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600347F")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationAnywhereFloorType other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				GridFloorType gridFloorType = other.type_;
				if (type_ == gridFloorType)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003480")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (type_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003481")]
		[Cpp2IlInjected.Address(RVA = "0x2751BC0", Offset = "0x27505C0", VA = "0x182751BC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003482")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_001c
			if (type_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003483")]
		[Cpp2IlInjected.Address(RVA = "0x27518E0", Offset = "0x27502E0", VA = "0x1827518E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				GridFloorType gridFloorType = type_;
				num = 0;
				if (gridFloorType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)gridFloorType);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x6003484")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationAnywhereFloorType other)
		{
			if (other != null)
			{
				GridFloorType gridFloorType = other.type_;
				if (gridFloorType != 0)
				{
					type_ = gridFloorType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003485")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(type_ = (GridFloorType)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003486")]
		[Cpp2IlInjected.Address(RVA = "0x2751A90", Offset = "0x2750490", VA = "0x182751A90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				GridFloorType gridFloorType = type_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003487")]
		[Cpp2IlInjected.Address(RVA = "0x2751B40", Offset = "0x2750540", VA = "0x182751B40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				type_ = (GridFloorType)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003488")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				type_ = GridFloorType.Void;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003489")]
		[Cpp2IlInjected.Address(RVA = "0x2751C20", Offset = "0x2750620", VA = "0x182751C20")]
		static LocationAnywhereFloorType()
		{
			Func<LocationAnywhereFloorType> func = default(Func<LocationAnywhereFloorType>);
			_parser = (MessageParser<LocationAnywhereFloorType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
