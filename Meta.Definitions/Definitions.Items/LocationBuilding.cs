using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200044E")]
	public sealed class LocationBuilding : IMessage<LocationBuilding>, IMessage, IEquatable<LocationBuilding>, IDeepCloneable<LocationBuilding>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001780")]
		private static readonly MessageParser<LocationBuilding> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001781")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001782")]
		public const int BuildingFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001783")]
		private int building_;

		[Cpp2IlInjected.Token(Token = "0x17000D8B")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationBuilding> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60034EF")]
			[Cpp2IlInjected.Address(RVA = "0x2753AA0", Offset = "0x27524A0", VA = "0x182753AA0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60034F0")]
			[Cpp2IlInjected.Address(RVA = "0x27539D0", Offset = "0x27523D0", VA = "0x1827539D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60034F1")]
			[Cpp2IlInjected.Address(RVA = "0x2753B00", Offset = "0x2752500", VA = "0x182753B00", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D8E")]
		[DebuggerNonUserCode]
		public int Building
		{
			[Cpp2IlInjected.Token(Token = "0x60034F5")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return building_;
			}
			[Cpp2IlInjected.Token(Token = "0x60034F6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				building_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034F2")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LocationBuilding()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60034F3")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public LocationBuilding(LocationBuilding other)
		{
			int num = (building_ = other.building_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034F4")]
		[Cpp2IlInjected.Address(RVA = "0x2753620", Offset = "0x2752020", VA = "0x182753620", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationBuilding Clone()
		{
			//Discarded unreachable code: IL_0029
			LocationBuilding locationBuilding = new LocationBuilding();
			int num = (locationBuilding.building_ = building_);
			UnknownFieldSet unknownFieldSet = (locationBuilding._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationBuilding;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F7")]
		[Cpp2IlInjected.Address(RVA = "0x27536A0", Offset = "0x27520A0", VA = "0x1827536A0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)building_ == (IntPtr)typeof(LocationBuilding).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F8")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationBuilding other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.building_;
				if (building_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034F9")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (building_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60034FA")]
		[Cpp2IlInjected.Address(RVA = "0x2753860", Offset = "0x2752260", VA = "0x182753860", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60034FB")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (building_ != 0)
			{
				int value = building_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60034FC")]
		[Cpp2IlInjected.Address(RVA = "0x2753580", Offset = "0x2751F80", VA = "0x182753580", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = building_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x60034FD")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationBuilding other)
		{
			if (other != null)
			{
				int num = other.building_;
				if (num != 0)
				{
					building_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034FE")]
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
					int num2 = (building_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034FF")]
		[Cpp2IlInjected.Address(RVA = "0x2753730", Offset = "0x2752130", VA = "0x182753730", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = building_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003500")]
		[Cpp2IlInjected.Address(RVA = "0x27537E0", Offset = "0x27521E0", VA = "0x1827537E0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				building_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003501")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				building_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003502")]
		[Cpp2IlInjected.Address(RVA = "0x27538C0", Offset = "0x27522C0", VA = "0x1827538C0")]
		static LocationBuilding()
		{
			Func<LocationBuilding> func = default(Func<LocationBuilding>);
			_parser = (MessageParser<LocationBuilding>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
