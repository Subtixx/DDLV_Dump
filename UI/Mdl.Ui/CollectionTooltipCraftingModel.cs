using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Google.Protobuf.Collections;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000312")]
	public class CollectionTooltipCraftingModel : CollectionTooltipModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000EE6")]
		private CraftingRecipeItemData _craftingRecipeData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000EE7")]
		private bool _displayPrice;

		[Cpp2IlInjected.Token(Token = "0x60013D8")]
		[Cpp2IlInjected.Address(RVA = "0x1149540", Offset = "0x1147F40", VA = "0x181149540")]
		public CollectionTooltipCraftingModel(CraftingRecipeItemData craftingRecipeData, bool displayPrice)
		{
			_craftingRecipeData = craftingRecipeData;
			_displayPrice = displayPrice;
		}

		[Cpp2IlInjected.Token(Token = "0x60013D9")]
		[Cpp2IlInjected.Address(RVA = "0x1148EC0", Offset = "0x11478C0", VA = "0x181148EC0", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltip viewBase)
		{
			//IL_0082: Expected I4, but got I8
			//IL_0090: Expected O, but got I4
			//IL_00c6: Expected I4, but got I8
			//IL_01b0: Expected I4, but got I8
			int num = 0;
			int num2 = 0;
			int count = ((RepeatedField<T>)(object)_craftingRecipeData.ingredients_).Count;
			int num3 = num3 - count;
			int num4 = default(int);
			int num5 = num4 - 1;
			int index = 0;
			Transform transform = default(Transform);
			CollectionTooltipElementRect component = transform.GetChild(index).GetComponent<CollectionTooltipElementRect>();
			RecycleBin recycleBin = viewBase.RecycleBin;
			GameObject gameObject = component.gameObject;
			recycleBin.SendToBin(gameObject);
			int num6 = default(int);
			int num7 = num6 - 1;
			Transform transform2 = default(Transform);
			GameObject gameObject2 = transform2.gameObject;
			RepeatedField<CraftingRecipeItemData.Types.Ingredient> ingredients_ = _craftingRecipeData.ingredients_;
			int count2 = ((RepeatedField<T>)(object)ingredients_).Count;
			if (num < count2)
			{
				ulong num8 = default(ulong);
				CraftingRecipeItemData.Types.Ingredient ingredient = (CraftingRecipeItemData.Types.Ingredient)((RepeatedField<T>)(object)ingredients_)[(int)num8];
				int num9 = 0;
				Transform transform3 = default(Transform);
				transform3.parentInternal = (Transform)num9;
				RecycleBin recycleBin2 = viewBase.RecycleBin;
				Type typeFromHandle = typeof(CollectionTooltipElementRect);
				GameObject gameObject3 = recycleBin2.FindReusableOrNew(typeFromHandle, transform3);
				gameObject3.transform.SetAsFirstSibling();
				ulong num10 = default(ulong);
				gameObject3.SetActive((byte)num10 != 0);
				int index2 = 0;
				Transform transform4 = default(Transform);
				CollectionTooltipElementRect component2 = transform4.GetChild(index2).GetComponent<CollectionTooltipElementRect>();
				int emptyMode = 0;
				component2.SetEmptyMode((byte)emptyMode != 0);
				CraftingRecipeItemData.Types.Ingredient ingredient2 = Enumerable.ElementAt<CraftingRecipeItemData.Types.Ingredient>((IEnumerable<>)(object)_craftingRecipeData.ingredients_, num);
				CollectionTooltipCraftingIngredientElementModel collectionTooltipCraftingIngredientElementModel = new CollectionTooltipCraftingIngredientElementModel();
				Item item = (collectionTooltipCraftingIngredientElementModel.CraftingIngredientItem = ingredient2.Item);
				Item item2 = ingredient2.Item;
				IItemData itemData = default(IItemData);
				((CollectionTooltipElementModel)collectionTooltipCraftingIngredientElementModel).ItemData = itemData;
				((CollectionTooltipElement)component2).Model = collectionTooltipCraftingIngredientElementModel;
				((CollectionTooltipElement)component2).Model.UpdateDisplay(component2);
				Transform transform5 = default(Transform);
				TextBase component3 = transform5.GetChild(1).GetComponent<TextBase>();
				int amount_ = ingredient2.amount_;
				string text = default(string);
				component3.Text = text;
				CraftingRecipeItemData craftingRecipeData = _craftingRecipeData;
				num++;
			}
			if (_displayPrice)
			{
				IItemData itemData2 = base.ItemData;
				bool flag = default(bool);
				if (!flag)
				{
					CollectionTooltipFurnitureSellPriceElementModel collectionTooltipFurnitureSellPriceElementModel = new CollectionTooltipFurnitureSellPriceElementModel();
					collectionTooltipFurnitureSellPriceElementModel.SellTextBase = (TextBase)(((CollectionTooltipElementModel)collectionTooltipFurnitureSellPriceElementModel).ItemData = base.ItemData);
					Dictionary<SpriteType, string> _003CSprites_003Ek__BackingField = ((CollectionTooltipElementModel)collectionTooltipFurnitureSellPriceElementModel).Sprites;
					GameObject gameObject4 = default(GameObject);
					ulong num11 = default(ulong);
					gameObject4.SetActive((byte)num11 != 0);
					return;
				}
			}
			throw new NullReferenceException();
		}
	}
}
