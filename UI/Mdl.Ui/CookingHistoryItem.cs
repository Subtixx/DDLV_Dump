using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200037C")]
	[RequiredAllNotNull]
	public class CookingHistoryItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40010E0")]
		[SerializeField]
		private AsyncAtlassedIcon _icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40010E1")]
		[SerializeField]
		private StarComponent _star;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40010E2")]
		[SerializeField]
		private RectTransform _ingredienList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40010E3")]
		[SerializeField]
		private CookingHistoryIngredientItem _ingredienPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40010E4")]
		[SerializeField]
		private Sprite _spriteGoodIngredient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40010E5")]
		[SerializeField]
		private Sprite _spriteGoodType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40010E6")]
		[SerializeField]
		private Sprite _spriteWrongIngredient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40010E7")]
		[SerializeField]
		private Sprite _spriteEmpty;

		[Cpp2IlInjected.Token(Token = "0x170003D4")]
		public CookingHistory HistoryInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6001642")]
			[Cpp2IlInjected.Address(RVA = "0x717ED0", Offset = "0x7168D0", VA = "0x180717ED0")]
			[CompilerGenerated]
			get
			{
				return _003CHistoryInfo_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001643")]
			[Cpp2IlInjected.Address(RVA = "0x718050", Offset = "0x716A50", VA = "0x180718050")]
			[CompilerGenerated]
			internal set
			{
				_003CHistoryInfo_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170003D5")]
		private Cookbook _cookbook
		{
			[Cpp2IlInjected.Token(Token = "0x6001644")]
			[Cpp2IlInjected.Address(RVA = "0x14A8810", Offset = "0x14A7210", VA = "0x1814A8810")]
			get
			{
				//Discarded unreachable code: IL_001a
				return SystemRoot.Instance.Client.Profile.player_.cookbook_;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001645")]
		[Cpp2IlInjected.Address(RVA = "0x14A7FE0", Offset = "0x14A69E0", VA = "0x1814A7FE0")]
		internal void RefreshDisplay()
		{
			//Discarded unreachable code: IL_021f
			//IL_00ee: Expected I4, but got O
			//IL_00f7: Expected O, but got I4
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			CookingHistory cookingHistory = HistoryInfo;
			MealItemData mealItemData2 = default(MealItemData);
			MealItemData mealItemData = mealItemData2;
			ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			int subItemEnumType = 0;
			IEnumerable<> allByType = _003CInstance_003Ek__BackingField2.GetAllByType<RecipeItemData, ActivityDataItemType>(ItemType.ActivityData, (ActivityDataItemType)subItemEnumType);
			Func<RecipeItemData, bool> func = (Func<RecipeItemData, bool>)(object)(Func<T, TResult>)delegate(RecipeItemData x)
			{
				//Discarded unreachable code: IL_0018
				int resultItemID = x.ResultItemID;
				int iD = mealItemData.ID;
				return resultItemID == iD;
			};
			RecipeItemData recipeItemData = Enumerable.FirstOrDefault<RecipeItemData>(allByType, (Func<, >)(object)func);
			AsyncAtlassedIcon icon = _icon;
			StarComponent star = _star;
			int num = 0;
			int childCount = _ingredienList.childCount;
			CookingHistoryIngredientItem ingredienPrefab = _ingredienPrefab;
			RectTransform ingredienList = _ingredienList;
			CookingHistoryIngredientItem cookingHistoryIngredientItem = UnityEngine.Object.Instantiate(ingredienPrefab, ingredienList);
			CookingHistoryIngredientItem component = _ingredienList.GetChild(num).GetComponent<CookingHistoryIngredientItem>();
			RectTransform component2 = component.GetComponent<RectTransform>();
			Item ingredient = Item.Invalid;
			int count = ((RepeatedField<T>)(object)HistoryInfo.ingredients_).Count;
			Sprite spriteEmpty = _spriteEmpty;
			int num2 = (int)((RepeatedField<T>)(object)HistoryInfo.ingredients_)[num];
			ingredient = (Item)num2;
			Item item = ingredient;
			int num3 = 0;
			int count2 = ((RepeatedField<T>)(object)recipeItemData.ingredients_).Count;
			if (num3 < count2)
			{
				RecipeItemData.Types.Ingredient ingredient2 = (RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)recipeItemData.ingredients_)[num3];
				RepeatedField<RecipeItemData.Types.Ingredient> ingredients_ = recipeItemData.ingredients_;
				if (ingredient2.ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.Any)
				{
					goto IL_01a7;
				}
				RecipeItemData.Types.Ingredient ingredient3 = (RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_)[num3];
				RepeatedField<RecipeItemData.Types.Ingredient> ingredients_2 = recipeItemData.ingredients_;
				if (ingredient3.ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.ValidItemsList)
				{
					goto IL_0193;
				}
				if (((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_2)[num3]).ingredientCase_ == RecipeItemData.Types.Ingredient.IngredientOneofCase.TagsList)
				{
					Item[] tags = ((RecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)recipeItemData.ingredients_)[num3]).Tags;
					ICookingIngredient cookingIngredient = default(ICookingIngredient);
					if (ItemDataExtensions.HasAllTags((IHasTags)cookingIngredient, (IEnumerable<>)(object)tags))
					{
						num3++;
						goto IL_0193;
					}
				}
				goto IL_01b0;
			}
			goto IL_01b6;
			IL_01b0:
			num3++;
			goto IL_01b6;
			IL_0193:
			RecipeItemData.Types.Ingredient ingredient4 = default(RecipeItemData.Types.Ingredient);
			Item[] itemsList = ingredient4.ItemsList;
			bool flag = default(bool);
			if (flag)
			{
				num3++;
				goto IL_01a7;
			}
			goto IL_01b0;
			IL_01b6:
			if (1u != 0)
			{
			}
			RepeatedField<RecipeItemData.Types.Ingredient> ingredients_3 = recipeItemData.ingredients_;
			Func<RecipeItemData.Types.Ingredient, bool> func2 = (Func<RecipeItemData.Types.Ingredient, bool>)(object)(Func<T, TResult>)delegate(RecipeItemData.Types.Ingredient x)
			{
				//Discarded unreachable code: IL_001a
				if (x.ingredientCase_ != RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
				{
					int num4 = 0;
				}
				return (IntPtr)x.ItemID == (IntPtr)ingredient;
			};
			RecipeItemData.Types.Ingredient ingredient5 = Enumerable.FirstOrDefault<RecipeItemData.Types.Ingredient>(Enumerable.Where<RecipeItemData.Types.Ingredient>((IEnumerable<>)(object)ingredients_3, (Func<, >)(object)func2));
			bool flag2 = ingredient5 != null;
			if (ingredient5 != null)
			{
			}
			Sprite spriteWrongIngredient = default(Sprite);
			if (1 == 0 && !flag2)
			{
				spriteWrongIngredient = _spriteWrongIngredient;
			}
			Item ingredient6 = ingredient;
			component.Init(ingredient6, spriteWrongIngredient);
			num++;
			return;
			IL_01a7:
			RecipeItemData.Types.Ingredient ingredient7 = default(RecipeItemData.Types.Ingredient);
			Item? anyItem = (Item?)ingredient7.get_AnyItem();
			goto IL_01b0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001646")]
		[Cpp2IlInjected.Address(RVA = "0x14A7F10", Offset = "0x14A6910", VA = "0x1814A7F10")]
		private void OnItemDataHandler(ListBase.ListEventData arg0)
		{
			//Discarded unreachable code: IL_0035
			//IL_0015: Expected O, but got I4
			//IL_0034: Expected I4, but got O
			CookingHistoryIngredientItem component = arg0.DisplayObject.GetComponent<CookingHistoryIngredientItem>();
			int num = 0;
			if (!(component == (UnityEngine.Object)num))
			{
				RepeatedField<int> ingredients_ = HistoryInfo.ingredients_;
				int itemIndex = arg0.ItemIndex;
				int num2 = (int)((RepeatedField<T>)(object)ingredients_)[itemIndex];
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001647")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CookingHistoryItem()
		{
		}
	}
}
