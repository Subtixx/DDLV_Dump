using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000501")]
	public sealed class LocationInHouse : IMessage<LocationInHouse>, IMessage, IEquatable<LocationInHouse>, IDeepCloneable<LocationInHouse>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001ABD")]
		private static readonly MessageParser<LocationInHouse> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001ABE")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001ABF")]
		public const int BuildingFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001AC0")]
		private int building_;

		[Cpp2IlInjected.Token(Token = "0x17000FD8")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationInHouse> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003DD4")]
			[Cpp2IlInjected.Address(RVA = "0x2755390", Offset = "0x2753D90", VA = "0x182755390")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FD9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003DD5")]
			[Cpp2IlInjected.Address(RVA = "0x27552C0", Offset = "0x2753CC0", VA = "0x1827552C0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003DD6")]
			[Cpp2IlInjected.Address(RVA = "0x27553F0", Offset = "0x2753DF0", VA = "0x1827553F0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000FDB")]
		[DebuggerNonUserCode]
		public int Building
		{
			[Cpp2IlInjected.Token(Token = "0x6003DDA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return building_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003DDB")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				building_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003DD7")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LocationInHouse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003DD8")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public LocationInHouse(LocationInHouse other)
		{
			int num = (building_ = other.building_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003DD9")]
		[Cpp2IlInjected.Address(RVA = "0x2754F10", Offset = "0x2753910", VA = "0x182754F10", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationInHouse Clone()
		{
			//Discarded unreachable code: IL_0029
			LocationInHouse locationInHouse = new LocationInHouse();
			int num = (locationInHouse.building_ = building_);
			UnknownFieldSet unknownFieldSet = (locationInHouse._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationInHouse;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DDC")]
		[Cpp2IlInjected.Address(RVA = "0x2754F90", Offset = "0x2753990", VA = "0x182754F90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)building_ == (IntPtr)typeof(LocationInHouse).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003DDD")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationInHouse other)
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

		[Cpp2IlInjected.Token(Token = "0x6003DDE")]
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

		[Cpp2IlInjected.Token(Token = "0x6003DDF")]
		[Cpp2IlInjected.Address(RVA = "0x2755150", Offset = "0x2753B50", VA = "0x182755150", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003DE0")]
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

		[Cpp2IlInjected.Token(Token = "0x6003DE1")]
		[Cpp2IlInjected.Address(RVA = "0x2754E70", Offset = "0x2753870", VA = "0x182754E70", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6003DE2")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationInHouse other)
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

		[Cpp2IlInjected.Token(Token = "0x6003DE3")]
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

		[Cpp2IlInjected.Token(Token = "0x6003DE4")]
		[Cpp2IlInjected.Address(RVA = "0x2755020", Offset = "0x2753A20", VA = "0x182755020", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6003DE5")]
		[Cpp2IlInjected.Address(RVA = "0x27550D0", Offset = "0x2753AD0", VA = "0x1827550D0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x6003DE6")]
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

		[Cpp2IlInjected.Token(Token = "0x6003DE7")]
		[Cpp2IlInjected.Address(RVA = "0x27551B0", Offset = "0x2753BB0", VA = "0x1827551B0")]
		static LocationInHouse()
		{
			Func<LocationInHouse> func = default(Func<LocationInHouse>);
			_parser = (MessageParser<LocationInHouse>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
