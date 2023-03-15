using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Sw
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class MinMax : IMessage<MinMax>, IMessage, IEquatable<MinMax>, IDeepCloneable<MinMax>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly MessageParser<MinMax> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public const int MinFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int min_;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public const int MaxFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int max_;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[DebuggerNonUserCode]
		public static MessageParser<MinMax> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A660", Offset = "0x1D29060", VA = "0x181D2A660")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A590", Offset = "0x1D28F90", VA = "0x181D2A590")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x1D2A6C0", Offset = "0x1D290C0", VA = "0x181D2A6C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		[DebuggerNonUserCode]
		public int Min
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return min_;
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				min_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[DebuggerNonUserCode]
		public int Max
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return max_;
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				max_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MinMax()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public MinMax(MinMax other)
		{
			int num = (min_ = other.min_);
			int num2 = (max_ = other.max_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A180", Offset = "0x1D28B80", VA = "0x181D2A180", Slot = "10")]
		[DebuggerNonUserCode]
		public MinMax Clone()
		{
			//Discarded unreachable code: IL_0037
			MinMax minMax = new MinMax();
			int num = (minMax.min_ = min_);
			int num2 = (minMax.max_ = max_);
			UnknownFieldSet unknownFieldSet = (minMax._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return minMax;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A210", Offset = "0x1D28C10", VA = "0x181D2A210", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)min_ == (IntPtr)typeof(MinMax).TypeHandle && (IntPtr)max_ == (IntPtr)typeof(MinMax).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MinMax other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.min_;
				if (min_ == num)
				{
					int num2 = other.max_;
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

		[Cpp2IlInjected.Token(Token = "0x600001E")]
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

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A420", Offset = "0x1D28E20", VA = "0x181D2A420", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (min_ != 0)
			{
				int value = min_;
				output.WriteInt32(value);
			}
			if (max_ != 0)
			{
				int value2 = max_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A0B0", Offset = "0x1D28AB0", VA = "0x181D2A0B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = min_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = max_;
				if (num4 != 0)
				{
					int num5 = CodedOutputStream.ComputeInt32Size(num4);
					num5++;
					num2 += num5;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num6 = unknownFields.CalculateSize();
			return num6 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MinMax other)
		{
			if (other != null)
			{
				int num = other.min_;
				if (num != 0)
				{
					min_ = num;
				}
				int num2 = other.max_;
				if (num2 != 0)
				{
					max_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
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
					int num2 = (min_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (max_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A2A0", Offset = "0x1D28CA0", VA = "0x181D2A2A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = min_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A360", Offset = "0x1D28D60", VA = "0x181D2A360", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				min_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			max_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				min_ = 0;
				break;
			case 2:
				max_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1D2A480", Offset = "0x1D28E80", VA = "0x181D2A480")]
		static MinMax()
		{
			Func<MinMax> func = default(Func<MinMax>);
			_parser = (MessageParser<MinMax>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
