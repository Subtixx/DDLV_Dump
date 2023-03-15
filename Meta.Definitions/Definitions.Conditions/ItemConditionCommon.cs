using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200083D")]
	public sealed class ItemConditionCommon : IMessage<ItemConditionCommon>, IMessage, IEquatable<ItemConditionCommon>, IDeepCloneable<ItemConditionCommon>, IMessageFieldAccessor, IItemCondition, IReplaceItemCondition, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x40028E0")]
		private static readonly MessageParser<ItemConditionCommon> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40028E1")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40028E2")]
		public const int ConditionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028E3")]
		private int condition_;

		[Cpp2IlInjected.Token(Token = "0x40028E4")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40028E5")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x1700173A")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemConditionCommon> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005C1B")]
			[Cpp2IlInjected.Address(RVA = "0x22C2610", Offset = "0x22C1010", VA = "0x1822C2610")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173B")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005C1C")]
			[Cpp2IlInjected.Address(RVA = "0x22C24D0", Offset = "0x22C0ED0", VA = "0x1822C24D0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173C")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005C1D")]
			[Cpp2IlInjected.Address(RVA = "0x22C2670", Offset = "0x22C1070", VA = "0x1822C2670", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173D")]
		[DebuggerNonUserCode]
		public int Condition
		{
			[Cpp2IlInjected.Token(Token = "0x6005C21")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return condition_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C22")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				condition_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173E")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005C23")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C24")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700173F")]
		IItemCondition IReplaceItemCondition.ReplaceCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6005C30")]
			[Cpp2IlInjected.Address(RVA = "0x22C1EF0", Offset = "0x22C08F0", VA = "0x1822C1EF0", Slot = "16")]
			get
			{
				return CommonCondition;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001740")]
		private Item ConditionItem
		{
			[Cpp2IlInjected.Token(Token = "0x6005C31")]
			[Cpp2IlInjected.Address(RVA = "0x22C2470", Offset = "0x22C0E70", VA = "0x1822C2470")]
			get
			{
				long num = Convert.ToInt64((uint)condition_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001741")]
		private IItemCondition CommonCondition
		{
			[Cpp2IlInjected.Token(Token = "0x6005C32")]
			[Cpp2IlInjected.Address(RVA = "0x22C2340", Offset = "0x22C0D40", VA = "0x1822C2340")]
			get
			{
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)condition_);
				ItemConditionItemData itemConditionItemData = default(ItemConditionItemData);
				if (itemConditionItemData != null)
				{
					ItemConditionsList conditions_ = itemConditionItemData.conditions_;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001742")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005C34")]
			[Cpp2IlInjected.Address(RVA = "0x22C25A0", Offset = "0x22C0FA0", VA = "0x1822C25A0", Slot = "15")]
			get
			{
				IItemCondition commonCondition = CommonCondition;
				if (commonCondition == null || commonCondition == null)
				{
				}
				return "(none)";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C1E")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemConditionCommon()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005C1F")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ItemConditionCommon(ItemConditionCommon other)
		{
			int num = (condition_ = other.condition_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C20")]
		[Cpp2IlInjected.Address(RVA = "0x22C1DC0", Offset = "0x22C07C0", VA = "0x1822C1DC0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemConditionCommon Clone()
		{
			//Discarded unreachable code: IL_0037
			ItemConditionCommon itemConditionCommon = new ItemConditionCommon();
			int num = (itemConditionCommon.condition_ = condition_);
			bool flag = (itemConditionCommon.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (itemConditionCommon._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemConditionCommon;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C25")]
		[Cpp2IlInjected.Address(RVA = "0x22C1F00", Offset = "0x22C0900", VA = "0x1822C1F00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)condition_ == (IntPtr)typeof(ItemConditionCommon).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ItemConditionCommon).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C26")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemConditionCommon other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.condition_;
				if (condition_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6005C27")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (condition_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005C28")]
		[Cpp2IlInjected.Address(RVA = "0x22C21D0", Offset = "0x22C0BD0", VA = "0x1822C21D0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C29")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (condition_ != 0)
			{
				int value = condition_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C2A")]
		[Cpp2IlInjected.Address(RVA = "0x22C1D30", Offset = "0x22C0730", VA = "0x1822C1D30", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = condition_;
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

		[Cpp2IlInjected.Token(Token = "0x6005C2B")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemConditionCommon other)
		{
			if (other != null)
			{
				int num = other.condition_;
				if (num != 0)
				{
					condition_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005C2C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (condition_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C2D")]
		[Cpp2IlInjected.Address(RVA = "0x22C2010", Offset = "0x22C0A10", VA = "0x1822C2010", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = condition_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C2E")]
		[Cpp2IlInjected.Address(RVA = "0x22C2100", Offset = "0x22C0B00", VA = "0x1822C2100", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				condition_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C2F")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				condition_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C33")]
		[Cpp2IlInjected.Address(RVA = "0x22C1F90", Offset = "0x22C0990", VA = "0x1822C1F90", Slot = "14")]
		public bool Evaluate(Item target)
		{
			if (CommonCondition == null)
			{
			}
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C35")]
		[Cpp2IlInjected.Address(RVA = "0x22C1E50", Offset = "0x22C0850", VA = "0x1822C1E50", Slot = "17")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_002d
			//IL_0024: Expected O, but got I4
			if (condition_ != 0 && CommonCondition == null)
			{
				int num = condition_;
				string error = $"Invalid common conditions (id={num})";
				context.AddError(error);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C36")]
		[Cpp2IlInjected.Address(RVA = "0x22C2230", Offset = "0x22C0C30", VA = "0x1822C2230")]
		static ItemConditionCommon()
		{
			Func<ItemConditionCommon> func = default(Func<ItemConditionCommon>);
			_parser = (MessageParser<ItemConditionCommon>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
