using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200081D")]
	public sealed class ConditionToolUnlocked : ICondition, IDataValidation, IMessage<ConditionToolUnlocked>, IMessage, IEquatable<ConditionToolUnlocked>, IDeepCloneable<ConditionToolUnlocked>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002862")]
		private static readonly MessageParser<ConditionToolUnlocked> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002863")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002864")]
		public const int ToolFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002865")]
		private int tool_;

		[Cpp2IlInjected.Token(Token = "0x4002866")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002867")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x170016F3")]
		public Item ToolItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB2")]
			[Cpp2IlInjected.Address(RVA = "0x24CD300", Offset = "0x24CBD00", VA = "0x1824CD300")]
			get
			{
				long num = Convert.ToInt64((uint)tool_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F4")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB4")]
			[Cpp2IlInjected.Address(RVA = "0x24CD1A0", Offset = "0x24CBBA0", VA = "0x1824CD1A0", Slot = "5")]
			get
			{
				long num = Convert.ToInt64((uint)tool_);
				if (!inversed_)
				{
				}
				string text = default(string);
				return "Tool '" + text + "' " + "locked";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F5")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB5")]
			[Cpp2IlInjected.Address(RVA = "0x24CD290", Offset = "0x24CBC90", VA = "0x1824CD290", Slot = "6")]
			get
			{
				return ConditionListener.ToolUnlocked;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F6")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionToolUnlocked> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB8")]
			[Cpp2IlInjected.Address(RVA = "0x24CD2A0", Offset = "0x24CBCA0", VA = "0x1824CD2A0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F7")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005AB9")]
			[Cpp2IlInjected.Address(RVA = "0x24CD0D0", Offset = "0x24CBAD0", VA = "0x1824CD0D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F8")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005ABA")]
			[Cpp2IlInjected.Address(RVA = "0x24CD360", Offset = "0x24CBD60", VA = "0x1824CD360", Slot = "13")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016F9")]
		[DebuggerNonUserCode]
		public int Tool
		{
			[Cpp2IlInjected.Token(Token = "0x6005ABE")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return tool_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005ABF")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				tool_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170016FA")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005AC0")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005AC1")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005AB3")]
		[Cpp2IlInjected.Address(RVA = "0x24CCC40", Offset = "0x24CB640", VA = "0x1824CCC40")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfilePlayer section = playerProfile.Section;
			int num = tool_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AB6")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AB7")]
		[Cpp2IlInjected.Address(RVA = "0x24CCBD0", Offset = "0x24CB5D0", VA = "0x1824CCBD0", Slot = "8")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_001a
			if (tool_ == 0)
			{
				context.AddInvalidMemberError("Please select a tool", "Tool");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005ABB")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionToolUnlocked()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005ABC")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionToolUnlocked(ConditionToolUnlocked other)
		{
			int num = (tool_ = other.tool_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005ABD")]
		[Cpp2IlInjected.Address(RVA = "0x24CCB40", Offset = "0x24CB540", VA = "0x1824CCB40", Slot = "15")]
		[DebuggerNonUserCode]
		public ConditionToolUnlocked Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionToolUnlocked conditionToolUnlocked = new ConditionToolUnlocked();
			int num = (conditionToolUnlocked.tool_ = tool_);
			bool flag = (conditionToolUnlocked.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionToolUnlocked._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionToolUnlocked;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AC2")]
		[Cpp2IlInjected.Address(RVA = "0x24CCD10", Offset = "0x24CB710", VA = "0x1824CCD10", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)tool_ == (IntPtr)typeof(ConditionToolUnlocked).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionToolUnlocked).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005AC3")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "14")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionToolUnlocked other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.tool_;
				if (tool_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6005AC4")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (tool_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005AC5")]
		[Cpp2IlInjected.Address(RVA = "0x24CCF60", Offset = "0x24CB960", VA = "0x1824CCF60", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AC6")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "11")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (tool_ != 0)
			{
				int value = tool_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005AC7")]
		[Cpp2IlInjected.Address(RVA = "0x24CCAB0", Offset = "0x24CB4B0", VA = "0x1824CCAB0", Slot = "12")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = tool_;
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

		[Cpp2IlInjected.Token(Token = "0x6005AC8")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionToolUnlocked other)
		{
			if (other != null)
			{
				int num = other.tool_;
				if (num != 0)
				{
					tool_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005AC9")]
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
					int num2 = (tool_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005ACA")]
		[Cpp2IlInjected.Address(RVA = "0x24CCDA0", Offset = "0x24CB7A0", VA = "0x1824CCDA0", Slot = "16")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = tool_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005ACB")]
		[Cpp2IlInjected.Address(RVA = "0x24CCE90", Offset = "0x24CB890", VA = "0x1824CCE90", Slot = "17")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				tool_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005ACC")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "18")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				tool_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005ACD")]
		[Cpp2IlInjected.Address(RVA = "0x24CCFC0", Offset = "0x24CB9C0", VA = "0x1824CCFC0")]
		static ConditionToolUnlocked()
		{
			Func<ConditionToolUnlocked> func = default(Func<ConditionToolUnlocked>);
			_parser = (MessageParser<ConditionToolUnlocked>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005ACE")]
		[Cpp2IlInjected.Address(RVA = "0x24CCC40", Offset = "0x24CB640", VA = "0x1824CCC40", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfilePlayer section = playerProfile.Section;
			int num = tool_;
			bool result = default(bool);
			return result;
		}
	}
}
