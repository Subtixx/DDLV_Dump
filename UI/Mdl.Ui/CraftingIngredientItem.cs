using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Systems;
using Meta;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003C8")]
	public class CraftingIngredientItem : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001278")]
		[SerializeField]
		private GameObject _itemBackgroundRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4001279")]
		[SerializeField]
		private GameObject _itemBackgroundMissing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400127A")]
		[SerializeField]
		private AsyncAtlassedIcon _itemIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400127B")]
		[SerializeField]
		private TextBase _itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400127C")]
		[SerializeField]
		private RectTransform _count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400127D")]
		[SerializeField]
		private TextBase _inventoryCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400127E")]
		[SerializeField]
		private TextBase _recipeCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400127F")]
		[SerializeField]
		private Color _inventoryCountRegularColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4001280")]
		[SerializeField]
		private Color _inventoryCountLockedColor;

		[Cpp2IlInjected.Token(Token = "0x6001803")]
		[Cpp2IlInjected.Address(RVA = "0x14B21F0", Offset = "0x14B0BF0", VA = "0x1814B21F0")]
		public void Init(CraftingRecipeItemData.Types.Ingredient ingredient, int recipeAmount)
		{
			//Discarded unreachable code: IL_0105
			int num = 0;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			TextBase itemName = _itemName;
			AsyncAtlassedIcon itemIcon = _itemIcon;
			ProfilePlayer playerSection = SystemRoot.Instance.MetaClient.profile.player_;
			ContainerInventory containerInventory = default(ContainerInventory);
			bool belongsToPlayer_ = containerInventory.belongsToPlayer_;
			Func<ContainerInventory, bool> func = (Func<ContainerInventory, bool>)(object)(Func<T, TResult>)delegate(ContainerInventory x)
			{
				if (x.belongsToPlayer_)
				{
					ContainerInventory backpack = playerSection.Backpack;
					if (x != backpack)
					{
						ContainerInventory homeStorage = playerSection.HomeStorage;
						return x != homeStorage;
					}
				}
				int num6 = 0;
				throw new NullReferenceException();
			};
			ICollection<> collection = default(ICollection<>);
			IEnumerable<ContainerInventory> enumerable = (IEnumerable<ContainerInventory>)Enumerable.Where<ContainerInventory>((IEnumerable<>)collection, (Func<, >)(object)func);
			Func<ContainerInventory, int> func2 = (Func<ContainerInventory, int>)(object)(Func<T, TResult>)delegate
			{
				//Discarded unreachable code: IL_000e
				Item item = ingredient.Item;
				int result = default(int);
				return result;
			};
			int num2 = Enumerable.Sum<ContainerInventory>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
			bool flag = default(bool);
			if (flag)
			{
			}
			ItemType itemType = default(ItemType);
			if (itemType == ItemType.Currency)
			{
			}
			TextBase recipeCount = _recipeCount;
			int num4 = default(int);
			int num3 = num3 + num4;
			num3 += num;
			num3 += num2;
			int num5 = default(int);
			num3 += num5;
			string text = default(string);
			recipeCount.Text = text;
			string text2 = default(string);
			_inventoryCount.Text = text2;
			TextMeshProUGUI textComponent = _inventoryCount.TextComponent;
			Color color = (textComponent.color = _inventoryCountLockedColor);
			bool active = default(bool);
			_itemBackgroundRegular.SetActive(active);
			bool active2 = default(bool);
			_itemBackgroundMissing.SetActive(active2);
			LayoutRebuilder.ForceRebuildLayoutImmediate(_count);
		}

		[Cpp2IlInjected.Token(Token = "0x6001804")]
		[Cpp2IlInjected.Address(RVA = "0x837160", Offset = "0x835B60", VA = "0x180837160")]
		public CraftingIngredientItem()
		{
		}
	}
}
