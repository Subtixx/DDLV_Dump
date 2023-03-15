using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x200083F")]
	public sealed class ItemConditionsList : IMessage<ItemConditionsList>, IMessage, IEquatable<ItemConditionsList>, IDeepCloneable<ItemConditionsList>, IMessageFieldAccessor, IItemCondition, IItemConditions
	{
		[Cpp2IlInjected.Token(Token = "0x40028E7")]
		private static readonly MessageParser<ItemConditionsList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40028E8")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40028E9")]
		public const int OperatorFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40028EA")]
		private BoolOperator operator_;

		[Cpp2IlInjected.Token(Token = "0x40028EB")]
		public const int ConditionsFieldNumber = 2;

		[Cpp2IlInjected.Token(Token = "0x40028EC")]
		private static readonly FieldCodec<ItemConditionOneOf> _repeated_conditions_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40028ED")]
		private readonly RepeatedField<ItemConditionOneOf> conditions_;

		[Cpp2IlInjected.Token(Token = "0x17001743")]
		[DebuggerNonUserCode]
		public static MessageParser<ItemConditionsList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005C3A")]
			[Cpp2IlInjected.Address(RVA = "0x22CA510", Offset = "0x22C8F10", VA = "0x1822CA510")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001744")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005C3B")]
			[Cpp2IlInjected.Address(RVA = "0x22CA3A0", Offset = "0x22C8DA0", VA = "0x1822CA3A0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001745")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005C3C")]
			[Cpp2IlInjected.Address(RVA = "0x22CA570", Offset = "0x22C8F70", VA = "0x1822CA570", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001746")]
		[DebuggerNonUserCode]
		public BoolOperator Operator
		{
			[Cpp2IlInjected.Token(Token = "0x6005C40")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return operator_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005C41")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				operator_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001747")]
		[DebuggerNonUserCode]
		public RepeatedField<ItemConditionOneOf> Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6005C42")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return conditions_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001748")]
		IEnumerable<IItemCondition> IItemConditions.Conditions
		{
			[Cpp2IlInjected.Token(Token = "0x6005C4E")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0", Slot = "16")]
			get
			{
				RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001749")]
		private bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6005C4F")]
			[Cpp2IlInjected.Address(RVA = "0x22CA4C0", Offset = "0x22C8EC0", VA = "0x1822CA4C0")]
			get
			{
				//Discarded unreachable code: IL_000f
				return ((RepeatedField<T>)(object)conditions_).Count == 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700174A")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x6005C51")]
			[Cpp2IlInjected.Address(RVA = "0x22CA470", Offset = "0x22C8E70", VA = "0x1822CA470", Slot = "15")]
			get
			{
				string result = "All conditions are true (AND)";
				if (operator_ == BoolOperator.Or)
				{
					result = "Any condition is true (OR)";
				}
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C3D")]
		[Cpp2IlInjected.Address(RVA = "0x22CA320", Offset = "0x22C8D20", VA = "0x1822CA320")]
		[DebuggerNonUserCode]
		public ItemConditionsList()
		{
			conditions_ = (RepeatedField<ItemConditionOneOf>)(object)new RepeatedField<T>();
			base._002Ector();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C3E")]
		[Cpp2IlInjected.Address(RVA = "0x22CA290", Offset = "0x22C8C90", VA = "0x1822CA290")]
		[DebuggerNonUserCode]
		public ItemConditionsList(ItemConditionsList other)
		{
			BoolOperator boolOperator = (operator_ = other.operator_);
			RepeatedField<ItemConditionOneOf> repeatedField = (conditions_ = (RepeatedField<ItemConditionOneOf>)(object)((RepeatedField<T>)(object)other.conditions_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C3F")]
		[Cpp2IlInjected.Address(RVA = "0x22C9330", Offset = "0x22C7D30", VA = "0x1822C9330", Slot = "10")]
		[DebuggerNonUserCode]
		public ItemConditionsList Clone()
		{
			//Discarded unreachable code: IL_003c
			ItemConditionsList itemConditionsList = new ItemConditionsList();
			BoolOperator boolOperator = (itemConditionsList.operator_ = operator_);
			RepeatedField<ItemConditionOneOf> repeatedField = (itemConditionsList.conditions_ = (RepeatedField<ItemConditionOneOf>)(object)((RepeatedField<T>)(object)conditions_).Clone());
			UnknownFieldSet unknownFieldSet = (itemConditionsList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return itemConditionsList;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C43")]
		[Cpp2IlInjected.Address(RVA = "0x22C93F0", Offset = "0x22C7DF0", VA = "0x1822C93F0", Slot = "0")]
		[DebuggerNonUserCode]
		public unsafe override bool Equals(object other)
		{
			int num = 0;
			if (other != null)
			{
			}
			if (num != 0)
			{
				if ((IntPtr)num == (IntPtr)this)
				{
					return true;
				}
				if ((IntPtr)(void*)(int)operator_ == (IntPtr)typeof(ItemConditionsList).TypeHandle)
				{
					RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
					bool flag = default(bool);
					if (flag)
					{
						return object.Equals(_unknownFields, other);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C44")]
		[Cpp2IlInjected.Address(RVA = "0x22C94D0", Offset = "0x22C7ED0", VA = "0x1822C94D0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(ItemConditionsList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				BoolOperator boolOperator = other.operator_;
				if (operator_ == boolOperator)
				{
					RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
					RepeatedField<ItemConditionOneOf> repeatedField2 = other.conditions_;
					if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C45")]
		[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0029
			if (operator_ != 0)
			{
			}
			int hashCode = ((RepeatedField<T>)(object)conditions_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return 1;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C46")]
		[Cpp2IlInjected.Address(RVA = "0x22C9BA0", Offset = "0x22C85A0", VA = "0x1822C9BA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C47")]
		[Cpp2IlInjected.Address(RVA = "0x22C9FD0", Offset = "0x22C89D0", VA = "0x1822C9FD0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0031
			if (operator_ != 0)
			{
			}
			RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
			FieldCodec<ItemConditionOneOf> repeated_conditions_codec = _repeated_conditions_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_conditions_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005C48")]
		[Cpp2IlInjected.Address(RVA = "0x22C91D0", Offset = "0x22C7BD0", VA = "0x1822C91D0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_004e
			BoolOperator boolOperator = operator_;
			int num = 0;
			if (boolOperator != 0)
			{
				int num2 = CodedOutputStream.ComputeEnumSize((int)boolOperator);
			}
			RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
			FieldCodec<ItemConditionOneOf> repeated_conditions_codec = _repeated_conditions_codec;
			int num3 = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_conditions_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			num += num3;
			if (unknownFields != null)
			{
				int num4 = unknownFields.CalculateSize();
				num += num4;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C49")]
		[Cpp2IlInjected.Address(RVA = "0x22C9940", Offset = "0x22C8340", VA = "0x1822C9940", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(ItemConditionsList other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				BoolOperator boolOperator = other.operator_;
				if (boolOperator != 0)
				{
					operator_ = boolOperator;
				}
				RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
				RepeatedField<ItemConditionOneOf> repeatedField2 = other.conditions_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C4A")]
		[Cpp2IlInjected.Address(RVA = "0x22C99D0", Offset = "0x22C83D0", VA = "0x1822C99D0", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0051
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (int)(operator_ = (BoolOperator)input.ReadInt32());
				}
				if (num == 18)
				{
					RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
					FieldCodec<ItemConditionOneOf> repeated_conditions_codec = _repeated_conditions_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_conditions_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C4B")]
		[Cpp2IlInjected.Address(RVA = "0x22C9870", Offset = "0x22C8270", VA = "0x1822C9870", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				BoolOperator boolOperator = operator_;
			}
			if (fieldNumber == 2)
			{
				RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C4C")]
		[Cpp2IlInjected.Address(RVA = "0x22C9AD0", Offset = "0x22C84D0", VA = "0x1822C9AD0", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				operator_ = (BoolOperator)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C4D")]
		[Cpp2IlInjected.Address(RVA = "0x22C92C0", Offset = "0x22C7CC0", VA = "0x1822C92C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				operator_ = BoolOperator.And;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C50")]
		[Cpp2IlInjected.Address(RVA = "0x22C9570", Offset = "0x22C7F70", VA = "0x1822C9570", Slot = "14")]
		public bool Evaluate(Item target)
		{
			if (((RepeatedField<T>)(object)conditions_).Count != 0)
			{
				RepeatedField<ItemConditionOneOf> repeatedField = conditions_;
				int num = 0;
				int count = ((RepeatedField<T>)(object)repeatedField).Count;
				if (num < count)
				{
					ItemConditionOneOf itemConditionOneOf = (ItemConditionOneOf)((RepeatedField<T>)(object)conditions_)[num];
					if ((object)typeof(IItemCondition).TypeHandle != null)
					{
					}
					int num2 = 0;
					BoolOperator boolOperator = operator_;
					if ((num2 == 0 && boolOperator != 0) || boolOperator != BoolOperator.Or)
					{
						RepeatedField<ItemConditionOneOf> repeatedField2 = conditions_;
					}
				}
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C52")]
		[Cpp2IlInjected.Address(RVA = "0x22C9810", Offset = "0x22C8210", VA = "0x1822C9810")]
		public string GetAllInfo()
		{
			int deep2 = 0;
			return GetInfo(this, deep2);
			[Cpp2IlInjected.Token(Token = "0x6005C58")]
			[Cpp2IlInjected.Address(RVA = "0x22C9C00", Offset = "0x22C8600", VA = "0x1822C9C00")]
			static string GetInfo(IItemCondition condition, int deep)
			{
				_003C_003Ec__DisplayClass40_0 _003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_0();
				_003C_003Ec__DisplayClass40_.deep = deep;
				if (_003C_003Ec__DisplayClass40_ != null)
				{
				}
				int num = default(int);
				if (condition != null && condition != null && num == 1)
				{
					int deep3 = _003C_003Ec__DisplayClass40_.deep;
					ItemConditionOneOf condition2 = default(ItemConditionOneOf);
					return GetInfo(condition2, deep3);
				}
				string text = "" + "  ";
				string text2 = text + text;
				if (text2 != null && text2 != null && Enumerable.Any<IItemCondition>((IEnumerable<>)(object)text2))
				{
					string text3 = default(string);
					string text4 = "\n" + text3;
					Func<IItemCondition, string> func = default(Func<IItemCondition, string>);
					IEnumerable<IItemCondition> enumerable = (IEnumerable<IItemCondition>)Enumerable.Select<IItemCondition, string>((IEnumerable<>)(object)text4, (Func<, >)(object)func);
					string text5 = string.Join(text4, (IEnumerable<>)enumerable);
					string text6 = text2 + text4 + text5;
				}
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005C53")]
		[Cpp2IlInjected.Address(RVA = "0x22C96F0", Offset = "0x22C80F0", VA = "0x1822C96F0")]
		public IEnumerable<IItemCondition> GetAllConditions()
		{
			new _003CGetAllConditions_003Ed__43(-2)._003C_003E3__condition = this;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C54")]
		[Cpp2IlInjected.Address(RVA = "0x19AD920", Offset = "0x19AC320", VA = "0x1819AD920")]
		public IEnumerable<> GetAllConditions<T>() where T : class, IItemCondition
		{
			//IL_000e: Expected O, but got I4
			int num = 0;
			IEnumerator<IItemCondition> enumerator = (IEnumerator<IItemCondition>)((IEnumerable<T>)Enumerable.Where<IItemCondition>(ItemConditionsList.GetAllConditions((IItemCondition)this), (Func<, >)num)).GetEnumerator();
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005C55")]
		[Cpp2IlInjected.Address(RVA = "0x22C97A0", Offset = "0x22C81A0", VA = "0x1822C97A0")]
		[IteratorStateMachine(typeof(_003CGetAllConditions_003Ed__43))]
		private static IEnumerable<IItemCondition> GetAllConditions(IItemCondition condition)
		{
			new _003CGetAllConditions_003Ed__43(-2)._003C_003E3__condition = condition;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005C56")]
		[Cpp2IlInjected.Address(RVA = "0x22CA0C0", Offset = "0x22C8AC0", VA = "0x1822CA0C0")]
		static ItemConditionsList()
		{
			Func<ItemConditionsList> func = default(Func<ItemConditionsList>);
			_parser = (MessageParser<ItemConditionsList>)(object)new MessageParser<T>((Func<>)(object)func);
			MessageParser<ItemConditionOneOf> parser = ItemConditionOneOf._parser;
			uint num = default(uint);
			_parser = (MessageParser<ItemConditionsList>)(object)FieldCodec.ForMessage<ItemConditionOneOf>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
