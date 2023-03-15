using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Gameloft.Localization.Formatter;
using Mdl.Systems;
using Meta;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000297")]
	public class ImportAvatarCodeMenu : TemplateMenu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000BAB")]
		[SerializeField]
		private TextBase _tfError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000BAC")]
		[SerializeField]
		private InputTextBase _tfInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000BAD")]
		[SerializeField]
		private BaseButton _okButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000BAE")]
		[SerializeField]
		private BaseButton _cancelButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000BAF")]
		[SerializeField]
		private FocusNavigation _focusNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000BB0")]
		[SerializeField]
		private AssetReference _importAvatarErrorMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000BB1")]
		[SerializeField]
		private CanvasGroup _mainCanvasGroup;

		[Cpp2IlInjected.Token(Token = "0x600104F")]
		[Cpp2IlInjected.Address(RVA = "0x13139D0", Offset = "0x13123D0", VA = "0x1813139D0")]
		private void Start()
		{
			//Discarded unreachable code: IL_0037
			//IL_0036: Expected O, but got I4
			InputTextBase tfInput = _tfInput;
			TMP_InputField.OnValidateInput onValidateInput = ((TMP_InputField)tfInput).m_OnValidateInput;
			TMP_InputField.OnValidateInput b = ValidateAvatarCode;
			Delegate @delegate = Delegate.Combine(onValidateInput, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				tfInput.onValidateInput = (TMP_InputField.OnValidateInput)num;
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001050")]
		[Cpp2IlInjected.Address(RVA = "0x1313B70", Offset = "0x1312570", VA = "0x181313B70")]
		private char ValidateAvatarCode(string text, int charindex, char addedchar)
		{
			return char.ToUpper(addedchar);
		}

		[Cpp2IlInjected.Token(Token = "0x6001051")]
		[Cpp2IlInjected.Address(RVA = "0x1313080", Offset = "0x1311A80", VA = "0x181313080", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_00d3
			//IL_0059: Expected O, but got I4
			base.OnPush(stack, param);
			ProfilePlayer player_ = SystemRoot.Instance.MetaClient.profile.player_;
			if (!player_.transferDone_)
			{
				int num = 0;
				if (param != null)
				{
					object obj = param.Params[0];
					if (obj != null && obj == null)
					{
						throw new InvalidCastException();
					}
				}
				bool flag = player_ == null;
				if (player_ == null)
				{
					_tfInput.SetTextWithoutNotify((string)num);
				}
				_tfError.gameObject.SetActive(flag);
				SetInputFieldEnabled(flag);
				SetOkButtonStatus();
			}
			else
			{
				int inputFieldEnabled = 0;
				SetInputFieldEnabled((byte)inputFieldEnabled != 0);
				BaseButton okButton = _okButton;
				int num2 = ((okButton.IsActive = false) ? 1 : 0);
				Selectable selectable = _okButton.Selectable;
				int num3 = ((selectable.interactable = false) ? 1 : 0);
				_okButton.GetComponent<FocusNavigationElement>().IgnoreThis = true;
				_tfError.gameObject.SetActive(value: true);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001052")]
		[Cpp2IlInjected.Address(RVA = "0x13129C0", Offset = "0x13113C0", VA = "0x1813129C0")]
		private void DisableEverythingButCancel()
		{
			//Discarded unreachable code: IL_0053
			int inputFieldEnabled = 0;
			SetInputFieldEnabled((byte)inputFieldEnabled != 0);
			BaseButton okButton = _okButton;
			int num = ((okButton.IsActive = false) ? 1 : 0);
			Selectable selectable = _okButton.Selectable;
			int num2 = ((selectable.interactable = false) ? 1 : 0);
			_okButton.GetComponent<FocusNavigationElement>().IgnoreThis = true;
			_tfError.gameObject.SetActive(value: true);
		}

		[Cpp2IlInjected.Token(Token = "0x6001053")]
		[Cpp2IlInjected.Address(RVA = "0x13135C0", Offset = "0x1311FC0", VA = "0x1813135C0")]
		private void SetInputFieldEnabled(bool status)
		{
			//Discarded unreachable code: IL_002f
			_tfInput.enabled = status;
			_tfInput.GetComponent<FocusNavigationElement>().IgnoreThis = status;
			_tfInput.GetComponent<MenuInputField>().enabled = status;
		}

		[Cpp2IlInjected.Token(Token = "0x6001054")]
		[Cpp2IlInjected.Address(RVA = "0x1313450", Offset = "0x1311E50", VA = "0x181313450")]
		private void SetCodeState(string avatarCode)
		{
			//Discarded unreachable code: IL_002b
			_tfInput.SetTextWithoutNotify(avatarCode);
			bool flag = default(bool);
			_tfError.gameObject.SetActive(flag);
			SetInputFieldEnabled(flag);
			SetOkButtonStatus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001055")]
		[Cpp2IlInjected.Address(RVA = "0x1312D60", Offset = "0x1311760", VA = "0x181312D60", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_005e
			base.OnFocusIn();
			if (_tfInput.enabled)
			{
			}
			GameObject gameObject = _cancelButton.gameObject;
			FocusNavigation focusNavigation = base.MenuNavigation.FocusNavigation;
			FocusNavigationElement component = gameObject.GetComponent<FocusNavigationElement>();
			focusNavigation.SetFocus(component);
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(_mainCanvasGroup, 1f, 0.2f)).SetEase(Ease.InCirc).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001056")]
		[Cpp2IlInjected.Address(RVA = "0x1312E90", Offset = "0x1311890", VA = "0x181312E90", Slot = "28")]
		public override void OnFocusOut(bool popAfterFocusOut = false, bool animate = true)
		{
			//IL_001d: Expected F4, but got I4
			base.OnFocusOut(popAfterFocusOut, animate);
			CanvasGroup mainCanvasGroup = _mainCanvasGroup;
			int num = 0;
			TweenerCore<float, float, FloatOptions> tweenerCore = ((TweenerCore<float, float, FloatOptions>)(object)DOTweenModuleUI.DOFade(mainCanvasGroup, (float)num, 0.2f)).SetEase(Ease.InCirc).Play();
		}

		[Cpp2IlInjected.Token(Token = "0x6001057")]
		[Cpp2IlInjected.Address(RVA = "0x1312C80", Offset = "0x1311680", VA = "0x181312C80", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0060
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				if (_tfInput.enabled)
				{
				}
				GameObject gameObject = _cancelButton.gameObject;
				MenuNavigation menuNavigation = base.MenuNavigation;
				BaseButton cancelButton = _cancelButton;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				FocusNavigationElement component = cancelButton.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001058")]
		[Cpp2IlInjected.Address(RVA = "0x13134F0", Offset = "0x1311EF0", VA = "0x1813134F0")]
		private void SetFocusForController()
		{
			//Discarded unreachable code: IL_005a
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				if (_tfInput.enabled)
				{
				}
				GameObject gameObject = _cancelButton.gameObject;
				MenuNavigation menuNavigation = base.MenuNavigation;
				BaseButton cancelButton = _cancelButton;
				FocusNavigation focusNavigation = menuNavigation.FocusNavigation;
				FocusNavigationElement component = cancelButton.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001059")]
		[Cpp2IlInjected.Address(RVA = "0x1313330", Offset = "0x1311D30", VA = "0x181313330", Slot = "30")]
		protected override void RegisterBaseListeners()
		{
			//Discarded unreachable code: IL_0042
			((object)this)._002Ector();
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_tfInput).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnAvatarCodeInputChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			InputTextBase tfInput = _tfInput;
			TMP_InputField.OnValidateInput onValidateInput2 = (tfInput.onValidateInput = OnAvatarCodeValidateInput);
		}

		[Cpp2IlInjected.Token(Token = "0x600105A")]
		[Cpp2IlInjected.Address(RVA = "0x1313AA0", Offset = "0x13124A0", VA = "0x181313AA0", Slot = "31")]
		protected override void UnregisterBaseListeners()
		{
			//Discarded unreachable code: IL_0027
			((object)this)._002Ector();
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_tfInput).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnAvatarCodeInputChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x600105B")]
		[Cpp2IlInjected.Address(RVA = "0x8565A0", Offset = "0x854FA0", VA = "0x1808565A0")]
		public void OnCancelPressed()
		{
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x600105C")]
		[Cpp2IlInjected.Address(RVA = "0x1313680", Offset = "0x1312080", VA = "0x181313680")]
		private void SetOkButtonStatus()
		{
			//Discarded unreachable code: IL_0053
			int stringLength = ((TMP_InputField)_tfInput).m_Text.m_stringLength;
			BaseButton okButton = _okButton;
			bool interactable = (okButton.IsActive = stringLength > 0);
			_okButton.Selectable.interactable = interactable;
			FocusNavigationElement component = _okButton.GetComponent<FocusNavigationElement>();
			bool flag2 = (component.IgnoreThis = stringLength <= 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600105D")]
		[Cpp2IlInjected.Address(RVA = "0x1312F30", Offset = "0x1311930", VA = "0x181312F30")]
		public void OnOkPressed()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task asyncTask = default(Task);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x600105E")]
		[Cpp2IlInjected.Address(RVA = "0x1312A90", Offset = "0x1311490", VA = "0x181312A90")]
		[AsyncStateMachine(typeof(_003CDoAvatarTransfer_003Ed__22))]
		private Task DoAvatarTransfer()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			Task result = default(Task);
			return result;
		}

		[Cpp2IlInjected.Token(Token = "0x600105F")]
		[Cpp2IlInjected.Address(RVA = "0x1312BE0", Offset = "0x13115E0", VA = "0x181312BE0")]
		public void OnAvatarCodeInputChanged(string avatarCode)
		{
			SetOkButtonStatus();
		}

		[Cpp2IlInjected.Token(Token = "0x6001060")]
		[Cpp2IlInjected.Address(RVA = "0x1312BF0", Offset = "0x13115F0", VA = "0x181312BF0")]
		private char OnAvatarCodeValidateInput(string text, int charIndex, char addedChar)
		{
			if (!char.IsLetterOrDigit(addedChar))
			{
				int num = 0;
			}
			return char.ToUpper(addedChar);
		}

		[Cpp2IlInjected.Token(Token = "0x6001061")]
		[Cpp2IlInjected.Address(RVA = "0x1312BA0", Offset = "0x13115A0", VA = "0x181312BA0", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			if ((redirectionType > RedirectionType.GamePromptClose && redirectionType == RedirectionType.GamePromptGoBackward) || redirectionType == RedirectionType.GamePromptClose)
			{
				IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001062")]
		[Cpp2IlInjected.Address(RVA = "0x1313760", Offset = "0x1312160", VA = "0x181313760")]
		private void ShowResultPopup(string errorMessageId, bool success = false)
		{
			//Discarded unreachable code: IL_007a
			//IL_001a: Expected O, but got I4
			//IL_0024: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			string text;
			string text2;
			BaseUiRoot _003CInstance_003Ek__BackingField;
			AlertButton[] array;
			AlertButton alertButton;
			int isDefaultGamepadFocus = default(int);
			int num3;
			do
			{
				string stringID = "menu.import_avatar_error_title";
				if (success)
				{
					stringID = "menu.button_avatar_import";
				}
				int num = 0;
				text = LocalizationManager.FromStringID(stringID, (IResolver)num);
				int num2 = 0;
				text2 = LocalizationManager.FromStringID(errorMessageId, (IResolver)num2);
				_003CInstance_003Ek__BackingField = BaseUiRoot.Instance;
				array = new AlertButton[1];
				alertButton = new AlertButton(AlertButtonStyle.Cancel, "menu.button_common_okay", (byte)isDefaultGamepadFocus != 0);
				num3 = 0;
				isDefaultGamepadFocus = 0;
			}
			while (alertButton != null && alertButton == null);
			array[0] = alertButton;
			string text3 = default(string);
			_003CInstance_003Ek__BackingField.UIAlert(text2, (IEnumerable<>)(object)array, text, (byte)num3 != 0, text3, (AK.Wwise.Event)num3, (AK.Wwise.Event)num3, (CancellationToken)num3).FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001063")]
		[Cpp2IlInjected.Address(RVA = "0xE1AF70", Offset = "0xE19970", VA = "0x180E1AF70")]
		public ImportAvatarCodeMenu()
		{
		}
	}
}
