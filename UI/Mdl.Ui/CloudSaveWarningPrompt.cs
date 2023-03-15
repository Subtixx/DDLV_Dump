using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2IlInjected;
using Gameloft.Localization.Formatter;
using Mdl.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20004D7")]
	[RequiredAllNotNull]
	public class CloudSaveWarningPrompt : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.Token(Token = "0x20004D8")]
		public class CloudSaveWarningPromptParam : MenuParam
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4001992")]
			public string PackName;

			[Cpp2IlInjected.Token(Token = "0x6001FA5")]
			[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
			public CloudSaveWarningPromptParam()
			{
				((System.Runtime.Serialization.Formatters.Binary.InternalFE)(object)this)._002Ector();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20004D9")]
		private enum CloudSaveWarningPromptState
		{
			[Cpp2IlInjected.Token(Token = "0x4001994")]
			FirstWarning,
			[Cpp2IlInjected.Token(Token = "0x4001995")]
			SecondWarning
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001988")]
		[SerializeField]
		private BaseButton _btnClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001989")]
		[SerializeField]
		private ButtonTmPro _btnClaimAnyway;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400198A")]
		[SerializeField]
		private ButtonTmPro _btnMainMenuRedirect;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400198B")]
		[SerializeField]
		private TextBase _tfDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400198C")]
		[SerializeField]
		private TextBase _tfSubDesc;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400198D")]
		[SerializeField]
		private TextBase _tfTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400198E")]
		[SerializeField]
		private RectTransform _animatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400198F")]
		private CloudSaveWarningPromptState _currentState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001990")]
		private string _packName = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001991")]
		private CloudSaveWarningPromptParam _param;

		[Cpp2IlInjected.Token(Token = "0x6001F99")]
		[Cpp2IlInjected.Address(RVA = "0x1003920", Offset = "0x1002320", VA = "0x181003920", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_007a
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnMainMenuRedirect.ButtonComponent.m_OnClick;
			UnityAction call = OnRedirectButton;
			onClick.AddListener(call);
			Button.ButtonClickedEvent onClick2 = _btnClaimAnyway.ButtonComponent.m_OnClick;
			UnityAction call2 = OnClaimButton;
			onClick2.AddListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnClose.ButtonComponent.m_OnClick;
			UnityAction call3 = OnCloseButton;
			onClick3.AddListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9A")]
		[Cpp2IlInjected.Address(RVA = "0x1003B50", Offset = "0x1002550", VA = "0x181003B50", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_007a
			((object)this)._002Ector();
			Button.ButtonClickedEvent onClick = _btnMainMenuRedirect.ButtonComponent.m_OnClick;
			UnityAction call = OnRedirectButton;
			onClick.RemoveListener(call);
			Button.ButtonClickedEvent onClick2 = _btnClaimAnyway.ButtonComponent.m_OnClick;
			UnityAction call2 = OnClaimButton;
			onClick2.RemoveListener(call2);
			Button.ButtonClickedEvent onClick3 = _btnClose.ButtonComponent.m_OnClick;
			UnityAction call3 = OnCloseButton;
			onClick3.RemoveListener(call3);
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9B")]
		[Cpp2IlInjected.Address(RVA = "0x1002FA0", Offset = "0x10019A0", VA = "0x181002FA0", Slot = "25")]
		public override void OnPush(MenuStack stack, [System.Runtime.InteropServices.Optional] MenuParam param)
		{
			base.OnPush(stack, param);
			if (param != null)
			{
				int num = 0;
				if (param == null)
				{
					goto IL_001b;
				}
				_param = (CloudSaveWarningPromptParam)param;
			}
			int currentState = 0;
			goto IL_001b;
			IL_001b:
			_currentState = (CloudSaveWarningPromptState)currentState;
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9C")]
		[Cpp2IlInjected.Address(RVA = "0x1002F30", Offset = "0x1001930", VA = "0x181002F30", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_0042
			base.OnFocusIn();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				SetFocus();
			}
			CloudSaveWarningPromptParam param = _param;
			if (param != null)
			{
				string text = (_packName = param.PackName);
			}
			RefreshDisplay();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9D")]
		[Cpp2IlInjected.Address(RVA = "0x10031A0", Offset = "0x1001BA0", VA = "0x1810031A0")]
		private void RefreshDisplay()
		{
			//Discarded unreachable code: IL_0051, IL_0140, IL_0278
			//IL_0225: Expected O, but got I4
			GraphicSettingsData _003CCurrentGraphicSettingsData_003Ek__BackingField = GraphicSettings.CurrentGraphicSettingsData;
			int num = 0;
			if ((object)_003CCurrentGraphicSettingsData_003Ek__BackingField != null)
			{
				bool supportsReturnToMainMenu = _003CCurrentGraphicSettingsData_003Ek__BackingField.SupportsReturnToMainMenu;
			}
			if (_currentState == CloudSaveWarningPromptState.FirstWarning)
			{
				_tfDesc.StringID = "menu.cloud_save_suggest";
				TextBase tfSubDesc = _tfSubDesc;
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				string text = _packName.ToString();
				throw new NullReferenceException();
			}
			TextBase textBase = default(TextBase);
			if ((long)textBase == 1)
			{
				_tfDesc.StringID = "menu.cloud_save_confirmation";
				TextBase tfSubDesc2 = _tfSubDesc;
				Dictionary<string, object> dictionary2 = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				string text2 = _packName.ToString();
				throw new NullReferenceException();
			}
			bool flag = default(bool);
			if (!flag)
			{
				if (_currentState == CloudSaveWarningPromptState.FirstWarning)
				{
					TextBase tfDesc = _tfDesc;
					string text3 = tfDesc._text;
					int num2 = 0;
					string text4 = LocalizationManager.FromStringID("menu.cloud_save_access_main_menu", (IResolver)num2);
					string text6 = (tfDesc.Text = text3 + "\n" + text4);
				}
				TextBase label = _btnMainMenuRedirect.Label;
			}
			_btnMainMenuRedirect.Label.StringID = "menu.cloud_save_redirect";
			_tfDesc.RectTransform.parent.RebuildLayout();
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9E")]
		[Cpp2IlInjected.Address(RVA = "0x1003AB0", Offset = "0x10024B0", VA = "0x181003AB0")]
		public void SetFocus()
		{
			//Discarded unreachable code: IL_0044
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigationElement component = _btnMainMenuRedirect.GetComponent<FocusNavigationElement>();
				base.MenuNavigation?.FocusNavigation?.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001F9F")]
		[Cpp2IlInjected.Address(RVA = "0x1002F10", Offset = "0x1001910", VA = "0x181002F10", Slot = "35")]
		internal override void OnControllerChanged()
		{
			base.OnControllerChanged();
			SetFocus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA0")]
		[Cpp2IlInjected.Address(RVA = "0x1003050", Offset = "0x1001A50", VA = "0x181003050")]
		private void OnRedirectButton()
		{
			//Discarded unreachable code: IL_0034
			//IL_002d: Expected O, but got I4
			GraphicSettingsData _003CCurrentGraphicSettingsData_003Ek__BackingField = GraphicSettings.CurrentGraphicSettingsData;
			int num = 0;
			if ((object)_003CCurrentGraphicSettingsData_003Ek__BackingField != null)
			{
				bool supportsReturnToMainMenu = _003CCurrentGraphicSettingsData_003Ek__BackingField.SupportsReturnToMainMenu;
			}
			_param?.AnswerAction((T)1);
			PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA1")]
		[Cpp2IlInjected.Address(RVA = "0x1002E00", Offset = "0x1001800", VA = "0x181002E00")]
		private void OnClaimButton()
		{
			//Discarded unreachable code: IL_0047
			//IL_0024: Expected O, but got I4
			//IL_0040: Expected I4, but got I8
			if (_currentState != 0)
			{
				CloudSaveWarningPromptParam param = _param;
				if (param != null)
				{
					Action<int> answerAction = param.AnswerAction;
					int num = 0;
					answerAction((T)num);
				}
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
			else
			{
				_btnClaimAnyway.PostWwiseEvent();
				_currentState = CloudSaveWarningPromptState.SecondWarning;
				RefreshDisplay();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA2")]
		[Cpp2IlInjected.Address(RVA = "0x1002EA0", Offset = "0x10018A0", VA = "0x181002EA0")]
		private void OnCloseButton()
		{
			//Discarded unreachable code: IL_001f
			//IL_0017: Expected O, but got I4
			_param?.AnswerAction((T)(-1));
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA3")]
		[Cpp2IlInjected.Address(RVA = "0x1002D80", Offset = "0x1001780", VA = "0x181002D80", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [System.Runtime.InteropServices.Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_0026
			//IL_001f: Expected O, but got I4
			if (redirectionType == RedirectionType.GamePromptGoBackward)
			{
				_param?.AnswerAction((T)(-1));
				PopSelf();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA4")]
		[Cpp2IlInjected.Address(RVA = "0x1003CE0", Offset = "0x10026E0", VA = "0x181003CE0")]
		public CloudSaveWarningPrompt()
		{
		}
	}
}
