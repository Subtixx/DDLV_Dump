using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Conditions;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005D0")]
	public sealed class ItemNameTagCondition : IMessage<ItemNameTagCondition>, IMessage, IEquatable<ItemNameTagCondition>, IDeepCloneable<ItemNameTagCondition>, IMessageFieldAccessor, IDataValidation
	{
		[Cpp2IlInjected.Token(Token = "0x4001FBA")]
		private static readonly MessageParser<ItemNameTagCondition> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001FBB")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001FBC")]
		public const int ConditionFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001FBD")]
		private ItemConditionsList condition_;

		[Cpp2IlInjected.Token(Token = "0x4001FBE")]
		public const int XmlTagFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001FBF")]
		private string xmlTag_ = "";

		[Cpp2IlInjected.Token(Token = "0x170012AD")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemNameTagCondition> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004878")]
			[Cpp2IlInjected.Address(RVA = "0x25E5DB0", Offset = "0x25E47B0", VA = "0x1825E5DB0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012AE")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004879")]
			[Cpp2IlInjected.Address(RVA = "0x25E5CE0", Offset = "0x25E46E0", VA = "0x1825E5CE0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012AF")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x600487A")]
			[Cpp2IlInjected.Address(RVA = "0x25E5E10", Offset = "0x25E4810", VA = "0x1825E5E10", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B0")]
		[DebuggerNonUserCode]
		public ItemConditionsList Condition
		{
			[Cpp2IlInjected.Token(Token = "0x600487F")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return condition_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004880")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			set
			{
				condition_ = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170012B1")]
		[DebuggerNonUserCode]
		public string XmlTag
		{
			[Cpp2IlInjected.Token(Token = "0x6004881")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return xmlTag_;
			}
			[Cpp2IlInjected.Token(Token = "0x6004882")]
			[Cpp2IlInjected.Address(RVA = "0x25E5F20", Offset = "0x25E4920", VA = "0x1825E5F20")]
			set
			{
				string text = (xmlTag_ = ProtoPreconditions.CheckNotNull(value, "value"));
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600487B")]
		[Cpp2IlInjected.Address(RVA = "0x25E5C40", Offset = "0x25E4640", VA = "0x1825E5C40")]
		[DebuggerNonUserCode]
		public ItemNameTagCondition()
		{
			ItemConditionsList itemConditionsList = (condition_ = new ItemConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600487C")]
		[Cpp2IlInjected.Address(RVA = "0x25E57F0", Offset = "0x25E41F0", VA = "0x1825E57F0")]
		private void OnConstruction()
		{
			ItemConditionsList itemConditionsList = (condition_ = new ItemConditionsList());
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600487D")]
		[Cpp2IlInjected.Address(RVA = "0x25E5B20", Offset = "0x25E4520", VA = "0x1825E5B20")]
		[DebuggerNonUserCode]
		public ItemNameTagCondition(ItemNameTagCondition other)
		{
			//IL_0039: Expected O, but got I4
			ItemConditionsList itemConditionsList = (condition_ = new ItemConditionsList());
			ItemConditionsList itemConditionsList2 = other.condition_;
			if (itemConditionsList2 != null)
			{
				ItemConditionsList itemConditionsList3 = itemConditionsList2.Clone();
			}
			int num = 0;
			condition_ = (ItemConditionsList)num;
			string text = (xmlTag_ = other.xmlTag_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600487E")]
		[Cpp2IlInjected.Address(RVA = "0x25E51F0", Offset = "0x25E3BF0", VA = "0x1825E51F0", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemNameTagCondition Clone()
		{
			//Discarded unreachable code: IL_0062
			//IL_003b: Expected O, but got I4
			ItemNameTagCondition itemNameTagCondition = new ItemNameTagCondition();
			itemNameTagCondition.xmlTag_ = "";
			ItemConditionsList itemConditionsList = (itemNameTagCondition.condition_ = new ItemConditionsList());
			ItemConditionsList itemConditionsList2 = condition_;
			if (itemConditionsList2 != null)
			{
				ItemConditionsList itemConditionsList3 = itemConditionsList2.Clone();
			}
			int num = 0;
			itemNameTagCondition.condition_ = (ItemConditionsList)num;
			string text = (itemNameTagCondition.xmlTag_ = xmlTag_);
			UnknownFieldSet unknownFieldSet = (itemNameTagCondition._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemNameTagCondition;
		}

		[Cpp2IlInjected.Token(Token = "0x6004883")]
		[Cpp2IlInjected.Address(RVA = "0x25E5430", Offset = "0x25E3E30", VA = "0x1825E5430", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if (object.Equals(condition_, other))
				{
					string text = xmlTag_;
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

		[Cpp2IlInjected.Token(Token = "0x6004884")]
		[Cpp2IlInjected.Address(RVA = "0x25E53B0", Offset = "0x25E3DB0", VA = "0x1825E53B0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemNameTagCondition other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				ItemConditionsList objB = other.condition_;
				if (object.Equals(condition_, objB))
				{
					string text = other.xmlTag_;
					if (!(xmlTag_ != text))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004885")]
		[Cpp2IlInjected.Address(RVA = "0x25E5580", Offset = "0x25E3F80", VA = "0x1825E5580", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0041
			ItemConditionsList itemConditionsList = condition_;
			if (itemConditionsList != null)
			{
				int hashCode = itemConditionsList.GetHashCode();
			}
			string text = xmlTag_;
			if (text.m_stringLength != 0)
			{
				int hashCode2 = text.GetHashCode();
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode3 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6004886")]
		[Cpp2IlInjected.Address(RVA = "0x25E5920", Offset = "0x25E4320", VA = "0x1825E5920", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004887")]
		[Cpp2IlInjected.Address(RVA = "0x25E5980", Offset = "0x25E4380", VA = "0x1825E5980", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0048
			if ((long)condition_ != 0)
			{
				ItemConditionsList value = condition_;
				output.WriteMessage(value);
			}
			if (xmlTag_.m_stringLength != 0)
			{
				string value2 = xmlTag_;
				output.WriteString(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004888")]
		[Cpp2IlInjected.Address(RVA = "0x25E50B0", Offset = "0x25E3AB0", VA = "0x1825E50B0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			ItemConditionsList itemConditionsList = condition_;
			int num = 0;
			if (itemConditionsList != null)
			{
				int num2 = CodedOutputStream.ComputeMessageSize(itemConditionsList);
			}
			string text = xmlTag_;
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

		[Cpp2IlInjected.Token(Token = "0x6004889")]
		[Cpp2IlInjected.Address(RVA = "0x25E5600", Offset = "0x25E4000", VA = "0x1825E5600", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemNameTagCondition other)
		{
			//Discarded unreachable code: IL_006c
			if (other == null)
			{
				return;
			}
			if ((long)other.condition_ != 0)
			{
				ItemConditionsList itemConditionsList = condition_;
				if (itemConditionsList == null)
				{
					ItemConditionsList itemConditionsList2 = (condition_ = new ItemConditionsList());
				}
				ItemConditionsList other2 = other.condition_;
				itemConditionsList.MergeFrom(other2);
			}
			string text = other.xmlTag_;
			if (text.m_stringLength != 0)
			{
				XmlTag = text;
			}
			UnknownFieldSet unknownFields = other._unknownFields;
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
		}

		[Cpp2IlInjected.Token(Token = "0x600488A")]
		[Cpp2IlInjected.Address(RVA = "0x25E56F0", Offset = "0x25E40F0", VA = "0x1825E56F0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_005c
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if (num == 10)
			{
				ItemConditionsList itemConditionsList = condition_;
				if (itemConditionsList == null)
				{
					ItemConditionsList itemConditionsList2 = (condition_ = new ItemConditionsList());
				}
				input.ReadMessage(itemConditionsList);
			}
			if (num == 18)
			{
				string text2 = (XmlTag = input.ReadString());
			}
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
		}

		[Cpp2IlInjected.Token(Token = "0x600488B")]
		[Cpp2IlInjected.Address(RVA = "0x25E54F0", Offset = "0x25E3EF0", VA = "0x1825E54F0", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				ItemConditionsList itemConditionsList = condition_;
			}
			if (fieldNumber == 2)
			{
				string text = xmlTag_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600488C")]
		[Cpp2IlInjected.Address(RVA = "0x25E5850", Offset = "0x25E4250", VA = "0x1825E5850", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_0015: Expected O, but got I4
			if (fieldNumber == 1)
			{
				int num = 0;
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
				condition_ = (ItemConditionsList)num;
			}
			else
			{
				while (fieldNumber != 2)
				{
				}
				if (value != null && value == null)
				{
					throw new InvalidCastException();
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600488D")]
		[Cpp2IlInjected.Address(RVA = "0x25E5180", Offset = "0x25E3B80", VA = "0x1825E5180", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
			}
			if (fieldNumber == 2)
			{
				XmlTag = "";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600488E")]
		[Cpp2IlInjected.Address(RVA = "0x25E4D50", Offset = "0x25E3750", VA = "0x1825E4D50")]
		public string AddTag(string str)
		{
			//Discarded unreachable code: IL_00e2
			string[] array;
			while (true)
			{
				string text = xmlTag_;
				if (">" != null)
				{
					return str;
				}
				array = new string[7];
				if ("<" != null && "<" == null)
				{
					continue;
				}
				array[0] = "<";
				string text2 = xmlTag_;
				if (text2 != null && "<" == null)
				{
					continue;
				}
				array[1] = text2;
				if (">" != null && ">" == null)
				{
					continue;
				}
				array[2] = ">";
				if (str != null && ">" == null)
				{
					continue;
				}
				array[3] = str;
				if ("</" != null && "</" == null)
				{
					continue;
				}
				array[4] = "</";
				string text3 = xmlTag_;
				if (text3 == null || "</" != null)
				{
					array[5] = text3;
					if (">" == null || ">" != null)
					{
						break;
					}
				}
			}
			array[6] = ">";
			return string.Concat(array);
		}

		[Cpp2IlInjected.Token(Token = "0x600488F")]
		[Cpp2IlInjected.Address(RVA = "0x25E5330", Offset = "0x25E3D30", VA = "0x1825E5330", Slot = "14")]
		public void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_0020
			string text = xmlTag_;
			if ("XmlTag" != null)
			{
				context.AddInvalidMemberError("Cannot be empty", "XmlTag");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004890")]
		[Cpp2IlInjected.Address(RVA = "0x25E5A10", Offset = "0x25E4410", VA = "0x1825E5A10")]
		static ItemNameTagCondition()
		{
			Func<ItemNameTagCondition> func = default(Func<ItemNameTagCondition>);
			_parser = (MessageParser<ItemNameTagCondition>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
