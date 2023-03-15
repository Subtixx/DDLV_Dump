using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007E2")]
	public sealed class ConditionCountry : ICondition, IDataValidation, IMessage<ConditionCountry>, IMessage, IEquatable<ConditionCountry>, IDeepCloneable<ConditionCountry>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002782")]
		private static readonly MessageParser<ConditionCountry> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002783")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002784")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002785")]
		private StringOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x4002786")]
		public const int CountryFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002787")]
		private string country_ = "";

		[Cpp2IlInjected.Token(Token = "0x1700160B")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005701")]
			[Cpp2IlInjected.Address(RVA = "0x3217FB0", Offset = "0x32169B0", VA = "0x183217FB0", Slot = "5")]
			get
			{
				string text = Operations.ToString(operator_);
				string text2 = country_;
				return "Country " + text + " " + text2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160C")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005702")]
			[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "6")]
			get
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160D")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCountry> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005705")]
			[Cpp2IlInjected.Address(RVA = "0x3218020", Offset = "0x3216A20", VA = "0x183218020")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160E")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005706")]
			[Cpp2IlInjected.Address(RVA = "0x3217EE0", Offset = "0x32168E0", VA = "0x183217EE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700160F")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005707")]
			[Cpp2IlInjected.Address(RVA = "0x3218080", Offset = "0x3216A80", VA = "0x183218080", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001610")]
		[DebuggerNonUserCode]
		public StringOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x600570B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x600570C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001611")]
		[DebuggerNonUserCode]
		public string Country
		{
			[Cpp2IlInjected.Token(Token = "0x600570D")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return country_;
			}
			[Cpp2IlInjected.Token(Token = "0x600570E")]
			[Cpp2IlInjected.Address(RVA = "0x3218190", Offset = "0x3216B90", VA = "0x183218190")]
			set
			{
				string text = (country_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005700")]
		[Cpp2IlInjected.Address(RVA = "0x32178B0", Offset = "0x32162B0", VA = "0x1832178B0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005703")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005704")]
		[Cpp2IlInjected.Address(RVA = "0x3217830", Offset = "0x3216230", VA = "0x183217830", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0020
			string text = country_;
			if ("Please enter a country condition" != null)
			{
				context.AddInvalidMemberError("Please enter a country condition", "Country");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005708")]
		[Cpp2IlInjected.Address(RVA = "0x3217E90", Offset = "0x3216890", VA = "0x183217E90")]
		[DebuggerNonUserCode]
		public ConditionCountry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005709")]
		[Cpp2IlInjected.Address(RVA = "0x3217DF0", Offset = "0x32167F0", VA = "0x183217DF0")]
		[DebuggerNonUserCode]
		public ConditionCountry(ConditionCountry other)
		{
			StringOperator stringOperator = (operator_ = other.operator_);
			string text = (country_ = other.country_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600570A")]
		[Cpp2IlInjected.Address(RVA = "0x3217760", Offset = "0x3216160", VA = "0x183217760", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionCountry Clone()
		{
			//Discarded unreachable code: IL_0042
			ConditionCountry conditionCountry = new ConditionCountry();
			conditionCountry.country_ = "";
			StringOperator stringOperator = (conditionCountry.operator_ = operator_);
			string text = (conditionCountry.country_ = country_);
			UnknownFieldSet unknownFieldSet = (conditionCountry._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCountry;
		}

		[Cpp2IlInjected.Token(Token = "0x600570F")]
		[Cpp2IlInjected.Address(RVA = "0x3217920", Offset = "0x3216320", VA = "0x183217920", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ConditionCountry).TypeHandle)
				{
					string text = country_;
					bool flag = default(bool);
					if (!flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005710")]
		[Cpp2IlInjected.Address(RVA = "0x1708900", Offset = "0x1707300", VA = "0x181708900", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCountry other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				StringOperator stringOperator = other.operator_;
				if (operator_ == stringOperator)
				{
					string text = other.country_;
					if (!(country_ != text))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005711")]
		[Cpp2IlInjected.Address(RVA = "0x1708AF0", Offset = "0x17074F0", VA = "0x181708AF0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0035
			if (operator_ != 0)
			{
			}
			string text = country_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005712")]
		[Cpp2IlInjected.Address(RVA = "0x3217C80", Offset = "0x3216680", VA = "0x183217C80", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005713")]
		[Cpp2IlInjected.Address(RVA = "0x1708DC0", Offset = "0x17077C0", VA = "0x181708DC0", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0038
			if (operator_ != 0)
			{
			}
			if (country_.m_stringLength != 0)
			{
				string value = country_;
				output.WriteString(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005714")]
		[Cpp2IlInjected.Address(RVA = "0x3217620", Offset = "0x3216020", VA = "0x183217620", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			StringOperator stringOperator = operator_;
			int num = 0;
			if (stringOperator != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)stringOperator);
			}
			string text = country_;
			if (text.m_stringLength != 0)
			{
				int num3 = CodedOutputStream.ComputeStringSize(text);
				num3++;
				num += num3;
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005715")]
		[Cpp2IlInjected.Address(RVA = "0x3217B40", Offset = "0x3216540", VA = "0x183217B40", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCountry other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				StringOperator stringOperator = other.operator_;
				if (stringOperator != 0)
				{
					operator_ = stringOperator;
				}
				string text = other.country_;
				if (text.m_stringLength != 0)
				{
					Country = text;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005716")]
		[Cpp2IlInjected.Address(RVA = "0x3217AA0", Offset = "0x32164A0", VA = "0x183217AA0", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(operator_ = (StringOperator)input.ReadInt32());
				}
				if (num == 18)
				{
					string text2 = (Country = input.ReadString());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005717")]
		[Cpp2IlInjected.Address(RVA = "0x32179D0", Offset = "0x32163D0", VA = "0x1832179D0", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				StringOperator stringOperator = operator_;
			}
			if (fieldNumber == 2)
			{
				string text = country_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005718")]
		[Cpp2IlInjected.Address(RVA = "0x3217BB0", Offset = "0x32165B0", VA = "0x183217BB0", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				operator_ = (StringOperator)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			if (value == null || value != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005719")]
		[Cpp2IlInjected.Address(RVA = "0x32176F0", Offset = "0x32160F0", VA = "0x1832176F0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				operator_ = StringOperator.Equal;
				break;
			case 2:
				Country = "";
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600571A")]
		[Cpp2IlInjected.Address(RVA = "0x3217CE0", Offset = "0x32166E0", VA = "0x183217CE0")]
		static ConditionCountry()
		{
			Func<ConditionCountry> func = default(Func<ConditionCountry>);
			_parser = (MessageParser<ConditionCountry>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600571B")]
		[Cpp2IlInjected.Address(RVA = "0x32178B0", Offset = "0x32162B0", VA = "0x1832178B0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0002
			bool result = default(bool);
			return result;
		}
	}
}
