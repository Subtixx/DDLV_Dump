using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20003F5")]
	public class DebugShortcutIndicator : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400136B")]
		[SerializeField]
		private Button _btnClose;

		[Cpp2IlInjected.Token(Token = "0x600191E")]
		[Cpp2IlInjected.Address(RVA = "0x1556F80", Offset = "0x1555980", VA = "0x181556F80")]
		private void Start()
		{
			Debug.Log("THIS IS Debug Menu :: DebugShortcutIndicator");
		}

		[Cpp2IlInjected.Token(Token = "0x600191F")]
		[Cpp2IlInjected.Address(RVA = "0x1556ED0", Offset = "0x15558D0", VA = "0x181556ED0", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = onCloseHandler;
			onClick.AddListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001920")]
		[Cpp2IlInjected.Address(RVA = "0x1556FE0", Offset = "0x15559E0", VA = "0x181556FE0", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0027
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnClose.m_OnClick;
			UnityAction call = onCloseHandler;
			onClick.RemoveListener(call);
		}

		[Cpp2IlInjected.Token(Token = "0x6001921")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		private void onCloseHandler()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001922")]
		[Cpp2IlInjected.Address(RVA = "0x1556EA0", Offset = "0x15558A0", VA = "0x181556EA0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.GamePromptClose || redirectionType == RedirectionType.GamePromptGoBackward)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001923")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public DebugShortcutIndicator()
		{
		}
	}
}
