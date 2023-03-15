using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Options
{
	[Cpp2IlInjected.Token(Token = "0x200079F")]
	public sealed class StepAmountFieldOptions : IMessage<StepAmountFieldOptions>, IMessage, IEquatable<StepAmountFieldOptions>, IDeepCloneable<StepAmountFieldOptions>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400263F")]
		private static readonly MessageParser<StepAmountFieldOptions> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002640")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002641")]
		public const int HideValueFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002642")]
		private bool hideValue_;

		[Cpp2IlInjected.Token(Token = "0x4002643")]
		public const int HideRangeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4002644")]
		private bool hideRange_;

		[Cpp2IlInjected.Token(Token = "0x4002645")]
		public const int HideVariableFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4002646")]
		private bool hideVariable_;

		[Cpp2IlInjected.Token(Token = "0x1700154B")]
		[DebuggerNonUserCode]
		public static MessageParser<StepAmountFieldOptions> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600541A")]
			[Cpp2IlInjected.Address(RVA = "0x26318B0", Offset = "0x26302B0", VA = "0x1826318B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700154C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600541B")]
			[Cpp2IlInjected.Address(RVA = "0x26317E0", Offset = "0x26301E0", VA = "0x1826317E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700154D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600541C")]
			[Cpp2IlInjected.Address(RVA = "0x2631910", Offset = "0x2630310", VA = "0x182631910", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700154E")]
		[DebuggerNonUserCode]
		public bool HideValue
		{
			[Cpp2IlInjected.Token(Token = "0x6005420")]
			[Cpp2IlInjected.Address(RVA = "0x63C0D0", Offset = "0x63AAD0", VA = "0x18063C0D0")]
			get
			{
				return hideValue_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005421")]
			[Cpp2IlInjected.Address(RVA = "0x63C2A0", Offset = "0x63ACA0", VA = "0x18063C2A0")]
			set
			{
				hideValue_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700154F")]
		[DebuggerNonUserCode]
		public bool HideRange
		{
			[Cpp2IlInjected.Token(Token = "0x6005422")]
			[Cpp2IlInjected.Address(RVA = "0x63C0C0", Offset = "0x63AAC0", VA = "0x18063C0C0")]
			get
			{
				return hideRange_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005423")]
			[Cpp2IlInjected.Address(RVA = "0x63C290", Offset = "0x63AC90", VA = "0x18063C290")]
			set
			{
				hideRange_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001550")]
		[DebuggerNonUserCode]
		public bool HideVariable
		{
			[Cpp2IlInjected.Token(Token = "0x6005424")]
			[Cpp2IlInjected.Address(RVA = "0x63C0B0", Offset = "0x63AAB0", VA = "0x18063C0B0")]
			get
			{
				return hideVariable_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005425")]
			[Cpp2IlInjected.Address(RVA = "0x63C280", Offset = "0x63AC80", VA = "0x18063C280")]
			set
			{
				hideVariable_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600541D")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public StepAmountFieldOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600541E")]
		[Cpp2IlInjected.Address(RVA = "0x2631780", Offset = "0x2630180", VA = "0x182631780")]
		[DebuggerNonUserCode]
		public StepAmountFieldOptions(StepAmountFieldOptions other)
		{
			bool flag = (hideValue_ = other.hideValue_);
			bool flag2 = (hideRange_ = other.hideRange_);
			bool flag3 = (hideVariable_ = other.hideVariable_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600541F")]
		[Cpp2IlInjected.Address(RVA = "0x2631050", Offset = "0x262FA50", VA = "0x182631050", Slot = "10")]
		[DebuggerNonUserCode]
		public StepAmountFieldOptions Clone()
		{
			//Discarded unreachable code: IL_0047
			StepAmountFieldOptions stepAmountFieldOptions = new StepAmountFieldOptions();
			bool flag = (stepAmountFieldOptions.hideValue_ = hideValue_);
			bool flag2 = (stepAmountFieldOptions.hideRange_ = hideRange_);
			bool flag3 = (stepAmountFieldOptions.hideVariable_ = hideVariable_);
			UnknownFieldSet unknownFieldSet = (stepAmountFieldOptions._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return stepAmountFieldOptions;
		}

		[Cpp2IlInjected.Token(Token = "0x6005426")]
		[Cpp2IlInjected.Address(RVA = "0x2631120", Offset = "0x262FB20", VA = "0x182631120", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(hideValue_ ? 1 : 0) == (IntPtr)typeof(StepAmountFieldOptions).TypeHandle && (IntPtr)(hideRange_ ? 1 : 0) == (IntPtr)typeof(StepAmountFieldOptions).TypeHandle && (IntPtr)(hideVariable_ ? 1 : 0) == (IntPtr)typeof(StepAmountFieldOptions).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005427")]
		[Cpp2IlInjected.Address(RVA = "0x26310E0", Offset = "0x262FAE0", VA = "0x1826310E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(StepAmountFieldOptions other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				bool flag = other.hideValue_;
				if (hideValue_ == flag)
				{
					bool flag2 = other.hideRange_;
					if (hideRange_ == flag2)
					{
						bool flag3 = other.hideVariable_;
						if (hideVariable_ == flag3)
						{
							UnknownFieldSet unknownFields = other._unknownFields;
							return object.Equals(_unknownFields, unknownFields);
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005428")]
		[Cpp2IlInjected.Address(RVA = "0x2631290", Offset = "0x262FC90", VA = "0x182631290", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (hideValue_)
				{
				}
				if (hideRange_)
				{
				}
				if (hideVariable_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005429")]
		[Cpp2IlInjected.Address(RVA = "0x2631560", Offset = "0x262FF60", VA = "0x182631560", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600542A")]
		[Cpp2IlInjected.Address(RVA = "0x26315C0", Offset = "0x262FFC0", VA = "0x1826315C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0058
			if (hideValue_)
			{
				bool value = hideValue_;
				output.WriteBool(value);
			}
			if (hideRange_)
			{
				bool value2 = hideRange_;
				output.WriteBool(value2);
			}
			if (hideVariable_)
			{
				bool value3 = hideVariable_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600542B")]
		[Cpp2IlInjected.Address(RVA = "0x2630FE0", Offset = "0x262F9E0", VA = "0x182630FE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			UnknownFieldSet unknownFields;
			do
			{
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.CalculateSize();
		}

		[Cpp2IlInjected.Token(Token = "0x600542C")]
		[Cpp2IlInjected.Address(RVA = "0x26313E0", Offset = "0x262FDE0", VA = "0x1826313E0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(StepAmountFieldOptions other)
		{
			if (other != null)
			{
				bool flag = other.hideValue_;
				if (flag)
				{
					hideValue_ = flag;
				}
				bool flag2 = other.hideRange_;
				if (flag2)
				{
					hideRange_ = flag2;
				}
				bool flag3 = other.hideVariable_;
				if (flag3)
				{
					hideVariable_ = flag3;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600542D")]
		[Cpp2IlInjected.Address(RVA = "0x2631330", Offset = "0x262FD30", VA = "0x182631330", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					bool flag = (hideValue_ = input.ReadBool());
				}
				bool flag2 = default(bool);
				if (num == 16)
				{
					flag2 = (hideRange_ = input.ReadBool());
				}
				if (flag2)
				{
					bool flag3 = (hideVariable_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600542E")]
		[Cpp2IlInjected.Address(RVA = "0x26311C0", Offset = "0x262FBC0", VA = "0x1826311C0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num == 0 || num == 0 || num == 1)
			{
				bool flag = hideValue_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600542F")]
		[Cpp2IlInjected.Address(RVA = "0x2631450", Offset = "0x262FE50", VA = "0x182631450", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0028
			//IL_0017: Expected I4, but got O
			//IL_001f: Expected I4, but got O
			//IL_0027: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				switch (num)
				{
				case 1:
				{
					object obj2 = default(object);
					hideVariable_ = (byte)(int)obj2 != 0;
					break;
				}
				case 0:
				{
					object obj = default(object);
					hideRange_ = (byte)(int)obj != 0;
					break;
				}
				}
			}
			else
			{
				object obj3 = default(object);
				hideValue_ = (byte)(int)obj3 != 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005430")]
		[Cpp2IlInjected.Address(RVA = "0x2631030", Offset = "0x262FA30", VA = "0x182631030", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c, IL_0014
			if (fieldNumber == 1)
			{
				hideVariable_ = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005431")]
		[Cpp2IlInjected.Address(RVA = "0x2631670", Offset = "0x2630070", VA = "0x182631670")]
		static StepAmountFieldOptions()
		{
			Func<StepAmountFieldOptions> func = default(Func<StepAmountFieldOptions>);
			_parser = (MessageParser<StepAmountFieldOptions>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
