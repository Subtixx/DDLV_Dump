using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004A8")]
	public class UnlockPremiumPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400186D")]
		[SerializeField]
		private BaseButton _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400186E")]
		[SerializeField]
		private UnlockPremiumContent _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400186F")]
		private bool _isInFocus = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001870")]
		private BattlePassSeasonData _battlePassData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001871")]
		private UnlockPremiumContent.UnlockPremiumParam _param;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001872")]
		private int _currencyOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4001873")]
		private bool _isPremiumUnlocked;

		[Cpp2IlInjected.Token(Token = "0x6001E4A")]
		[Cpp2IlInjected.Address(RVA = "0xCABE80", Offset = "0xCAA880", VA = "0x180CABE80", Slot = "32")]
		protected override void RegisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0062
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnClose.ButtonComponent.m_OnClick;
			UnityAction call = OnCancelClickHandler;
			onClick.AddListener(call);
			UnlockPremiumContent content = _content;
			UnlockPremiumContent.Confirmed b = OnConfirmed;
			UnlockPremiumContent.Confirmed onConfirmed = content.OnConfirmed;
			Delegate @delegate = Delegate.Combine(onConfirmed, b);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onConfirmed)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4B")]
		[Cpp2IlInjected.Address(RVA = "0xCAC080", Offset = "0xCAAA80", VA = "0x180CAC080", Slot = "33")]
		protected override void UnregisterFocusedListeners()
		{
			//Discarded unreachable code: IL_0062
			base.UnregisterFocusedListeners();
			Button.ButtonClickedEvent onClick = _btnClose.ButtonComponent.m_OnClick;
			UnityAction call = OnCancelClickHandler;
			onClick.RemoveListener(call);
			UnlockPremiumContent content = _content;
			UnlockPremiumContent.Confirmed value = OnConfirmed;
			UnlockPremiumContent.Confirmed onConfirmed = content.OnConfirmed;
			Delegate @delegate = Delegate.Remove(onConfirmed, value);
			if ((object)@delegate == null || (object)@delegate != null)
			{
				while ((object)@delegate != onConfirmed)
				{
				}
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4C")]
		[Cpp2IlInjected.Address(RVA = "0xCABDA0", Offset = "0xCAA7A0", VA = "0x180CABDA0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param != null)
				{
					int num2 = 0;
					_param = (UnlockPremiumContent.UnlockPremiumParam)param;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4D")]
		[Cpp2IlInjected.Address(RVA = "0xCABCC0", Offset = "0xCAA6C0", VA = "0x180CABCC0", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0040
			base.OnFocusIn();
			UnlockPremiumContent.UnlockPremiumParam param = _param;
			if (param != null)
			{
				_content.Init(param);
			}
			base.IsDataUpToDate = true;
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4E")]
		[Cpp2IlInjected.Address(RVA = "0xCABC70", Offset = "0xCAA670", VA = "0x180CABC70", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0022
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E4F")]
		[Cpp2IlInjected.Address(RVA = "0xCABD40", Offset = "0xCAA740", VA = "0x180CABD40", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			AK.Wwise.Event @event = closeSFX;
			if (@event != null)
			{
				GameObject gameObject = base.gameObject;
				uint num = @event.Post(gameObject);
			}
			int animate2 = 0;
			base.OnFocusOut(popAfterFocusOut, (byte)animate2 != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6001E50")]
		[Cpp2IlInjected.Address(RVA = "0xCABB50", Offset = "0xCAA550", VA = "0x180CABB50", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if (redirectionType == RedirectionType.MenuNavGoBackward || redirectionType == RedirectionType.MenuNavClose || redirectionType == RedirectionType.GamePromptClose)
			{
				OnCancelClickHandler();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E51")]
		[Cpp2IlInjected.Address(RVA = "0xCABBF0", Offset = "0xCAA5F0", VA = "0x180CABBF0")]
		private void OnConfirmed(UnlockPremiumContent.UnlockPremiumResult answer)
		{
			//Discarded unreachable code: IL_001b
			//IL_0013: Expected O, but got I4
			_param.AnswerAction((T)answer);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001E52")]
		[Cpp2IlInjected.Address(RVA = "0xCABB70", Offset = "0xCAA570", VA = "0x180CABB70")]
		private void OnCancelClickHandler()
		{
			//Discarded unreachable code: IL_0023
			//IL_001a: Expected O, but got I4
			if (_isInFocus)
			{
				_param.AnswerAction((T)(-1));
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E53")]
		[Cpp2IlInjected.Address(RVA = "0xCAC010", Offset = "0xCAAA10", VA = "0x180CAC010")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_0031
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				UnlockPremiumContent content = _content;
				FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
				content.SetFocus(focusNavigation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001E54")]
		[Cpp2IlInjected.Address(RVA = "0xCAC210", Offset = "0xCAAC10", VA = "0x180CAC210")]
		public UnlockPremiumPopup()
		{
		}
	}
}
