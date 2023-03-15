using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using Gameloft.Localization.Formatter;
using UnityEngine.Events;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200031D")]
	public class CollectionTooltipFavoriteElementModel : CollectionTooltipElementModel
	{
		[Cpp2IlInjected.Token(Token = "0x17000373")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x38"), Cpp2IlInjected.Token(Token = "0x4000F06")]
		public PreferredItemStatus PreferredItemStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6001406")]
			[Cpp2IlInjected.Address(RVA = "0x7FA490", Offset = "0x7F8E90", VA = "0x1807FA490")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001407")]
			[Cpp2IlInjected.Address(RVA = "0x7FA620", Offset = "0x7F9020", VA = "0x1807FA620")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000374")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x3C"), Cpp2IlInjected.Token(Token = "0x4000F07")]
		public PreferredItemCategory PreferredItemCategory
		{
			[Cpp2IlInjected.Token(Token = "0x6001408")]
			[Cpp2IlInjected.Address(RVA = "0xC561B0", Offset = "0xC54BB0", VA = "0x180C561B0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6001409")]
			[Cpp2IlInjected.Address(RVA = "0xC561E0", Offset = "0xC54BE0", VA = "0x180C561E0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000375")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x40"), Cpp2IlInjected.Token(Token = "0x4000F08")]
		public bool IsAlreadyGifted
		{
			[Cpp2IlInjected.Token(Token = "0x600140A")]
			[Cpp2IlInjected.Address(RVA = "0x63F620", Offset = "0x63E020", VA = "0x18063F620")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600140B")]
			[Cpp2IlInjected.Address(RVA = "0x63FA40", Offset = "0x63E440", VA = "0x18063FA40")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600140C")]
		[Cpp2IlInjected.Address(RVA = "0x114AE60", Offset = "0x1149860", VA = "0x18114AE60", Slot = "4")]
		public override void UpdateDisplay(CollectionTooltipElement view)
		{
			//Discarded unreachable code: IL_0077, IL_00c4, IL_0102
			//IL_006f: Expected O, but got I4
			int num = 0;
			if (PreferredItemCategory == (PreferredItemCategory)num)
			{
				PreferredItemStatus = (PreferredItemStatus)num;
			}
			_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
			if (PreferredItemStatus == PreferredItemStatus.Category)
			{
				PreferredItemCategory preferredItemCategory = PreferredItemCategory;
				string text = _003C_003Ec__DisplayClass12_.ToString();
				_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_2 = _003C_003Ec__DisplayClass12_;
				string text2 = (_003C_003Ec__DisplayClass12_.categoryName = text.ToLower());
				string categoryName = _003C_003Ec__DisplayClass12_.categoryName;
				Dictionary<TextType, string> dictionary = base.Texts;
				string stringID = "menu.label_" + categoryName;
				int num2 = 0;
				string text3 = LocalizationManager.FromStringID(stringID, (IResolver)num2);
				throw new NullReferenceException();
			}
			Dictionary<SpriteType, string> dictionary2 = default(Dictionary<SpriteType, string>);
			if ((long)dictionary2 == 2)
			{
				IItemData itemData = base.ItemData;
				Dictionary<TextType, string> dictionary3 = base.Texts;
				throw new NullReferenceException();
			}
			if (IsAlreadyGifted)
			{
			}
			UnityEvent[] onPhaseChanged = view.OnPhaseChanged;
			PreferredItemStatus preferredItemStatus = PreferredItemStatus;
			onPhaseChanged[(int)preferredItemStatus].Invoke();
		}

		[Cpp2IlInjected.Token(Token = "0x600140D")]
		[Cpp2IlInjected.Address(RVA = "0x1148EB0", Offset = "0x11478B0", VA = "0x181148EB0")]
		public CollectionTooltipFavoriteElementModel()
		{
		}
	}
}
