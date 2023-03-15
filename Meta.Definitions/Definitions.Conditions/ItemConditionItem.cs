using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x2000847")]
	public sealed class ItemConditionItem : IMessage<ItemConditionItem>, IMessage, IEquatable<ItemConditionItem>, IDeepCloneable<ItemConditionItem>, IMessageFieldAccessor, IItemCondition
	{
		[Cpp2IlInjected.Token(Token = "0x400290C")]
		private static readonly MessageParser<ItemConditionItem> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400290D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400290E")]
		public const int ItemFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400290F")]
		private int item_;

		[Cpp2IlInjected.Token(Token = "0x4002910")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002911")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001759")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemConditionItem> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005C96")]
			[Cpp2IlInjected.Address(RVA = "0x22C4C50", Offset = "0x22C3650", VA = "0x1822C4C50")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700175A")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005C97")]
			[Cpp2IlInjected.Address(RVA = "0x22C4AD0", Offset = "0x22C34D0", VA = "0x1822C4AD0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700175B")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005C98")]
			[Cpp2IlInjected.Address(RVA = "0x22C4CB0", Offset = "0x22C36B0", VA = "0x1822C4CB0", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700175C")]
		[DebuggerNonUserCode]
		public int Item
		{
			[Cpp2IlInjected.Token(Token = "0x6005C9C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return item_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C9D")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				item_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700175D")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005C9E")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C9F")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700175E")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005CAC")]
			[Cpp2IlInjected.Address(RVA = "0x22C4BA0", Offset = "0x22C35A0", VA = "0x1822C4BA0", Slot = "15")]
			get
			{
				//IL_0020: Expected O, but got I4
				if (!inversed_)
				{
				}
				int num = item_;
				return string.Format("Is{0} {1}", " NOT", num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C99")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ItemConditionItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005C9A")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ItemConditionItem(ItemConditionItem other)
		{
			int num = (item_ = other.item_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C9B")]
		[Cpp2IlInjected.Address(RVA = "0x22C4660", Offset = "0x22C3060", VA = "0x1822C4660", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemConditionItem Clone()
		{
			//Discarded unreachable code: IL_0037
			ItemConditionItem itemConditionItem = new ItemConditionItem();
			int num = (itemConditionItem.item_ = item_);
			bool flag = (itemConditionItem.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (itemConditionItem._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemConditionItem;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA0")]
		[Cpp2IlInjected.Address(RVA = "0x22C46F0", Offset = "0x22C30F0", VA = "0x1822C46F0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)item_ == (IntPtr)typeof(ItemConditionItem).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ItemConditionItem).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA1")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemConditionItem other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.item_;
				if (item_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x6005CA2")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (item_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x6005CA3")]
		[Cpp2IlInjected.Address(RVA = "0x22C4960", Offset = "0x22C3360", VA = "0x1822C4960", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA4")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (item_ != 0)
			{
				int value = item_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA5")]
		[Cpp2IlInjected.Address(RVA = "0x22C45D0", Offset = "0x22C2FD0", VA = "0x1822C45D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = item_;
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

		[Cpp2IlInjected.Token(Token = "0x6005CA6")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemConditionItem other)
		{
			if (other != null)
			{
				int num = other.item_;
				if (num != 0)
				{
					item_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005CA7")]
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
					int num2 = (item_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA8")]
		[Cpp2IlInjected.Address(RVA = "0x22C47A0", Offset = "0x22C31A0", VA = "0x1822C47A0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = item_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CA9")]
		[Cpp2IlInjected.Address(RVA = "0x22C4890", Offset = "0x22C3290", VA = "0x1822C4890", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				item_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CAA")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				item_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CAB")]
		[Cpp2IlInjected.Address(RVA = "0x22C4780", Offset = "0x22C3180", VA = "0x1822C4780", Slot = "14")]
		public bool Evaluate(Item target)
		{
			bool inversed = inversed_;
			return Operations.EvaluateInverse((IntPtr)target == (IntPtr)item_, inversed);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CAD")]
		[Cpp2IlInjected.Address(RVA = "0x22C49C0", Offset = "0x22C33C0", VA = "0x1822C49C0")]
		static ItemConditionItem()
		{
			Func<ItemConditionItem> func = default(Func<ItemConditionItem>);
			_parser = (MessageParser<ItemConditionItem>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
