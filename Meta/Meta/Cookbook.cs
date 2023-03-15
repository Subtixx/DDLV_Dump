using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x200087D")]
	public sealed class Cookbook : IMessage<Cookbook>, IMessage, IEquatable<Cookbook>, IDeepCloneable<Cookbook>, IMessageFieldAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x4002220")]
		private static readonly MessageParser<Cookbook> _parser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002221")]
		private UnknownFieldSet _unknownFields;

		[Cpp2IlInjected.Token(Token = "0x4002222")]
		public const int RecipesFieldNumber = 1;

		[Cpp2IlInjected.Token(Token = "0x4002223")]
		private static readonly FieldCodec<int> _repeated_recipes_codec;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4002224")]
		private readonly RepeatedField<int> recipes_ = (RepeatedField<int>)(object)new RepeatedField<T>();

		[Cpp2IlInjected.Token(Token = "0x17000BE0")]
		[DebuggerNonUserCode]
		public static MessageParser<Cookbook> Parser
		{
			[Cpp2IlInjected.Token(Token = "0x60047A3")]
			[Cpp2IlInjected.Address(RVA = "0x18BB510", Offset = "0x18B9F10", VA = "0x1818BB510")]
			get
			{
				return _parser;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE1")]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047A4")]
			[Cpp2IlInjected.Address(RVA = "0x18BB440", Offset = "0x18B9E40", VA = "0x1818BB440")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE2")]
		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
		{
			[Cpp2IlInjected.Token(Token = "0x60047A5")]
			[Cpp2IlInjected.Address(RVA = "0x18BB570", Offset = "0x18B9F70", VA = "0x1818BB570", Slot = "8")]
			get
			{
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000BE3")]
		[DebuggerNonUserCode]
		public RepeatedField<int> Recipes
		{
			[Cpp2IlInjected.Token(Token = "0x60047A9")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return recipes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047A6")]
		[Cpp2IlInjected.Address(RVA = "0x18BB2C0", Offset = "0x18B9CC0", VA = "0x1818BB2C0")]
		[DebuggerNonUserCode]
		public Cookbook()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60047A7")]
		[Cpp2IlInjected.Address(RVA = "0x18BB340", Offset = "0x18B9D40", VA = "0x1818BB340")]
		[DebuggerNonUserCode]
		public Cookbook(Cookbook other)
		{
			RepeatedField<int> repeatedField = (recipes_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)other.recipes_).Clone());
			UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.Clone(other._unknownFields));
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047A8")]
		[Cpp2IlInjected.Address(RVA = "0x18BA770", Offset = "0x18B9170", VA = "0x1818BA770", Slot = "10")]
		[DebuggerNonUserCode]
		public Cookbook Clone()
		{
			//Discarded unreachable code: IL_003b
			Cookbook cookbook = new Cookbook();
			RepeatedField<int> repeatedField = (cookbook.recipes_ = (RepeatedField<int>)(object)new RepeatedField<T>());
			RepeatedField<int> repeatedField2 = (cookbook.recipes_ = (RepeatedField<int>)(object)((RepeatedField<T>)(object)recipes_).Clone());
			UnknownFieldSet unknownFieldSet = (cookbook._unknownFields = UnknownFieldSet.Clone(_unknownFields));
			return cookbook;
		}

		[Cpp2IlInjected.Token(Token = "0x60047AA")]
		[Cpp2IlInjected.Address(RVA = "0x18BA930", Offset = "0x18B9330", VA = "0x1818BA930", Slot = "0")]
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
				RepeatedField<int> repeatedField = recipes_;
				bool flag = default(bool);
				if (flag)
				{
					return object.Equals(_unknownFields, other);
				}
			}
			int num2 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047AB")]
		[Cpp2IlInjected.Address(RVA = "0x18BA8A0", Offset = "0x18B92A0", VA = "0x1818BA8A0", Slot = "9")]
		[DebuggerNonUserCode]
		public bool Equals(Cookbook other)
		{
			if (other != null)
			{
				if (other == this)
				{
					return true;
				}
				RepeatedField<int> repeatedField = recipes_;
				RepeatedField<int> repeatedField2 = other.recipes_;
				if (((RepeatedField<T>)(object)repeatedField).Equals((RepeatedField<>)(object)repeatedField2))
				{
					UnknownFieldSet unknownFields = other._unknownFields;
					return object.Equals(_unknownFields, unknownFields);
				}
			}
			int num = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047AC")]
		[Cpp2IlInjected.Address(RVA = "0x5B8EB0", Offset = "0x5B78B0", VA = "0x1805B8EB0", Slot = "2")]
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			//Discarded unreachable code: IL_0020
			int hashCode = ((RepeatedField<T>)(object)recipes_).GetHashCode();
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int hashCode2 = unknownFields.GetHashCode();
			}
			return hashCode;
		}

		[Cpp2IlInjected.Token(Token = "0x60047AD")]
		[Cpp2IlInjected.Address(RVA = "0x18BADA0", Offset = "0x18B97A0", VA = "0x1818BADA0", Slot = "3")]
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[Cpp2IlInjected.Token(Token = "0x60047AE")]
		[Cpp2IlInjected.Address(RVA = "0x18BB0C0", Offset = "0x18B9AC0", VA = "0x1818BB0C0", Slot = "6")]
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			//Discarded unreachable code: IL_0028
			RepeatedField<int> repeatedField = recipes_;
			FieldCodec<int> repeated_recipes_codec = _repeated_recipes_codec;
			((RepeatedField<T>)(object)repeatedField).WriteTo(output, (FieldCodec<>)(object)repeated_recipes_codec);
			_unknownFields?.WriteTo(output);
		}

		[Cpp2IlInjected.Token(Token = "0x60047AF")]
		[Cpp2IlInjected.Address(RVA = "0x18BA660", Offset = "0x18B9060", VA = "0x1818BA660", Slot = "7")]
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			//Discarded unreachable code: IL_002f
			RepeatedField<int> repeatedField = recipes_;
			FieldCodec<int> repeated_recipes_codec = _repeated_recipes_codec;
			int num = ((RepeatedField<T>)(object)repeatedField).CalculateSize((FieldCodec<>)(object)repeated_recipes_codec);
			UnknownFieldSet unknownFields = _unknownFields;
			if (unknownFields != null)
			{
				int num2 = unknownFields.CalculateSize();
				num += num2;
			}
			return num;
		}

		[Cpp2IlInjected.Token(Token = "0x60047B0")]
		[Cpp2IlInjected.Address(RVA = "0x18BABD0", Offset = "0x18B95D0", VA = "0x1818BABD0", Slot = "4")]
		[DebuggerNonUserCode]
		public void MergeFrom(Cookbook other)
		{
			//Discarded unreachable code: IL_0035
			if (other != null)
			{
				RepeatedField<int> repeatedField = recipes_;
				RepeatedField<int> repeatedField2 = other.recipes_;
				((RepeatedField<T>)(object)repeatedField).Add((IEnumerable<>)(object)repeatedField2);
				UnknownFieldSet unknownFields = other._unknownFields;
				UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, unknownFields));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047B1")]
		[Cpp2IlInjected.Address(RVA = "0x18BAC50", Offset = "0x18B9650", VA = "0x1818BAC50", Slot = "5")]
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			//Discarded unreachable code: IL_0042
			uint num = input.ReadTag();
			if (num != 0)
			{
				num += 4294967288u;
				if (num != 4294967293u)
				{
					UnknownFieldSet unknownFieldSet = (_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, input));
				}
				RepeatedField<int> repeatedField = recipes_;
				FieldCodec<int> repeated_recipes_codec = _repeated_recipes_codec;
				((RepeatedField<T>)(object)repeatedField).AddEntriesFrom(input, (FieldCodec<>)(object)repeated_recipes_codec);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047B2")]
		[Cpp2IlInjected.Address(RVA = "0x18BAA10", Offset = "0x18B9410", VA = "0x1818BAA10", Slot = "11")]
		[DebuggerNonUserCode]
		public object GetFieldValue(int fieldNumber)
		{
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = recipes_;
			}
			ArgumentException ex = new ArgumentException("Invalid field number", "fieldNumber");
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60047B3")]
		[Cpp2IlInjected.Address(RVA = "0x18BAD40", Offset = "0x18B9740", VA = "0x1818BAD40", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60047B4")]
		[Cpp2IlInjected.Address(RVA = "0x18BA710", Offset = "0x18B9110", VA = "0x1818BA710", Slot = "13")]
		[DebuggerNonUserCode]
		public void ClearFieldValue(int fieldNumber)
		{
			//Discarded unreachable code: IL_000c
			if (fieldNumber == 1)
			{
				RepeatedField<int> repeatedField = recipes_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047B5")]
		[Cpp2IlInjected.Address(RVA = "0x18BAF90", Offset = "0x18B9990", VA = "0x1818BAF90")]
		internal bool UnlockRecipe(Item recipeItem, IPlayerEventDispatcher dispatcher, InvActionType reason = InvActionType.None)
		{
			//IL_0013: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			int itemID = recipeItem.ItemID;
			if (((RepeatedField<T>)(object)recipes_).Contains((T)itemID))
			{
				int num = 0;
			}
			((RepeatedField<T>)(object)recipes_).Add((T)itemID);
			if (dispatcher != null)
			{
				int num2 = 0;
				uint num3 = default(uint);
				if (num2 < (int)num3)
				{
					num2 += num2;
					num2++;
				}
			}
			itemID += itemID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60047B6")]
		[Cpp2IlInjected.Address(RVA = "0x18BAB70", Offset = "0x18B9570", VA = "0x1818BAB70")]
		public bool IsRecipeUnlocked(Item recipeItem)
		{
			//Discarded unreachable code: IL_0014
			//IL_0013: Expected O, but got I4
			int itemID = recipeItem.ItemID;
			return ((RepeatedField<T>)(object)recipes_).Contains((T)itemID);
		}

		[Cpp2IlInjected.Token(Token = "0x60047B7")]
		[Cpp2IlInjected.Address(RVA = "0x18BAA90", Offset = "0x18B9490", VA = "0x1818BAA90")]
		public bool HasRecipeUnlockedWith(int minStarRating)
		{
			//Discarded unreachable code: IL_0029
			RepeatedField<int> cpp2il__autoParamName__idx_ = recipes_;
			Func<int, bool> cpp2il__autoParamName__idx_2 = (Func<int, bool>)(object)(Func<T, TResult>)delegate(int x)
			{
				//Discarded unreachable code: IL_001b
				MealItemData resultMealData = GetResultMealData(x);
				int num2 = minStarRating;
				return resultMealData.starRating_ >= num2;
			};
			return ((IEnumerable<>)(object)cpp2il__autoParamName__idx_).Any<int>((Func<, >)(object)cpp2il__autoParamName__idx_2);
			[Cpp2IlInjected.Token(Token = "0x60047B9")]
			[Cpp2IlInjected.Address(RVA = "0x18BAE00", Offset = "0x18B9800", VA = "0x1818BAE00")]
			static MealItemData GetResultMealData(int recipeID)
			{
				//Discarded unreachable code: IL_001e
				ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
				long num = Convert.ToInt64((uint)recipeID);
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				RecipeItemData recipeItemData = default(RecipeItemData);
				int resultItemID = recipeItemData.ResultItemID;
				MealItemData result = default(MealItemData);
				return result;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60047B8")]
		[Cpp2IlInjected.Address(RVA = "0x18BB180", Offset = "0x18B9B80", VA = "0x1818BB180")]
		static Cookbook()
		{
			Func<Cookbook> func = default(Func<Cookbook>);
			_parser = (MessageParser<Cookbook>)(object)new MessageParser<T>((Func<>)(object)func);
			_parser = (MessageParser<Cookbook>)(object)FieldCodec.ForInt32(10u);
			/*Error: Unexpected end of block*/;
		}
	}
}
