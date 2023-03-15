using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Scene;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000446")]
	public sealed class LocationAnywhereVillageArea : IMessage<LocationAnywhereVillageArea>, IMessage, IEquatable<LocationAnywhereVillageArea>, IDeepCloneable<LocationAnywhereVillageArea>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400176C")]
		private static readonly MessageParser<LocationAnywhereVillageArea> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400176D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400176E")]
		public const int LocationFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400176F")]
		private VillageAreaType location_;

		[Cpp2IlInjected.Token(Token = "0x17000D79")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationAnywhereVillageArea> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600348D")]
			[Cpp2IlInjected.Address(RVA = "0x2752D80", Offset = "0x2751780", VA = "0x182752D80")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600348E")]
			[Cpp2IlInjected.Address(RVA = "0x2752CB0", Offset = "0x27516B0", VA = "0x182752CB0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600348F")]
			[Cpp2IlInjected.Address(RVA = "0x2752DE0", Offset = "0x27517E0", VA = "0x182752DE0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D7C")]
		[DebuggerNonUserCode]
		public VillageAreaType Location
		{
			[Cpp2IlInjected.Token(Token = "0x6003493")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return location_;
			}
			[Cpp2IlInjected.Token(Token = "0x6003494")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				location_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003490")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LocationAnywhereVillageArea()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6003491")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public LocationAnywhereVillageArea(LocationAnywhereVillageArea other)
		{
			VillageAreaType villageAreaType = (location_ = other.location_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6003492")]
		[Cpp2IlInjected.Address(RVA = "0x2752900", Offset = "0x2751300", VA = "0x182752900", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationAnywhereVillageArea Clone()
		{
			//Discarded unreachable code: IL_0029
			LocationAnywhereVillageArea locationAnywhereVillageArea = new LocationAnywhereVillageArea();
			VillageAreaType villageAreaType = (locationAnywhereVillageArea.location_ = location_);
			UnknownFieldSet unknownFieldSet = (locationAnywhereVillageArea._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationAnywhereVillageArea;
		}

		[Cpp2IlInjected.Token(Token = "0x6003495")]
		[Cpp2IlInjected.Address(RVA = "0x2752980", Offset = "0x2751380", VA = "0x182752980", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)location_ == (IntPtr)typeof(LocationAnywhereVillageArea).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003496")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationAnywhereVillageArea other)
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

		[Cpp2IlInjected.Token(Token = "0x6003497")]
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

		[Cpp2IlInjected.Token(Token = "0x6003498")]
		[Cpp2IlInjected.Address(RVA = "0x2752B40", Offset = "0x2751540", VA = "0x182752B40", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003499")]
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

		[Cpp2IlInjected.Token(Token = "0x600349A")]
		[Cpp2IlInjected.Address(RVA = "0x2752860", Offset = "0x2751260", VA = "0x182752860", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x600349B")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationAnywhereVillageArea other)
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

		[Cpp2IlInjected.Token(Token = "0x600349C")]
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

		[Cpp2IlInjected.Token(Token = "0x600349D")]
		[Cpp2IlInjected.Address(RVA = "0x2752A10", Offset = "0x2751410", VA = "0x182752A10", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x600349E")]
		[Cpp2IlInjected.Address(RVA = "0x2752AC0", Offset = "0x27514C0", VA = "0x182752AC0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600349F")]
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

		[Cpp2IlInjected.Token(Token = "0x60034A0")]
		[Cpp2IlInjected.Address(RVA = "0x2752BA0", Offset = "0x27515A0", VA = "0x182752BA0")]
		static LocationAnywhereVillageArea()
		{
			Func<LocationAnywhereVillageArea> func = default(Func<LocationAnywhereVillageArea>);
			_parser = (MessageParser<LocationAnywhereVillageArea>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
