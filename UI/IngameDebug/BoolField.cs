using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class BoolField : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		[SerializeField]
		private Image toggleBackground;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		[SerializeField]
		private Toggle input;

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA62D40", Offset = "0xA61740", VA = "0x180A62D40", Slot = "6")]
		public override void Initialize()
		{
			//Discarded unreachable code: IL_0027
			base.Initialize();
			Toggle.ToggleEvent onValueChanged = input.onValueChanged;
			UnityAction<bool> unityAction = (UnityAction<bool>)(object)new UnityAction<T0>(OnValueChanged);
			((UnityEvent<T0>)(object)onValueChanged).AddListener((UnityAction<>)(object)unityAction);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA63080", Offset = "0xA61A80", VA = "0x180A63080", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(bool);
			return ((object)type).Equals((object)typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA62F70", Offset = "0xA61970", VA = "0x180A62F70")]
		private void OnValueChanged(bool input)
		{
			//Discarded unreachable code: IL_000c
			base.m_inspector.RefreshDelayed();
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA62E10", Offset = "0xA61810", VA = "0x180A62E10", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_008b
			//IL_007c: Expected O, but got I4
			base.OnSkinChanged();
			UISkin skin = base.m_skin;
			Image image = toggleBackground;
			Color color = (image.color = skin.m_inputFieldNormalBackgroundColor);
			Toggle toggle = input;
			UISkin skin2 = base.m_skin;
			Graphic graphic = toggle.graphic;
			Color color2 = (graphic.color = skin2.m_toggleCheckmarkColor);
			UISkin skin3 = base.m_skin;
			Image image2 = variableNameMask;
			float labelWidthPercentage = skin3.m_labelWidthPercentage;
			int num = 0;
			RectTransform rectTransform = image2.rectTransform;
			int num2 = 0;
			rectTransform.anchorMin = (Vector2)num;
			if ((object)input.transform != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA62FF0", Offset = "0xA619F0", VA = "0x180A62FF0", Slot = "14")]
		public override void Refresh()
		{
			//Discarded unreachable code: IL_0018
			//IL_0009: Expected O, but got I4
			int num = 0;
			base.OnBound((MemberInfo)num);
			Toggle toggle = input;
			object value = base.m_value;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public BoolField()
		{
		}
	}
}
