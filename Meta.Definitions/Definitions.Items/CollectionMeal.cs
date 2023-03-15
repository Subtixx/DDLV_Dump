using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Items
{
	[Cpp2IlInjected.Token(Token = "0x20005B2")]
	public sealed class CollectionMeal : IMessage<CollectionMeal>, IMessage, IEquatable<CollectionMeal>, IDeepCloneable<CollectionMeal>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4001F1B")]
		private static readonly MessageParser<CollectionMeal> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001F1C")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4001F1D")]
		public const int MealTypeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001F1E")]
		private int mealType_;

		[Cpp2IlInjected.Token(Token = "0x17001267")]
		[DebuggerNonUserCode]
		public static MessageParser<CollectionMeal> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6004725")]
			[Cpp2IlInjected.Address(RVA = "0x320A000", Offset = "0x3208A00", VA = "0x18320A000")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001268")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004726")]
			[Cpp2IlInjected.Address(RVA = "0x3209F30", Offset = "0x3208930", VA = "0x183209F30")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001269")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6004727")]
			[Cpp2IlInjected.Address(RVA = "0x320A060", Offset = "0x3208A60", VA = "0x18320A060", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700126A")]
		[DebuggerNonUserCode]
		public int MealType
		{
			[Cpp2IlInjected.Token(Token = "0x600472B")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return mealType_;
			}
			[Cpp2IlInjected.Token(Token = "0x600472C")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				mealType_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004728")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public CollectionMeal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004729")]
		[Cpp2IlInjected.Address(RVA = "0x5C2B50", Offset = "0x5C1550", VA = "0x1805C2B50")]
		[DebuggerNonUserCode]
		public CollectionMeal(CollectionMeal other)
		{
			int num = (mealType_ = other.mealType_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600472A")]
		[Cpp2IlInjected.Address(RVA = "0x3209B80", Offset = "0x3208580", VA = "0x183209B80", Slot = "10")]
		[DebuggerNonUserCode]
		public CollectionMeal Clone()
		{
			//Discarded unreachable code: IL_0029
			CollectionMeal collectionMeal = new CollectionMeal();
			int num = (collectionMeal.mealType_ = mealType_);
			UnknownFieldSet unknownFieldSet = (collectionMeal._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return collectionMeal;
		}

		[Cpp2IlInjected.Token(Token = "0x600472D")]
		[Cpp2IlInjected.Address(RVA = "0x3209C00", Offset = "0x3208600", VA = "0x183209C00", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)mealType_ == (IntPtr)typeof(CollectionMeal).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600472E")]
		[Cpp2IlInjected.Address(RVA = "0x5C26E0", Offset = "0x5C10E0", VA = "0x1805C26E0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(CollectionMeal other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.mealType_;
				if (mealType_ == num)
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num2 = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600472F")]
		[Cpp2IlInjected.Address(RVA = "0x5C27C0", Offset = "0x5C11C0", VA = "0x1805C27C0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (mealType_ != 0)
				{
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			return unknownFields.GetHashCode();
		}

		[Cpp2IlInjected.Token(Token = "0x6004730")]
		[Cpp2IlInjected.Address(RVA = "0x3209DC0", Offset = "0x32087C0", VA = "0x183209DC0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6004731")]
		[Cpp2IlInjected.Address(RVA = "0x71C040", Offset = "0x71AA40", VA = "0x18071C040", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_002a
			if (mealType_ != 0)
			{
				int value = mealType_;
				output.WriteInt32(value);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6004732")]
		[Cpp2IlInjected.Address(RVA = "0x3209AE0", Offset = "0x32084E0", VA = "0x183209AE0", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = mealType_;
				num2 = 0;
				if (num != 0)
				{
					int num3 = CodedOutputStream.ComputeInt32Size(num);
				}
				unknownFields = _unknownFields;
			}
			while (unknownFields == null);
			int num4 = unknownFields.CalculateSize();
			return num4 + num2;
		}

		[Cpp2IlInjected.Token(Token = "0x6004733")]
		[Cpp2IlInjected.Address(RVA = "0x5C28B0", Offset = "0x5C12B0", VA = "0x1805C28B0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(CollectionMeal other)
		{
			if (other != null)
			{
				int num = other.mealType_;
				if (num != 0)
				{
					mealType_ = num;
				}
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004734")]
		[Cpp2IlInjected.Address(RVA = "0x5C2830", Offset = "0x5C1230", VA = "0x1805C2830", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0034
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (mealType_ = input.ReadInt32());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004735")]
		[Cpp2IlInjected.Address(RVA = "0x3209C90", Offset = "0x3208690", VA = "0x183209C90", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = mealType_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6004736")]
		[Cpp2IlInjected.Address(RVA = "0x3209D40", Offset = "0x3208740", VA = "0x183209D40", Slot = "12")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_000c
			//IL_000b: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				mealType_ = (int)obj;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004737")]
		[Cpp2IlInjected.Address(RVA = "0x5C25C0", Offset = "0x5C0FC0", VA = "0x1805C25C0", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			if (fieldNumber == 1)
			{
				mealType_ = 0;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004738")]
		[Cpp2IlInjected.Address(RVA = "0x3209E20", Offset = "0x3208820", VA = "0x183209E20")]
		static CollectionMeal()
		{
			Func<CollectionMeal> func = default(Func<CollectionMeal>);
			_parser = (MessageParser<CollectionMeal>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}
	}
}
