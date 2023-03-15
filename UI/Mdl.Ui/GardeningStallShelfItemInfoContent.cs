using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AK.Wwise;
using Cpp2IlInjected;
using Definitions.Activities;
using Definitions.Items;
using Definitions.Shops;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameloft.Common;
using Google.Protobuf.Collections;
using Mdl.Buildings;
using Mdl.InputSystem;
using Mdl.Systems;
using Mdl.Utils;
using Meta;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20002B1")]
	[RequiredAllNotNull]
	public class GardeningStallShelfItemInfoContent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000C35")]
		[SerializeField]
		private RectTransform _mcAnimatedContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000C36")]
		[SerializeField]
		private RectTransform _mcCostContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000C37")]
		[SerializeField]
		private ButtonTmProIcon _btnBuy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000C38")]
		[SerializeField]
		private ButtonTmPro _btnCancel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000C39")]
		[SerializeField]
		private BaseButton _btnAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000C3A")]
		[SerializeField]
		private BaseButton _btnSubtract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000C3B")]
		[SerializeField]
		private TextBase _tfItemTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000C3C")]
		[SerializeField]
		private TextBase _tfSelectedAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000C3D")]
		[SerializeField]
		private TextBase _tfInventoryAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000C3E")]
		[SerializeField]
		private TextBase _tfBuyLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000C3F")]
		[SerializeField]
		private AK.Wwise.Event _purchaseSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000C40")]
		[SerializeField]
		private Switch _purchaseSuccededSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000C41")]
		[SerializeField]
		private AK.Wwise.Event _pickupSfx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000C42")]
		[SerializeField]
		private Switch _pickupFailSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000C43")]
		[SerializeField]
		private AK.Wwise.Event _hideSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000C45")]
		public Action OnBuyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000C46")]
		public Action OnBuyCancelled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000C47")]
		private InputAction _inputActionIncrement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000C48")]
		private InputAction _inputActionDecrement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000C49")]
		private InputAction _inputActionIncrementDpad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000C4A")]
		private InputAction _inputActionDecrementDpad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000C4B")]
		[SerializeField]
		[Header("Hold config")]
		private float _holdDurationBeforePress = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000C4C")]
		[SerializeField]
		private float _holdClickRepetitionInterval = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000C4D")]
		[SerializeField]
		private float _holdClickFastRepetitionInterval = 0.07f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000C4E")]
		private int _repetitionAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000C4F")]
		private float _buttonHeldDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000C50")]
		private bool _subtractButtonPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
		[Cpp2IlInjected.Token(Token = "0x4000C51")]
		private bool _addButtonPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDE")]
		[Cpp2IlInjected.Token(Token = "0x4000C52")]
		private bool _justPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000C53")]
		[SerializeField]
		[Header("Buy Btn config")]
		private CanvasGroup _buyBgCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000C54")]
		[SerializeField]
		private CanvasGroup _buyFgCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000C55")]
		[SerializeField]
		private SpriteAtlasImage _buyBgImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000C56")]
		private Menu _menu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000C57")]
		private ShoppingStall _stall;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000C58")]
		private GameObject _shelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000C59")]
		private Item _item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000C5A")]
		private Item _currencyItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000C5B")]
		private Action _close;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000C5C")]
		private int _selectedAmount = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000C5D")]
		private int _maxAmount = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000C5E")]
		private int _price;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000C5F")]
		private Profile _profile;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000C60")]
		private Item _currentScene;

		[Cpp2IlInjected.Token(Token = "0x17000305")]
		public BaseButton AddButton
		{
			[Cpp2IlInjected.Token(Token = "0x60010EA")]
			[Cpp2IlInjected.Address(RVA = "0x5C2240", Offset = "0x5C0C40", VA = "0x1805C2240")]
			get
			{
				return _btnAdd;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000306")]
		public BaseButton SubtractButton
		{
			[Cpp2IlInjected.Token(Token = "0x60010EB")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			get
			{
				return _btnSubtract;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000307")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x90"), Cpp2IlInjected.Token(Token = "0x4000C44")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60010EC")]
			[Cpp2IlInjected.Address(RVA = "0x7DAEA0", Offset = "0x7D98A0", VA = "0x1807DAEA0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60010ED")]
			[Cpp2IlInjected.Address(RVA = "0x7DB470", Offset = "0x7D9E70", VA = "0x1807DB470")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		public ButtonTmProIcon BuyButton
		{
			[Cpp2IlInjected.Token(Token = "0x60010EE")]
			[Cpp2IlInjected.Address(RVA = "0x52C9C0", Offset = "0x52B3C0", VA = "0x18052C9C0")]
			get
			{
				return _btnBuy;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000309")]
		public Item Item
		{
			[Cpp2IlInjected.Token(Token = "0x60010EF")]
			[Cpp2IlInjected.Address(RVA = "0xE4DF60", Offset = "0xE4C960", VA = "0x180E4DF60")]
			get
			{
				return _item;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030A")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x13C"), Cpp2IlInjected.Token(Token = "0x4000C61")]
		public bool NotEnoughCurrency
		{
			[Cpp2IlInjected.Token(Token = "0x60010F0")]
			[Cpp2IlInjected.Address(RVA = "0xE4DF70", Offset = "0xE4C970", VA = "0x180E4DF70")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60010F1")]
			[Cpp2IlInjected.Address(RVA = "0xE4E110", Offset = "0xE4CB10", VA = "0x180E4E110")]
			private set;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F2")]
		[Cpp2IlInjected.Address(RVA = "0xE4BF40", Offset = "0xE4A940", VA = "0x180E4BF40")]
		private void Awake()
		{
			//Discarded unreachable code: IL_00d1
			Button.ButtonClickedEvent onClick = _btnBuy.ButtonComponent.m_OnClick;
			UnityAction call = onBuyClickHandler;
			onClick.AddListener(call);
			BaseButton btnAdd = _btnAdd;
			BaseButton.OnBaseButtonPress value = OnAddPressedHandler;
			btnAdd.OnPress += value;
			BaseButton btnAdd2 = _btnAdd;
			BaseButton.OnBaseButtonRelease value2 = OnAddReleasedHandler;
			btnAdd2.OnRelease += value2;
			BaseButton btnSubtract = _btnSubtract;
			BaseButton.OnBaseButtonPress value3 = OnSubtractPressedHandler;
			btnSubtract.OnPress += value3;
			BaseButton btnSubtract2 = _btnSubtract;
			BaseButton.OnBaseButtonRelease value4 = OnSubtractReleasedHandler;
			btnSubtract2.OnRelease += value4;
			float num = (_buttonHeldDuration = _holdClickRepetitionInterval);
			Item item = (_currentScene = SystemRoot.Instance.Client.Profile.player_.CurrentScene);
		}

		[Cpp2IlInjected.Token(Token = "0x60010F3")]
		[Cpp2IlInjected.Address(RVA = "0xE4D0E0", Offset = "0xE4BAE0", VA = "0x180E4D0E0")]
		private void OnSubtractPressedHandler(BaseButton button)
		{
			float num = (_buttonHeldDuration = _holdDurationBeforePress);
			_subtractButtonPressed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F4")]
		[Cpp2IlInjected.Address(RVA = "0xE4D100", Offset = "0xE4BB00", VA = "0x180E4D100")]
		private void OnSubtractReleasedHandler(BaseButton button)
		{
			_subtractButtonPressed = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F5")]
		[Cpp2IlInjected.Address(RVA = "0xE4CEC0", Offset = "0xE4B8C0", VA = "0x180E4CEC0")]
		private void OnAddPressedHandler(BaseButton button)
		{
			float num = (_buttonHeldDuration = _holdDurationBeforePress);
			_addButtonPressed = true;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F6")]
		[Cpp2IlInjected.Address(RVA = "0xE4CEE0", Offset = "0xE4B8E0", VA = "0x180E4CEE0")]
		private void OnAddReleasedHandler(BaseButton button)
		{
			_addButtonPressed = false;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F7")]
		[Cpp2IlInjected.Address(RVA = "0xE4CEF0", Offset = "0xE4B8F0", VA = "0x180E4CEF0")]
		private void OnDestroy()
		{
			//Discarded unreachable code: IL_009e
			Button.ButtonClickedEvent onClick = _btnBuy.ButtonComponent.m_OnClick;
			UnityAction call = onBuyClickHandler;
			onClick.RemoveListener(call);
			BaseButton btnAdd = _btnAdd;
			BaseButton.OnBaseButtonPress value = OnAddPressedHandler;
			btnAdd.OnPress -= value;
			BaseButton btnAdd2 = _btnAdd;
			BaseButton.OnBaseButtonRelease value2 = OnAddReleasedHandler;
			btnAdd2.OnRelease -= value2;
			BaseButton btnSubtract = _btnSubtract;
			BaseButton.OnBaseButtonPress value3 = OnSubtractPressedHandler;
			btnSubtract.OnPress -= value3;
			BaseButton btnSubtract2 = _btnSubtract;
			BaseButton.OnBaseButtonRelease value4 = OnSubtractReleasedHandler;
			btnSubtract2.OnRelease -= value4;
		}

		[Cpp2IlInjected.Token(Token = "0x60010F8")]
		[Cpp2IlInjected.Address(RVA = "0xE4D9A0", Offset = "0xE4C3A0", VA = "0x180E4D9A0")]
		private void Update()
		{
			//Discarded unreachable code: IL_0318
			//IL_00fa: Expected I4, but got I8
			//IL_01b1: Invalid comparison between I4 and F4
			while (IsVisible)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				InputAction[] array = new InputAction[4];
				InputAction inputActionIncrement = _inputActionIncrement;
				if (inputActionIncrement != null && array == null)
				{
					continue;
				}
				array[0] = inputActionIncrement;
				InputAction inputActionDecrement = _inputActionDecrement;
				if (inputActionDecrement != null && array == null)
				{
					continue;
				}
				array[1] = inputActionDecrement;
				InputAction inputActionIncrementDpad = _inputActionIncrementDpad;
				if (inputActionIncrementDpad != null && array == null)
				{
					continue;
				}
				array[2] = inputActionIncrementDpad;
				InputAction inputActionDecrementDpad = _inputActionDecrementDpad;
				if (inputActionDecrementDpad != null && array == null)
				{
					continue;
				}
				array[3] = inputActionDecrementDpad;
				InputAction.UpdateAll(deltaTime, array);
				bool subtractButtonPressed = _subtractButtonPressed;
				if (!subtractButtonPressed && _addButtonPressed == subtractButtonPressed && _inputActionIncrement.IsTriggered == subtractButtonPressed && _inputActionDecrement.IsTriggered == subtractButtonPressed && _inputActionIncrementDpad.IsTriggered == subtractButtonPressed && _inputActionDecrementDpad.IsTriggered == subtractButtonPressed)
				{
					_justPressed = subtractButtonPressed;
					if (_repetitionAmount > 0)
					{
						_repetitionAmount = 0;
					}
					float holdDurationBeforePress = _holdDurationBeforePress;
					if (_repetitionAmount == 0)
					{
						break;
					}
					_buttonHeldDuration = holdDurationBeforePress;
				}
				if (_repetitionAmount > 0)
				{
					int selectedAmount = _selectedAmount;
					if ((selectedAmount == _maxAmount && (_addButtonPressed || _inputActionIncrement.IsTriggered || _inputActionIncrementDpad.IsTriggered)) || (selectedAmount == 1 && (subtractButtonPressed || _inputActionDecrement.IsTriggered != subtractButtonPressed || _inputActionDecrementDpad.IsTriggered != subtractButtonPressed)))
					{
						break;
					}
				}
				float buttonHeldDuration = _buttonHeldDuration;
				int num2 = 0;
				float deltaTime2 = Time.deltaTime;
				int num3 = 0;
				_buttonHeldDuration = buttonHeldDuration;
				if (!((float)num3 >= buttonHeldDuration))
				{
					if (_justPressed)
					{
						break;
					}
					float holdDurationBeforePress2 = _holdDurationBeforePress;
					if (_justPressed)
					{
						_buttonHeldDuration = holdDurationBeforePress2;
					}
					_justPressed = true;
					if (!_subtractButtonPressed && !_inputActionDecrement.IsTriggered && !_inputActionDecrementDpad.IsTriggered)
					{
						if ((!_addButtonPressed && !_inputActionIncrement.IsTriggered && !_inputActionIncrementDpad.IsTriggered) || _maxAmount == 1)
						{
							break;
						}
						int selectedAmount2 = _selectedAmount;
					}
					int maxAmount = _maxAmount;
					if (maxAmount == 1)
					{
						break;
					}
					int selectedAmount3 = _selectedAmount;
					int selectedAmount4 = selectedAmount3 - 1;
					if (selectedAmount3 == 1)
					{
						selectedAmount4 = maxAmount;
					}
					_selectedAmount = selectedAmount4;
					RefreshAmount();
				}
				if (!_subtractButtonPressed && !_inputActionDecrement.IsTriggered && !_inputActionDecrementDpad.IsTriggered)
				{
					if ((!_addButtonPressed && !_inputActionIncrement.IsTriggered && !_inputActionIncrementDpad.IsTriggered) || _maxAmount == 1)
					{
						goto IL_0307;
					}
					int selectedAmount5 = _selectedAmount;
				}
				int maxAmount2 = _maxAmount;
				if (maxAmount2 != 1)
				{
					int selectedAmount6 = _selectedAmount;
					int selectedAmount7 = selectedAmount6 - 1;
					if (selectedAmount6 == 1)
					{
						selectedAmount7 = maxAmount2;
					}
					_selectedAmount = selectedAmount7;
					RefreshAmount();
				}
				goto IL_0307;
				IL_0307:
				float num4 = (_buttonHeldDuration = _holdClickRepetitionInterval);
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010F9")]
		[Cpp2IlInjected.Address(RVA = "0xE4D690", Offset = "0xE4C090", VA = "0x180E4D690")]
		public void Show(float delay = 0f)
		{
			//Discarded unreachable code: IL_011e
			//IL_0051: Expected O, but got I4
			//IL_0074: Expected O, but got I4
			//IL_0096: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			RectTransform mcAnimatedContent = _mcAnimatedContent;
			IsVisible = true;
			mcAnimatedContent.gameObject.SetActive(value: true);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ((TweenerCore<Vector3, Vector3, VectorOptions>)(object)ShortcutExtensions.DOScale((Transform)_mcAnimatedContent, 1f, 0.35f)).SetEase(Ease.OutBack).SetDelay(delay);
			InputTriggerDown trigger = new InputTriggerDown();
			int num = default(int);
			InputActionBool inputActionIncrement = new InputActionBool("[LStick Right]", trigger, (InputProvider)num);
			int num2 = 0;
			num = 0;
			_inputActionIncrement = inputActionIncrement;
			InputTriggerDown trigger2 = new InputTriggerDown();
			int num3 = default(int);
			InputActionBool inputActionDecrement = new InputActionBool("[LStick Left]", trigger2, (InputProvider)num3);
			num3 = 0;
			_inputActionDecrement = inputActionDecrement;
			InputTriggerDown trigger3 = new InputTriggerDown();
			int num4 = default(int);
			InputActionBool inputActionIncrementDpad = new InputActionBool("[DPad Right]", trigger3, (InputProvider)num4);
			num4 = 0;
			_inputActionIncrementDpad = inputActionIncrementDpad;
			InputTriggerDown trigger4 = new InputTriggerDown();
			int num5 = default(int);
			InputActionBool inputActionDecrementDpad = new InputActionBool("[DPad Left]", trigger4, (InputProvider)num5);
			num5 = 0;
			_inputActionDecrementDpad = inputActionDecrementDpad;
			int num6 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			bool flag = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			ButtonTmPro btnCancel = _btnCancel;
			if (!flag)
			{
				btnCancel.gameObject.SetActive(value: true);
				return;
			}
			GameObject gameObject = btnCancel.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			_btnAdd.GetComponentInChildren<ShortcutIndicator>().TransformToPreset();
		}

		[Cpp2IlInjected.Token(Token = "0x60010FA")]
		[Cpp2IlInjected.Address(RVA = "0xE4C360", Offset = "0xE4AD60", VA = "0x180E4C360")]
		public void Hide()
		{
			//Discarded unreachable code: IL_0035
			AK.Wwise.Event hideSFX = _hideSFX;
			IsVisible = false;
			GameObject gameObject = base.gameObject;
			uint num = hideSFX.Post(gameObject);
			GameObject gameObject2 = _mcAnimatedContent.gameObject;
			int active = 0;
			gameObject2.SetActive((byte)active != 0);
		}

		[Cpp2IlInjected.Token(Token = "0x60010FB")]
		[Cpp2IlInjected.Address(RVA = "0xE4D110", Offset = "0xE4BB10", VA = "0x180E4D110")]
		private void RefreshAmount()
		{
			//Discarded unreachable code: IL_0112
			BaseButton btnSubtract = _btnSubtract;
			if (_maxAmount != 1)
			{
				btnSubtract.gameObject.SetActive(value: true);
				_btnAdd.gameObject.SetActive(value: true);
				TextBase tfSelectedAmount = _tfSelectedAmount;
			}
			GameObject gameObject = btnSubtract.gameObject;
			int active = 0;
			gameObject.SetActive((byte)active != 0);
			GameObject gameObject2 = _btnAdd.gameObject;
			int active2 = 0;
			gameObject2.SetActive((byte)active2 != 0);
			_tfSelectedAmount.Text = "1";
			Definitions.Shops.Shop definition = _stall.GetShop().Definition;
			ButtonTmProIcon btnBuy = _btnBuy;
			if (!definition.isDispenser_)
			{
				string text = default(string);
				btnBuy.Label.Text = text;
				Profile profile = (_profile = SystemRoot.Instance.Client.Profile);
				ProfilePlayer player_ = _profile.player_;
				Item currencyItem = _currencyItem;
				int genericCurrencyOnly = 0;
				int currencyAmount = player_.GetCurrencyAmount(currencyItem, (byte)genericCurrencyOnly != 0);
				bool flag = (NotEnoughCurrency = _selectedAmount > currencyAmount);
				RefreshBuyButton();
			}
			int selectedAmount = _selectedAmount;
			LayoutRebuilder.ForceRebuildLayoutImmediate(_btnBuy.AnimatedContent);
		}

		[Cpp2IlInjected.Token(Token = "0x60010FC")]
		[Cpp2IlInjected.Address(RVA = "0xE4C3D0", Offset = "0xE4ADD0", VA = "0x180E4C3D0")]
		private void IncrementAmount()
		{
			if (_maxAmount != 1)
			{
				int selectedAmount = _selectedAmount;
				_selectedAmount = 1;
				RefreshAmount();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010FD")]
		[Cpp2IlInjected.Address(RVA = "0xE4C330", Offset = "0xE4AD30", VA = "0x180E4C330")]
		private void DecrementAmount()
		{
			int maxAmount = _maxAmount;
			if (maxAmount != 1)
			{
				int selectedAmount = _selectedAmount;
				int selectedAmount2 = selectedAmount - 1;
				if (selectedAmount == 1)
				{
					selectedAmount2 = maxAmount;
				}
				_selectedAmount = selectedAmount2;
				RefreshAmount();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60010FE")]
		[Cpp2IlInjected.Address(RVA = "0xE4C410", Offset = "0xE4AE10", VA = "0x180E4C410")]
		public unsafe void Init(Menu menu, ShoppingStall stall, GameObject shelf, Item item, Action close)
		{
			//IL_0014: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			//IL_0079: Expected I4, but got I8
			//IL_015b: Expected O, but got I4
			//IL_0207: Expected I4, but got I8
			//IL_0253: Expected I4, but got I8
			//IL_0253: Expected F8, but got I4
			//IL_028a: Expected O, but got I4
			Item item2 = (Item)0;
			_menu = menu;
			_stall = stall;
			GameObject gameObject = (_shelf = shelf);
			Item item3 = item2;
			_close = (Action)0;
			_item = item3;
			Meta.Shop shop = stall.GetShop();
			if (shop != null)
			{
				Definitions.Shops.Shop definition = shop.Definition;
			}
			bool itemsRestricted = shop != null;
			_selectedAmount = 1;
			ItemDatabase _003CInstance_003Ek__BackingField = ItemDatabase.Instance;
			Item item4 = item2;
			if (_003CInstance_003Ek__BackingField.GetItemData(item4) != null)
			{
				ItemDatabase _003CInstance_003Ek__BackingField2 = ItemDatabase.Instance;
			}
			TextBase tfItemTitle = _tfItemTitle;
			RepeatedField<ContainerInventory.Types.Slot> inventory_ = SystemRoot.Instance.Client.Profile.Backpack.inventory_;
			Func<ContainerInventory.Types.Slot, bool> func = (Func<ContainerInventory.Types.Slot, bool>)(object)(Func<T, TResult>)delegate(ContainerInventory.Types.Slot x)
			{
				int num7 = 0;
				if ((itemsRestricted ? 1 : 0) != num7)
				{
					ItemState state_ = x.state_;
					if (state_ != null)
					{
						Item? sceneRestrictionItem = (Item?)state_.get_SceneRestrictionItem();
					}
					Item currentScene = _currentScene;
					if (num7 == 0 || !(*(Item*)num7 == *(Item*)currentScene))
					{
						int num8 = 0;
					}
				}
				int itemID2 = x.ItemID;
				throw new NullReferenceException();
			};
			IEnumerable<ContainerInventory.Types.Slot> enumerable = (IEnumerable<ContainerInventory.Types.Slot>)Enumerable.Where<ContainerInventory.Types.Slot>((IEnumerable<>)(object)inventory_, (Func<, >)(object)func);
			Func<ContainerInventory.Types.Slot, int> func2 = default(Func<ContainerInventory.Types.Slot, int>);
			if (_003C_003Ec._003C_003E9__71_1 == null)
			{
				func2 = (Func<ContainerInventory.Types.Slot, int>)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((ContainerInventory.Types.Slot x) => x.amount_));
			}
			int num = Enumerable.Sum<ContainerInventory.Types.Slot>((IEnumerable<>)enumerable, (Func<, >)(object)func2);
			string text = default(string);
			_tfInventoryAmount.Text = text;
			ShopData shopData = stall.GetShopData(shop);
			List<GameObject> shelves = stall.Shelves;
			Predicate<GameObject> predicate = (Predicate<GameObject>)(object)(Predicate<T>)delegate(GameObject x)
			{
				GameObject gameObject3 = shelf;
				return x == gameObject3;
			};
			int index = ((List<T>)(object)shelves).FindIndex((Predicate<>)(object)predicate);
			int currencyId_ = ((Definitions.Shops.ShopSlot)((RepeatedField<T>)(object)shop.Definition.slots_)[index]).currencyId_;
			_currencyItem = (Item)currencyId_;
			ItemDatabase _003CInstance_003Ek__BackingField3 = ItemDatabase.Instance;
			Item currencyItem = _currencyItem;
			IItemData itemData = _003CInstance_003Ek__BackingField3.GetItemData<IItemData>(currencyItem);
			Definitions.Activities.ShopSlot shopSlot = (Definitions.Activities.ShopSlot)((RepeatedField<T>)(object)shopData.slots_)[index];
			if (!shopSlot.IsEmpty)
			{
				if (((Definitions.Shops.ShopSlot)((RepeatedField<T>)(object)shop.Definition.slots_)[index]).HasLimit)
				{
					int amount_ = shopSlot.item_.amount_;
					index = ((Definitions.Shops.ShopSlot)((RepeatedField<T>)(object)shop.Definition.slots_)[index]).LimitAmount;
				}
				uint maxAmount = default(uint);
				_maxAmount = (int)maxAmount;
				int num2 = (_price = 0);
				if ((shop.Definition.isDispenser_ ? 1 : 0) == num2)
				{
					ulong num3 = default(ulong);
					_mcCostContent.gameObject.SetActive((byte)num3 != 0);
					AsyncAtlassedIcon currencyIcon = _btnBuy._currencyIcon;
					int itemID = shopSlot.item_.Item.ItemID;
					Item currencyItem2 = _currencyItem;
					bool flag = default(bool);
					if (!flag)
					{
						goto IL_02e5;
					}
					TextBase label = _btnBuy.Label;
					uint maxDigits = default(uint);
					uint num4 = default(uint);
					ulong num5 = default(ulong);
					string text3 = (label.Text = TextUtilities.FormatNumber(itemID, (int)maxDigits, (int)num4, (int)num4, (byte)num5 != 0));
					_mcCostContent.RebuildLayout();
					TextBase tfBuyLabel = _tfBuyLabel;
				}
				AsyncAtlassedIcon currencyIcon2 = _btnBuy._currencyIcon;
				int num6 = 0;
				bool flag2 = currencyIcon2.SetIcon((string)num6);
				_btnBuy.Label.StringID = "menu.stall_dispenser_free";
				_mcCostContent.RebuildLayout();
				GameObject gameObject2 = _mcCostContent.gameObject;
				int active = 0;
				gameObject2.SetActive((byte)active != 0);
				_tfBuyLabel.StringID = "menu.button_common_collect";
				LayoutRebuilder.ForceRebuildLayoutImmediate(_btnBuy.GetComponent<RectTransform>());
				goto IL_02e5;
			}
			Action close2 = _close;
			while (close2 == null)
			{
			}
			close2();
			throw new NullReferenceException();
			IL_02e5:
			RefreshAmount();
		}

		[Cpp2IlInjected.Token(Token = "0x60010FF")]
		[Cpp2IlInjected.Address(RVA = "0xE4D460", Offset = "0xE4BE60", VA = "0x180E4D460")]
		public void RefreshBuyButton()
		{
			//Discarded unreachable code: IL_010f
			//IL_010e: Expected O, but got I4
			CanvasGroup buyBgCanvasGroup = _buyBgCanvasGroup;
			if (NotEnoughCurrency)
			{
			}
			buyBgCanvasGroup.alpha = 1f;
			CanvasGroup buyFgCanvasGroup = _buyFgCanvasGroup;
			if (NotEnoughCurrency)
			{
			}
			buyFgCanvasGroup.alpha = 0.5f;
			Image image = _buyBgImage.Image;
			if (NotEnoughCurrency)
			{
				int num = 0;
				UIGameColors gameColors = UiRoot.Instance._gameColors;
			}
			Color white = Color.white;
			ButtonTmProIcon btnBuy = _btnBuy;
			bool flag2 = (btnBuy.IsActive = !NotEnoughCurrency);
			Selectable selectable = _btnBuy.Selectable;
			bool flag4 = (selectable.interactable = !NotEnoughCurrency);
			ButtonTmProIcon btnBuy2 = _btnBuy;
			bool flag5 = (btnBuy2.UseHighlightOnMouseHover = !NotEnoughCurrency);
			FocusNavigationElement component = _btnBuy.GetComponent<FocusNavigationElement>();
			bool ignoreThis = NotEnoughCurrency;
			int num2 = 0;
			component.IgnoreThis = ignoreThis;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				FocusNavigation focusNavigation = _menu.MenuNavigation.FocusNavigation;
				int num3 = 0;
				focusNavigation.SetFocus((FocusNavigationElement)num3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001100")]
		[Cpp2IlInjected.Address(RVA = "0xE4DF80", Offset = "0xE4C980", VA = "0x180E4DF80")]
		private void onBuyClickHandler()
		{
			//Discarded unreachable code: IL_001c
			CancellationToken cancellationToken = _menu.CancellationToken;
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> asyncTask = default(Task<>);
			asyncTask.FireAndForgetTask();
		}

		[Cpp2IlInjected.Token(Token = "0x6001101")]
		[Cpp2IlInjected.Address(RVA = "0xE4C200", Offset = "0xE4AC00", VA = "0x180E4C200")]
		[AsyncStateMachine(typeof(_003CBuyTask_003Ed__74))]
		public Task<ShopBuyItem.Types.Response> BuyTask(bool buyMissingSoftCurrencyWithHardCurrency, CancellationToken ct)
		{
			int num = 0;
			AsyncTaskMethodBuilder<> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
			Task<> result = default(Task<>);
			return (Task<ShopBuyItem.Types.Response>)(object)result;
		}

		[Cpp2IlInjected.Token(Token = "0x6001102")]
		[Cpp2IlInjected.Address(RVA = "0xE4DF20", Offset = "0xE4C920", VA = "0x180E4DF20")]
		public GardeningStallShelfItemInfoContent()
		{
		}//IL_002a: Expected I4, but got I8
		//IL_0033: Expected I4, but got I8

	}
}
