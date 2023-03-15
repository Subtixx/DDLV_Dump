using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	public class NumberRangeField : NumberField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		[SerializeField]
		private BoundSlider slider;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x12A1DA0", Offset = "0x12A07A0", VA = "0x1812A1DA0", Slot = "6")]
		public override void Initialize()
		{
			//IL_003c: Expected O, but got I4
			base.Initialize();
			BoundSlider boundSlider = slider;
			BoundSlider.OnValueChangedDelegate onValueChanged = boundSlider.OnValueChanged;
			BoundSlider.OnValueChangedDelegate b = OnSliderValueChanged;
			Delegate @delegate = Delegate.Combine(onValueChanged, b);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				boundSlider.OnValueChanged = (BoundSlider.OnValueChangedDelegate)num;
				throw new NullReferenceException();
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x12A1D20", Offset = "0x12A0720", VA = "0x1812A1D20", Slot = "8")]
		public override bool CanBindTo(Type type, MemberInfo variable)
		{
			//IL_0009: Expected O, but got I4
			int num = 0;
			bool flag = variable != (MemberInfo)num;
			if (!flag)
			{
				return flag;
			}
			return variable.HasAttribute<RangeAttribute>();
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x12A1E80", Offset = "0x12A0880", VA = "0x1812A1E80", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			//Discarded unreachable code: IL_00b4
			base.OnBound(variable);
			RangeAttribute attribute = variable.GetAttribute<RangeAttribute>();
			BoundSlider boundSlider = this.slider;
			INumberHandler numberHandler = base.numberHandler;
			int num = 0;
			INumberHandler numberHandler2 = base.numberHandler;
			float num2 = default(float);
			float max = Mathf.Min(num2, num2);
			boundSlider.SetRange(num2, max);
			Slider slider = this.slider.slider;
			Type boundVariableType = ((InspectorField)this).m_boundVariableType;
			Type typeFromHandle = typeof(float);
			if (boundVariableType != typeFromHandle)
			{
				Type boundVariableType2 = ((InspectorField)this).m_boundVariableType;
				Type typeFromHandle2 = typeof(double);
				if (boundVariableType2 != typeFromHandle2)
				{
					Type boundVariableType3 = ((InspectorField)this).m_boundVariableType;
					Type typeFromHandle3 = typeof(decimal);
					bool flag = boundVariableType3 != typeFromHandle3;
				}
			}
			int num3 = ((slider.wholeNumbers = false) ? 1 : 0);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x12A2500", Offset = "0x12A0F00", VA = "0x1812A2500", Slot = "15")]
		protected override bool OnValueChanged(BoundInputField source, string input)
		{
			//IL_003d: Expected O, but got I4
			INumberHandler numberHandler = base.numberHandler;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if ((object)typeof(INumberHandler).TypeHandle != null)
			{
				INumberHandler numberHandler2 = base.numberHandler;
				float maxValue = slider.slider.m_MaxValue;
				base.Value = num;
			}
			int num3 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x12A23B0", Offset = "0x12A0DB0", VA = "0x1812A23B0")]
		private void OnSliderValueChanged(BoundSlider source, float value)
		{
			//Discarded unreachable code: IL_005f
			BoundInputField boundInputField = input;
			if (!boundInputField.inputField.m_AllowInput)
			{
				INumberHandler numberHandler = base.numberHandler;
				int num = 0;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				base.Value = boundInputField;
				object value2 = ((InspectorField)this).m_value;
				BoundInputField boundInputField2 = input;
				string text2 = (boundInputField2.Text = value2.ToString());
				((InspectorField)this).m_inspector.RefreshDelayed();
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x12A2100", Offset = "0x12A0B00", VA = "0x1812A2100", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_00c0
			//IL_0041: Expected O, but got I4
			//IL_0095: Expected O, but got I4
			((InspectorField)this).OnSkinChanged();
			BoundInputField boundInputField = input;
			UISkin uISkin = (boundInputField.Skin = ((InspectorField)this).m_skin);
			UISkin skin2 = ((InspectorField)this).m_skin;
			Image image = variableNameMask;
			float labelWidthPercentage = skin2.m_labelWidthPercentage;
			int num = 0;
			image.rectTransform.anchorMin = (Vector2)num;
			Transform transform = input.transform;
			int num2 = 0;
			if ((object)transform != null)
			{
				BoundSlider boundSlider = slider;
				UISkin uISkin2 = (boundSlider.Skin = ((InspectorField)this).m_skin);
				float labelWidthPercentage2 = ((InspectorField)this).m_skin.m_labelWidthPercentage;
				Image image2 = variableNameMask;
				int num3 = 0;
				image2.rectTransform.anchorMin = (Vector2)num3;
				if ((object)slider.transform != null && (object)slider.transform != null && (object)input.transform != null)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x12A2660", Offset = "0x12A1060", VA = "0x1812A2660", Slot = "14")]
		public override void Refresh()
		{
			//Discarded unreachable code: IL_0059
			//IL_0009: Expected O, but got I4
			int num = 0;
			((InspectorField)this).OnBound((MemberInfo)num);
			INumberHandler numberHandler = base.numberHandler;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			if ((object)typeof(INumberHandler).TypeHandle == null)
			{
				object value = ((InspectorField)this).m_value;
				BoundInputField boundInputField = input;
				string text2 = (boundInputField.Text = value.ToString());
			}
			INumberHandler numberHandler2 = base.numberHandler;
			BoundSlider boundSlider = slider;
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x12A27E0", Offset = "0x12A11E0", VA = "0x1812A27E0")]
		public NumberRangeField()
		{
		}
	}
}
