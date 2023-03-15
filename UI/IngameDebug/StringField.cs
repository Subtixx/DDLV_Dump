using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public class StringField : InspectorField
	{
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			OnValueChange,
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			OnSubmit
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[SerializeField]
		private BoundInputField input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private Mode m_setterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private int lineCount = 1;

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public Mode SetterMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x1024670", Offset = "0x1023070", VA = "0x181024670")]
			get
			{
				return m_setterMode;
			}
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x17E3700", Offset = "0x17E2100", VA = "0x1817E3700")]
			set
			{
				//Discarded unreachable code: IL_001b
				BoundInputField boundInputField = input;
				m_setterMode = value;
				bool flag = (boundInputField.CacheTextOnValueChange = value == Mode.OnValueChange);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		protected override float HeightMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x17E36F0", Offset = "0x17E20F0", VA = "0x1817E36F0", Slot = "5")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x17E30F0", Offset = "0x17E1AF0", VA = "0x1817E30F0", Slot = "6")]
		public override void Initialize()
		{
			//IL_003e: Expected O, but got I4
			base.Initialize();
			input.Initialize();
			BoundInputField boundInputField = input;
			BoundInputField.OnValueChangedDelegate onValueChangedDelegate = OnValueChanged;
			Delegate @delegate = Delegate.Combine(onValueChangedDelegate, onValueChangedDelegate);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				boundInputField.OnValueChanged = (BoundInputField.OnValueChangedDelegate)num;
				BoundInputField boundInputField2 = input;
				BoundInputField.OnValueChangedDelegate onValueChangedDelegate2 = OnValueSubmitted;
				Delegate delegate2 = Delegate.Combine(onValueChangedDelegate2, onValueChangedDelegate2);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					boundInputField2.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate2;
					BoundInputField boundInputField3 = input;
					string text = (boundInputField3.DefaultEmptyValue = string.Empty);
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x17E3650", Offset = "0x17E2050", VA = "0x1817E3650", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(string);
			return ((object)type).Equals((object)typeFromHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x17E32B0", Offset = "0x17E1CB0", VA = "0x1817E32B0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			//Discarded unreachable code: IL_0080
			//IL_0017: Expected O, but got I4
			base.OnBound(variable);
			int num = lineCount;
			int num2 = 0;
			if (!(variable == (MemberInfo)num2))
			{
				MultilineAttribute attribute = variable.GetAttribute<MultilineAttribute>();
				if (attribute == null)
				{
					bool flag = variable.HasAttribute<TextAreaAttribute>();
				}
				int lines = attribute.lines;
				int num3 = Mathf.Max(1, lines);
			}
			lineCount = 1;
			if (num != 1)
			{
				InputField inputField = input.inputField;
				int num4 = (int)(inputField.lineType = InputField.LineType.SingleLine);
				input.inputField.m_TextComponent.alignment = TextAnchor.MiddleLeft;
				OnSkinChanged();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x17E3540", Offset = "0x17E1F40", VA = "0x1817E3540")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			if (m_setterMode == Mode.OnValueChange)
			{
				base.Value = input;
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x17E3570", Offset = "0x17E1F70", VA = "0x1817E3570")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_001d
			if (m_setterMode == Mode.OnSubmit)
			{
				base.Value = input;
			}
			base.m_inspector.RefreshDelayed();
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x17E3450", Offset = "0x17E1E50", VA = "0x1817E3450", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_0057
			//IL_0048: Expected O, but got I4
			base.OnSkinChanged();
			BoundInputField boundInputField = input;
			UISkin uISkin = (boundInputField.Skin = base.m_skin);
			UISkin skin2 = base.m_skin;
			Image image = variableNameMask;
			float labelWidthPercentage = skin2.m_labelWidthPercentage;
			int num = 0;
			RectTransform rectTransform = image.rectTransform;
			int num2 = 0;
			rectTransform.anchorMin = (Vector2)num;
			if ((object)input.transform != null)
			{
				return;
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x17E35B0", Offset = "0x17E1FB0", VA = "0x1817E35B0", Slot = "14")]
		public override void Refresh()
		{
			//Discarded unreachable code: IL_002e
			//IL_0009: Expected O, but got I4
			int num = 0;
			base.OnBound((MemberInfo)num);
			object value = base.m_value;
			BoundInputField boundInputField = input;
			if (value != null)
			{
				if (value == null)
				{
					throw new InvalidCastException();
				}
			}
			else
			{
				string text = (boundInputField.Text = string.Empty);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x17E36D0", Offset = "0x17E20D0", VA = "0x1817E36D0")]
		public StringField()
		{
		}//IL_0009: Expected I4, but got I8

	}
}
