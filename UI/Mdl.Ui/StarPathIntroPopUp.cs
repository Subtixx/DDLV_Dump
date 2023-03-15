using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using Mdl.Navigation;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200050E")]
	[RequiredAllNotNull]
	public class StarPathIntroPopUp : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001B55")]
		[SerializeField]
		private Button _btnRedirectStarPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001B56")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001B57")]
		[SerializeField]
		private bool _allowClose;

		[Cpp2IlInjected.Token(Token = "0x60020ED")]
		[Cpp2IlInjected.Address(RVA = "0x8566E0", Offset = "0x8550E0", VA = "0x1808566E0", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0047
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnRedirectStarPath.m_OnClick;
			UnityAction call = OnRedirectStarPath;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnClose.m_OnClick;
			UnityAction call2 = OnClose;
			onClick2.AddListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x60020EE")]
		[Cpp2IlInjected.Address(RVA = "0x856880", Offset = "0x855280", VA = "0x180856880", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0047
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnRedirectStarPath.m_OnClick;
			UnityAction call = OnRedirectStarPath;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnClose.m_OnClick;
			UnityAction call2 = OnClose;
			onClick2.RemoveListener(call2);
		}

		[Cpp2IlInjected.Token(Token = "0x60020EF")]
		[Cpp2IlInjected.Address(RVA = "0x8567E0", Offset = "0x8551E0", VA = "0x1808567E0")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_0043
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			MenuNavigation menuNavigation = base.MenuNavigation;
			if ((object)menuNavigation != null)
			{
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				if ((object)focusNavigation != null)
				{
					FocusNavigationElement component = _btnRedirectStarPath.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020F0")]
		[Cpp2IlInjected.Address(RVA = "0x8565C0", Offset = "0x854FC0", VA = "0x1808565C0", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0049
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				return;
			}
			MenuNavigation menuNavigation = base.MenuNavigation;
			if ((object)menuNavigation != null)
			{
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				if ((object)focusNavigation != null)
				{
					FocusNavigationElement component = _btnRedirectStarPath.GetComponent<FocusNavigationElement>();
					focusNavigation.SetFocus(component);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020F1")]
		[Cpp2IlInjected.Address(RVA = "0x856660", Offset = "0x855060", VA = "0x180856660")]
		private void OnRedirectStarPath()
		{
			//Discarded unreachable code: IL_0034
			//IL_002b: Expected I4, but got I8
			//IL_002b: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			//IL_002b: Expected O, but got I4
			int num = 0;
			RedirectionManager redirection = UiRoot.Instance.Redirection;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			ulong num5 = default(ulong);
			redirection.Redirect(RedirectionType.MenuEvents, (MenuParam)num4, (PlayerTaskCollider)num3, (ItemFilterData)num2, (string)num2, (Action)num2, (byte)num2 != 0, (byte)num2 != 0, (byte)num2 != 0, (byte)num5 != 0);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60020F2")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void OnClose()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60020F3")]
		[Cpp2IlInjected.Address(RVA = "0x856570", Offset = "0x854F70", VA = "0x180856570", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.GamePromptClose && _allowClose)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020F4")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public StarPathIntroPopUp()
		{
		}
	}
}
