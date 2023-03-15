using System;
using Cpp2IlInjected;
using Mdl.InputSystem;
using UnityEngine;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x2000356")]
	public class ItemAmountSelector : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000357")]
		public enum AssociatedMenuEnum
		{
			[Cpp2IlInjected.Token(Token = "0x4001014")]
			Backpack,
			[Cpp2IlInjected.Token(Token = "0x4001015")]
			Storage,
			[Cpp2IlInjected.Token(Token = "0x4001016")]
			Other
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000FF2")]
		[SerializeField]
		private TextBase _countLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000FF3")]
		[SerializeField]
		private AsyncAtlassedIcon _itemIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000FF4")]
		[SerializeField]
		[Header("Disable/Enable config")]
		private BaseButton _btnValidation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000FF5")]
		[SerializeField]
		private BaseButton _btnAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000FF6")]
		[SerializeField]
		private CanvasGroup _btnAddIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000FF7")]
		[SerializeField]
		private BaseButton _btnSubtract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000FF8")]
		[SerializeField]
		private CanvasGroup _btnSubtractIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000FF9")]
		[SerializeField]
		private CanvasGroup _priceCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000FFA")]
		[SerializeField]
		private float _disabledPriceOpacity = 0.8f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000FFB")]
		[SerializeField]
		private CanvasGroup _interactableCanvasGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000FFC")]
		[SerializeField]
		private GameObject _disabledMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000FFD")]
		[SerializeField]
		private bool _hideBtnValidationOnGamepad = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000FFE")]
		public Action ValueChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000FFF")]
		private bool _validateOnDisable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4001000")]
		private bool _hideOnValidate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4001001")]
		private int _min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4001002")]
		private int? _max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4001003")]
		private int? _amount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4001004")]
		private Action<int?> _validate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4001005")]
		private bool _isDisabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4001006")]
		[Header("Hold config")]
		protected InputAction _inputActionIncrementStick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4001007")]
		protected InputAction _inputActionDecrementStick;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4001008")]
		protected InputAction _inputActionIncrementDpad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4001009")]
		protected InputAction _inputActionDecrementDpad;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400100A")]
		[SerializeField]
		private float _holdDurationBeforePress = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400100B")]
		[SerializeField]
		private float _holdClickRepetitionInterval = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400100C")]
		[SerializeField]
		private float _holdClickFastRepetitionInterval = 0.07f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400100D")]
		private int _repetitionAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400100E")]
		private float _buttonHeldDuration = 0.5f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400100F")]
		private bool _subtractButtonPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDD")]
		[Cpp2IlInjected.Token(Token = "0x4001010")]
		private bool _addButtonPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDE")]
		[Cpp2IlInjected.Token(Token = "0x4001011")]
		private bool _justPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4001012")]
		public AssociatedMenuEnum AssociatedMenu = AssociatedMenuEnum.Other;

		[Cpp2IlInjected.Token(Token = "0x170003B1")]
		public unsafe int? Amount
		{
			[Cpp2IlInjected.Token(Token = "0x6001540")]
			[Cpp2IlInjected.Address(RVA = "0x88B0C0", Offset = "0x889AC0", VA = "0x18088B0C0")]
			get
			{
				return _amount;
			}
			[Cpp2IlInjected.Token(Token = "0x6001541")]
			[Cpp2IlInjected.Address(RVA = "0xD33F80", Offset = "0xD32980", VA = "0x180D33F80")]
			set
			{
				//Discarded unreachable code: IL_009b
				_amount = value;
				int? max = _max;
				BaseButton btnSubtract = _btnSubtract;
				if ((IntPtr)(((long)max == 1) ? 1 : 0) == (IntPtr)(void*)max)
				{
					btnSubtract.gameObject.SetActive(value: true);
					_btnAdd.gameObject.SetActive(value: true);
					int? amount = _amount;
					TextBase countLabel = _countLabel;
				}
				GameObject gameObject = btnSubtract.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _btnAdd.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				_countLabel.Text = "1";
				ValueChanged?.Invoke();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001542")]
		[Cpp2IlInjected.Address(RVA = "0xD32E00", Offset = "0xD31800", VA = "0x180D32E00")]
		public unsafe void Init(string iconTexture, int defaultValue, int min, int? max, Action<int?> validate, bool hideOnValidate = true, bool validateOnDisable = true)
		{
			//IL_0015: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_002c: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			//IL_00fa: Expected O, but got I4
			//IL_011c: Expected O, but got I4
			//IL_013e: Expected O, but got I4
			//IL_0160: Expected O, but got I4
			//IL_0181: Expected O, but got I4
			//IL_019d: Expected O, but got I4
			//IL_01ce: Expected F4, but got I4
			_validateOnDisable = false;
			_hideOnValidate = false;
			_max = (int?)(object)0;
			_min = min;
			_validate = (Action<int?>)0;
			int num = 0;
			this.set_Amount((Nullable<>)num);
			AsyncAtlassedIcon itemIcon = _itemIcon;
			int num2 = 0;
			if (itemIcon != (UnityEngine.Object)num2)
			{
				bool flag = _itemIcon.SetIcon(iconTexture);
			}
			int? max2 = _max;
			if ((IntPtr)(((object)max2 == null) ? 1 : 0) == (IntPtr)(void*)max2)
			{
				EnableButtons();
			}
			DisableButtons();
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
			InputTriggerDown trigger = new InputTriggerDown();
			int num3 = default(int);
			InputActionBool inputActionIncrementStick = new InputActionBool("[LStick Right]", trigger, (InputProvider)num3);
			num3 = 0;
			_inputActionIncrementStick = inputActionIncrementStick;
			InputTriggerDown trigger2 = new InputTriggerDown();
			int num4 = default(int);
			InputActionBool inputActionDecrementStick = new InputActionBool("[LStick Left]", trigger2, (InputProvider)num4);
			num4 = 0;
			_inputActionDecrementStick = inputActionDecrementStick;
			InputTriggerDown trigger3 = new InputTriggerDown();
			int num5 = default(int);
			InputActionBool inputActionIncrementDpad = new InputActionBool("[DPad Right]", trigger3, (InputProvider)num5);
			num5 = 0;
			_inputActionIncrementDpad = inputActionIncrementDpad;
			InputTriggerDown trigger4 = new InputTriggerDown();
			int num6 = default(int);
			InputActionBool inputActionDecrementDpad = new InputActionBool("[DPad Left]", trigger4, (InputProvider)num6);
			num6 = 0;
			_inputActionDecrementDpad = inputActionDecrementDpad;
			BaseButton btnValidation = _btnValidation;
			int num7 = 0;
			if (!(btnValidation != (UnityEngine.Object)num7))
			{
				return;
			}
			CanvasGroup component = _btnValidation.GetComponent<CanvasGroup>();
			int num8 = 0;
			if (component != (UnityEngine.Object)num8)
			{
				int num9 = 0;
				UiRoot instance = UiRoot.Instance;
				int useKeyboardAsController = 0;
				if (!instance.IsControllerConnected((byte)useKeyboardAsController != 0) || (_hideBtnValidationOnGamepad ? 1 : 0) == num)
				{
					throw new NullReferenceException();
				}
				int num10 = 0;
				component.alpha = num10;
				int num11 = ((component.interactable = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001543")]
		[Cpp2IlInjected.Address(RVA = "0xD339E0", Offset = "0xD323E0", VA = "0x180D339E0")]
		private unsafe void Update()
		{
			//Discarded unreachable code: IL_02c7
			//IL_01d6: Invalid comparison between I4 and F4
			while (!_isDisabled)
			{
				int num = 0;
				float deltaTime = Time.deltaTime;
				InputAction[] array = new InputAction[4];
				InputAction inputActionIncrementStick = _inputActionIncrementStick;
				if (inputActionIncrementStick != null && array == null)
				{
					continue;
				}
				array[0] = inputActionIncrementStick;
				InputAction inputActionDecrementStick = _inputActionDecrementStick;
				if (inputActionDecrementStick != null && array == null)
				{
					continue;
				}
				array[1] = inputActionDecrementStick;
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
				if (!subtractButtonPressed && _addButtonPressed == subtractButtonPressed && _inputActionIncrementStick.IsTriggered == subtractButtonPressed && _inputActionDecrementStick.IsTriggered == subtractButtonPressed && _inputActionIncrementDpad.IsTriggered == subtractButtonPressed && _inputActionDecrementDpad.IsTriggered == subtractButtonPressed)
				{
					_justPressed = subtractButtonPressed;
					if (_repetitionAmount > 0)
					{
						int num2 = (_repetitionAmount = 0);
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
					int? amount = _amount;
					int num3 = 0;
					int? max = _max;
					bool flag = (object)amount == (object)max;
					if ((object)amount == (object)max != flag && ((_addButtonPressed ? 1 : 0) != num3 || (_inputActionIncrementStick.IsTriggered ? 1 : 0) != num3 || (_inputActionIncrementDpad.IsTriggered ? 1 : 0) != num3))
					{
						break;
					}
					bool flag2 = (long)amount == 1;
					if ((IntPtr)(void*)amount != (IntPtr)(flag2 ? 1 : 0) && (subtractButtonPressed || _inputActionDecrementStick.IsTriggered != subtractButtonPressed || _inputActionDecrementDpad.IsTriggered != subtractButtonPressed))
					{
						break;
					}
				}
				float buttonHeldDuration = _buttonHeldDuration;
				int num4 = 0;
				float deltaTime2 = Time.deltaTime;
				int num5 = 0;
				_buttonHeldDuration = buttonHeldDuration;
				if (!((float)num5 >= buttonHeldDuration))
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
					if (!_subtractButtonPressed && !_inputActionDecrementStick.IsTriggered && !_inputActionDecrementDpad.IsTriggered)
					{
						if (!_addButtonPressed && !_inputActionIncrementStick.IsTriggered && !_inputActionIncrementDpad.IsTriggered)
						{
							break;
						}
						IncrementAmount();
					}
					DecrementAmount();
				}
				if (!_subtractButtonPressed && !_inputActionDecrementStick.IsTriggered && !_inputActionDecrementDpad.IsTriggered)
				{
					if (!_addButtonPressed && !_inputActionIncrementStick.IsTriggered && !_inputActionIncrementDpad.IsTriggered)
					{
						goto IL_02b6;
					}
					IncrementAmount();
				}
				DecrementAmount();
				goto IL_02b6;
				IL_02b6:
				float num6 = (_buttonHeldDuration = _holdClickRepetitionInterval);
				break;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001544")]
		[Cpp2IlInjected.Address(RVA = "0xD33550", Offset = "0xD31F50", VA = "0x180D33550")]
		private void OnSubtractPressedHandler(BaseButton button)
		{
			if (!_isDisabled)
			{
				float num = (_buttonHeldDuration = _holdDurationBeforePress);
				_subtractButtonPressed = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001545")]
		[Cpp2IlInjected.Address(RVA = "0xD33570", Offset = "0xD31F70", VA = "0x180D33570")]
		private void OnSubtractReleasedHandler(BaseButton button)
		{
			//IL_0012: Expected I4, but got I8
			if (!_isDisabled)
			{
				_repetitionAmount = 0;
				_subtractButtonPressed = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001546")]
		[Cpp2IlInjected.Address(RVA = "0xD33340", Offset = "0xD31D40", VA = "0x180D33340")]
		private void OnAddPressedHandler(BaseButton button)
		{
			if (!_isDisabled)
			{
				float num = (_buttonHeldDuration = _holdDurationBeforePress);
				_addButtonPressed = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001547")]
		[Cpp2IlInjected.Address(RVA = "0xD33360", Offset = "0xD31D60", VA = "0x180D33360")]
		private void OnAddReleasedHandler(BaseButton button)
		{
			//IL_0012: Expected I4, but got I8
			if (!_isDisabled)
			{
				_repetitionAmount = 0;
				_addButtonPressed = false;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001548")]
		[Cpp2IlInjected.Address(RVA = "0xD33650", Offset = "0xD32050", VA = "0x180D33650")]
		private unsafe void RefreshAmount()
		{
			//Discarded unreachable code: IL_0086
			int? max = _max;
			BaseButton btnSubtract = _btnSubtract;
			if ((IntPtr)(((long)max == 1) ? 1 : 0) == (IntPtr)(void*)max)
			{
				btnSubtract.gameObject.SetActive(value: true);
				_btnAdd.gameObject.SetActive(value: true);
				int? amount = _amount;
				string text = default(string);
				_countLabel.Text = text;
			}
			else
			{
				GameObject gameObject = btnSubtract.gameObject;
				int active = 0;
				gameObject.SetActive((byte)active != 0);
				GameObject gameObject2 = _btnAdd.gameObject;
				int active2 = 0;
				gameObject2.SetActive((byte)active2 != 0);
				_countLabel.Text = "1";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001549")]
		[Cpp2IlInjected.Address(RVA = "0xD32D00", Offset = "0xD31700", VA = "0x180D32D00")]
		private unsafe void IncrementAmount()
		{
			//IL_003d: Expected O, but got I4
			//IL_0045: Expected O, but got I4
			if (_isDisabled)
			{
				return;
			}
			int? max = _max;
			int num = 0;
			bool flag = (long)max == 1;
			if ((IntPtr)(void*)max != (IntPtr)(flag ? 1 : 0))
			{
				return;
			}
			int? amount = _amount;
			bool flag2 = (object)amount == (object)max;
			if ((object)amount == (object)max == flag2)
			{
				if ((object)amount != null)
				{
				}
				this.set_Amount((Nullable<>)num);
			}
			else
			{
				this.set_Amount((Nullable<>)num);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600154A")]
		[Cpp2IlInjected.Address(RVA = "0xD32630", Offset = "0xD31030", VA = "0x180D32630")]
		private unsafe void DecrementAmount()
		{
			//IL_0038: Expected O, but got I4
			//IL_0040: Expected O, but got I4
			if (_isDisabled)
			{
				return;
			}
			int? max = _max;
			int num = 0;
			if ((IntPtr)(((long)max == 1) ? 1 : 0) == (IntPtr)(void*)max)
			{
				int? amount = _amount;
				bool flag = (long)amount == 1;
				if ((IntPtr)(void*)amount == (IntPtr)(flag ? 1 : 0) && (object)amount != null)
				{
					this.set_Amount((Nullable<>)num);
				}
				else
				{
					this.set_Amount((Nullable<>)num);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600154B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void OnPlusButtonClicked()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600154C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0640", Offset = "0x5BF040", VA = "0x1805C0640")]
		public void OnMinusButtonClicked()
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x600154D")]
		[Cpp2IlInjected.Address(RVA = "0xD33590", Offset = "0xD31F90", VA = "0x180D33590")]
		public void OnValidateClicked()
		{
			//Discarded unreachable code: IL_0055
			//IL_0034: Expected O, but got I8
			if (!_isDisabled)
			{
				Action<int?> validate = _validate;
				if (validate != null)
				{
					int? amount = _amount;
					validate((T)amount);
				}
				if (!_validateOnDisable)
				{
					_validate = (Action<int?>)0;
				}
				if (_hideOnValidate)
				{
					GameObject gameObject = base.gameObject;
					int active = 0;
					gameObject.SetActive((byte)active != 0);
				}
				RefreshSelectedSlot();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600154E")]
		[Cpp2IlInjected.Address(RVA = "0xD33380", Offset = "0xD31D80", VA = "0x180D33380")]
		private void OnDisable()
		{
			//Discarded unreachable code: IL_00a8
			//IL_0026: Expected O, but got I4
			//IL_002f: Expected O, but got I8
			if (_validateOnDisable && !_isDisabled)
			{
				Action<int?> validate = _validate;
				if (validate != null)
				{
					int num = 0;
					validate((T)num);
				}
				_validate = (Action<int?>)0;
			}
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

		[Cpp2IlInjected.Token(Token = "0x600154F")]
		[Cpp2IlInjected.Address(RVA = "0xD33930", Offset = "0xD32330", VA = "0x180D33930")]
		internal void SetFocus(FocusNavigation focusNavigation)
		{
			//Discarded unreachable code: IL_002b
			//IL_0010: Expected O, but got I4
			BaseButton btnValidation = _btnValidation;
			int num = 0;
			if (btnValidation != (UnityEngine.Object)num && (object)focusNavigation != null)
			{
				FocusNavigationElement component = _btnValidation.GetComponent<FocusNavigationElement>();
				focusNavigation.SetFocus(component);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001550")]
		[Cpp2IlInjected.Address(RVA = "0xD329E0", Offset = "0xD313E0", VA = "0x180D329E0")]
		public void EnableButtons()
		{
			//Discarded unreachable code: IL_0160
			//IL_0017: Expected O, but got I4
			//IL_003e: Expected O, but got I4
			//IL_0072: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			//IL_00b8: Expected O, but got I4
			//IL_00df: Expected O, but got I4
			//IL_0106: Expected O, but got I4
			//IL_012d: Expected O, but got I4
			//IL_0150: Expected O, but got I4
			GameObject disabledMessage = _disabledMessage;
			_isDisabled = false;
			int num = 0;
			if (disabledMessage != (UnityEngine.Object)num)
			{
				GameObject disabledMessage2 = _disabledMessage;
				int active = 0;
				disabledMessage2.SetActive((byte)active != 0);
			}
			BaseButton btnValidation = _btnValidation;
			int num2 = 0;
			if (btnValidation != (UnityEngine.Object)num2)
			{
				_btnValidation.IsActive = true;
				_btnValidation.GetComponent<FocusNavigationElement>().IgnoreThis = false;
			}
			BaseButton btnAdd = _btnAdd;
			int num3 = 0;
			if (btnAdd != (UnityEngine.Object)num3)
			{
				_btnAdd.IsActive = true;
			}
			BaseButton btnSubtract = _btnSubtract;
			int num4 = 0;
			if (btnSubtract != (UnityEngine.Object)num4)
			{
				_btnSubtract.IsActive = true;
			}
			CanvasGroup btnAddIcon = _btnAddIcon;
			int num5 = 0;
			if (btnAddIcon != (UnityEngine.Object)num5)
			{
				_btnAddIcon.alpha = 1f;
			}
			CanvasGroup btnSubtractIcon = _btnSubtractIcon;
			int num6 = 0;
			if (btnSubtractIcon != (UnityEngine.Object)num6)
			{
				_btnSubtractIcon.alpha = 1f;
			}
			CanvasGroup priceCanvasGroup = _priceCanvasGroup;
			int num7 = 0;
			if (priceCanvasGroup != (UnityEngine.Object)num7)
			{
				_priceCanvasGroup.alpha = 1f;
			}
			CanvasGroup interactableCanvasGroup = _interactableCanvasGroup;
			int num8 = 0;
			if (interactableCanvasGroup != (UnityEngine.Object)num8)
			{
				_interactableCanvasGroup.interactable = true;
			}
			CanvasGroup interactableCanvasGroup2 = _interactableCanvasGroup;
			int num9 = 0;
			if (interactableCanvasGroup2 != (UnityEngine.Object)num9)
			{
				_interactableCanvasGroup.blocksRaycasts = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001551")]
		[Cpp2IlInjected.Address(RVA = "0xD32700", Offset = "0xD31100", VA = "0x180D32700")]
		public void DisableButtons()
		{
			//Discarded unreachable code: IL_017a
			//IL_0029: Expected O, but got I4
			//IL_0063: Expected O, but got I4
			//IL_008e: Expected O, but got I4
			//IL_00b9: Expected O, but got I4
			//IL_00e0: Expected O, but got I4
			//IL_0107: Expected O, but got I4
			//IL_0137: Expected O, but got I4
			//IL_0162: Expected O, but got I4
			GameObject disabledMessage = _disabledMessage;
			_isDisabled = true;
			disabledMessage?.SetActive(value: true);
			BaseButton btnValidation = _btnValidation;
			int num = 0;
			if (btnValidation != (UnityEngine.Object)num)
			{
				_btnValidation.GetComponent<FocusNavigationElement>().IgnoreThis = true;
				BaseButton btnValidation2 = _btnValidation;
				int num2 = ((btnValidation2.IsActive = false) ? 1 : 0);
			}
			BaseButton btnAdd = _btnAdd;
			int num3 = 0;
			if (btnAdd != (UnityEngine.Object)num3)
			{
				BaseButton btnAdd2 = _btnAdd;
				int num4 = ((btnAdd2.IsActive = false) ? 1 : 0);
			}
			BaseButton btnSubtract = _btnSubtract;
			int num5 = 0;
			if (btnSubtract != (UnityEngine.Object)num5)
			{
				BaseButton btnSubtract2 = _btnSubtract;
				int num6 = ((btnSubtract2.IsActive = false) ? 1 : 0);
			}
			CanvasGroup btnAddIcon = _btnAddIcon;
			int num7 = 0;
			if (btnAddIcon != (UnityEngine.Object)num7)
			{
				_btnAddIcon.alpha = 0.5f;
			}
			CanvasGroup btnSubtractIcon = _btnSubtractIcon;
			int num8 = 0;
			if (btnSubtractIcon != (UnityEngine.Object)num8)
			{
				_btnSubtractIcon.alpha = 0.5f;
			}
			CanvasGroup priceCanvasGroup = _priceCanvasGroup;
			int num9 = 0;
			if (priceCanvasGroup != (UnityEngine.Object)num9)
			{
				CanvasGroup priceCanvasGroup2 = _priceCanvasGroup;
				float num10 = (priceCanvasGroup2.alpha = _disabledPriceOpacity);
			}
			BaseButton btnValidation3 = _btnValidation;
			int num11 = 0;
			if (btnValidation3 != (UnityEngine.Object)num11)
			{
				CanvasGroup interactableCanvasGroup = _interactableCanvasGroup;
				int num12 = ((interactableCanvasGroup.interactable = false) ? 1 : 0);
			}
			BaseButton btnValidation4 = _btnValidation;
			int num13 = 0;
			if (btnValidation4 != (UnityEngine.Object)num13)
			{
				CanvasGroup interactableCanvasGroup2 = _interactableCanvasGroup;
				int num14 = ((interactableCanvasGroup2.blocksRaycasts = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001552")]
		[Cpp2IlInjected.Address(RVA = "0xD337C0", Offset = "0xD321C0", VA = "0x180D337C0")]
		private void RefreshSelectedSlot()
		{
			//IL_002f: Expected O, but got I4
			//IL_003d: Expected O, but got I4
			int num = 0;
			StorageMenu menu = UiRoot.Instance._menuStack.GetMenu<StorageMenu>();
			int num2 = 0;
			InventoryMenu menu2 = UiRoot.Instance._menuStack.GetMenu<InventoryMenu>();
			int num3 = 0;
			if (!(menu != (UnityEngine.Object)num3))
			{
				int num4 = 0;
				if (menu2 != (UnityEngine.Object)num4 && AssociatedMenu == AssociatedMenuEnum.Backpack)
				{
					BackpackContent backpackContent = menu2.BackpackContent;
					int ignoreSelected = 0;
					backpackContent.RefreshAllSelectedState((byte)ignoreSelected != 0);
				}
				return;
			}
			AssociatedMenuEnum associatedMenu = AssociatedMenu;
			if (associatedMenu == AssociatedMenuEnum.Backpack)
			{
			}
			while (associatedMenu != AssociatedMenuEnum.Storage)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6001553")]
		[Cpp2IlInjected.Address(RVA = "0xD33F30", Offset = "0xD32930", VA = "0x180D33F30")]
		public ItemAmountSelector()
		{
		}//IL_0047: Expected I4, but got I8

	}
}
