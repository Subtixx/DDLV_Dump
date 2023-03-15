using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005A2")]
	public sealed class CollectionTypeWithLocation : IMessage<CollectionTypeWithLocation>, IMessage, IEquatable<CollectionTypeWithLocation>, IDeepCloneable<CollectionTypeWithLocation>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001EE5")]
		private static readonly MessageParser<CollectionTypeWithLocation> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001EE6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001EE7")]
		public const int UseLocationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001EE8")]
		private bool useLocation_;

		[Cpp2IlInjected.Token(Token = "0x4001EE9")]
		public const int LocationFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4001EEA")]
		private VillageAreaType location_;

		[Cpp2IlInjected.Token(Token = "0x17001245")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionTypeWithLocation> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004677")]
			[Cpp2IlInjected.Address(RVA = "0x320EB30", Offset = "0x320D530", VA = "0x18320EB30")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001246")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004678")]
			[Cpp2IlInjected.Address(RVA = "0x320EA60", Offset = "0x320D460", VA = "0x18320EA60")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001247")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004679")]
			[Cpp2IlInjected.Address(RVA = "0x320EB90", Offset = "0x320D590", VA = "0x18320EB90", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001248")]
		[DebuggerNonUserCode]
		public bool UseLocation
		{
			[Cpp2IlInjected.Token(Token = "0x600467D")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return useLocation_;
			}
			[Cpp2IlInjected.Token(Token = "0x600467E")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				useLocation_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001249")]
		[DebuggerNonUserCode]
		public VillageAreaType Location
		{
			[Cpp2IlInjected.Token(Token = "0x600467F")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004680")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600467A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionTypeWithLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600467B")]
		[Cpp2IlInjected.Address(RVA = "0x7187C0", Offset = "0x7171C0", VA = "0x1807187C0")]
		[DebuggerNonUserCode]
		public CollectionTypeWithLocation(CollectionTypeWithLocation other)
		{
			bool flag = (useLocation_ = other.useLocation_);
			VillageAreaType villageAreaType = (location_ = other.location_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600467C")]
		[Cpp2IlInjected.Address(RVA = "0x320E610", Offset = "0x320D010", VA = "0x18320E610", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionTypeWithLocation Clone()
		{
			//Discarded unreachable code: IL_0037
			CollectionTypeWithLocation collectionTypeWithLocation = new CollectionTypeWithLocation();
			bool flag = (collectionTypeWithLocation.useLocation_ = useLocation_);
			VillageAreaType villageAreaType = (collectionTypeWithLocation.location_ = location_);
			UnknownFieldSet unknownFieldSet = (collectionTypeWithLocation._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionTypeWithLocation;
		}

		[Cpp2IlInjected.Token(Token = "0x6004681")]
		[Cpp2IlInjected.Address(RVA = "0x320E6A0", Offset = "0x320D0A0", VA = "0x18320E6A0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(useLocation_ ? 1 : 0) == (IntPtr)typeof(CollectionTypeWithLocation).TypeHandle && (IntPtr)(void*)(int)location_ == (IntPtr)typeof(CollectionTypeWithLocation).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004682")]
		[Cpp2IlInjected.Address(RVA = "0x718240", Offset = "0x716C40", VA = "0x180718240", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionTypeWithLocation other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.useLocation_;
				if (useLocation_ == flag)
				{
					VillageAreaType villageAreaType = other.location_;
					if (location_ == villageAreaType)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004683")]
		[Cpp2IlInjected.Address(RVA = "0x718370", Offset = "0x716D70", VA = "0x180718370", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (useLocation_)
				{
				}
				if (location_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004684")]
		[Cpp2IlInjected.Address(RVA = "0x320E8F0", Offset = "0x320D2F0", VA = "0x18320E8F0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004685")]
		[Cpp2IlInjected.Address(RVA = "0x718620", Offset = "0x717020", VA = "0x180718620", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0033
			if (useLocation_)
			{
				bool value = useLocation_;
				output.WriteBool(value);
			}
			if (location_ != 0)
			{
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004686")]
		[Cpp2IlInjected.Address(RVA = "0x320E570", Offset = "0x320CF70", VA = "0x18320E570", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				VillageAreaType villageAreaType = location_;
				if (villageAreaType != 0)
				{
					int num = CodedOutputStream.ComputeEnumSize((int)villageAreaType);
					num++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x6004687")]
		[Cpp2IlInjected.Address(RVA = "0x718490", Offset = "0x716E90", VA = "0x180718490", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionTypeWithLocation other)
		{
			if (other != null)
			{
				bool flag = other.useLocation_;
				if (flag)
				{
					useLocation_ = flag;
				}
				VillageAreaType villageAreaType = other.location_;
				if (villageAreaType != 0)
				{
					location_ = villageAreaType;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004688")]
		[Cpp2IlInjected.Address(RVA = "0x718400", Offset = "0x716E00", VA = "0x180718400", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (useLocation_ = input.ReadBool());
				}
				if (num == 16)
				{
					int num2 = (int)(location_ = (VillageAreaType)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004689")]
		[Cpp2IlInjected.Address(RVA = "0x320E730", Offset = "0x320D130", VA = "0x18320E730", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				bool flag = useLocation_;
			}
			if (fieldNumber == 2)
			{
				VillageAreaType villageAreaType = location_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600468A")]
		[Cpp2IlInjected.Address(RVA = "0x320E820", Offset = "0x320D220", VA = "0x18320E820", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				useLocation_ = (byte)(int)obj != 0;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			location_ = (VillageAreaType)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x600468B")]
		[Cpp2IlInjected.Address(RVA = "0x718100", Offset = "0x716B00", VA = "0x180718100", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0019: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				useLocation_ = false;
				break;
			case 2:
				location_ = VillageAreaType.Beach;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600468C")]
		[Cpp2IlInjected.Address(RVA = "0x320E950", Offset = "0x320D350", VA = "0x18320E950")]
		static CollectionTypeWithLocation()
		{
			Func<CollectionTypeWithLocation> func = default(Func<CollectionTypeWithLocation>);
			_parser = (MessageParser<CollectionTypeWithLocation>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
