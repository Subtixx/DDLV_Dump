using System;
using System.Diagnostics;
using Cpp2IlInjected;
using Definitions.Items;
using Definitions.Util;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Definitions.Conditions
{
	[Cpp2IlInjected.Token(Token = "0x20007E8")]
	public sealed class ConditionCraftingRecipeVisible : ICondition, IMessage<ConditionCraftingRecipeVisible>, IMessage, IEquatable<ConditionCraftingRecipeVisible>, IDeepCloneable<ConditionCraftingRecipeVisible>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002795")]
		private static readonly MessageParser<ConditionCraftingRecipeVisible> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002796")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002797")]
		public const int RecipeFieldNumber = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002798")]
		private int recipe_;

		[Cpp2IlInjected.Token(Token = "0x4002799")]
		public const int InversedFieldNumber = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400279A")]
		private bool inversed_;

		[Cpp2IlInjected.Token(Token = "0x17001620")]
		private Item RecipeItem
		{
			[Cpp2IlInjected.Token(Token = "0x600575A")]
			[Cpp2IlInjected.Address(RVA = "0x3218BF0", Offset = "0x32175F0", VA = "0x183218BF0")]
			get
			{
				long num = Convert.ToInt64((uint)recipe_);
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001621")]
		public string Info
		{
			[Cpp2IlInjected.Token(Token = "0x600575C")]
			[Cpp2IlInjected.Address(RVA = "0x3218900", Offset = "0x3217300", VA = "0x183218900", Slot = "5")]
			get
			{
				//Discarded unreachable code: IL_003c
				long num = Convert.ToInt64((uint)recipe_);
				string text = default(string);
				string text2 = text.Replace("ActivityData/CraftingRecipe/", "");
				if (!inversed_)
				{
				}
				return "CraftingRecipe " + text2 + " is " + "hidden";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001622")]
		public ConditionListener Listener
		{
			[Cpp2IlInjected.Token(Token = "0x600575D")]
			[Cpp2IlInjected.Address(RVA = "0x3218A20", Offset = "0x3217420", VA = "0x183218A20", Slot = "6")]
			get
			{
				//Discarded unreachable code: IL_001c
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)recipe_);
				bool flag = default(bool);
				if (flag)
				{
				}
				return ConditionListener.CraftingRecipeVisibility;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001623")]
		[DebuggerNonUserCode]
		public static MessageParser<ConditionCraftingRecipeVisible> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x600575F")]
			[Cpp2IlInjected.Address(RVA = "0x3218B90", Offset = "0x3217590", VA = "0x183218B90")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001624")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005760")]
			[Cpp2IlInjected.Address(RVA = "0x3218830", Offset = "0x3217230", VA = "0x183218830")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001625")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005761")]
			[Cpp2IlInjected.Address(RVA = "0x3218C50", Offset = "0x3217650", VA = "0x183218C50", Slot = "12")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001626")]
		[DebuggerNonUserCode]
		public int Recipe
		{
			[Cpp2IlInjected.Token(Token = "0x6005765")]
			[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
			get
			{
				return recipe_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005766")]
			[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
			set
			{
				recipe_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17001627")]
		[DebuggerNonUserCode]
		public bool Inversed
		{
			[Cpp2IlInjected.Token(Token = "0x6005767")]
			[Cpp2IlInjected.Address(RVA = "0x63C0E0", Offset = "0x63AAE0", VA = "0x18063C0E0")]
			get
			{
				return inversed_;
			}
			[Cpp2IlInjected.Token(Token = "0x6005768")]
			[Cpp2IlInjected.Address(RVA = "0x63C2B0", Offset = "0x63ACB0", VA = "0x18063C2B0")]
			set
			{
				inversed_ = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600575B")]
		[Cpp2IlInjected.Address(RVA = "0x3218320", Offset = "0x3216D20", VA = "0x183218320")]
		public bool Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			IProfilePlayer section = playerProfile.Section;
			int num = recipe_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			bool flag = inversed_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600575E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8D0", Offset = "0x6ED2D0", VA = "0x1806EE8D0", Slot = "7")]
		public LockedInfo GetLockedInfo(MissionItemData data)
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005762")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		[DebuggerNonUserCode]
		public ConditionCraftingRecipeVisible()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005763")]
		[Cpp2IlInjected.Address(RVA = "0x18D9A50", Offset = "0x18D8450", VA = "0x1818D9A50")]
		[DebuggerNonUserCode]
		public ConditionCraftingRecipeVisible(ConditionCraftingRecipeVisible other)
		{
			int num = (recipe_ = other.recipe_);
			bool flag = (inversed_ = other.inversed_);
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005764")]
		[Cpp2IlInjected.Address(RVA = "0x3218290", Offset = "0x3216C90", VA = "0x183218290", Slot = "14")]
		[DebuggerNonUserCode]
		public ConditionCraftingRecipeVisible Clone()
		{
			//Discarded unreachable code: IL_0037
			ConditionCraftingRecipeVisible conditionCraftingRecipeVisible = new ConditionCraftingRecipeVisible();
			int num = (conditionCraftingRecipeVisible.recipe_ = recipe_);
			bool flag = (conditionCraftingRecipeVisible.inversed_ = inversed_);
			UnknownFieldSet unknownFieldSet = (conditionCraftingRecipeVisible._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return conditionCraftingRecipeVisible;
		}

		[Cpp2IlInjected.Token(Token = "0x6005769")]
		[Cpp2IlInjected.Address(RVA = "0x3218470", Offset = "0x3216E70", VA = "0x183218470", Slot = "0")]
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			if (other != null && other != null)
			{
				if (other == this)
				{
					return true;
				}
				if ((IntPtr)recipe_ == (IntPtr)typeof(ConditionCraftingRecipeVisible).TypeHandle && (IntPtr)(inversed_ ? 1 : 0) == (IntPtr)typeof(ConditionCraftingRecipeVisible).TypeHandle)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600576A")]
		[Cpp2IlInjected.Address(RVA = "0x7C42D0", Offset = "0x7C2CD0", VA = "0x1807C42D0", Slot = "13")]
		[DebuggerNonUserCode]
		public bool Equals(ConditionCraftingRecipeVisible other)
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

		[Cpp2IlInjected.Token(Token = "0x600576B")]
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

		[Cpp2IlInjected.Token(Token = "0x600576C")]
		[Cpp2IlInjected.Address(RVA = "0x32186C0", Offset = "0x32170C0", VA = "0x1832186C0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x600576D")]
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

		[Cpp2IlInjected.Token(Token = "0x600576E")]
		[Cpp2IlInjected.Address(RVA = "0x3218200", Offset = "0x3216C00", VA = "0x183218200", Slot = "11")]
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

		[Cpp2IlInjected.Token(Token = "0x600576F")]
		[Cpp2IlInjected.Address(RVA = "0x7C78F0", Offset = "0x7C62F0", VA = "0x1807C78F0", Slot = "8")]
		[DebuggerNonUserCode]
		public void MergeFrom(ConditionCraftingRecipeVisible other)
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

		[Cpp2IlInjected.Token(Token = "0x6005770")]
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

		[Cpp2IlInjected.Token(Token = "0x6005771")]
		[Cpp2IlInjected.Address(RVA = "0x3218500", Offset = "0x3216F00", VA = "0x183218500", Slot = "15")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				int num = recipe_;
			}
			if (fieldNumber == 2)
			{
				bool flag = inversed_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005772")]
		[Cpp2IlInjected.Address(RVA = "0x32185F0", Offset = "0x3216FF0", VA = "0x1832185F0", Slot = "16")]
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

		[Cpp2IlInjected.Token(Token = "0x6005773")]
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

		[Cpp2IlInjected.Token(Token = "0x6005774")]
		[Cpp2IlInjected.Address(RVA = "0x3218720", Offset = "0x3217120", VA = "0x183218720")]
		static ConditionCraftingRecipeVisible()
		{
			Func<ConditionCraftingRecipeVisible> func = default(Func<ConditionCraftingRecipeVisible>);
			_parser = (MessageParser<ConditionCraftingRecipeVisible>)(object)new MessageParser<T>((Func<>)(object)func);
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005775")]
		[Cpp2IlInjected.Address(RVA = "0x3218320", Offset = "0x3216D20", VA = "0x183218320", Slot = "4")]
		bool ICondition.Evaluate(in PlayerProfile playerProfile, in WorldProfile worldProfile, ITransactionContext context)
		{
			//Discarded unreachable code: IL_0027
			IProfilePlayer section = playerProfile.Section;
			int num = recipe_;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			bool flag = inversed_;
			bool result = default(bool);
			return result;
		}
	}
}
