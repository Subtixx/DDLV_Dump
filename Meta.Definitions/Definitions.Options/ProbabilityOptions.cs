using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x2000794")]
	public sealed class ProbabilityOptions : IMessage<ProbabilityOptions>, IMessage, IEquatable<ProbabilityOptions>, IDeepCloneable<ProbabilityOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40025F5")]
		private static readonly MessageParser<ProbabilityOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40025F6")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40025F7")]
		public const int ValueOfOnePercentFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40025F8")]
		private int valueOfOnePercent_;

		[Cpp2IlInjected.Token(Token = "0x17001522")]
		[DebuggerNonUserCode]
		public static MessageParser<ProbabilityOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600537D")]
			[Cpp2IlInjected.Address(RVA = "0x2885860", Offset = "0x2884260", VA = "0x182885860")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001523")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600537E")]
			[Cpp2IlInjected.Address(RVA = "0x2885790", Offset = "0x2884190", VA = "0x182885790")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001524")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600537F")]
			[Cpp2IlInjected.Address(RVA = "0x28858C0", Offset = "0x28842C0", VA = "0x1828858C0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001525")]
		[DebuggerNonUserCode]
		public int ValueOfOnePercent
		{
			[Cpp2IlInjected.Token(Token = "0x6005383")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return valueOfOnePercent_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005384")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				valueOfOnePercent_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005380")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ProbabilityOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005381")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public ProbabilityOptions(ProbabilityOptions other)
		{
			int num = (valueOfOnePercent_ = other.valueOfOnePercent_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005382")]
		[Cpp2IlInjected.Address(RVA = "0x28853E0", Offset = "0x2883DE0", VA = "0x1828853E0", Slot = "10")]
		[DebuggerNonUserCode]
		public ProbabilityOptions Clone()
		{
			//Discarded unreachable code: IL_0029
			ProbabilityOptions probabilityOptions = new ProbabilityOptions();
			int num = (probabilityOptions.valueOfOnePercent_ = valueOfOnePercent_);
			UnknownFieldSet unknownFieldSet = (probabilityOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return probabilityOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x6005385")]
		[Cpp2IlInjected.Address(RVA = "0x2885460", Offset = "0x2883E60", VA = "0x182885460", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)valueOfOnePercent_ == (IntPtr)typeof(ProbabilityOptions).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005386")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ProbabilityOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.valueOfOnePercent_;
				if (valueOfOnePercent_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005387")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (valueOfOnePercent_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005388")]
		[Cpp2IlInjected.Address(RVA = "0x2885620", Offset = "0x2884020", VA = "0x182885620", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005389")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (valueOfOnePercent_ != 0)
			{
				int value = valueOfOnePercent_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600538A")]
		[Cpp2IlInjected.Address(RVA = "0x2885340", Offset = "0x2883D40", VA = "0x182885340", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = valueOfOnePercent_;
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

		[Cpp2IlInjected.Token(Token = "0x600538B")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ProbabilityOptions other)
		{
			if (other != null)
			{
				int num = other.valueOfOnePercent_;
				if (num != 0)
				{
					valueOfOnePercent_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600538C")]
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
					int num2 = (valueOfOnePercent_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600538D")]
		[Cpp2IlInjected.Address(RVA = "0x28854F0", Offset = "0x2883EF0", VA = "0x1828854F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = valueOfOnePercent_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600538E")]
		[Cpp2IlInjected.Address(RVA = "0x28855A0", Offset = "0x2883FA0", VA = "0x1828855A0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				valueOfOnePercent_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600538F")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				valueOfOnePercent_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005390")]
		[Cpp2IlInjected.Address(RVA = "0x2885680", Offset = "0x2884080", VA = "0x182885680")]
		static ProbabilityOptions()
		{
			Func<ProbabilityOptions> func = default(Func<ProbabilityOptions>);
			_parser = (MessageParser<ProbabilityOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
