using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Missions
{
	[Cpp2IlInjected.Token(Token = "0x2000252")]
	public sealed class MissionRewardRange : IMessage<MissionRewardRange>, IMessage, IEquatable<MissionRewardRange>, IDeepCloneable<MissionRewardRange>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4000940")]
		private static readonly MessageParser<MissionRewardRange> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000941")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4000942")]
		public const int MinFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000943")]
		private int min_;

		[Cpp2IlInjected.Token(Token = "0x4000944")]
		public const int MaxFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000945")]
		private int max_;

		[Cpp2IlInjected.Token(Token = "0x170004E7")]
		[DebuggerNonUserCode]
		public static MessageParser<MissionRewardRange> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6001616")]
			[Cpp2IlInjected.Address(RVA = "0x29E1620", Offset = "0x29E0020", VA = "0x1829E1620")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E8")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001617")]
			[Cpp2IlInjected.Address(RVA = "0x29E1550", Offset = "0x29DFF50", VA = "0x1829E1550")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004E9")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6001618")]
			[Cpp2IlInjected.Address(RVA = "0x29E1680", Offset = "0x29E0080", VA = "0x1829E1680", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EA")]
		[DebuggerNonUserCode]
		public int Min
		{
			[Cpp2IlInjected.Token(Token = "0x600161C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return min_;
			}
			[Cpp2IlInjected.Token(Token = "0x600161D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				min_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170004EB")]
		[DebuggerNonUserCode]
		public int Max
		{
			[Cpp2IlInjected.Token(Token = "0x600161E")]
			[Cpp2IlInjected.Address(RVA = "0x646180", Offset = "0x644B80", VA = "0x180646180")]
			get
			{
				return max_;
			}
			[Cpp2IlInjected.Token(Token = "0x600161F")]
			[Cpp2IlInjected.Address(RVA = "0x6463D0", Offset = "0x644DD0", VA = "0x1806463D0")]
			set
			{
				max_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001619")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public MissionRewardRange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600161A")]
		[Cpp2IlInjected.Address(RVA = "0x646120", Offset = "0x644B20", VA = "0x180646120")]
		[DebuggerNonUserCode]
		public MissionRewardRange(MissionRewardRange other)
		{
			int num = (min_ = other.min_);
			int num2 = (max_ = other.max_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600161B")]
		[Cpp2IlInjected.Address(RVA = "0x29E1140", Offset = "0x29DFB40", VA = "0x1829E1140", Slot = "10")]
		[DebuggerNonUserCode]
		public MissionRewardRange Clone()
		{
			//Discarded unreachable code: IL_0037
			MissionRewardRange missionRewardRange = new MissionRewardRange();
			int num = (missionRewardRange.min_ = min_);
			int num2 = (missionRewardRange.max_ = max_);
			UnknownFieldSet unknownFieldSet = (missionRewardRange._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return missionRewardRange;
		}

		[Cpp2IlInjected.Token(Token = "0x6001620")]
		[Cpp2IlInjected.Address(RVA = "0x29E11D0", Offset = "0x29DFBD0", VA = "0x1829E11D0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)min_ == (IntPtr)typeof(MissionRewardRange).TypeHandle && (IntPtr)max_ == (IntPtr)typeof(MissionRewardRange).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001621")]
		[Cpp2IlInjected.Address(RVA = "0x645BF0", Offset = "0x6445F0", VA = "0x180645BF0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(MissionRewardRange other)
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

		[Cpp2IlInjected.Token(Token = "0x6001622")]
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

		[Cpp2IlInjected.Token(Token = "0x6001623")]
		[Cpp2IlInjected.Address(RVA = "0x29E13E0", Offset = "0x29DFDE0", VA = "0x1829E13E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6001624")]
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

		[Cpp2IlInjected.Token(Token = "0x6001625")]
		[Cpp2IlInjected.Address(RVA = "0x29E1070", Offset = "0x29DFA70", VA = "0x1829E1070", Slot = "7")]
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

		[Cpp2IlInjected.Token(Token = "0x6001626")]
		[Cpp2IlInjected.Address(RVA = "0x645E00", Offset = "0x644800", VA = "0x180645E00", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(MissionRewardRange other)
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

		[Cpp2IlInjected.Token(Token = "0x6001627")]
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

		[Cpp2IlInjected.Token(Token = "0x6001628")]
		[Cpp2IlInjected.Address(RVA = "0x29E1260", Offset = "0x29DFC60", VA = "0x1829E1260", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x6001629")]
		[Cpp2IlInjected.Address(RVA = "0x29E1320", Offset = "0x29DFD20", VA = "0x1829E1320", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x600162A")]
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

		[Cpp2IlInjected.Token(Token = "0x600162B")]
		[Cpp2IlInjected.Address(RVA = "0x29E1440", Offset = "0x29DFE40", VA = "0x1829E1440")]
		static MissionRewardRange()
		{
			Func<MissionRewardRange> func = default(Func<MissionRewardRange>);
			_parser = (MessageParser<MissionRewardRange>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
