using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200031F")]
	public class CollectionTooltipIngredientElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000376")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000F0A")]
		public Item CookingIngredientType
		{
			[Cpp2IlInjected.Token(Token = "0x6001410")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001411")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6001412")]
		[Cpp2IlInjected.Address(RVA = "0x114C480", Offset = "0x114AE80", VA = "0x18114C480", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_0028, IL_0058, IL_006a
			Item item = CookingIngredientType;
			bool flag = default(bool);
			if (!flag)
			{
				UnityEvent[] onPhaseChanged = view.OnPhaseChanged;
			}
			if (base.ItemData != null)
			{
				Dictionary<SpriteType, string> dictionary = base.Sprites;
				throw new NullReferenceException();
			}
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item2 = CookingIngredientType;
			IItemData itemData = _003CInstance_003Ek__BackingField.GetItemData(item2);
			Dictionary<SpriteType, string> dictionary2 = base.Sprites;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001413")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipIngredientElementModel()
		{
		}
	}
}
