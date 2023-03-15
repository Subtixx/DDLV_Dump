using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Meta.Customization
{
	[Cpp2IlInjected.Token(Token = "0x20010FC")]
	public sealed class ClothingDesignData : IMessage<ClothingDesignData>, IMessage, IEquatable<ClothingDesignData>, IDeepCloneable<ClothingDesignData>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4004616")]
		private static readonly MessageParser<ClothingDesignData> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4004617")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4004618")]
		public const int LimitFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4004619")]
		private int limit_;

		[Cpp2IlInjected.Token(Token = "0x1700183C")]
		[DebuggerNonUserCode]
		public static MessageParser<ClothingDesignData> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6008A74")]
			[Cpp2IlInjected.Address(RVA = "0x1674680", Offset = "0x1673080", VA = "0x181674680")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A75")]
			[Cpp2IlInjected.Address(RVA = "0x16745B0", Offset = "0x1672FB0", VA = "0x1816745B0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6008A76")]
			[Cpp2IlInjected.Address(RVA = "0x16746E0", Offset = "0x16730E0", VA = "0x1816746E0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700183F")]
		[DebuggerNonUserCode]
		public int Limit
		{
			[Cpp2IlInjected.Token(Token = "0x6008A7A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return limit_;
			}
			[Cpp2IlInjected.Token(Token = "0x6008A7B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				limit_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A77")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ClothingDesignData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6008A78")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ClothingDesignData(ClothingDesignData other)
		{
			int num = (limit_ = other.limit_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A79")]
		[Cpp2IlInjected.Address(RVA = "0x1674200", Offset = "0x1672C00", VA = "0x181674200", Slot = "10")]
		[DebuggerNonUserCode]
		public ClothingDesignData Clone()
		{
			//Discarded unreachable code: IL_0029
			ClothingDesignData clothingDesignData = new ClothingDesignData();
			int num = (clothingDesignData.limit_ = limit_);
			UnknownFieldSet unknownFieldSet = (clothingDesignData._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return clothingDesignData;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A7C")]
		[Cpp2IlInjected.Address(RVA = "0x1674280", Offset = "0x1672C80", VA = "0x181674280", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)limit_ == (IntPtr)typeof(ClothingDesignData).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A7D")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ClothingDesignData other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.limit_;
				if (limit_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A7E")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (limit_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6008A7F")]
		[Cpp2IlInjected.Address(RVA = "0x1674440", Offset = "0x1672E40", VA = "0x181674440", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6008A80")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (limit_ != 0)
			{
				int value = limit_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6008A81")]
		[Cpp2IlInjected.Address(RVA = "0x1674160", Offset = "0x1672B60", VA = "0x181674160", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = limit_;
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

		[Cpp2IlInjected.Token(Token = "0x6008A82")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ClothingDesignData other)
		{
			if (other != null)
			{
				int num = other.limit_;
				if (num != 0)
				{
					limit_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A83")]
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
					int num2 = (limit_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A84")]
		[Cpp2IlInjected.Address(RVA = "0x1674310", Offset = "0x1672D10", VA = "0x181674310", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = limit_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6008A85")]
		[Cpp2IlInjected.Address(RVA = "0x16743C0", Offset = "0x1672DC0", VA = "0x1816743C0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				limit_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A86")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				limit_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6008A87")]
		[Cpp2IlInjected.Address(RVA = "0x16744A0", Offset = "0x1672EA0", VA = "0x1816744A0")]
		static ClothingDesignData()
		{
			Func<ClothingDesignData> func = default(Func<ClothingDesignData>);
			_parser = (MessageParser<ClothingDesignData>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
