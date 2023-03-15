using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200088E")]
	public sealed class CookingHistory : IMessage<CookingHistory>, IMessage, IEquatable<CookingHistory>, IDeepCloneable<CookingHistory>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002267")]
		private static readonly MessageParser<CookingHistory> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002268")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002269")]
		public const int IngredientsFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x400226A")]
		private static readonly FieldCodec<int> _repeated_ingredients_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400226B")]
		private readonly RepeatedField<int> ingredients_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x400226C")]
		public const int MealItemIDFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400226D")]
		private int mealItemID_;

		[Cpp2IlInjected.Token(Token = "0x17000C10")]
		[DebuggerNonUserCode]
		public static MessageParser<CookingHistory> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004883")]
			[Cpp2IlInjected.Address(RVA = "0x18BC320", Offset = "0x18BAD20", VA = "0x1818BC320")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C11")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004884")]
			[Cpp2IlInjected.Address(RVA = "0x18BC250", Offset = "0x18BAC50", VA = "0x1818BC250")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C12")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004885")]
			[Cpp2IlInjected.Address(RVA = "0x18BC380", Offset = "0x18BAD80", VA = "0x1818BC380", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C13")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Ingredients
		{
			[Cpp2IlInjected.Token(Token = "0x6004889")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return ingredients_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000C14")]
		[DebuggerNonUserCode]
		public int MealItemID
		{
			[Cpp2IlInjected.Token(Token = "0x600488A")]
			[Cpp2IlInjected.Address(RVA = "0x5706B0", Offset = "0x56F0B0", VA = "0x1805706B0")]
			get
			{
				return mealItemID_;
			}
			[Cpp2IlInjected.Token(Token = "0x600488B")]
			[Cpp2IlInjected.Address(RVA = "0x6F4AE0", Offset = "0x6F34E0", VA = "0x1806F4AE0")]
			set
			{
				mealItemID_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004886")]
		[Cpp2IlInjected.Address(RVA = "0x18BC1D0", Offset = "0x18BABD0", VA = "0x1818BC1D0")]
		[DebuggerNonUserCode]
		public CookingHistory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004887")]
		[Cpp2IlInjected.Address(RVA = "0x18BC0D0", Offset = "0x18BAAD0", VA = "0x1818BC0D0")]
		[DebuggerNonUserCode]
		public CookingHistory(CookingHistory other)
		{
			RepeatedField<int> repeatedField = (ingredients_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.ingredients_).Clone());
			int num = (mealItemID_ = other.mealItemID_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6004888")]
		[Cpp2IlInjected.Address(RVA = "0x18BB7E0", Offset = "0x18BA1E0", VA = "0x1818BB7E0", Slot = "10")]
		[DebuggerNonUserCode]
		public CookingHistory Clone()
		{
			//Discarded unreachable code: IL_004b
			CookingHistory cookingHistory = new CookingHistory();
			RepeatedField<int> repeatedField = (cookingHistory.ingredients_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (cookingHistory.ingredients_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)ingredients_).Clone());
			int num = (cookingHistory.mealItemID_ = mealItemID_);
			UnknownFieldSet unknownFieldSet = (cookingHistory._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return cookingHistory;
		}

		[Cpp2IlInjected.Token(Token = "0x600488C")]
		[Cpp2IlInjected.Address(RVA = "0x18BB9B0", Offset = "0x18BA3B0", VA = "0x1818BB9B0", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
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
				RepeatedField<int> repeatedField = ingredients_;
				bool flag = default(bool);
				if (flag && mealItemID_ == (flag ? 1 : 0))
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600488D")]
		[Cpp2IlInjected.Address(RVA = "0x18BB910", Offset = "0x18BA310", VA = "0x1818BB910", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CookingHistory other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = ingredients_;
				RepeatedField<int> repeatedField2 = other.ingredients_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					int num = other.mealItemID_;
					if (mealItemID_ == num)
					{
						UnknownFieldSet unknownFields = other._unknownFields;
						return object.Equals(_unknownFields, unknownFields);
					}
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600488E")]
		[Cpp2IlInjected.Address(RVA = "0x18BBB60", Offset = "0x18BA560", VA = "0x1818BBB60", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_002b
			int hashCode = ((RepeatedField<T>)(object)ingredients_).GetHashCode();
			if (mealItemID_ != 0)
			{
			}
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x600488F")]
		[Cpp2IlInjected.Address(RVA = "0x18BBE50", Offset = "0x18BA850", VA = "0x1818BBE50", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004890")]
		[Cpp2IlInjected.Address(RVA = "0x18BBEB0", Offset = "0x18BA8B0", VA = "0x1818BBEB0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_003f
			RepeatedField<int> repeatedField = ingredients_;
			FieldCodec<int> repeated_ingredients_codec = _repeated_ingredients_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_ingredients_codec);
			if (mealItemID_ != 0)
			{
				int value = mealItemID_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004891")]
		[Cpp2IlInjected.Address(RVA = "0x18BB680", Offset = "0x18BA080", VA = "0x1818BB680", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_0054
			RepeatedField<int> repeatedField = ingredients_;
			FieldCodec<int> repeated_ingredients_codec = _repeated_ingredients_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_ingredients_codec);
			int num2 = mealItemID_;
			if (num2 != 0)
			{
				int num3 = CodedOutputStream.ComputeInt32Size(num2);
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

		[Cpp2IlInjected.Token(Token = "0x6004892")]
		[Cpp2IlInjected.Address(RVA = "0x18BBBE0", Offset = "0x18BA5E0", VA = "0x1818BBBE0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CookingHistory other)
		{
			//Discarded unreachable code: IL_0049
			if (other != null)
			{
				RepeatedField<int> repeatedField = ingredients_;
				RepeatedField<int> repeatedField2 = other.ingredients_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				int num = other.mealItemID_;
				if (num != 0)
				{
					mealItemID_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004893")]
		[Cpp2IlInjected.Address(RVA = "0x18BBC70", Offset = "0x18BA670", VA = "0x1818BBC70", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0059
			uint num = input.ReadTag();
			if (num == 0)
			{
				return;
			}
			if ((long)input != 4294967293L)
			{
				if (num == 16)
				{
					int num2 = (mealItemID_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
			RepeatedField<int> repeatedField = ingredients_;
			FieldCodec<int> repeated_ingredients_codec = _repeated_ingredients_codec;
			((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_ingredients_codec);
		}

		[Cpp2IlInjected.Token(Token = "0x6004894")]
		[Cpp2IlInjected.Address(RVA = "0x18BBA90", Offset = "0x18BA490", VA = "0x1818BBA90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = ingredients_;
			}
			if (fieldNumber == 2)
			{
				int num = mealItemID_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004895")]
		[Cpp2IlInjected.Address(RVA = "0x18BBD80", Offset = "0x18BA780", VA = "0x1818BBD80", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0010
			//IL_000f: Expected I4, but got O
			switch (fieldNumber)
			{
			case 2:
			{
				object obj = default(object);
				mealItemID_ = (int)obj;
				break;
			}
			case 1:
			{
				InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
				/*Error: Unexpected end of block*/;
			}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004896")]
		[Cpp2IlInjected.Address(RVA = "0x18BB770", Offset = "0x18BA170", VA = "0x1818BB770", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_0019
			//IL_0018: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = ingredients_;
			}
			if (fieldNumber == 2)
			{
				mealItemID_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004897")]
		[Cpp2IlInjected.Address(RVA = "0x18BBF90", Offset = "0x18BA990", VA = "0x1818BBF90")]
		static CookingHistory()
		{
			Func<CookingHistory> func = default(Func<CookingHistory>);
			_parser = (MessageParser<CookingHistory>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<CookingHistory>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
