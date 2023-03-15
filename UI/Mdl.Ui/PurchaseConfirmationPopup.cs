using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Definitions.Items;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Localization.Core;
using Mdl.InputSystem;
using Mdl.Navigation;
using Mdl.Systems;
using UnityEngine;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000505")]
	public class PurchaseConfirmationPopup : Menu, IHasRedirectionHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4001B12")]
		[SerializeField]
		private TextBase _desc;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4001B13")]
		[SerializeField]
		private ButtonTmPro _btnConfirm;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001B14")]
		[SerializeField]
		private CanvasGroup _confirmBgRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4001B15")]
		[SerializeField]
		private Image _confirmLeftBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4001B16")]
		[SerializeField]
		private Image _confirmRightBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4001B17")]
		[SerializeField]
		private ButtonTmPro _btnCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4001B18")]
		[SerializeField]
		private RectTransform _confirmButtonCurrencyHolder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4001B19")]
		[SerializeField]
		private TextBase _price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4001B1A")]
		[SerializeField]
		private RectTransform _content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4001B1B")]
		[SerializeField]
		private RectTransform _mcButtonContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4001B1C")]
		private Item _selectedItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4001B1D")]
		private IItemData _currencyItemData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4001B1E")]
		private int _currencyAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4001B1F")]
		private bool _notEnoughCurrency;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4001B20")]
		private InputAction _back;

		[Cpp2IlInjected.Token(Token = "0x17000522")]
		private Localizator _localizator
		{
			[Cpp2IlInjected.Token(Token = "0x60020AE")]
			[Cpp2IlInjected.Address(RVA = "0xE205B0", Offset = "0xE1EFB0", VA = "0x180E205B0")]
			get
			{
				//Discarded unreachable code: IL_0010
				return SystemRoot.Instance._localizationManager.Localizator;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020AF")]
		[Cpp2IlInjected.Address(RVA = "0xE1F9E0", Offset = "0xE1E3E0", VA = "0x180E1F9E0", Slot = "25")]
		public override void OnPush(MenuStack stack, [Optional] MenuParam param)
		{
			//Discarded unreachable code: IL_006b, IL_0094, IL_00c6, IL_00d8, IL_00f9, IL_0120, IL_0128, IL_016a
			//IL_00de: Expected O, but got I4
			//IL_0135: Expected O, but got I4
			//IL_015c: Expected O, but got I4
			int num = 0;
			base.OnPush(stack, param);
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				object[] @params = menuParam.Params;
				int length = @params.Length;
				object obj = @params[0];
				if (obj != null && obj != null)
				{
					object obj2 = (_selectedItem = (Item)obj);
				}
				Item selectedItem = _selectedItem;
				Dictionary<string, object> dictionary = (Dictionary<string, object>)(object)new Dictionary<TKey, TValue>();
				Localizator _003CLocalizator_003Ek__BackingField = SystemRoot.Instance._localizationManager.Localizator;
				throw new NullReferenceException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020B0")]
		[Cpp2IlInjected.Address(RVA = "0xE1F540", Offset = "0xE1DF40", VA = "0x180E1F540", Slot = "35")]
		internal override void OnControllerChanged()
		{
			//Discarded unreachable code: IL_0041
			base.OnControllerChanged();
			int num = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				if (_notEnoughCurrency)
				{
				}
				FocusNavigationElement component = _btnConfirm.GetComponent<FocusNavigationElement>();
				base.MenuNavigation.FocusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020B1")]
		[Cpp2IlInjected.Address(RVA = "0xE20390", Offset = "0xE1ED90", VA = "0x180E20390")]
		private void SetFocus()
		{
			//Discarded unreachable code: IL_0027
			if (_notEnoughCurrency)
			{
			}
			FocusNavigationElement component = _btnConfirm.GetComponent<FocusNavigationElement>();
			base.MenuNavigation.FocusNavigation.SetFocus(component);
		}

		[Cpp2IlInjected.Token(Token = "0x60020B2")]
		[Cpp2IlInjected.Address(RVA = "0xE1F600", Offset = "0xE1E000", VA = "0x180E1F600", Slot = "27")]
		public override void OnFocusIn()
		{
			//Discarded unreachable code: IL_00f2
			base.OnFocusIn();
			_confirmButtonCurrencyHolder.gameObject.SetActive(value: true);
			int num = 0;
			string text = default(string);
			_price.Text = text;
			LayoutRebuilder.ForceRebuildLayoutImmediate(_confirmButtonCurrencyHolder);
			Vector2 sizeDelta = _confirmButtonCurrencyHolder.sizeDelta;
			Transform transform = _btnConfirm.transform;
			Vector2 vector = default(Vector2);
			if (sizeDelta > vector)
			{
				Transform transform2 = _btnConfirm.transform;
				Vector2 sizeDelta2 = _confirmButtonCurrencyHolder.sizeDelta;
				Transform transform3 = _btnConfirm.transform;
				LayoutRebuilder.ForceRebuildLayoutImmediate(_mcButtonContent);
			}
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = default(bool);
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0) && !flag)
			{
				PlayerNavigation playerNavigation = default(PlayerNavigation);
				PlayerNavigation.TemporaryOverrideScope temporaryOverrideScope = (_overrideAllScope = playerNavigation.OverrideAllScope());
			}
			base.IsDataUpToDate = true;
			RectTransform content = _content;
			float z = Vector3.zero.z;
			RectTransform content2 = _content;
			float z2 = Vector3.one.z;
			TweenerCore<Vector3, Vector3, VectorOptions> t = default(TweenerCore<Vector3, Vector3, VectorOptions>);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = t.SetEase(Ease.OutBack);
			RefreshBuyButton();
		}

		[Cpp2IlInjected.Token(Token = "0x60020B3")]
		[Cpp2IlInjected.Address(RVA = "0xE20420", Offset = "0xE1EE20", VA = "0x180E20420")]
		private void Update()
		{
			//Discarded unreachable code: IL_0082
			//IL_007b: Expected O, but got I4
			float deltaTime;
			InputAction[] array;
			InputAction back;
			do
			{
				int num = 0;
				deltaTime = Time.deltaTime;
				array = new InputAction[1];
				back = _back;
			}
			while (back != null && array == null);
			array[0] = back;
			InputAction.UpdateAll(deltaTime, array);
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || !_back.IsTriggered)
			{
				return;
			}
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				Action<int> answerAction = menuParam.AnswerAction;
				if (answerAction != null)
				{
					int num3 = 0;
					answerAction((T)num3);
				}
			}
			PopSelf();
		}

		[Cpp2IlInjected.Token(Token = "0x60020B4")]
		[Cpp2IlInjected.Address(RVA = "0xE20020", Offset = "0xE1EA20", VA = "0x180E20020", Slot = "29")]
		[IteratorStateMachine(typeof(_003CPreFocusOut_003Ed__22))]
		public override IEnumerator PreFocusOut(bool popAfterPreFocusOut = false)
		{
			int _003C_003E1__state = default(int);
			_003CPreFocusOut_003Ed__22 _003CPreFocusOut_003Ed__ = new _003CPreFocusOut_003Ed__22(_003C_003E1__state);
			_003C_003E1__state = 0;
			_003CPreFocusOut_003Ed__._003C_003E4__this = this;
			_003CPreFocusOut_003Ed__.popAfterPreFocusOut = popAfterPreFocusOut;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60020B5")]
		[Cpp2IlInjected.Address(RVA = "0xE1F4D0", Offset = "0xE1DED0", VA = "0x180E1F4D0")]
		public void OnConfirmClickHandler()
		{
			//IL_001d: Expected O, but got I4
			((Action<T>)(object)_menuParam?.AnswerAction)?.Invoke((T)1);
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60020B6")]
		[Cpp2IlInjected.Address(RVA = "0xE1F460", Offset = "0xE1DE60", VA = "0x180E1F460")]
		public void OnCancelClickHandler()
		{
			//IL_001f: Expected O, but got I4
			MenuParam menuParam = _menuParam;
			if (menuParam != null)
			{
				Action<int> answerAction = menuParam.AnswerAction;
				if (answerAction != null)
				{
					int num = 0;
					answerAction((T)num);
				}
			}
			IExtenderProvider[] extenderProviders = ((IExtenderListService)this).GetExtenderProviders();
		}

		[Cpp2IlInjected.Token(Token = "0x60020B7")]
		[Cpp2IlInjected.Address(RVA = "0xE1F390", Offset = "0xE1DD90", VA = "0x180E1F390", Slot = "38")]
		public void HandleRedirection(RedirectionType redirectionType, [Optional] MenuParam menuParam)
		{
			//Discarded unreachable code: IL_002d
			if (redirectionType == (RedirectionType)1)
			{
				Button buttonComponent = _btnCancel.ButtonComponent;
				_btnCancel.ButtonComponent.m_OnClick?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60020B8")]
		[Cpp2IlInjected.Address(RVA = "0xE200A0", Offset = "0xE1EAA0", VA = "0x180E200A0")]
		private void RefreshBuyButton()
		{
			//Discarded unreachable code: IL_011d
			//IL_001d: Expected O, but got I4
			//IL_004d: Expected O, but got I4
			//IL_0064: Expected O, but got I4
			_price.ColorKey = UIGameColors.GameColorName.OffWhite;
			CanvasGroup confirmBgRoot = _confirmBgRoot;
			int num = 0;
			if (confirmBgRoot != (UnityEngine.Object)num)
			{
				CanvasGroup confirmBgRoot2 = _confirmBgRoot;
				if (_notEnoughCurrency)
				{
				}
				confirmBgRoot2.alpha = 1f;
			}
			Image confirmLeftBackground = _confirmLeftBackground;
			int num2 = 0;
			if (confirmLeftBackground != (UnityEngine.Object)num2)
			{
				Image confirmRightBackground = _confirmRightBackground;
				int num3 = 0;
				if (confirmRightBackground != (UnityEngine.Object)num3)
				{
					Image confirmLeftBackground2 = _confirmLeftBackground;
					int num4 = 0;
					if ((_notEnoughCurrency ? 1 : 0) != num4)
					{
						UIGameColors gameColors = UiRoot.Instance._gameColors;
					}
					UIGameColors gameColors2 = UiRoot.Instance._gameColors;
					Image confirmRightBackground2 = _confirmRightBackground;
					int num5 = 0;
					if ((_notEnoughCurrency ? 1 : 0) != num5)
					{
						UIGameColors gameColors3 = UiRoot.Instance._gameColors;
					}
					UIGameColors gameColors4 = UiRoot.Instance._gameColors;
				}
			}
			ButtonTmPro btnConfirm = _btnConfirm;
			bool flag2 = (btnConfirm.IsActive = !_notEnoughCurrency);
			Selectable selectable = _btnConfirm.Selectable;
			bool flag4 = (selectable.interactable = !_notEnoughCurrency);
			FocusNavigationElement component = _btnConfirm.GetComponent<FocusNavigationElement>();
			bool flag5 = (component.IgnoreThis = _notEnoughCurrency);
		}

		[Cpp2IlInjected.Token(Token = "0x60020B9")]
		[Cpp2IlInjected.Address(RVA = "0x856980", Offset = "0x855380", VA = "0x180856980")]
		public PurchaseConfirmationPopup()
		{
		}
	}
}
