using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Sw
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class MinMaxUnsigned : IMessage<MinMaxUnsigned>, IMessage, IEquatable<MinMaxUnsigned>, IDeepCloneable<MinMaxUnsigned>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly MessageParser<MinMaxUnsigned> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public const int MinFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private uint min_;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public const int MaxFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private uint max_;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerNonUserCode]
		public static MessageParser<MinMaxUnsigned> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1D29F40", Offset = "0x1D28940", VA = "0x181D29F40")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1D29E70", Offset = "0x1D28870", VA = "0x181D29E70")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1D29FA0", Offset = "0x1D289A0", VA = "0x181D29FA0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[DebuggerNonUserCode]
		public uint Min
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return min_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				min_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[DebuggerNonUserCode]
		public uint Max
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return max_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				max_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MinMaxUnsigned()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public MinMaxUnsigned(MinMaxUnsigned other)
		{
			uint num = (min_ = other.min_);
			uint num2 = (max_ = other.max_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D29A60", Offset = "0x1D28460", VA = "0x181D29A60", Slot = "10")]
		[DebuggerNonUserCode]
		public MinMaxUnsigned Clone()
		{
			//Discarded unreachable code: IL_0037
			MinMaxUnsigned minMaxUnsigned = new MinMaxUnsigned();
			uint num = (minMaxUnsigned.min_ = min_);
			uint num2 = (minMaxUnsigned.max_ = max_);
			UnknownFieldSet unknownFieldSet = (minMaxUnsigned._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return minMaxUnsigned;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D29AF0", Offset = "0x1D284F0", VA = "0x181D29AF0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(int)min_ == (IntPtr)typeof(MinMaxUnsigned).TypeHandle && (IntPtr)(int)max_ == (IntPtr)typeof(MinMaxUnsigned).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MinMaxUnsigned other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				uint num = other.min_;
				if (min_ == num)
				{
					uint num2 = other.max_;
					if (max_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (min_ != 0)
				{
				}
				if (max_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1D29D00", Offset = "0x1D28700", VA = "0x181D29D00", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x108E870", Offset = "0x108D270", VA = "0x18108E870", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0043
			if (min_ != 0)
			{
				uint value = min_;
				output.WriteUInt32(value);
			}
			if (max_ != 0)
			{
				uint value2 = max_;
				output.WriteUInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D29990", Offset = "0x1D28390", VA = "0x181D29990", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				uint num = min_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeUInt32Size(num);
				}
				uint num4 = max_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeUInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MinMaxUnsigned other)
		{
			if (other != null)
			{
				uint num = other.min_;
				if (num != 0)
				{
					min_ = num;
				}
				uint num2 = other.max_;
				if (num2 != 0)
				{
					max_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x645D70", Offset = "0x644770", VA = "0x180645D70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(min_ = (uint)input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (int)(max_ = (uint)input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1D29B80", Offset = "0x1D28580", VA = "0x181D29B80", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				uint num = min_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1D29C40", Offset = "0x1D28640", VA = "0x181D29C40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				min_ = (uint)(int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			max_ = (uint)(int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				min_ = 0u;
				break;
			case 2:
				max_ = 0u;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D29D60", Offset = "0x1D28760", VA = "0x181D29D60")]
		static MinMaxUnsigned()
		{
			Func<MinMaxUnsigned> func = default(Func<MinMaxUnsigned>);
			_parser = (MessageParser<MinMaxUnsigned>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
