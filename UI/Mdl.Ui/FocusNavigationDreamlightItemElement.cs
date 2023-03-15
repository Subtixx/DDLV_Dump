using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200044B")]
	public class FocusNavigationDreamlightItemElement : FocusNavigationElement
	{
		[Cpp2IlInjected.Token(Token = "0x1700048D")]
		public DreamlightMenu DreamlightMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6001BDC")]
			[Cpp2IlInjected.Address(RVA = "0x738E80", Offset = "0x737880", VA = "0x180738E80")]
			[CompilerGenerated]
			get
			{
				return _003CDreamlightMenu_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BDD")]
			[Cpp2IlInjected.Address(RVA = "0x739E90", Offset = "0x738890", VA = "0x180739E90")]
			[CompilerGenerated]
			set
			{
				_003CDreamlightMenu_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700048E")]
		public DreamlightItem DreamlightItem
		{
			[Cpp2IlInjected.Token(Token = "0x6001BDE")]
			[Cpp2IlInjected.Address(RVA = "0x738AC0", Offset = "0x7374C0", VA = "0x180738AC0")]
			[CompilerGenerated]
			get
			{
				return _003CDreamlightItem_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6001BDF")]
			[Cpp2IlInjected.Address(RVA = "0x976550", Offset = "0x974F50", VA = "0x180976550")]
			[CompilerGenerated]
			set
			{
				_003CDreamlightItem_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE0")]
		[Cpp2IlInjected.Address(RVA = "0x1662440", Offset = "0x1660E40", VA = "0x181662440", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//Discarded unreachable code: IL_0036
			//IL_001f: Expected O, but got I4
			ISupportsFocusNavigation supportsFocusNavigation = default(ISupportsFocusNavigation);
			if (supportsFocusNavigation == null && direction == FocusDirection.Left)
			{
				DreamlightTabButton selectedTab = DreamlightMenu._selectedTab;
				int num = 0;
				if (selectedTab != (Object)num)
				{
					FocusNavigationElement component = DreamlightMenu._selectedTab.GetComponent<FocusNavigationElement>();
				}
			}
			return supportsFocusNavigation;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE1")]
		[Cpp2IlInjected.Address(RVA = "0x16625C0", Offset = "0x1660FC0", VA = "0x1816625C0", Slot = "20")]
		public override void SetFocus()
		{
			//Discarded unreachable code: IL_0021
			base.SetFocus();
			DreamlightMenu dreamlightMenu = DreamlightMenu;
			int num = (dreamlightMenu.FocusedItemIndex = base.transform.GetSiblingIndex());
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE2")]
		[Cpp2IlInjected.Address(RVA = "0x1662580", Offset = "0x1660F80", VA = "0x181662580", Slot = "17")]
		protected override bool IsInFirstRow()
		{
			//Discarded unreachable code: IL_000c
			return DreamlightItem.IsInFirstRow;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE3")]
		[Cpp2IlInjected.Address(RVA = "0x16625A0", Offset = "0x1660FA0", VA = "0x1816625A0", Slot = "18")]
		protected override bool IsInLastRow()
		{
			//Discarded unreachable code: IL_000c
			return DreamlightItem.IsInLastRow;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE4")]
		[Cpp2IlInjected.Address(RVA = "0x1662610", Offset = "0x1661010", VA = "0x181662610")]
		public FocusNavigationDreamlightItemElement()
		{
		}
	}
}
