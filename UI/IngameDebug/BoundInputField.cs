using System;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public class BoundInputField : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public delegate bool OnValueChangedDelegate(BoundInputField source, string input);

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private bool initialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private bool inputValid = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private bool inputAltered;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private InputField inputField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private Image inputFieldBackground;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public string DefaultEmptyValue = string.Empty;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public bool CacheTextOnValueChange = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private string recentText = string.Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private int m_skinVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private UISkin m_skin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public OnValueChangedDelegate OnValueChanged;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public OnValueChangedDelegate OnValueSubmitted;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public InputField BackingField
		{
			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x52C9B0", Offset = "0x52B3B0", VA = "0x18052C9B0")]
			get
			{
				return inputField;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA634F0", Offset = "0xA61EF0", VA = "0x180A634F0")]
			get
			{
				//Discarded unreachable code: IL_000c
				return inputField.m_Text;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xA63750", Offset = "0xA62150", VA = "0x180A63750")]
			set
			{
				//Discarded unreachable code: IL_0042
				recentText = value;
				InputField inputField = this.inputField;
				if (!inputField.m_AllowInput)
				{
					inputValid = true;
					inputField.text = value;
					UISkin skin = m_skin;
					Image image = inputFieldBackground;
					Color color = (image.color = skin.m_inputFieldNormalBackgroundColor);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public UISkin Skin
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x5706C0", Offset = "0x56F0C0", VA = "0x1805706C0")]
			get
			{
				return m_skin;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xA63510", Offset = "0xA61F10", VA = "0x180A63510")]
			set
			{
				//Discarded unreachable code: IL_0077
				//IL_0073: Expected O, but got I4
				bool flag = default(bool);
				if (flag || m_skinVersion != (flag ? 1 : 0))
				{
					Initialize();
					m_skin = value;
					InputField inputField = this.inputField;
					int num = (m_skinVersion = value.m_version);
					inputField.m_TextComponent.SetSkinInputFieldText(value);
					Image image = inputFieldBackground;
					Color color = (image.color = value.m_inputFieldNormalBackgroundColor);
					Graphic placeholder = this.inputField.m_Placeholder;
					if ((object)placeholder == null)
					{
					}
					int num2 = 0;
					int num3 = 0;
					if (!(placeholder != (UnityEngine.Object)num3))
					{
					}
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xA63110", Offset = "0xA61B10", VA = "0x180A63110")]
		private void Awake()
		{
			Initialize();
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xA63120", Offset = "0xA61B20", VA = "0x180A63120")]
		public void Initialize()
		{
			//Discarded unreachable code: IL_0071
			if (!initialized)
			{
				InputField inputField = (this.inputField = GetComponent<InputField>());
				Image image = (inputFieldBackground = GetComponent<Image>());
				InputField.OnChangeEvent onValueChanged = this.inputField.m_OnValueChanged;
				UnityAction<string> unityAction = (UnityAction<string>)(object)new UnityAction<T0>(InputFieldValueChanged);
				((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
				InputField.SubmitEvent onEndEdit = this.inputField.m_OnEndEdit;
				UnityAction<string> unityAction2 = (UnityAction<string>)(object)new UnityAction<T0>(InputFieldValueSubmitted);
				((UnityEvent<T0>)(object)onEndEdit).AddListener((UnityAction<>)(object)unityAction2);
				initialized = true;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xA632B0", Offset = "0xA61CB0", VA = "0x180A632B0")]
		private void InputFieldValueChanged(string str)
		{
			//Discarded unreachable code: IL_0080
			if (!inputField.m_AllowInput)
			{
				return;
			}
			inputAltered = true;
			if (str == null || str.m_stringLength == 0)
			{
			}
			OnValueChangedDelegate onValueChanged = OnValueChanged;
			if (onValueChanged != null)
			{
				bool flag = default(bool);
				if ((inputValid = onValueChanged(this, str)) && CacheTextOnValueChange)
				{
					recentText = str;
					flag = inputValid;
				}
				Image image = inputFieldBackground;
				UISkin skin = m_skin;
				if (flag)
				{
				}
				Color color = (image.color = skin.m_inputFieldInvalidBackgroundColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA63390", Offset = "0xA61D90", VA = "0x180A63390")]
		private void InputFieldValueSubmitted(string str)
		{
			//Discarded unreachable code: IL_0091
			UISkin skin = m_skin;
			Image image = inputFieldBackground;
			Color color = (image.color = skin.m_inputFieldNormalBackgroundColor);
			if (inputAltered)
			{
				inputAltered = false;
				if (str == null || str.m_stringLength == 0)
				{
				}
				OnValueChangedDelegate onValueSubmitted = OnValueSubmitted;
				if (onValueSubmitted == null)
				{
				}
				if (onValueSubmitted(this, str))
				{
					recentText = str;
				}
				InputField inputField = this.inputField;
				string text2 = (inputField.text = recentText);
				inputValid = true;
			}
			else
			{
				InputField inputField2 = this.inputField;
				string text4 = (inputField2.text = recentText);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA63470", Offset = "0xA61E70", VA = "0x180A63470")]
		public BoundInputField()
		{
		}
	}
}
