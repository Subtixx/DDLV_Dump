using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Google.Protobuf.Collections;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000339")]
	public class CollectionTooltipRecipeModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000386")]
		public MealItemData MealItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001465")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			[CompilerGenerated]
			get
			{
				return _003CMealItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001466")]
			[Cpp2IlInjected.Address(RVA = "0x52C510", Offset = "0x52AF10", VA = "0x18052C510")]
			[CompilerGenerated]
			set
			{
				_003CMealItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000387")]
		public RecipeItemData RecipeItemData
		{
			[Cpp2IlInjected.Token(Token = "0x6001467")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			[CompilerGenerated]
			get
			{
				return _003CRecipeItemData_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001468")]
			[Cpp2IlInjected.Address(RVA = "0x52C9F0", Offset = "0x52B3F0", VA = "0x18052C9F0")]
			[CompilerGenerated]
			set
			{
				_003CRecipeItemData_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001469")]
		[Cpp2IlInjected.Address(RVA = "0x114DB80", Offset = "0x114C580", VA = "0x18114DB80", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//Discarded unreachable code: IL_01ee
			//IL_00c4: Expected O, but got I4
			//IL_00cb: Expected I4, but got I8
			//IL_00dd: Expected I4, but got I8
			//IL_0180: Expected I4, but got O
			int num = 0;
			if ((object)viewBase == null)
			{
			}
			int num2 = 0;
			IItemData itemData = base.ItemData;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			MealItemData mealItemData = default(MealItemData);
			MealItemData = mealItemData;
			if ((IntPtr)RecipeItemData == (IntPtr)num)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
				Func<RecipeItemData, bool> func = (Func<RecipeItemData, bool>)(object)(Func<T, TResult>)delegate(RecipeItemData y)
				{
					//Discarded unreachable code: IL_0018
					int resultItemID = y.ResultItemID;
					int iD = MealItemData.ID;
					return resultItemID == iD;
				};
				IEnumerable<> enumerable = default(IEnumerable<>);
				RecipeItemData recipeItemData = (RecipeItemData = Enumerable.FirstOrDefault<RecipeItemData>(enumerable, (Func<, >)(object)func));
			}
			Cookbook cookbook_ = SystemRoot.Instance.MetaClient.profile.player_.cookbook_;
			int num4 = default(int);
			int num3 = num3 - num4;
			int num5 = default(int);
			int num6 = num5 - 1;
			Transform transform = default(Transform);
			CollectionTooltipElementRect component = transform.GetComponent<CollectionTooltipElementRect>();
			RecycleBin recycleBin = viewBase.RecycleBin;
			GameObject gameObject = component.gameObject;
			recycleBin.SendToBin(gameObject);
			int price = ((BattlePassReward)(object)recycleBin).Price;
			int num7 = 0;
			RecycleBin recycleBin2 = viewBase.RecycleBin;
			Type typeFromHandle = typeof(CollectionTooltipElementRect);
			ulong num8 = default(ulong);
			recycleBin2.FindReusableOrNew(typeFromHandle, (Transform)num7).SetActive((byte)num8 != 0);
			Transform transform2 = default(Transform);
			CollectionTooltipElementRect component2 = transform2.GetComponent<CollectionTooltipElementRect>();
			ulong num9 = default(ulong);
			component2.SetEmptyMode((byte)num9 != 0);
			int emptyMode = 0;
			component2.SetEmptyMode((byte)emptyMode != 0);
			GameObject backgroundFull = component2.BackgroundFull;
			RecipeItemData.Types.Ingredient ingredient2 = default(RecipeItemData.Types.Ingredient);
			RecipeItemData.Types.Ingredient ingredient = ingredient2;
			CollectionTooltipIngredientElementModel collectionTooltipIngredientElementModel = new CollectionTooltipIngredientElementModel();
			bool flag = default(bool);
			if (flag)
			{
				RecipeItemData.Types.Ingredient ingredient3 = ingredient;
				RecipeItemData.Types.Ingredient.IngredientOneofCase ingredientCase_ = ingredient3.ingredientCase_;
				if (ingredient3 != null)
				{
					if (ingredient3 != null)
					{
						if (ingredient3 != null)
						{
							if (ingredientCase_ != RecipeItemData.Types.Ingredient.IngredientOneofCase.ItemID)
							{
								goto IL_01a0;
							}
							Func<ICookingIngredient, bool> func2 = (Func<ICookingIngredient, bool>)(object)(Func<T, TResult>)delegate(ICookingIngredient x)
							{
								//Discarded unreachable code: IL_0014
								Item[] tags = ingredient.Tags;
								return ItemDataExtensions.HasAllTags((IHasTags)x, (IEnumerable<>)(object)tags);
							};
							IEnumerable<> enumerable2 = default(IEnumerable<>);
							ICookingIngredient cookingIngredient = (ICookingIngredient)(collectionTooltipIngredientElementModel.CookingIngredientType = (Item)Enumerable.FirstOrDefault<ICookingIngredient>(Enumerable.Where<ICookingIngredient>(enumerable2, (Func<, >)(object)func2)));
						}
						RepeatedField<int> list_ = ingredient.ValidItemsList.list_;
						int index = 0;
						int num10 = (int)((RepeatedField<T>)(object)list_)[index];
					}
					Item _003CCookingIngredientType_003Ek__BackingField = default(Item);
					collectionTooltipIngredientElementModel.CookingIngredientType = _003CCookingIngredientType_003Ek__BackingField;
				}
				Item? item = (Item?)ingredient.get_Item();
				IItemData itemData2 = default(IItemData);
				((CollectionTooltipElementModel)collectionTooltipIngredientElementModel).ItemData = itemData2;
			}
			goto IL_01a0;
			IL_01a0:
			((CollectionTooltipElement)component2).Model = collectionTooltipIngredientElementModel;
			((CollectionTooltipElement)component2).Model.UpdateDisplay(component2);
			num++;
			CollectionTooltipSellPriceElementModel collectionTooltipSellPriceElementModel = new CollectionTooltipSellPriceElementModel();
			((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).ItemData = (IItemData)collectionTooltipSellPriceElementModel;
			Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipSellPriceElementModel).Sprites;
			CollectionTooltipEnergyElementModel collectionTooltipEnergyElementModel = new CollectionTooltipEnergyElementModel();
			((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).ItemData = (IItemData)collectionTooltipEnergyElementModel;
			Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField2 = ((CollectionTooltipElementModel)collectionTooltipEnergyElementModel).Sprites;
		}

		[Cpp2IlInjected.Token(Token = "0x600146A")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CollectionTooltipRecipeModel()
		{
		}
	}
}
