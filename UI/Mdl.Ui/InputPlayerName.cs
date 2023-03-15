using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Cpp2IlInjected;
using Mdl.Platform;
using Mdl.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Mdl.Ui
{
	[Cpp2IlInjected.Token(Token = "0x200027C")]
	public class InputPlayerName : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200027D")]
		public delegate void NameChanged(string newName, bool isValid);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000B46")]
		[SerializeField]
		private InputTextBase _tfInput;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000B47")]
		[Nulllable]
		private GameObject _mcLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000B48")]
		[Nulllable]
		private Button _btnReset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000B49")]
		[SerializeField]
		private int _maxCharacterNumber = 12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000B4C")]
		private bool _isFirstTimeInputLetter = true;

		[Cpp2IlInjected.Token(Token = "0x170002F0")]
		public InputTextBase TfInput
		{
			[Cpp2IlInjected.Token(Token = "0x6000FCC")]
			[Cpp2IlInjected.Address(RVA = "0x52C4F0", Offset = "0x52AEF0", VA = "0x18052C4F0")]
			get
			{
				return _tfInput;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F1")]
		public string InputName
		{
			[Cpp2IlInjected.Token(Token = "0x6000FCF")]
			[Cpp2IlInjected.Address(RVA = "0xD23660", Offset = "0xD22060", VA = "0x180D23660")]
			get
			{
				//Discarded unreachable code: IL_000c
				return ((TMP_InputField)_tfInput).m_Text;
			}
			[Cpp2IlInjected.Token(Token = "0x6000FD0")]
			[Cpp2IlInjected.Address(RVA = "0xD23720", Offset = "0xD22120", VA = "0x180D23720")]
			set
			{
				//Discarded unreachable code: IL_000d
				_tfInput.text = value;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F2")]
		public string ResetName
		{
			[Cpp2IlInjected.Token(Token = "0x6000FD1")]
			[Cpp2IlInjected.Address(RVA = "0x724C10", Offset = "0x723610", VA = "0x180724C10")]
			[CompilerGenerated]
			get
			{
				return _003CResetName_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x6000FD2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4D0", Offset = "0x7D9ED0", VA = "0x1807DB4D0")]
			[CompilerGenerated]
			set
			{
				_003CResetName_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		} = "";


		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event NameChanged OnNameChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000FCD")]
			[Cpp2IlInjected.Address(RVA = "0xD235C0", Offset = "0xD21FC0", VA = "0x180D235C0")]
			[CompilerGenerated]
			add
			{
				NameChanged onNameChanged = this.OnNameChanged;
				Delegate @delegate = Delegate.Combine(onNameChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onNameChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
			[Cpp2IlInjected.Token(Token = "0x6000FCE")]
			[Cpp2IlInjected.Address(RVA = "0xD23680", Offset = "0xD22080", VA = "0x180D23680")]
			[CompilerGenerated]
			remove
			{
				NameChanged onNameChanged = this.OnNameChanged;
				Delegate @delegate = Delegate.Remove(onNameChanged, value);
				if ((object)@delegate == null || (object)@delegate != null)
				{
					while ((object)@delegate != onNameChanged)
					{
					}
					return;
				}
				throw new InvalidCastException();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD3")]
		[Cpp2IlInjected.Address(RVA = "0xD22B80", Offset = "0xD21580", VA = "0x180D22B80")]
		private void Awake()
		{
			//Discarded unreachable code: IL_0050
			_tfInput.contentType = TMP_InputField.ContentType.Name;
			_tfInput.characterValidation = TMP_InputField.CharacterValidation.CustomValidator;
			CustomValidator customValidator = new CustomValidator();
			int num = 0;
			bool flag = (customValidator.DoNotAddCharacterToText = Application.platform == RuntimePlatform.Switch);
			_tfInput.inputValidator = customValidator;
			OnInputTextChanged("");
			_isFirstTimeInputLetter = true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD4")]
		[Cpp2IlInjected.Address(RVA = "0xD23350", Offset = "0xD21D50", VA = "0x180D23350")]
		public void Start()
		{
			//Discarded unreachable code: IL_0092
			//IL_0030: Expected O, but got I4
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_tfInput).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnInputTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
			Button btnReset = _btnReset;
			int num = 0;
			if (btnReset != (UnityEngine.Object)num)
			{
				Button.ButtonClickedEvent onClick = _btnReset.m_OnClick;
				UnityAction call = OnResetClickedHandler;
				onClick.AddListener(call);
			}
			InputTextBase tfInput = _tfInput;
			int num2 = (tfInput.characterLimit = _maxCharacterNumber);
			int num3 = 0;
			PlatformInterfaceManager instance = PlatformInterfaceManager.Instance;
			if (instance.UsernameProvider != null && instance == null)
			{
				InputTextBase tfInput2 = _tfInput;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD5")]
		[Cpp2IlInjected.Address(RVA = "0xD22E10", Offset = "0xD21810", VA = "0x180D22E10")]
		protected void OnDestroy()
		{
			//Discarded unreachable code: IL_0058
			//IL_0030: Expected O, but got I4
			TMP_InputField.OnChangeEvent onValueChanged = ((TMP_InputField)_tfInput).m_OnValueChanged;
			UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(OnInputTextChanged);
			((UnityEvent<T0>)(object)onValueChanged).RemoveListener((UnityAction<>)(object)unityAction);
			Button btnReset = _btnReset;
			int num = 0;
			if (btnReset != (UnityEngine.Object)num)
			{
				Button.ButtonClickedEvent onClick = _btnReset.m_OnClick;
				UnityAction call = OnResetClickedHandler;
				onClick.RemoveListener(call);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD6")]
		[Cpp2IlInjected.Address(RVA = "0xD23310", Offset = "0xD21D10", VA = "0x180D23310")]
		public void SetName(string name)
		{
			_tfInput.text = name;
			ResetName = name;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD7")]
		[Cpp2IlInjected.Address(RVA = "0xD22C80", Offset = "0xD21680", VA = "0x180D22C80")]
		public void EnableInput(bool enable)
		{
			//Discarded unreachable code: IL_000d
			_tfInput.enabled = enable;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD8")]
		[Cpp2IlInjected.Address(RVA = "0xD22C50", Offset = "0xD21650", VA = "0x180D22C50")]
		public void DisableInput()
		{
			//Discarded unreachable code: IL_0011
			InputTextBase tfInput = _tfInput;
			int num = ((tfInput.enabled = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x6000FD9")]
		[Cpp2IlInjected.Address(RVA = "0xD22CA0", Offset = "0xD216A0", VA = "0x180D22CA0")]
		private bool FilterProfanity()
		{
			//Discarded unreachable code: IL_004f
			//IL_004a: Expected O, but got I4
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (PlatformInterfaceManager.Instance.ProfanityFilterer != null && !string.IsNullOrEmpty(((TMP_InputField)_tfInput).m_Text))
			{
				InputTextBase tfInput = _tfInput;
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					num++;
				}
				if ((object)tfInput != null)
				{
					_tfInput.text = (string)num;
				}
			}
			return num2 == 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FDA")]
		[Cpp2IlInjected.Address(RVA = "0xD22F70", Offset = "0xD21970", VA = "0x180D22F70")]
		public void OnInputTextChanged(string arg)
		{
			//Discarded unreachable code: IL_0153
			//IL_0090: Expected O, but got I4
			//IL_00cc: Expected O, but got I4
			InputTextBase tfInput = _tfInput;
			string text = ((TMP_InputField)tfInput).m_Text;
			int num = 0;
			if (text != null)
			{
			}
			int maxCharacterNumber = _maxCharacterNumber;
			if (num == 1)
			{
				if ((_isFirstTimeInputLetter ? 1 : 0) == num)
				{
					goto IL_0096;
				}
				_isFirstTimeInputLetter = (byte)num != 0;
				string text3 = (tfInput.text = ((TMP_InputField)tfInput).m_Text.ToUpper());
			}
			bool flag = default(bool);
			if (num > 2)
			{
				int num2 = 0;
				if (PlatformInterfaceManager.Instance.ProfanityFilterer != null && !string.IsNullOrEmpty(((TMP_InputField)_tfInput).m_Text))
				{
					InputTextBase tfInput2 = _tfInput;
					uint num3 = default(uint);
					if (num < (int)num3)
					{
						num += num;
						num++;
					}
					if (num != 0)
					{
						_tfInput.text = (string)num;
					}
				}
				flag = num == 0;
			}
			goto IL_0096;
			IL_0096:
			GameObject mcLabel = _mcLabel;
			if ((object)mcLabel != null)
			{
				string text4 = ((TMP_InputField)_tfInput).m_Text;
				mcLabel.SetActive((byte)num != 0);
			}
			Button btnReset = _btnReset;
			int num4 = 0;
			bool flag2 = default(bool);
			if (btnReset != (UnityEngine.Object)num4)
			{
				GameObject gameObject = _btnReset.gameObject;
				flag2 = num > 0;
				gameObject.SetActive(flag2);
			}
			NameChanged onNameChanged = this.OnNameChanged;
			if (onNameChanged != null)
			{
				string text5 = ((TMP_InputField)_tfInput).m_Text;
				int num5 = default(int);
				if (!flag)
				{
					num5 = 0;
					flag2 = (byte)((flag2 ? 1u : 0u) + (flag2 ? 1u : 0u)) != 0;
					num5 += 312;
				}
				string text6 = ResetName;
				if (num5 != 0)
				{
				}
				string text7 = ((TMP_InputField)_tfInput).m_Text;
				bool isValid = ResetName != text7;
				onNameChanged(text5, isValid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000FDB")]
		[Cpp2IlInjected.Address(RVA = "0xD232C0", Offset = "0xD21CC0", VA = "0x180D232C0")]
		private void OnResetClickedHandler()
		{
			//Discarded unreachable code: IL_0022
			InputTextBase tfInput = _tfInput;
			string text2 = (tfInput.text = ResetName);
			bool dtdValidation = ((System.Xml.IDtdParserAdapterWithValidation)_tfInput).DtdValidation;
		}

		[Cpp2IlInjected.Token(Token = "0x6000FDC")]
		[Cpp2IlInjected.Address(RVA = "0xD23560", Offset = "0xD21F60", VA = "0x180D23560")]
		public InputPlayerName()
		{
		}//IL_000a: Expected I4, but got I8

	}
}
