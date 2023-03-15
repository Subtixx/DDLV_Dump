using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007E6")]
	public sealed class ConditionCookingRecipeVisible : ICondition, IMessage<ConditionCookingRecipeVisible>, IMessage, IEquatable<ConditionCookingRecipeVisible>, IDeepCloneable<ConditionCookingRecipeVisible>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x400278E")]
		private static readonly MessageParser<ConditionCookingRecipeVisible> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400278F")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002790")]
		public const int RecipeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002791")]
		private int recipe_;

		[Cpp2IlInjected.Token(Token = "0x4002792")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4002793")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001618")]
		private Item RecipeItem
		{
			[Cpp2IlInjected.Token(Token = "0x600573B")]
			[Cpp2IlInjected.Address(RVA = "0x32174B0", Offset = "0x3215EB0", VA = "0x1832174B0")]
			get
			{
				long num = Convert.ToInt64((uint)recipe_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001619")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600573D")]
			[Cpp2IlInjected.Address(RVA = "0x3217320", Offset = "0x3215D20", VA = "0x183217320", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_003c
				long num = Convert.ToInt64((uint)recipe_);
				string text = default(string);
				string text2 = text.Replace("ActivityData/CookingRecipe/", "");
				if (!inversed_)
				{
				}
				return "Recipe " + text2 + " NOT" + " in cookbook";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161A")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600573E")]
			[Cpp2IlInjected.Address(RVA = "0x3217440", Offset = "0x3215E40", VA = "0x183217440", Slot = "6")]
			get
			{
				return ConditionListener.CookingRecipeVisibility;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161B")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCookingRecipeVisible> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005740")]
			[Cpp2IlInjected.Address(RVA = "0x3217450", Offset = "0x3215E50", VA = "0x183217450")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161C")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005741")]
			[Cpp2IlInjected.Address(RVA = "0x3217250", Offset = "0x3215C50", VA = "0x183217250")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161D")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005742")]
			[Cpp2IlInjected.Address(RVA = "0x3217510", Offset = "0x3215F10", VA = "0x183217510", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161E")]
		[DebuggerNonUserCode]
		public int Recipe
		{
			[Cpp2IlInjected.Token(Token = "0x6005746")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recipe_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005747")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recipe_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700161F")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005748")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005749")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600573C")]
		[Cpp2IlInjected.Address(RVA = "0x3216DC0", Offset = "0x32157C0", VA = "0x183216DC0")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfilePlayer section = playerProfile.Section;
			int num = recipe_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600573F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005743")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionCookingRecipeVisible()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005744")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionCookingRecipeVisible(ConditionCookingRecipeVisible other)
		{
			int num = (recipe_ = other.recipe_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005745")]
		[Cpp2IlInjected.Address(RVA = "0x3216D30", Offset = "0x3215730", VA = "0x183216D30", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionCookingRecipeVisible Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionCookingRecipeVisible conditionCookingRecipeVisible = new ConditionCookingRecipeVisible();
			int num = (conditionCookingRecipeVisible.recipe_ = recipe_);
			bool flag = (conditionCookingRecipeVisible.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionCookingRecipeVisible._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCookingRecipeVisible;
		}

		[Cpp2IlInjected.Token(Token = "0x600574A")]
		[Cpp2IlInjected.Address(RVA = "0x3216E90", Offset = "0x3215890", VA = "0x183216E90", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)recipe_ == (IntPtr)typeof(ConditionCookingRecipeVisible).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionCookingRecipeVisible).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600574B")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCookingRecipeVisible other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				int num = other.recipe_;
				if (recipe_ == num)
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

		[Cpp2IlInjected.Token(Token = "0x600574C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7260", Offset = "0x7C5C60", VA = "0x1807C7260", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			UnknownFieldSet unknownFields;
			do
			{
				if (recipe_ != 0)
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

		[Cpp2IlInjected.Token(Token = "0x600574D")]
		[Cpp2IlInjected.Address(RVA = "0x32170E0", Offset = "0x3215AE0", VA = "0x1832170E0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600574E")]
		[Cpp2IlInjected.Address(RVA = "0x7C8200", Offset = "0x7C6C00", VA = "0x1807C8200", Slot = "10")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0041
			if (recipe_ != 0)
			{
				int value = recipe_;
				output.WriteInt32(value);
			}
			if (inversed_)
			{
				bool value2 = inversed_;
				output.WriteBool(value2);
			}
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x600574F")]
		[Cpp2IlInjected.Address(RVA = "0x3216CA0", Offset = "0x32156A0", VA = "0x183216CA0", Slot = "11")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num2;
			UnknownFieldSet unknownFields;
			do
			{
				int num = recipe_;
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

		[Cpp2IlInjected.Token(Token = "0x6005750")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCookingRecipeVisible other)
		{
			if (other != null)
			{
				int num = other.recipe_;
				if (num != 0)
				{
					recipe_ = num;
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

		[Cpp2IlInjected.Token(Token = "0x6005751")]
		[Cpp2IlInjected.Address(RVA = "0x7C7950", Offset = "0x7C6350", VA = "0x1807C7950", Slot = "9")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0048
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 8)
				{
					int num2 = (recipe_ = input.ReadInt32());
				}
				if (num == 16)
				{
					bool flag = (inversed_ = input.ReadBool());
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005752")]
		[Cpp2IlInjected.Address(RVA = "0x3216F20", Offset = "0x3215920", VA = "0x183216F20", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = recipe_;
			}
			bool flag = inversed_;
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005753")]
		[Cpp2IlInjected.Address(RVA = "0x3217010", Offset = "0x3215A10", VA = "0x183217010", Slot = "16")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			//Discarded unreachable code: IL_0018
			//IL_000b: Expected I4, but got O
			//IL_0017: Expected I4, but got O
			if (fieldNumber == 1)
			{
				object obj = default(object);
				recipe_ = (int)obj;
				return;
			}
			while (fieldNumber != 2)
			{
			}
			object obj2 = default(object);
			inversed_ = (byte)(int)obj2 != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6005754")]
		[Cpp2IlInjected.Address(RVA = "0x7C41D0", Offset = "0x7C2BD0", VA = "0x1807C41D0", Slot = "17")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//IL_000d: Expected I4, but got I8
			switch (fieldNumber)
			{
			case 1:
				recipe_ = 0;
				break;
			case 2:
				inversed_ = false;
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005755")]
		[Cpp2IlInjected.Address(RVA = "0x3217140", Offset = "0x3215B40", VA = "0x183217140")]
		static ConditionCookingRecipeVisible()
		{
			Func<ConditionCookingRecipeVisible> func = default(Func<ConditionCookingRecipeVisible>);
			_parser = (MessageParser<ConditionCookingRecipeVisible>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005756")]
		[Cpp2IlInjected.Address(RVA = "0x3216DC0", Offset = "0x32157C0", VA = "0x183216DC0", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0010
			IProfilePlayer section = playerProfile.Section;
			int num = recipe_;
			bool result = default(bool);
			return result;
		}
	}
}
