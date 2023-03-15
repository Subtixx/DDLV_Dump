using System;
using Cpp2IlInjected;
using Mdl.Platform;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x20001F7")]
	[RequireComponent(typeof(FocusNavigationElementInputText))]
	[RequireComponent(typeof(InputTextBase))]
	public class MenuInputField : TemplateButton
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000890")]
		[SerializeField]
		[Header("Menu Input Field")]
		private TemplateButton _resetButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000891")]
		[SerializeField]
		private Button _virtualKeyboardButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000892")]
		[SerializeField]
		private GameObject _highlight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000893")]
		public string ResetText = "";

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000894")]
		private InputTextBase _inputTextBase;

		[Cpp2IlInjected.Token(Token = "0x4000895")]
		public static InputTextBase _inputTextBaseLast;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000896")]
		private FocusNavigationElementInputText _focusNavigationElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000897")]
		private float _emptyRightMargin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000898")]
		private float _avoidResetButtonRightMargin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000899")]
		private bool _controllerConnected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400089A")]
		protected Callback<GamepadTextInputDismissed_t> m_GamepadTextInputDismissed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400089B")]
		protected Callback<FloatingGamepadTextInputDismissed_t> m_FloatingGamepadTextInputDismissed;

		[Cpp2IlInjected.Token(Token = "0x6000C9C")]
		[Cpp2IlInjected.Address(RVA = "0x118E120", Offset = "0x118CB20", VA = "0x18118E120")]
		private void Awake()
		{
			//Discarded unreachable code: IL_00a9
			//IL_0072: Expected F4, but got O
			InputTextBase inputTextBase = (_inputTextBase = GetComponent<InputTextBase>());
			FocusNavigationElementInputText focusNavigationElementInputText = (_focusNavigationElement = GetComponent<FocusNavigationElementInputText>());
			TemplateButton resetButton = _resetButton;
			base.UseHighlightWhenSelected = true;
			base.IgnoreHighlightWhenSelected = true;
			RectTransform component = resetButton.GetComponent<RectTransform>();
			Transform transform = _resetButton.transform;
			int index = 0;
			RectTransform component2 = transform.GetChild(index).GetComponent<RectTransform>();
			Vector2 offsetMax = ((TMP_InputField)_inputTextBase).m_TextViewport.offsetMax;
			_emptyRightMargin = (float)offsetMax;
			Callback<GamepadTextInputDismissed_t> callback = (m_GamepadTextInputDismissed = (Callback<GamepadTextInputDismissed_t>)(object)Callback<T>.Create((Callback<>.DispatchDelegate)(object)new Callback<T>.DispatchDelegate(OnGamepadTextInputDismissed)));
			Callback<FloatingGamepadTextInputDismissed_t> callback2 = (m_FloatingGamepadTextInputDismissed = (Callback<FloatingGamepadTextInputDismissed_t>)(object)Callback<T>.Create((Callback<>.DispatchDelegate)(object)new Callback<T>.DispatchDelegate(OnFloatingGamepadTextInputDismissed)));
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9D")]
		[Cpp2IlInjected.Address(RVA = "0x118E830", Offset = "0x118D230", VA = "0x18118E830", Slot = "12")]
		protected override void OnEnable()
		{
			//Discarded unreachable code: IL_017b
			base.OnEnable();
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call = UpdateVisuals;
			onHighlighted.AddListener(call);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call2 = UpdateVisuals;
			onDehighlighted.AddListener(call2);
			UnityEvent onSelected = OnSelected;
			UnityAction call3 = UpdateVisuals;
			onSelected.AddListener(call3);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call4 = UpdateVisuals;
			onDeselected.AddListener(call4);
			int num = 0;
			if (!PlatformUtils.IsSteamDeck())
			{
				TMP_InputField.SelectionEvent onSelect = ((TMP_InputField)_inputTextBase).m_OnSelect;
				UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(SetSelected);
				((UnityEvent<T0>)(object)onSelect).AddListener((UnityAction<>)(object)unityAction);
				TMP_InputField.SelectionEvent onDeselect = ((TMP_InputField)_inputTextBase).m_OnDeselect;
				UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(SetDeselected);
				((UnityEvent<T0>)(object)onDeselect).AddListener((UnityAction<>)(object)unityAction2);
			}
			UnityEvent onClicked = OnClicked;
			UnityAction call5 = delegate
			{
				//Discarded unreachable code: IL_000c
				SetSelected("");
			};
			onClicked.AddListener(call5);
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_inputTextBase).m_OnValueChanged;
			UnityAction<string> unityAction3 = (UnityAction<string>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction3);
			if ((bool)_resetButton)
			{
				UnityEvent onClicked2 = _resetButton.OnClicked;
				UnityAction call6 = OnResetButtonClickedHandler;
				onClicked2.AddListener(call6);
			}
			if ((bool)_virtualKeyboardButton)
			{
				Button.ButtonClickedEvent onClick = _virtualKeyboardButton.m_OnClick;
				UnityAction call7 = OnVirtualKeyboardButtonClickHandler;
				onClick.AddListener(call7);
			}
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9E")]
		[Cpp2IlInjected.Address(RVA = "0x118E3F0", Offset = "0x118CDF0", VA = "0x18118E3F0", Slot = "13")]
		protected override void OnDisable()
		{
			//Discarded unreachable code: IL_017b
			UnityEvent onHighlighted = OnHighlighted;
			UnityAction call = UpdateVisuals;
			onHighlighted.RemoveListener(call);
			UnityEvent onDehighlighted = OnDehighlighted;
			UnityAction call2 = UpdateVisuals;
			onDehighlighted.RemoveListener(call2);
			UnityEvent onSelected = OnSelected;
			UnityAction call3 = UpdateVisuals;
			onSelected.RemoveListener(call3);
			UnityEvent onDeselected = OnDeselected;
			UnityAction call4 = UpdateVisuals;
			onDeselected.RemoveListener(call4);
			int num = 0;
			if (!PlatformUtils.IsSteamDeck())
			{
				TMP_InputField.SelectionEvent onSelect = ((TMP_InputField)_inputTextBase).m_OnSelect;
				UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(SetSelected);
				((UnityEvent<T0>)(object)onSelect).RemoveListener((UnityAction<>)(object)unityAction);
				TMP_InputField.SelectionEvent onDeselect = ((TMP_InputField)_inputTextBase).m_OnDeselect;
				UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(SetDeselected);
				((UnityEvent<T0>)(object)onDeselect).RemoveListener((UnityAction<>)(object)unityAction2);
			}
			UnityEvent onClicked = OnClicked;
			UnityAction call5 = delegate
			{
				//Discarded unreachable code: IL_000c
				SetSelected("");
			};
			onClicked.RemoveListener(call5);
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_inputTextBase).m_OnValueChanged;
			UnityAction<string> unityAction3 = (UnityAction<string>)(object)new UnityAction<T0>(OnValueChangedHandler);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction3);
			if ((bool)_resetButton)
			{
				UnityEvent onClicked2 = _resetButton.OnClicked;
				UnityAction call6 = OnResetButtonClickedHandler;
				onClicked2.RemoveListener(call6);
			}
			if ((bool)_virtualKeyboardButton)
			{
				Button.ButtonClickedEvent onClick = _virtualKeyboardButton.m_OnClick;
				UnityAction call7 = OnVirtualKeyboardButtonClickHandler;
				onClick.RemoveListener(call7);
			}
			base.OnDisable();
			UpdateVisuals();
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0x118F300", Offset = "0x118DD00", VA = "0x18118F300")]
		private void OnValueChangedHandler(string value)
		{
			//IL_0010: Expected O, but got I4
			//IL_006e: Expected F4, but got I4
			TemplateButton resetButton = _resetButton;
			int num = 0;
			if (resetButton != (UnityEngine.Object)num)
			{
				GameObject gameObject = _resetButton.gameObject;
				bool flag = value != "";
				int active = 0;
				if (flag)
				{
				}
				gameObject.SetActive((byte)active != 0);
				bool activeInHierarchy = _resetButton.gameObject.activeInHierarchy;
				InputTextBase inputTextBase = _inputTextBase;
				if (activeInHierarchy)
				{
					float renderedWidth = ((TMP_InputField)_inputTextBase).m_TextComponent.renderedWidth;
					InputTextBase inputTextBase2 = _inputTextBase;
					float avoidResetButtonRightMargin = _avoidResetButtonRightMargin;
					avoidResetButtonRightMargin = Mathf.Lerp(_emptyRightMargin, avoidResetButtonRightMargin, renderedWidth);
					throw new NullReferenceException();
				}
				RectTransform textViewport = ((TMP_InputField)inputTextBase).m_TextViewport;
				int num2 = 0;
				textViewport.SetRight(num2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA0")]
		[Cpp2IlInjected.Address(RVA = "0x118F220", Offset = "0x118DC20", VA = "0x18118F220")]
		private void OnResetButtonClickedHandler()
		{
			//Discarded unreachable code: IL_0060
			//IL_002a: Expected F4, but got I4
			//IL_0035: Expected F4, but got I4
			//IL_0053: Expected F4, but got I4
			//IL_005f: Expected F4, but got I4
			InputTextBase inputTextBase = _inputTextBase;
			string text = (inputTextBase.text = ResetText);
			RectTransform rectTransform = GetComponentInChildren<TMP_SelectionCaret>().rectTransform;
			int num = 0;
			rectTransform.SetLeft(num);
			int num2 = 0;
			rectTransform.SetRight(num2);
			RectTransform rectTransform2 = ((TMP_InputField)_inputTextBase).m_TextComponent.rectTransform;
			int num3 = 0;
			rectTransform2.SetLeft(num3);
			int num4 = 0;
			rectTransform2.SetRight(num4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA1")]
		[Cpp2IlInjected.Address(RVA = "0x118F510", Offset = "0x118DF10", VA = "0x18118F510")]
		private void OnVirtualKeyboardButtonClickHandler()
		{
			//Discarded unreachable code: IL_000c
			_inputTextBase.ActivateVirtualKeyboard();
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA2")]
		[Cpp2IlInjected.Address(RVA = "0x118F5D0", Offset = "0x118DFD0", VA = "0x18118F5D0")]
		private void SetSelected(string _)
		{
			//Discarded unreachable code: IL_00ad
			bool flag2 = (base.IsSelected = _inputTextBase.isActiveAndEnabled);
			int num = 0;
			if (PlatformUtils.IsSteamDeck())
			{
				_inputTextBaseLast = _inputTextBase;
			}
			int num2 = 0;
			UiRoot instance = UiRoot.Instance;
			int num3 = 0;
			int useKeyboardAsController = 0;
			bool controllerConnected = instance.IsControllerConnected((byte)useKeyboardAsController != 0);
			int num4 = 0;
			_controllerConnected = controllerConnected;
			if (!PlatformUtils.UseSteam())
			{
				return;
			}
			int num5 = 0;
			if (!SteamUtils.IsSteamInBigPictureMode())
			{
				int num6 = 0;
				if (PlatformUtils.IsSteamDeck())
				{
					int num7 = 0;
					int width = Screen.width;
					int num8 = 0;
					int height = Screen.height;
					if (SteamUtils.ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode.k_EFloatingGamepadTextInputModeModeSingleLine, width, num3, width, num3))
					{
						MonoBehaviour.print("Steam floating keyboard shown");
					}
				}
			}
			else
			{
				int num9 = 0;
				bool flag3 = default(bool);
				while (!flag3)
				{
				}
				MonoBehaviour.print("Steam keyboard shown");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA3")]
		[Cpp2IlInjected.Address(RVA = "0x118F7D0", Offset = "0x118E1D0", VA = "0x18118F7D0")]
		private void ShowSteamKeyboard()
		{
			//Discarded unreachable code: IL_006a
			bool flag = default(bool);
			string text;
			do
			{
				int num = 0;
				if (!SteamUtils.IsSteamInBigPictureMode())
				{
					int num2 = 0;
					if (PlatformUtils.IsSteamDeck())
					{
						int num3 = 0;
						int width = Screen.width;
						int num4 = 0;
						int height = Screen.height;
						int num5 = 0;
						if (flag)
						{
							MonoBehaviour.print("Steam floating keyboard shown");
						}
					}
					return;
				}
				text = ((TMP_InputField)_inputTextBase).m_Text;
			}
			while (!SteamUtils.ShowGamepadTextInput(EGamepadTextInputMode.k_EGamepadTextInputModeNormal, EGamepadTextInputLineMode.k_EGamepadTextInputLineModeMultipleLines, "Enter your text", 10000u, text));
			MonoBehaviour.print("Steam keyboard shown");
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA4")]
		[Cpp2IlInjected.Address(RVA = "0x118EDA0", Offset = "0x118D7A0", VA = "0x18118EDA0")]
		private void OnGamepadTextInputDismissed(GamepadTextInputDismissed_t pCallback)
		{
			//Discarded unreachable code: IL_00df
			//IL_00d4: Expected O, but got I4
			string[] array;
			string text = default(string);
			string text2 = default(string);
			string text3 = default(string);
			while (true)
			{
				array = new string[6];
				if ("Steam [" != null && "Steam [" == null)
				{
					continue;
				}
				array[0] = "Steam [";
				if (text != null && text == null)
				{
					continue;
				}
				array[1] = text;
				if (" - GamepadTextInputDismissed] - " != null && " - GamepadTextInputDismissed] - " == null)
				{
					continue;
				}
				array[2] = " - GamepadTextInputDismissed] - ";
				if (text2 != null && text2 == null)
				{
					continue;
				}
				array[3] = text2;
				if (" -- " == null || " -- " != null)
				{
					array[4] = " -- ";
					if (text3 == null || text3 != null)
					{
						break;
					}
				}
			}
			array[5] = text3;
			Debug.Log(string.Concat(array));
			int num = 0;
			uint enteredGamepadTextLength = SteamUtils.GetEnteredGamepadTextLength();
			string text4 = default(string);
			Debug.Log("Steam SteamUtils.GetEnteredGamepadTextLength() - " + text4);
			string message = default(string);
			Debug.Log(message);
			InputTextBase inputTextBaseLast = _inputTextBaseLast;
			int num2 = 0;
			if (inputTextBaseLast != (UnityEngine.Object)num2)
			{
				InputTextBase inputTextBaseLast2 = _inputTextBaseLast;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA5")]
		[Cpp2IlInjected.Address(RVA = "0x118EC70", Offset = "0x118D670", VA = "0x18118EC70")]
		private void OnFloatingGamepadTextInputDismissed(FloatingGamepadTextInputDismissed_t pCallback)
		{
			//Discarded unreachable code: IL_006c
			string text = default(string);
			Debug.Log("Steam [" + text + " - FloatingGamepadTextInputDismissed]");
			int num = ((base.IsSelected = false) ? 1 : 0);
			int num2 = 0;
			if (PlatformUtils.IsSteamDeck())
			{
				_inputTextBase.ReleaseSelection();
				InputTextBase inputTextBase = _inputTextBase;
				int clearSelection = 0;
				inputTextBase.DeactivateInputField((byte)clearSelection != 0);
			}
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num4 = ((base.IsHighlighted = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA6")]
		[Cpp2IlInjected.Address(RVA = "0x118F540", Offset = "0x118DF40", VA = "0x18118F540")]
		private void SetDeselected(string _)
		{
			//Discarded unreachable code: IL_0054
			int num = ((base.IsSelected = false) ? 1 : 0);
			int num2 = 0;
			if (PlatformUtils.IsSteamDeck())
			{
				_inputTextBase.ReleaseSelection();
				InputTextBase inputTextBase = _inputTextBase;
				int clearSelection = 0;
				inputTextBase.DeactivateInputField((byte)clearSelection != 0);
			}
			int num3 = 0;
			UiRoot instance = UiRoot.Instance;
			int useKeyboardAsController = 0;
			if (instance.IsControllerConnected((byte)useKeyboardAsController != 0))
			{
				int num4 = ((base.IsHighlighted = false) ? 1 : 0);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA7")]
		[Cpp2IlInjected.Address(RVA = "0x118F9D0", Offset = "0x118E3D0", VA = "0x18118F9D0")]
		private void UpdateVisuals()
		{
			//Discarded unreachable code: IL_002b
			//IL_0010: Expected O, but got I4
			GameObject highlight = _highlight;
			int num = 0;
			if (highlight != (UnityEngine.Object)num)
			{
				GameObject highlight2 = _highlight;
				bool active = 1 != 0;
				highlight2.SetActive(active);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CA8")]
		[Cpp2IlInjected.Address(RVA = "0x118FA70", Offset = "0x118E470", VA = "0x18118FA70")]
		public MenuInputField()
		{
		}
	}
}
