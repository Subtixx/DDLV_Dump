using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x2000450")]
	public sealed class LocationAvatarFront : IMessage<LocationAvatarFront>, IMessage, IEquatable<LocationAvatarFront>, IDeepCloneable<LocationAvatarFront>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001785")]
		private static readonly MessageParser<LocationAvatarFront> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001786")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001787")]
		public const int DistanceFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001788")]
		private int distance_;

		[Cpp2IlInjected.Token(Token = "0x17000D8F")]
		[DebuggerNonUserCode]
		public static MessageParser<LocationAvatarFront> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6003506")]
			[Cpp2IlInjected.Address(RVA = "0x2753410", Offset = "0x2751E10", VA = "0x182753410")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D90")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003507")]
			[Cpp2IlInjected.Address(RVA = "0x2753340", Offset = "0x2751D40", VA = "0x182753340")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D91")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6003508")]
			[Cpp2IlInjected.Address(RVA = "0x2753470", Offset = "0x2751E70", VA = "0x182753470", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000D92")]
		[DebuggerNonUserCode]
		public int Distance
		{
			[Cpp2IlInjected.Token(Token = "0x600350C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return distance_;
			}
			[Cpp2IlInjected.Token(Token = "0x600350D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				distance_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003509")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public LocationAvatarFront()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600350A")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public LocationAvatarFront(LocationAvatarFront other)
		{
			int num = (distance_ = other.distance_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600350B")]
		[Cpp2IlInjected.Address(RVA = "0x2752F90", Offset = "0x2751990", VA = "0x182752F90", Slot = "10")]
		[DebuggerNonUserCode]
		public LocationAvatarFront Clone()
		{
			//Discarded unreachable code: IL_0029
			LocationAvatarFront locationAvatarFront = new LocationAvatarFront();
			int num = (locationAvatarFront.distance_ = distance_);
			UnknownFieldSet unknownFieldSet = (locationAvatarFront._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return locationAvatarFront;
		}

		[Cpp2IlInjected.Token(Token = "0x600350E")]
		[Cpp2IlInjected.Address(RVA = "0x2753010", Offset = "0x2751A10", VA = "0x182753010", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)distance_ == (IntPtr)typeof(LocationAvatarFront).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600350F")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(LocationAvatarFront other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.distance_;
				if (distance_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003510")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (distance_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6003511")]
		[Cpp2IlInjected.Address(RVA = "0x27531D0", Offset = "0x2751BD0", VA = "0x1827531D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6003512")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (distance_ != 0)
			{
				int value = distance_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6003513")]
		[Cpp2IlInjected.Address(RVA = "0x2752EF0", Offset = "0x27518F0", VA = "0x182752EF0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = distance_;
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

		[Cpp2IlInjected.Token(Token = "0x6003514")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(LocationAvatarFront other)
		{
			if (other != null)
			{
				int num = other.distance_;
				if (num != 0)
				{
					distance_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003515")]
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
					int num2 = (distance_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003516")]
		[Cpp2IlInjected.Address(RVA = "0x27530A0", Offset = "0x2751AA0", VA = "0x1827530A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = distance_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6003517")]
		[Cpp2IlInjected.Address(RVA = "0x2753150", Offset = "0x2751B50", VA = "0x182753150", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				distance_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003518")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				distance_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6003519")]
		[Cpp2IlInjected.Address(RVA = "0x2753230", Offset = "0x2751C30", VA = "0x182753230")]
		static LocationAvatarFront()
		{
			Func<LocationAvatarFront> func = default(Func<LocationAvatarFront>);
			_parser = (MessageParser<LocationAvatarFront>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
