using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Grid;
using Mdl.Systems;
using Meta;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200025B")]
	public class InventoryNavBar : MenuBarBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000A98")]
		public MainMenuTabButton BackpackButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000A99")]
		public MainMenuTabButton CatalogButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000A9A")]
		public MainMenuTabButton WardrobeButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000A9B")]
		public MainMenuTabButton PhoneButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000A9C")]
		[SerializeField]
		private InventorySideMenu _inventorySideMenu;

		[Cpp2IlInjected.Token(Token = "0x6000F0A")]
		[Cpp2IlInjected.Address(RVA = "0xD2ECE0", Offset = "0xD2D6E0", VA = "0x180D2ECE0")]
		private void OnEnable()
		{
			//Discarded unreachable code: IL_00ea
			bool isLimboActive = SystemRoot.Instance.GetSystem<CurseSystem>().isLimboActive;
			Profile profile = SystemRoot.Instance.MetaClient.profile;
			if (!profile.player_.HasHudApparition(32u))
			{
			}
			bool canStartEditMode = SystemRoot.Instance.GetSystem<GridEditMode>().CanStartEditMode;
			bool flag = profile.player_.HasHudApparition(64u);
			bool flag2 = profile.player_.HasHudApparition(256u);
			GameObject gameObject = CatalogButton.gameObject;
			bool active = !isLimboActive;
			gameObject.SetActive(active);
			IEnumerable<ProfileWorld.FilterInfo> filtersCatalogInfo = (IEnumerable<ProfileWorld.FilterInfo>)profile.world_.GetFiltersCatalogInfo();
			GameObject questIcon = CatalogButton.QuestIcon;
			bool active2 = Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)filtersCatalogInfo);
			questIcon.SetActive(active2);
			WardrobeButton.gameObject.SetActive(active);
			IEnumerable<ProfileWorld.FilterInfo> filtersWardrobeInfo = (IEnumerable<ProfileWorld.FilterInfo>)profile.world_.GetFiltersWardrobeInfo();
			GameObject questIcon2 = WardrobeButton.QuestIcon;
			bool active3 = Enumerable.Any<ProfileWorld.FilterInfo>((IEnumerable<>)filtersWardrobeInfo);
			questIcon2.SetActive(active3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0B")]
		[Cpp2IlInjected.Address(RVA = "0xD2F060", Offset = "0xD2DA60", VA = "0x180D2F060")]
		public void RedirectTab(MainMenuTabButton navTabButton)
		{
			//Discarded unreachable code: IL_0040
			//IL_000a: Expected O, but got I4
			//IL_001a: Expected O, but got I4
			int num = 0;
			Redirect(navTabButton, (ItemFilterData)num);
			InventorySideMenu inventorySideMenu = _inventorySideMenu;
			int num2 = 0;
			if (inventorySideMenu != (UnityEngine.Object)num2)
			{
				_inventorySideMenu.CurrentSelection.IsSelected = true;
				_inventorySideMenu.CurrentSelection.IsHighlighted = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0C")]
		[Cpp2IlInjected.Address(RVA = "0xD2F130", Offset = "0xD2DB30", VA = "0x180D2F130", Slot = "6")]
		public override void Redirect(MainMenuTabButton navTabButton, [Optional] ItemFilterData filter)
		{
			//IL_0010: Expected O, but got I4
			//IL_003b: Expected I4, but got I8
			InventorySideMenu inventorySideMenu = _inventorySideMenu;
			int num = 0;
			if (!(inventorySideMenu != (UnityEngine.Object)num))
			{
				base.Redirect(navTabButton, filter);
				return;
			}
			_inventorySideMenu.CurrentSelection = navTabButton;
			InventorySideMenu inventorySideMenu2 = _inventorySideMenu;
			int popAfterFocusOut = 0;
			ulong num2 = default(ulong);
			inventorySideMenu2.OnFocusOut((byte)popAfterFocusOut != 0, (byte)num2 != 0);
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000F0D")]
		[Cpp2IlInjected.Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public InventoryNavBar()
		{
		}
	}
}
