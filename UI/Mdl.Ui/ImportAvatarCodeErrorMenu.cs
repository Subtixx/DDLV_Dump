using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Navigation;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000296")]
	public class ImportAvatarCodeErrorMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000BA9")]
		[SerializeField]
		private BaseButton _designsButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000BAA")]
		[SerializeField]
		private BaseButton _cancelButton;

		[Cpp2IlInjected.Token(Token = "0x6001048")]
		[Cpp2IlInjected.Address(RVA = "0x1312900", Offset = "0x1311300", VA = "0x181312900", Slot = "27")]
		public override void OnFocusIn()
		{
			base.OnFocusIn();
			SetFocusForController();
		}

		[Cpp2IlInjected.Token(Token = "0x6001049")]
		[Cpp2IlInjected.Address(RVA = "0x13127E0", Offset = "0x13111E0", VA = "0x1813127E0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			SetFocusForController();
		}

		[Cpp2IlInjected.Token(Token = "0x600104A")]
		[Cpp2IlInjected.Address(RVA = "0x1312920", Offset = "0x1311320", VA = "0x181312920")]
		private void SetFocusForController()
		{
			//Discarded unreachable code: IL_003e
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				MenuNavigation menuNavigation = base.MenuNavigation;
				BaseButton cancelButton = _cancelButton;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				FocusNavigationElement component = cancelButton.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600104B")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		public void OnCancelPressed()
		{
			System.IO.Iterator<> iterator = ((System.IO.Iterator<TSource>)(object)this).Clone();
		}

		[Cpp2IlInjected.Token(Token = "0x600104C")]
		[Cpp2IlInjected.Address(RVA = "0x1312800", Offset = "0x1311200", VA = "0x181312800")]
		public void OnDesignsPressed()
		{
			//Discarded unreachable code: IL_0054
			//IL_0053: Expected I4, but got I8
			//IL_0053: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			//IL_0053: Expected O, but got I4
			PopSelf();
			int num = 0;
			UiRoot.Instance.GoBackToHudMenu();
			WardrobeMenuParam wardrobeMenuParam = new WardrobeMenuParam();
			wardrobeMenuParam.CategoryFilter = "Customization";
			int num2 = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num3 = 0;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuWardrobe, wardrobeMenuParam, (PlayerTaskCollider)num4, (ItemFilterData)num3, (string)num3, (Action)num3, (byte)num3 != 0, (byte)num3 != 0, (byte)num3 != 0, (byte)num5 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600104D")]
		[Cpp2IlInjected.Address(RVA = "0x1291C60", Offset = "0x1290660", VA = "0x181291C60", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.GamePromptClose)
			{
				System.IO.Iterator<> iterator = ((System.IO.Iterator<TSource>)(object)this).Clone();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600104E")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF70", Offset = "0xE19970", VA = "0x180E1AF70")]
		public ImportAvatarCodeErrorMenu()
		{
		}
	}
}
