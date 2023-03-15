using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Grid
{
	[Cpp2IlInjected.Token(Token = "0x2000709")]
	public sealed class AreaSize : IMessage<AreaSize>, IMessage, IEquatable<AreaSize>, IDeepCloneable<AreaSize>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400239E")]
		private static readonly MessageParser<AreaSize> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400239F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40023A0")]
		public const int XFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40023A1")]
		private int x_;

		[Cpp2IlInjected.Token(Token = "0x40023A2")]
		public const int YFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40023A3")]
		private int y_;

		[Cpp2IlInjected.Token(Token = "0x17001413")]
		[DebuggerNonUserCode]
		public static MessageParser<AreaSize> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004E74")]
			[Cpp2IlInjected.Address(RVA = "0x26EEE90", Offset = "0x26ED890", VA = "0x1826EEE90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001414")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E75")]
			[Cpp2IlInjected.Address(RVA = "0x26EEDC0", Offset = "0x26ED7C0", VA = "0x1826EEDC0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001415")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004E76")]
			[Cpp2IlInjected.Address(RVA = "0x26EEEF0", Offset = "0x26ED8F0", VA = "0x1826EEEF0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001416")]
		[DebuggerNonUserCode]
		public int X
		{
			[Cpp2IlInjected.Token(Token = "0x6004E7A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return x_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E7B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				x_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001417")]
		[DebuggerNonUserCode]
		public int Y
		{
			[Cpp2IlInjected.Token(Token = "0x6004E7C")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return y_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004E7D")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				y_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E77")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public AreaSize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004E78")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public AreaSize(AreaSize other)
		{
			int num = (x_ = other.x_);
			int num2 = (y_ = other.y_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E79")]
		[Cpp2IlInjected.Address(RVA = "0x26EE9B0", Offset = "0x26ED3B0", VA = "0x1826EE9B0", Slot = "10")]
		[DebuggerNonUserCode]
		public AreaSize Clone()
		{
			//Discarded unreachable code: IL_0037
			AreaSize areaSize = new AreaSize();
			int num = (areaSize.x_ = x_);
			int num2 = (areaSize.y_ = y_);
			UnknownFieldSet unknownFieldSet = (areaSize._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return areaSize;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E7E")]
		[Cpp2IlInjected.Address(RVA = "0x26EEA40", Offset = "0x26ED440", VA = "0x1826EEA40", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)x_ == (IntPtr)typeof(AreaSize).TypeHandle && (IntPtr)y_ == (IntPtr)typeof(AreaSize).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E7F")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(AreaSize other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.x_;
				if (x_ == num)
				{
					int num2 = other.y_;
					if (y_ == num2)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num3 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E80")]
		[Cpp2IlInjected.Address(RVA = "0x645CE0", Offset = "0x6446E0", VA = "0x180645CE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (x_ != 0)
				{
				}
				if (y_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004E81")]
		[Cpp2IlInjected.Address(RVA = "0x26EEC50", Offset = "0x26ED650", VA = "0x1826EEC50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E82")]
		[Cpp2IlInjected.Address(RVA = "0x645F80", Offset = "0x644980", VA = "0x180645F80", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (x_ != 0)
			{
				int value = x_;
				output.WriteInt32(value);
			}
			if (y_ != 0)
			{
				int value2 = y_;
				output.WriteInt32(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004E83")]
		[Cpp2IlInjected.Address(RVA = "0x26EE8E0", Offset = "0x26ED2E0", VA = "0x1826EE8E0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = x_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				int num4 = y_;
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

		[Cpp2IlInjected.Token(Token = "0x6004E84")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(AreaSize other)
		{
			if (other != null)
			{
				int num = other.x_;
				if (num != 0)
				{
					x_ = num;
				}
				int num2 = other.y_;
				if (num2 != 0)
				{
					y_ = num2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E85")]
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
					int num2 = (x_ = input.ReadInt32());
				}
				if (num == 16)
				{
					int num3 = (y_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E86")]
		[Cpp2IlInjected.Address(RVA = "0x26EEAD0", Offset = "0x26ED4D0", VA = "0x1826EEAD0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = x_;
			}
			if (fieldNumber == 2)
			{
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E87")]
		[Cpp2IlInjected.Address(RVA = "0x26EEB90", Offset = "0x26ED590", VA = "0x1826EEB90", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				x_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			y_ = (int)obj2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004E88")]
		[Cpp2IlInjected.Address(RVA = "0x645AB0", Offset = "0x6444B0", VA = "0x180645AB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			//IL_001b: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				x_ = 0;
				break;
			case 2:
				y_ = 0;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004E89")]
		[Cpp2IlInjected.Address(RVA = "0x26EECB0", Offset = "0x26ED6B0", VA = "0x1826EECB0")]
		static AreaSize()
		{
			Func<AreaSize> func = default(Func<AreaSize>);
			_parser = (MessageParser<AreaSize>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
