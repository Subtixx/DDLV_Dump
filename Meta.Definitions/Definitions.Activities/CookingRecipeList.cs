using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Definitions.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000871")]
	public sealed class CookingRecipeList : IDataValidation, IMessage<CookingRecipeList>, IMessage, IEquatable<CookingRecipeList>, IDeepCloneable<CookingRecipeList>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x2000872")]
		[DebuggerNonUserCode]
		public static class Types
		{
			[Cpp2IlInjected.Token(Token = "0x2000873")]
			public sealed class CategoryList : IDataValidation, IMessage<CategoryList>, IMessage, IEquatable<CategoryList>, IDeepCloneable<CategoryList>, IMessageFieldAccessor
			{
				[Cpp2IlInjected.Token(Token = "0x40029C3")]
				private static readonly MessageParser<CategoryList> _parser;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40029C4")]
				private UnknownFieldSet _unknownFields;

				[Cpp2IlInjected.Token(Token = "0x40029C5")]
				public const int CategoryFieldNumber = 1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40029C6")]
				private int category_;

				[Cpp2IlInjected.Token(Token = "0x40029C7")]
				public const int RecipesFieldNumber = 2;

				[Cpp2IlInjected.Token(Token = "0x40029C8")]
				private static readonly FieldCodec<int> _repeated_recipes_codec;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40029C9")]
				private readonly RepeatedField<int> recipes_;

				[Cpp2IlInjected.Token(Token = "0x170017CC")]
				[DebuggerNonUserCode]
				public static MessageParser<CategoryList> Parser
				{
					[Cpp2IlInjected.Token(Token = "0x6005E87")]
					[Cpp2IlInjected.Address(RVA = "0x293B170", Offset = "0x2939B70", VA = "0x18293B170")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017CD")]
				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005E88")]
					[Cpp2IlInjected.Address(RVA = "0x293B0F0", Offset = "0x2939AF0", VA = "0x18293B0F0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017CE")]
				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
				{
					[Cpp2IlInjected.Token(Token = "0x6005E89")]
					[Cpp2IlInjected.Address(RVA = "0x293B1D0", Offset = "0x2939BD0", VA = "0x18293B1D0", Slot = "9")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017CF")]
				[DebuggerNonUserCode]
				public int Category
				{
					[Cpp2IlInjected.Token(Token = "0x6005E8D")]
					[Cpp2IlInjected.Address(RVA = "0x5C2CD0", Offset = "0x5C16D0", VA = "0x1805C2CD0")]
					get
					{
						return default(int);
					}
					[Cpp2IlInjected.Token(Token = "0x6005E8E")]
					[Cpp2IlInjected.Address(RVA = "0x5C2DF0", Offset = "0x5C17F0", VA = "0x1805C2DF0")]
					set
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170017D0")]
				[DebuggerNonUserCode]
				public RepeatedField<int> Recipes
				{
					[Cpp2IlInjected.Token(Token = "0x6005E8F")]
					[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6005E86")]
				[Cpp2IlInjected.Address(RVA = "0x2939A40", Offset = "0x2938440", VA = "0x182939A40", Slot = "4")]
				public void DataValidation(DataValidation.Context context)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E8A")]
				[Cpp2IlInjected.Address(RVA = "0x293B070", Offset = "0x2939A70", VA = "0x18293B070")]
				[DebuggerNonUserCode]
				public CategoryList()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E8B")]
				[Cpp2IlInjected.Address(RVA = "0x293AF70", Offset = "0x2939970", VA = "0x18293AF70")]
				[DebuggerNonUserCode]
				public CategoryList(CategoryList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E8C")]
				[Cpp2IlInjected.Address(RVA = "0x2939910", Offset = "0x2938310", VA = "0x182939910", Slot = "11")]
				[DebuggerNonUserCode]
				public CategoryList Clone()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005E90")]
				[Cpp2IlInjected.Address(RVA = "0x293A820", Offset = "0x2939220", VA = "0x18293A820", Slot = "0")]
				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005E91")]
				[Cpp2IlInjected.Address(RVA = "0x293A900", Offset = "0x2939300", VA = "0x18293A900", Slot = "10")]
				[DebuggerNonUserCode]
				public bool Equals(CategoryList other)
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6005E92")]
				[Cpp2IlInjected.Address(RVA = "0x761FE0", Offset = "0x7609E0", VA = "0x180761FE0", Slot = "2")]
				[DebuggerNonUserCode]
				public override int GetHashCode()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005E93")]
				[Cpp2IlInjected.Address(RVA = "0x293ACE0", Offset = "0x29396E0", VA = "0x18293ACE0", Slot = "3")]
				[DebuggerNonUserCode]
				public override string ToString()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005E94")]
				[Cpp2IlInjected.Address(RVA = "0x293AD40", Offset = "0x2939740", VA = "0x18293AD40", Slot = "7")]
				[DebuggerNonUserCode]
				public void WriteTo(CodedOutputStream output)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E95")]
				[Cpp2IlInjected.Address(RVA = "0x29397B0", Offset = "0x29381B0", VA = "0x1829397B0", Slot = "8")]
				[DebuggerNonUserCode]
				public int CalculateSize()
				{
					return default(int);
				}

				[Cpp2IlInjected.Token(Token = "0x6005E96")]
				[Cpp2IlInjected.Address(RVA = "0x293AA70", Offset = "0x2939470", VA = "0x18293AA70", Slot = "5")]
				[DebuggerNonUserCode]
				public void MergeFrom(CategoryList other)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E97")]
				[Cpp2IlInjected.Address(RVA = "0x293AB00", Offset = "0x2939500", VA = "0x18293AB00", Slot = "6")]
				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E98")]
				[Cpp2IlInjected.Address(RVA = "0x293A9A0", Offset = "0x29393A0", VA = "0x18293A9A0", Slot = "12")]
				[DebuggerNonUserCode]
				public object GetFieldValue(int fieldNumber)
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6005E99")]
				[Cpp2IlInjected.Address(RVA = "0x293AC10", Offset = "0x2939610", VA = "0x18293AC10", Slot = "13")]
				[DebuggerNonUserCode]
				public void SetFieldValue(int fieldNumber, object value)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6005E9A")]
				[Cpp2IlInjected.Address(RVA = "0x29398A0", Offset = "0x29382A0", VA = "0x1829398A0", Slot = "14")]
				[DebuggerNonUserCode]
				public void ClearFieldValue(int fieldNumber)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40029BC")]
		public static readonly Item QuestsItem;

		[Cpp2IlInjected.Token(Token = "0x40029BD")]
		public static readonly Item SecretItem;

		[Cpp2IlInjected.Token(Token = "0x40029BE")]
		private static readonly MessageParser<CookingRecipeList> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40029BF")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x40029C0")]
		public const int ListFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x40029C1")]
		private static readonly FieldCodec<Types.CategoryList> _repeated_list_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40029C2")]
		private readonly RepeatedField<Types.CategoryList> list_ = (RepeatedField<Types.CategoryList>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x170017C8")]
		[DebuggerNonUserCode]
		public static MessageParser<CookingRecipeList> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x6005E73")]
			[Cpp2IlInjected.Address(RVA = "0x32855B0", Offset = "0x3283FB0", VA = "0x1832855B0")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017C9")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005E74")]
			[Cpp2IlInjected.Address(RVA = "0x32854E0", Offset = "0x3283EE0", VA = "0x1832854E0")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017CA")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x6005E75")]
			[Cpp2IlInjected.Address(RVA = "0x3285610", Offset = "0x3284010", VA = "0x183285610", Slot = "9")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170017CB")]
		[DebuggerNonUserCode]
		public RepeatedField<Types.CategoryList> List
		{
			[Cpp2IlInjected.Token(Token = "0x6005E79")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E70")]
		[Cpp2IlInjected.Address(RVA = "0x3284D70", Offset = "0x3283770", VA = "0x183284D70")]
		public bool IsRecipeQuestItem(Item item)
		{
			//Discarded unreachable code: IL_003c
			//IL_0022: Expected O, but got I4
			int itemID = item.ItemID;
			RepeatedField<Types.CategoryList> repeatedField = list_;
			int index = 0;
			if (((RepeatedField<T>)(object)((Types.CategoryList)((RepeatedField<T>)(object)repeatedField)[index]).recipes_).Contains((T)itemID))
			{
				return true;
			}
			RepeatedField<int> recipes_ = ((Types.CategoryList)((RepeatedField<T>)(object)list_)[1]).recipes_;
			bool result = default(bool);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E71")]
		[Cpp2IlInjected.Address(RVA = "0x3284AE0", Offset = "0x32834E0", VA = "0x183284AE0")]
		public static string GetEditorInfo(Item item)
		{
			//Discarded unreachable code: IL_002a
			//IL_0023: Expected O, but got I4
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			bool flag = default(bool);
			if (flag)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				bool flag2 = default(bool);
				int num2 = default(int);
				if (flag2)
				{
					return $"StarRating: {num2}";
				}
			}
			return "";
		}

		[Cpp2IlInjected.Token(Token = "0x6005E72")]
		[Cpp2IlInjected.Address(RVA = "0x32842C0", Offset = "0x3282CC0", VA = "0x1832842C0", Slot = "4")]
		public unsafe void DataValidation(DataValidation.Context context)
		{
			//Discarded unreachable code: IL_00f3, IL_00f9, IL_00ff, IL_0105, IL_010b, IL_0111, IL_0117, IL_011d, IL_0123, IL_0129, IL_012f
			//IL_0058: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			//IL_00d3: Expected O, but got I4
			int num2 = default(int);
			uint num3 = default(uint);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			do
			{
				int num = 0;
				if (((RepeatedField<T>)(object)list_).Count == 0)
				{
					break;
				}
				RepeatedField<Types.CategoryList> repeatedField = list_;
				int index = 0;
				int category_ = ((Types.CategoryList)((RepeatedField<T>)(object)repeatedField)[index]).category_;
				List<Item> list = (List<Item>)(object)new List<T>();
				RepeatedField<Types.CategoryList> repeatedField2 = list_;
				int index2 = 0;
				RepeatedField<int> recipes_ = ((Types.CategoryList)((RepeatedField<T>)(object)repeatedField2)[index2]).recipes_;
				Func<int, Item> func = (Func<int, Item>)(object)new Func<T, TResult>(num2, (IntPtr)(void*)(ulong)(UIntPtr/*delegate*<int, Item>*/)(&Item.New));
				num2 = 0;
				IEnumerable<int> enumerable = (IEnumerable<int>)Enumerable.Select<int, Item>((IEnumerable<>)(object)recipes_, (Func<, >)(object)func);
				if (enumerable != null)
				{
					if (num < (int)num3)
					{
						num += num;
						if (num == (int)num3)
						{
							goto IL_00be;
						}
						num++;
					}
					while (!flag)
					{
					}
					while (!flag2)
					{
					}
					if (_003C_003Ec._003C_003E9__4_0 == null)
					{
						_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Predicate<T>)delegate(RecipeItemData.Types.Ingredient x)
						{
							int num4 = 0;
							if ((object)x.get_Item() != null)
							{
								ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
								Item? item = (Item?)x.get_Item();
								bool flag5 = default(bool);
								if (flag5)
								{
									return flag5;
								}
							}
							int num5 = 0;
							throw new NullReferenceException();
						};
					}
					if (!flag3)
					{
						string text = $"Quests contain an invalid recipe: {flag3}\nReason: It don't contain 'quest' ingredient";
					}
					if (!flag4)
					{
						goto IL_00be;
					}
					goto IL_00c5;
				}
				goto IL_00d5;
				IL_00be:
				flag4 = (byte)((flag4 ? 1u : 0u) + (flag4 ? 1u : 0u)) != 0;
				goto IL_00c5;
				IL_00c5:
				string text2 = $"Quests cannot contain multiple recipes with the same result\nSharedResult: {flag4}\nRecipe2: {flag4}";
				goto IL_00d5;
				IL_00d5:
				if (enumerable != null)
				{
				}
			}
			while (flag4);
			context.AddInvalidMemberError("First category have to be Quest", "List");
		}

		[Cpp2IlInjected.Token(Token = "0x6005E76")]
		[Cpp2IlInjected.Address(RVA = "0x3285460", Offset = "0x3283E60", VA = "0x183285460")]
		[DebuggerNonUserCode]
		public CookingRecipeList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005E77")]
		[Cpp2IlInjected.Address(RVA = "0x3285360", Offset = "0x3283D60", VA = "0x183285360")]
		[DebuggerNonUserCode]
		public CookingRecipeList(CookingRecipeList other)
		{
			RepeatedField<Types.CategoryList> repeatedField = (list_ = (RepeatedField<Types.CategoryList>)(object)((RepeatedField<T>)(object)other.list_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E78")]
		[Cpp2IlInjected.Address(RVA = "0x3284190", Offset = "0x3282B90", VA = "0x183284190", Slot = "11")]
		[DebuggerNonUserCode]
		public CookingRecipeList Clone()
		{
			//Discarded unreachable code: IL_003b
			CookingRecipeList cookingRecipeList = new CookingRecipeList();
			RepeatedField<Types.CategoryList> repeatedField = (cookingRecipeList.list_ = (RepeatedField<Types.CategoryList>)(object)new RepeatedField<T>());
			RepeatedField<Types.CategoryList> repeatedField2 = (cookingRecipeList.list_ = (RepeatedField<Types.CategoryList>)(object)((RepeatedField<T>)(object)list_).Clone());
			UnknownFieldSet unknownFieldSet = (cookingRecipeList._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return cookingRecipeList;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E7A")]
		[Cpp2IlInjected.Address(RVA = "0x3284A00", Offset = "0x3283400", VA = "0x183284A00", Slot = "0")]
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
				RepeatedField<Types.CategoryList> repeatedField = list_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E7B")]
		[Cpp2IlInjected.Address(RVA = "0x3284970", Offset = "0x3283370", VA = "0x183284970", Slot = "10")]
		[DebuggerNonUserCode]
		public bool Equals(CookingRecipeList other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<Types.CategoryList> repeatedField = list_;
				RepeatedField<Types.CategoryList> repeatedField2 = other.list_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6005E7C")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)list_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E7D")]
		[Cpp2IlInjected.Address(RVA = "0x3285010", Offset = "0x3283A10", VA = "0x183285010", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E7E")]
		[Cpp2IlInjected.Address(RVA = "0x3285070", Offset = "0x3283A70", VA = "0x183285070", Slot = "7")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<Types.CategoryList> repeatedField = list_;
			FieldCodec<Types.CategoryList> repeated_list_codec = _repeated_list_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_list_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x6005E7F")]
		[Cpp2IlInjected.Address(RVA = "0x3284080", Offset = "0x3282A80", VA = "0x183284080", Slot = "8")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<Types.CategoryList> repeatedField = list_;
			FieldCodec<Types.CategoryList> repeated_list_codec = _repeated_list_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_list_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E80")]
		[Cpp2IlInjected.Address(RVA = "0x3284F30", Offset = "0x3283930", VA = "0x183284F30", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CookingRecipeList other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<Types.CategoryList> repeatedField = list_;
				RepeatedField<Types.CategoryList> repeatedField2 = other.list_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E81")]
		[Cpp2IlInjected.Address(RVA = "0x3284E40", Offset = "0x3283840", VA = "0x183284E40", Slot = "6")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_003c
			uint num = input.ReadTag();
			if (num != 0)
			{
				if (num == 10)
				{
					RepeatedField<Types.CategoryList> repeatedField = list_;
					FieldCodec<Types.CategoryList> repeated_list_codec = _repeated_list_codec;
					((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_list_codec);
				}
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E82")]
		[Cpp2IlInjected.Address(RVA = "0x3284CF0", Offset = "0x32836F0", VA = "0x183284CF0", Slot = "12")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<Types.CategoryList> repeatedField = list_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E83")]
		[Cpp2IlInjected.Address(RVA = "0x3284FB0", Offset = "0x32839B0", VA = "0x183284FB0", Slot = "13")]
		[DebuggerNonUserCode]
		public void SetFieldValue(int fieldNumber, object value)
		{
			if (fieldNumber != 1)
			{
				return;
			}
			InvalidOperationException ex = new InvalidOperationException("SetValue is not implemented");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6005E84")]
		[Cpp2IlInjected.Address(RVA = "0x3284130", Offset = "0x3282B30", VA = "0x183284130", Slot = "14")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<Types.CategoryList> repeatedField = list_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005E85")]
		[Cpp2IlInjected.Address(RVA = "0x3285130", Offset = "0x3283B30", VA = "0x183285130")]
		static CookingRecipeList()
		{
			//IL_000b: Expected O, but got I8
			//IL_0016: Expected O, but got I8
			uint value = default(uint);
			QuestsItem = (Item)Convert.ToInt64(value);
			uint value2 = default(uint);
			SecretItem = (Item)Convert.ToInt64(value2);
			QuestsItem = (Item)new MessageParser<T>((Func<>)(object)(Func<TResult>)(() => new CookingRecipeList()));
			MessageParser<Types.CategoryList> parser = Types.CategoryList._parser;
			uint num = default(uint);
			QuestsItem = (Item)FieldCodec.ForMessage<Types.CategoryList>(num, (MessageParser<>)(object)parser);
			/*Error: Unexpected end of block*/;
		}
	}
}
