using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200044C")]
	public class FocusNavigationDreamlightTabElement : FocusNavigationElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40015CA")]
		public DreamlightMenu DreamlightMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40015CB")]
		public SettingsMenu SettingMenu;

		[Cpp2IlInjected.Token(Token = "0x6001BE5")]
		[Cpp2IlInjected.Address(RVA = "0x1662670", Offset = "0x1661070", VA = "0x181662670", Slot = "16")]
		public override ISupportsFocusNavigation FindNext(FocusDirection direction, int input)
		{
			//IL_0020: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00b1: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			ISupportsFocusNavigation supportsFocusNavigation = default(ISupportsFocusNavigation);
			if (supportsFocusNavigation == null && direction == FocusDirection.Right)
			{
				DreamlightMenu dreamlightMenu = DreamlightMenu;
				int num = 0;
				if (dreamlightMenu != (UnityEngine.Object)num)
				{
					DreamlightMenu dreamlightMenu2 = DreamlightMenu;
					if (dreamlightMenu2.FocusedItemIndex != -1)
					{
						int childCount = dreamlightMenu2._items.childCount;
						DreamlightMenu dreamlightMenu3 = DreamlightMenu;
						int focusedItemIndex = dreamlightMenu3.FocusedItemIndex;
						if (childCount > focusedItemIndex)
						{
							Transform child = dreamlightMenu3._items.GetChild(focusedItemIndex);
						}
					}
					DreamlightItem anyVisibleItem = dreamlightMenu2.GetAnyVisibleItem();
					if ((object)anyVisibleItem != null)
					{
						FocusNavigationElement component = anyVisibleItem.GetComponent<FocusNavigationElement>();
					}
				}
				SettingsMenu settingMenu = SettingMenu;
				int num2 = 0;
				if (settingMenu != (UnityEngine.Object)num2)
				{
					GameObject selectedPanel = SettingMenu._selectedPanel;
					int num3 = 0;
					if (selectedPanel != (UnityEngine.Object)num3)
					{
						SettingsMenuPanel componentInChildren = SettingMenu._selectedPanel.GetComponentInChildren<SettingsMenuPanel>();
						if ((object)componentInChildren != null)
						{
							FocusNavigationElement lastFocusedChild = componentInChildren.LastFocusedChild;
							int num4 = 0;
							if (lastFocusedChild != (UnityEngine.Object)num4)
							{
								BaseButton baseButton = BaseButton;
								throw new NullReferenceException();
							}
							FocusNavigationElement firstFocusNavigationElement = componentInChildren.FirstFocusNavigationElement;
						}
					}
				}
			}
			return supportsFocusNavigation;
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE6")]
		[Cpp2IlInjected.Address(RVA = "0x16628E0", Offset = "0x16612E0", VA = "0x1816628E0", Slot = "20")]
		public override void SetFocus()
		{
			//Discarded unreachable code: IL_0063
			//IL_001b: Expected O, but got I4
			//IL_002e: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			base.SetFocus();
			DreamlightTabButton component = base.gameObject.GetComponent<DreamlightTabButton>();
			int num = 0;
			if (component != (UnityEngine.Object)num)
			{
				DreamlightMenu dreamlightMenu = DreamlightMenu;
				int num2 = 0;
				if (dreamlightMenu != (UnityEngine.Object)num2)
				{
					DreamlightMenu.SelectTab(component, fromMove: true);
				}
				SettingsMenu settingMenu = SettingMenu;
				int num3 = 0;
				if (settingMenu != (UnityEngine.Object)num3)
				{
					SettingMenu.SelectTab(component, fromMove: true);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001BE7")]
		[Cpp2IlInjected.Address(RVA = "0x1662A50", Offset = "0x1661450", VA = "0x181662A50")]
		public FocusNavigationDreamlightTabElement()
		{
		}
	}
}
