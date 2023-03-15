using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x200044A")]
	public sealed class LocationFishingSpot : IMessage<LocationFishingSpot>, IMessage, IEquatable<LocationFishingSpot>, IDeepCloneable<LocationFishingSpot>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001776")]
		private static readonly MessageParser<LocationFishingSpot> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001777")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001778")]
		public const int LocationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001779")]
		private VillageAreaType location_;

		[Cpp2IlInjected.Token(Token = "0x17000D83")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationFishingSpot> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60034C0")]
			[Cpp2IlInjected.Address(RVA = "0x2754D00", Offset = "0x2753700", VA = "0x182754D00")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D84")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60034C1")]
			[Cpp2IlInjected.Address(RVA = "0x2754C30", Offset = "0x2753630", VA = "0x182754C30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D85")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60034C2")]
			[Cpp2IlInjected.Address(RVA = "0x2754D60", Offset = "0x2753760", VA = "0x182754D60", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D86")]
		[DebuggerNonUserCode]
		public VillageAreaType Location
		{
			[Cpp2IlInjected.Token(Token = "0x60034C6")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x60034C7")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034C3")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LocationFishingSpot()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60034C4")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public LocationFishingSpot(LocationFishingSpot other)
		{
			VillageAreaType villageAreaType = (location_ = other.location_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60034C5")]
		[Cpp2IlInjected.Address(RVA = "0x2754880", Offset = "0x2753280", VA = "0x182754880", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationFishingSpot Clone()
		{
			//Discarded unreachable code: IL_0029
			LocationFishingSpot locationFishingSpot = new LocationFishingSpot();
			VillageAreaType villageAreaType = (locationFishingSpot.location_ = location_);
			UnknownFieldSet unknownFieldSet = (locationFishingSpot._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationFishingSpot;
		}

		[Cpp2IlInjected.Token(Token = "0x60034C8")]
		[Cpp2IlInjected.Address(RVA = "0x2754900", Offset = "0x2753300", VA = "0x182754900", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)location_ == (IntPtr)typeof(LocationFishingSpot).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationFishingSpot other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				VillageAreaType villageAreaType = other.location_;
				if (location_ == villageAreaType)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (location_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x60034CB")]
		[Cpp2IlInjected.Address(RVA = "0x2754AC0", Offset = "0x27534C0", VA = "0x182754AC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60034CC")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_001c
			if (location_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60034CD")]
		[Cpp2IlInjected.Address(RVA = "0x27547E0", Offset = "0x27531E0", VA = "0x1827547E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num;
			UnknownFieldSet unknownFields;
			do
			{
				VillageAreaType villageAreaType = location_;
				num = 0;
				if (villageAreaType != 0)
				{
					int num2 = CodedOutputStream.ComputeEnumSize((int)villageAreaType);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num3 = unknownFields.CalculateSize();
			return num3 + num;
		}

		[Cpp2IlInjected.Token(Token = "0x60034CE")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationFishingSpot other)
		{
			if (other != null)
			{
				VillageAreaType villageAreaType = other.location_;
				if (villageAreaType != 0)
				{
					location_ = villageAreaType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034CF")]
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
					int num2 = (int)(location_ = (VillageAreaType)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034D0")]
		[Cpp2IlInjected.Address(RVA = "0x2754990", Offset = "0x2753390", VA = "0x182754990", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				VillageAreaType villageAreaType = location_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60034D1")]
		[Cpp2IlInjected.Address(RVA = "0x2754A40", Offset = "0x2753440", VA = "0x182754A40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				location_ = (VillageAreaType)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034D2")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				location_ = VillageAreaType.Beach;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60034D3")]
		[Cpp2IlInjected.Address(RVA = "0x2754B20", Offset = "0x2753520", VA = "0x182754B20")]
		static LocationFishingSpot()
		{
			Func<LocationFishingSpot> func = default(Func<LocationFishingSpot>);
			_parser = (MessageParser<LocationFishingSpot>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
