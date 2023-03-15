using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class EnumField : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[SerializeField]
		private Image background;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		[SerializeField]
		private Image dropdownArrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		[SerializeField]
		private RectTransform templateTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		[SerializeField]
		private Image templateBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		[SerializeField]
		private Image templateCheckmark;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		[SerializeField]
		private Text templateText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		[SerializeField]
		private Dropdown input;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private static readonly Dictionary<Type, List<string>> enumNames = (Dictionary<Type, List<string>>)(object)new Dictionary<TKey, TValue>();

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private static readonly Dictionary<Type, List<object>> enumValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private List<string> currEnumNames;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private List<object> currEnumValues;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xF254E0", Offset = "0xF23EE0", VA = "0x180F254E0", Slot = "6")]
		public override void Initialize()
		{
			//Discarded unreachable code: IL_0027
			base.Initialize();
			Dropdown.DropdownEvent onValueChanged = input.m_OnValueChanged;
			UnityAction<int> unityAction = (UnityAction<int>)(object)new UnityAction<T0>(OnValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xF25D30", Offset = "0xF24730", VA = "0x180F25D30", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Guid gUID = type.GUID;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xF255B0", Offset = "0xF23FB0", VA = "0x180F255B0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			//Discarded unreachable code: IL_00b8, IL_00e5
			//IL_00e4: Expected O, but got I4
			base.OnBound(variable);
			Dictionary<Type, List<string>> dictionary = enumNames;
			bool flag = default(bool);
			if (flag)
			{
				Dictionary<Type, List<object>> dictionary2 = enumValues;
				bool flag2 = default(bool);
				if (flag2)
				{
					Dropdown dropdown = input;
					int num = 0;
					dropdown.ClearOptions();
					input.AddOptions((List<>)num);
					return;
				}
			}
			string[] names = Enum.GetNames(base.m_boundVariableType);
			Array values = Enum.GetValues(base.m_boundVariableType);
			int capacity = default(int);
			List<string> list = (List<string>)(object)new List<T>(capacity);
			capacity = names.Length;
			currEnumNames = list;
			int capacity2 = default(int);
			List<object> list2 = (List<object>)(object)new List<T>(capacity2);
			capacity2 = names.Length;
			currEnumValues = list2;
			int num2 = 0;
			int length = names.Length;
			if (num2 < length)
			{
				string text = names[num2];
				List<object> list3 = currEnumValues;
				object value = values.GetValue(num2);
				((List<T>)(object)list3).Add((T)value);
				num2++;
			}
			Dictionary<Type, List<string>> dictionary3 = enumNames;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xF25C20", Offset = "0xF24620", VA = "0x180F25C20")]
		private void OnValueChanged(int input)
		{
			throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xF25940", Offset = "0xF24340", VA = "0x180F25940", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_010a
			//IL_00fb: Expected O, but got I4
			base.OnSkinChanged();
			Vector2 sizeDelta = templateTransform.sizeDelta;
			UISkin skin = base.m_skin;
			templateTransform.sizeDelta = sizeDelta;
			UISkin skin2 = base.m_skin;
			Image image = background;
			Color color = (image.color = skin2.m_inputFieldNormalBackgroundColor);
			UISkin skin3 = base.m_skin;
			Image image2 = dropdownArrow;
			Color textColor = skin3.m_textColor;
			Dropdown dropdown = input;
			UISkin skin4 = base.m_skin;
			dropdown.m_CaptionText.SetSkinInputFieldText(skin4);
			UISkin skin5 = base.m_skin;
			templateText.SetSkinInputFieldText(skin5);
			UISkin skin6 = base.m_skin;
			Image image3 = templateBackground;
			Color inputFieldNormalBackgroundColor2 = skin6.m_inputFieldNormalBackgroundColor;
			UISkin skin7 = base.m_skin;
			Image image4 = templateCheckmark;
			Color color2 = (image4.color = skin7.m_toggleCheckmarkColor);
			UISkin skin8 = base.m_skin;
			Image image5 = variableNameMask;
			float labelWidthPercentage = skin8.m_labelWidthPercentage;
			int num = 0;
			RectTransform rectTransform = image5.rectTransform;
			int num2 = 0;
			rectTransform.anchorMin = (Vector2)num;
			if ((object)input.transform != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xF25CB0", Offset = "0xF246B0", VA = "0x180F25CB0", Slot = "14")]
		public override void Refresh()
		{
			//Discarded unreachable code: IL_0031
			//IL_0009: Expected O, but got I4
			int num = 0;
			base.OnBound((MemberInfo)num);
			List<object> list = currEnumValues;
			object value = base.m_value;
			int num2 = ((List<T>)(object)list).IndexOf((T)value);
			if (num2 != -1)
			{
				input.value = num2;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public EnumField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xF25D60", Offset = "0xF24760", VA = "0x180F25D60")]
		static EnumField()
		{
			enumNames = (Dictionary<Type, List<string>>)(object)new Dictionary<TKey, TValue>();
			/*Error: Unexpected end of block*/;
		}
	}
}
