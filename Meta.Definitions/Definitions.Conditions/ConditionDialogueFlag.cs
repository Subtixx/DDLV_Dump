using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007F2")]
	public sealed class ConditionDialogueFlag : ICondition, IDataValidation, IMessage<ConditionDialogueFlag>, IMessage, IEquatable<ConditionDialogueFlag>, IDeepCloneable<ConditionDialogueFlag>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x40027BE")]
		private static readonly MessageParser<ConditionDialogueFlag> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40027BF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40027C0")]
		public const int FlagFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40027C1")]
		private int flag_;

		[Cpp2IlInjected.Token(Token = "0x40027C2")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40027C3")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001649")]
		private Item FlagItem
		{
			[Cpp2IlInjected.Token(Token = "0x60057FD")]
			[Cpp2IlInjected.Address(RVA = "0x321C700", Offset = "0x321B100", VA = "0x18321C700")]
			get
			{
				long num = Convert.ToInt64((uint)flag_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164A")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x60057FF")]
			[Cpp2IlInjected.Address(RVA = "0x321C760", Offset = "0x321B160", VA = "0x18321C760", Slot = "5")]
			get
			{
				//IL_0025: Expected O, but got I8
				long num = Convert.ToInt64((uint)flag_);
				if (!inversed_)
				{
				}
				return string.Format("Flag '{0}' {1}", num, "is OFF");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164B")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005800")]
			[Cpp2IlInjected.Address(RVA = "0x321C840", Offset = "0x321B240", VA = "0x18321C840", Slot = "6")]
			get
			{
				return ConditionListener.DialogueFlag;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164C")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionDialogueFlag> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005803")]
			[Cpp2IlInjected.Address(RVA = "0x321C850", Offset = "0x321B250", VA = "0x18321C850")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164D")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005804")]
			[Cpp2IlInjected.Address(RVA = "0x321C630", Offset = "0x321B030", VA = "0x18321C630")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164E")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005805")]
			[Cpp2IlInjected.Address(RVA = "0x321C8B0", Offset = "0x321B2B0", VA = "0x18321C8B0", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164F")]
		[DebuggerNonUserCode]
		public int Flag
		{
			[Cpp2IlInjected.Token(Token = "0x6005809")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return flag_;
			}
			[Cpp2IlInjected.Token(Token = "0x600580A")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				flag_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001650")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x600580B")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x600580C")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60057FE")]
		[Cpp2IlInjected.Address(RVA = "0x321C1A0", Offset = "0x321ABA0", VA = "0x18321C1A0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = flag_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005801")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005802")]
		[Cpp2IlInjected.Address(RVA = "0x321C130", Offset = "0x321AB30", VA = "0x18321C130", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (flag_ == 0)
			{
				context.AddInvalidMemberError("Please select a flag", "Flag");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005806")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionDialogueFlag()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005807")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionDialogueFlag(ConditionDialogueFlag other)
		{
			int num = (flag_ = other.flag_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005808")]
		[Cpp2IlInjected.Address(RVA = "0x321C0A0", Offset = "0x321AAA0", VA = "0x18321C0A0", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionDialogueFlag Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionDialogueFlag conditionDialogueFlag = new ConditionDialogueFlag();
			int num = (conditionDialogueFlag.flag_ = flag_);
			bool flag = (conditionDialogueFlag.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionDialogueFlag._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionDialogueFlag;
		}

		[Cpp2IlInjected.Token(Token = "0x600580D")]
		[Cpp2IlInjected.Address(RVA = "0x321C270", Offset = "0x321AC70", VA = "0x18321C270", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)flag_ == (IntPtr)typeof(ConditionDialogueFlag).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionDialogueFlag).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600580E")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionDialogueFlag other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.flag_;
				if (flag_ == num)
				{
					bool flag = other.inversed_;
					if (inversed_ == flag)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600580F")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (flag_ != 0)
				{
				}
				if (inversed_)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6005810")]
		[Cpp2IlInjected.Address(RVA = "0x321C4C0", Offset = "0x321AEC0", VA = "0x18321C4C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005811")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (flag_ != 0)
			{
				int value = flag_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005812")]
		[Cpp2IlInjected.Address(RVA = "0x321C010", Offset = "0x321AA10", VA = "0x18321C010", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = flag_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
					num3++;
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6005813")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionDialogueFlag other)
		{
			if (other != null)
			{
				int num = other.flag_;
				if (num != 0)
				{
					flag_ = num;
				}
				bool flag = other.inversed_;
				if (flag)
				{
					inversed_ = flag;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005814")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "10")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (flag_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005815")]
		[Cpp2IlInjected.Address(RVA = "0x321C300", Offset = "0x321AD00", VA = "0x18321C300", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = flag_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005816")]
		[Cpp2IlInjected.Address(RVA = "0x321C3F0", Offset = "0x321ADF0", VA = "0x18321C3F0", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				flag_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005817")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				flag_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005818")]
		[Cpp2IlInjected.Address(RVA = "0x321C520", Offset = "0x321AF20", VA = "0x18321C520")]
		static ConditionDialogueFlag()
		{
			Func<ConditionDialogueFlag> func = default(Func<ConditionDialogueFlag>);
			_parser = (MessageParser<ConditionDialogueFlag>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005819")]
		[Cpp2IlInjected.Address(RVA = "0x321C1A0", Offset = "0x321ABA0", VA = "0x18321C1A0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfileWorld section = worldProfile.Section;
			int num = flag_;
			bool result = default(bool);
			return result;
		}
	}
}
