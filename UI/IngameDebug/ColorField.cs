using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class ColorField : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		[SerializeField]
		private RectTransform colorPickerArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		[SerializeField]
		private PointerEventListener inputColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private Image colorImg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private bool isColor32;

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1150170", Offset = "0x114EB70", VA = "0x181150170", Slot = "6")]
		public override void Initialize()
		{
			//Discarded unreachable code: IL_0035
			base.Initialize();
			Image image = (colorImg = inputColor.GetComponent<Image>());
			PointerEventListener pointerEventListener = inputColor;
			PointerEventListener.PointerEvent value = ShowColorPicker;
			pointerEventListener.PointerClick += value;
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1150710", Offset = "0x114F110", VA = "0x181150710", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(Color);
			if (((object)type).Equals((object)typeFromHandle))
			{
				return true;
			}
			Type typeFromHandle2 = typeof(Color32);
			return ((object)type).Equals((object)typeFromHandle2);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1150240", Offset = "0x114EC40", VA = "0x181150240", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			base.OnBound(variable);
			Type boundVariableType = base.m_boundVariableType;
			Type typeFromHandle = typeof(Color32);
			bool flag = (isColor32 = ((object)boundVariableType).Equals((object)typeFromHandle));
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1150580", Offset = "0x114EF80", VA = "0x181150580")]
		private void ShowColorPicker(PointerEventData eventData)
		{
			//Discarded unreachable code: IL_0052
			object value = base.m_value;
			if (isColor32)
			{
			}
			object obj = value;
			int num = 0;
			DebugColorPicker instance = DebugColorPicker.Instance;
			UISkin uISkin = (instance.Skin = ((SkinnedWindow)base.m_inspector).m_skin);
			int num2 = 0;
			DebugColorPicker instance2 = DebugColorPicker.Instance;
			ColorWheelControl.OnColorChangedDelegate onColorChangedDelegate = OnColorChanged;
			RuntimeInspector inspector = base.m_inspector;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x11502F0", Offset = "0x114ECF0", VA = "0x1811502F0")]
		private void OnColorChanged(Color32 color)
		{
			//Discarded unreachable code: IL_001f
			int rgba = color.rgba;
			Image image = colorImg;
			if (!isColor32)
			{
			}
			Color value = default(Color);
			base.Value = value;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x11503E0", Offset = "0x114EDE0", VA = "0x1811503E0", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_003d
			//IL_0030: Expected O, but got I4
			//IL_003c: Expected O, but got I4
			base.OnSkinChanged();
			UISkin skin = base.m_skin;
			Image image = variableNameMask;
			float labelWidthPercentage = skin.m_labelWidthPercentage;
			int num = 0;
			RectTransform rectTransform = image.rectTransform;
			int num2 = 0;
			rectTransform.anchorMin = (Vector2)num;
			colorPickerArea.anchorMin = (Vector2)num;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1150470", Offset = "0x114EE70", VA = "0x181150470", Slot = "14")]
		public override void Refresh()
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			base.OnBound((MemberInfo)num);
			Image image = colorImg;
			object value = base.m_value;
			if (!isColor32)
			{
				object obj = value;
				return;
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public ColorField()
		{
		}
	}
}
