using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200084B")]
	public sealed class ItemConditionType : IMessage<ItemConditionType>, IMessage, IEquatable<ItemConditionType>, IDeepCloneable<ItemConditionType>, IMessageFieldAccessor, IItemCondition, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x400291C")]
		private static readonly MessageParser<ItemConditionType> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400291D")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x400291E")]
		public const int ItemTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400291F")]
		private ItemType itemType_;

		[Cpp2IlInjected.Token(Token = "0x4002920")]
		public const int RestrictSubTypeFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002921")]
		private bool restrictSubType_;

		[Cpp2IlInjected.Token(Token = "0x4002922")]
		public const int SubTypeFieldNumber = 3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4002923")]
		private string subType_ = "";

		[Cpp2IlInjected.Token(Token = "0x4002924")]
		public const int InversedFieldNumber = 4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4002925")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001765")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemConditionType> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005CCD")]
			[Cpp2IlInjected.Address(RVA = "0x22C8FF0", Offset = "0x22C79F0", VA = "0x1822C8FF0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001766")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005CCE")]
			[Cpp2IlInjected.Address(RVA = "0x22C8E20", Offset = "0x22C7820", VA = "0x1822C8E20")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001767")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005CCF")]
			[Cpp2IlInjected.Address(RVA = "0x22C9050", Offset = "0x22C7A50", VA = "0x1822C9050", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001768")]
		[DebuggerNonUserCode]
		public ItemType ItemType
		{
			[Cpp2IlInjected.Token(Token = "0x6005CD3")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return itemType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CD4")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				itemType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001769")]
		[DebuggerNonUserCode]
		public bool RestrictSubType
		{
			[Cpp2IlInjected.Token(Token = "0x6005CD5")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return restrictSubType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CD6")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				restrictSubType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700176A")]
		[DebuggerNonUserCode]
		public string SubType
		{
			[Cpp2IlInjected.Token(Token = "0x6005CD7")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return subType_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CD8")]
			[Cpp2IlInjected.Address(RVA = "0x22C9160", Offset = "0x22C7B60", VA = "0x1822C9160")]
			set
			{
				string text = (subType_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700176B")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005CD9")]
			[Cpp2IlInjected.Address(RVA = "0x5CAB90", Offset = "0x5C9590", VA = "0x1805CAB90")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005CDA")]
			[Cpp2IlInjected.Address(RVA = "0x5CACB0", Offset = "0x5C96B0", VA = "0x1805CACB0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700176C")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005CE7")]
			[Cpp2IlInjected.Address(RVA = "0x22C8EF0", Offset = "0x22C78F0", VA = "0x1822C8EF0", Slot = "15")]
			get
			{
				//IL_0041: Expected O, but got I4
				if (!inversed_)
				{
				}
				ItemType itemType = itemType_;
				if (restrictSubType_)
				{
					string text = subType_;
					string text2 = "/" + text;
				}
				return string.Format("Type {0} {1}{2}", "!=", itemType, "");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CD0")]
		[Cpp2IlInjected.Address(RVA = "0x22C8DD0", Offset = "0x22C77D0", VA = "0x1822C8DD0")]
		[DebuggerNonUserCode]
		public ItemConditionType()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005CD1")]
		[Cpp2IlInjected.Address(RVA = "0x22C8D20", Offset = "0x22C7720", VA = "0x1822C8D20")]
		[DebuggerNonUserCode]
		public ItemConditionType(ItemConditionType other)
		{
			ItemType itemType = (itemType_ = other.itemType_);
			bool flag = (restrictSubType_ = other.restrictSubType_);
			string text = (subType_ = other.subType_);
			bool flag2 = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005CD2")]
		[Cpp2IlInjected.Address(RVA = "0x22C82C0", Offset = "0x22C6CC0", VA = "0x1822C82C0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemConditionType Clone()
		{
			//Discarded unreachable code: IL_0062
			ItemConditionType itemConditionType = new ItemConditionType();
			itemConditionType.subType_ = "";
			ItemType itemType = (itemConditionType.itemType_ = itemType_);
			bool flag = (itemConditionType.restrictSubType_ = restrictSubType_);
			string text = (itemConditionType.subType_ = subType_);
			bool flag2 = (itemConditionType.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (itemConditionType._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemConditionType;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDB")]
		[Cpp2IlInjected.Address(RVA = "0x22C8400", Offset = "0x22C6E00", VA = "0x1822C8400", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)itemType_ == (IntPtr)typeof(ItemConditionType).TypeHandle && (IntPtr)(restrictSubType_ ? 1 : 0) == (IntPtr)typeof(ItemConditionType).TypeHandle)
				{
					string text = subType_;
					bool flag = default(bool);
					if (!flag && inversed_ == flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDC")]
		[Cpp2IlInjected.Address(RVA = "0x22C84D0", Offset = "0x22C6ED0", VA = "0x1822C84D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemConditionType other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemType itemType = other.itemType_;
				if (itemType_ == itemType)
				{
					bool flag = other.restrictSubType_;
					if (restrictSubType_ == flag)
					{
						string text = other.subType_;
						if (!(subType_ != text))
						{
							bool flag2 = other.inversed_;
							if (inversed_ == flag2)
							{
								UnknownFieldSet unknownFields = other._unknownFields;
								return object.Equals(_unknownFields, unknownFields);
							}
						}
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDD")]
		[Cpp2IlInjected.Address(RVA = "0x22C8730", Offset = "0x22C7130", VA = "0x1822C8730", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_004b
			if (itemType_ != 0)
			{
			}
			if (restrictSubType_)
			{
			}
			string text = subType_;
			if (text.m_stringLength != 0)
			{
				int hashCode = text.GetHashCode();
			}
			if (inversed_)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDE")]
		[Cpp2IlInjected.Address(RVA = "0x22C8AC0", Offset = "0x22C74C0", VA = "0x1822C8AC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CDF")]
		[Cpp2IlInjected.Address(RVA = "0x22C8B20", Offset = "0x22C7520", VA = "0x1822C8B20", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0066
			if (itemType_ != 0)
			{
			}
			if (restrictSubType_)
			{
				bool value = restrictSubType_;
				output.WriteBool(value);
			}
			if (subType_.m_stringLength != 0)
			{
				string value2 = subType_;
				output.WriteString(value2);
			}
			if (inversed_)
			{
				bool value3 = inversed_;
				output.WriteBool(value3);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE0")]
		[Cpp2IlInjected.Address(RVA = "0x22C8150", Offset = "0x22C6B50", VA = "0x1822C8150", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0058
			ItemType itemType = itemType_;
			int num = 0;
			if (itemType != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)itemType);
				num2++;
			}
			string text = subType_;
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

		[Cpp2IlInjected.Token(Token = "0x6005CE1")]
		[Cpp2IlInjected.Address(RVA = "0x22C88C0", Offset = "0x22C72C0", VA = "0x1822C88C0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemConditionType other)
		{
			//Discarded unreachable code: IL_0071
			if (other != null)
			{
				ItemType itemType = other.itemType_;
				if (itemType != 0)
				{
					itemType_ = itemType;
				}
				bool flag = other.restrictSubType_;
				if (flag)
				{
					restrictSubType_ = flag;
				}
				string text = other.subType_;
				if (text.m_stringLength != 0)
				{
					SubType = text;
				}
				bool flag2 = other.inversed_;
				if (flag2)
				{
					inversed_ = flag2;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE2")]
		[Cpp2IlInjected.Address(RVA = "0x22C87F0", Offset = "0x22C71F0", VA = "0x1822C87F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0079
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((int)num > 16)
			{
				if (num == 26)
				{
					string text2 = (SubType = input.ReadString());
				}
				if (num != 32)
				{
					goto IL_0062;
				}
				bool flag = (inversed_ = input.ReadBool());
			}
			int num2 = default(int);
			if (num == 8)
			{
				num2 = (int)(itemType_ = (ItemType)input.ReadInt32());
			}
			if (num2 == 16)
			{
				bool flag2 = (restrictSubType_ = input.ReadBool());
			}
			goto IL_0062;
			IL_0062:
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE3")]
		[Cpp2IlInjected.Address(RVA = "0x22C8600", Offset = "0x22C7000", VA = "0x1822C8600", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0031;
						}
						bool flag = inversed_;
					}
					string text = subType_;
				}
				bool flag2 = restrictSubType_;
			}
			ItemType itemType = itemType_;
			goto IL_0031;
			IL_0031:
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE4")]
		[Cpp2IlInjected.Address(RVA = "0x22C8940", Offset = "0x22C7340", VA = "0x1822C8940", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0035
			//IL_001b: Expected I4, but got O
			//IL_002c: Expected I4, but got O
			//IL_0034: Expected I4, but got O
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
					{
						object obj = default(object);
						inversed_ = (byte)(int)obj != 0;
						break;
					}
					case 0:
						if (value == null || value != null)
						{
							break;
						}
						throw new InvalidCastException();
					}
				}
				else
				{
					object obj2 = default(object);
					restrictSubType_ = (byte)(int)obj2 != 0;
				}
			}
			else
			{
				object obj3 = default(object);
				itemType_ = (ItemType)obj3;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE5")]
		[Cpp2IlInjected.Address(RVA = "0x22C8230", Offset = "0x22C6C30", VA = "0x1822C8230", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_0039: Expected I4, but got I8
			int num = fieldNumber - 1;
			if (num != 0)
			{
				if (num != 0)
				{
					switch (num)
					{
					case 1:
						inversed_ = false;
						break;
					case 0:
						SubType = "";
						break;
					}
				}
				else
				{
					restrictSubType_ = false;
				}
			}
			else
			{
				itemType_ = ItemType.None;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE6")]
		[Cpp2IlInjected.Address(RVA = "0x22C8550", Offset = "0x22C6F50", VA = "0x1822C8550", Slot = "14")]
		public bool Evaluate(Item target)
		{
			int itemID = target.ItemID;
			ItemType itemType = itemType_;
			bool inversed = inversed_;
			bool condition = default(bool);
			return Operations.EvaluateInverse(condition, inversed);
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE8")]
		[Cpp2IlInjected.Address(RVA = "0x22C83A0", Offset = "0x22C6DA0", VA = "0x1822C83A0", Slot = "16")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0015
			if (itemType_ == ItemType.None)
			{
				context.AddError("ItemCondition Type cannot be None");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005CE9")]
		[Cpp2IlInjected.Address(RVA = "0x22C8C10", Offset = "0x22C7610", VA = "0x1822C8C10")]
		static ItemConditionType()
		{
			Func<ItemConditionType> func = default(Func<ItemConditionType>);
			_parser = (MessageParser<ItemConditionType>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
