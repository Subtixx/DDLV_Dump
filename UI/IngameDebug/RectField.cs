using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public class RectField : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[SerializeField]
		private BoundInputField inputX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		[SerializeField]
		private BoundInputField inputY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[SerializeField]
		private BoundInputField inputW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		[SerializeField]
		private BoundInputField inputH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		[SerializeField]
		private Text labelX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		[SerializeField]
		private Text labelY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[SerializeField]
		private Text labelW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		[SerializeField]
		private Text labelH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private bool isRectInt;

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		protected override float HeightMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0xF3BDA0", Offset = "0xF3A7A0", VA = "0x180F3BDA0", Slot = "5")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xF3A890", Offset = "0xF39290", VA = "0x180F3A890", Slot = "6")]
		public override void Initialize()
		{
			//IL_005f: Expected O, but got I4
			BoundInputField boundInputField3;
			Delegate delegate3;
			while (true)
			{
				base.Initialize();
				inputX.Initialize();
				inputY.Initialize();
				inputW.Initialize();
				inputH.Initialize();
				BoundInputField boundInputField = inputX;
				BoundInputField.OnValueChangedDelegate onValueChangedDelegate = OnValueChanged;
				Delegate @delegate = Delegate.Combine(onValueChangedDelegate, onValueChangedDelegate);
				int num = 0;
				if ((object)@delegate != null && (object)@delegate == null)
				{
					continue;
				}
				boundInputField.OnValueChanged = (BoundInputField.OnValueChangedDelegate)num;
				BoundInputField boundInputField2 = inputY;
				BoundInputField.OnValueChangedDelegate onValueChanged = boundInputField2.OnValueChanged;
				BoundInputField.OnValueChangedDelegate b = OnValueChanged;
				Delegate delegate2 = Delegate.Combine(onValueChanged, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					boundInputField2.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate2;
					boundInputField3 = inputW;
					BoundInputField.OnValueChangedDelegate onValueChanged2 = boundInputField3.OnValueChanged;
					BoundInputField.OnValueChangedDelegate b2 = OnValueChanged;
					delegate3 = Delegate.Combine(onValueChanged2, b2);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						break;
					}
				}
			}
			boundInputField3.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate3;
			BoundInputField boundInputField4 = inputH;
			BoundInputField.OnValueChangedDelegate onValueChanged3 = boundInputField4.OnValueChanged;
			BoundInputField.OnValueChangedDelegate b3 = OnValueChanged;
			Delegate delegate4 = Delegate.Combine(onValueChanged3, b3);
			if ((object)delegate4 == null || (object)delegate4 != null)
			{
				boundInputField4.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate4;
				BoundInputField boundInputField5 = inputX;
				BoundInputField.OnValueChangedDelegate onValueSubmitted = boundInputField5.OnValueSubmitted;
				BoundInputField.OnValueChangedDelegate b4 = OnValueSubmitted;
				Delegate delegate5 = Delegate.Combine(onValueSubmitted, b4);
				if ((object)delegate5 == null || (object)delegate5 != null)
				{
					boundInputField5.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate5;
					BoundInputField boundInputField6 = inputY;
					BoundInputField.OnValueChangedDelegate onValueSubmitted2 = boundInputField6.OnValueSubmitted;
					BoundInputField.OnValueChangedDelegate b5 = OnValueSubmitted;
					Delegate delegate6 = Delegate.Combine(onValueSubmitted2, b5);
					if ((object)delegate6 == null || (object)delegate6 != null)
					{
						boundInputField6.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate6;
						BoundInputField boundInputField7 = inputW;
						BoundInputField.OnValueChangedDelegate onValueSubmitted3 = boundInputField7.OnValueSubmitted;
						BoundInputField.OnValueChangedDelegate b6 = OnValueSubmitted;
						Delegate delegate7 = Delegate.Combine(onValueSubmitted3, b6);
						if ((object)delegate7 == null || (object)delegate7 != null)
						{
							boundInputField7.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate7;
							BoundInputField boundInputField8 = inputH;
							BoundInputField.OnValueChangedDelegate onValueSubmitted4 = boundInputField8.OnValueSubmitted;
							BoundInputField.OnValueChangedDelegate b7 = OnValueSubmitted;
							Delegate delegate8 = Delegate.Combine(onValueSubmitted4, b7);
							if ((object)delegate8 == null || (object)delegate8 != null)
							{
								boundInputField8.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate8;
								inputX.DefaultEmptyValue = "0";
								inputY.DefaultEmptyValue = "0";
								inputW.DefaultEmptyValue = "0";
								inputH.DefaultEmptyValue = "0";
								throw new NullReferenceException();
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xF3BCC0", Offset = "0xF3A6C0", VA = "0x180F3BCC0", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(RectInt);
			if (!((object)type).Equals((object)typeFromHandle))
			{
				Type typeFromHandle2 = typeof(Rect);
				return ((object)type).Equals((object)typeFromHandle2);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xF3ADE0", Offset = "0xF397E0", VA = "0x180F3ADE0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			//Discarded unreachable code: IL_008f
			base.OnBound(variable);
			Type boundVariableType = base.m_boundVariableType;
			Type typeFromHandle = typeof(RectInt);
			bool flag = ((object)boundVariableType).Equals((object)typeFromHandle);
			object value = base.m_value;
			isRectInt = flag;
			if (!flag)
			{
				string text = default(string);
				inputX.Text = text;
				string text2 = default(string);
				inputY.Text = text2;
				string text3 = default(string);
				inputW.Text = text3;
			}
			string text4 = default(string);
			inputX.Text = text4;
			string text5 = default(string);
			inputY.Text = text5;
			string text6 = default(string);
			inputW.Text = text6;
			string text7 = default(string);
			inputH.Text = text7;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xF3B4F0", Offset = "0xF39EF0", VA = "0x180F3B4F0")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			//IL_00a2: Expected O, but got I4
			int num = 0;
			if ((isRectInt ? 1 : 0) == num)
			{
				bool flag = default(bool);
				if (!flag)
				{
					goto IL_0052;
				}
				object value = base.m_value;
				BoundInputField boundInputField = inputX;
				if (!(source == boundInputField))
				{
					BoundInputField boundInputField2 = inputY;
					if (!(source == boundInputField2))
					{
						BoundInputField boundInputField3 = inputW;
						if (source == boundInputField3)
						{
						}
					}
				}
			}
			bool flag2 = default(bool);
			if (!flag2)
			{
				goto IL_0052;
			}
			goto IL_0055;
			IL_0055:
			object value2 = base.m_value;
			BoundInputField boundInputField4 = inputX;
			bool flag3 = default(bool);
			if (!(source == boundInputField4))
			{
				BoundInputField boundInputField5 = inputY;
				if (!(source == boundInputField5))
				{
					BoundInputField boundInputField6 = inputW;
					flag3 = source == boundInputField6;
					if (flag3)
					{
					}
				}
			}
			base.Value = flag3;
			throw new NullReferenceException();
			IL_0052:
			int num2 = 0;
			goto IL_0055;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xF3B850", Offset = "0xF3A250", VA = "0x180F3B850")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_0014
			base.m_inspector.RefreshDelayed();
			return OnValueChanged(source, input);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xF3B0C0", Offset = "0xF39AC0", VA = "0x180F3B0C0", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_0173
			//IL_00dc: Expected O, but got I4
			base.OnSkinChanged();
			UISkin skin = base.m_skin;
			labelX.SetSkinText(skin);
			UISkin skin2 = base.m_skin;
			labelY.SetSkinText(skin2);
			UISkin skin3 = base.m_skin;
			labelW.SetSkinText(skin3);
			UISkin skin4 = base.m_skin;
			labelH.SetSkinText(skin4);
			BoundInputField boundInputField = inputX;
			UISkin uISkin = (boundInputField.Skin = base.m_skin);
			BoundInputField boundInputField2 = inputY;
			UISkin uISkin2 = (boundInputField2.Skin = base.m_skin);
			BoundInputField boundInputField3 = inputW;
			UISkin uISkin3 = (boundInputField3.Skin = base.m_skin);
			BoundInputField boundInputField4 = inputH;
			UISkin uISkin4 = (boundInputField4.Skin = base.m_skin);
			float labelWidthPercentage = base.m_skin.m_labelWidthPercentage;
			Image image = variableNameMask;
			int num = 0;
			image.rectTransform.anchorMin = (Vector2)num;
			Transform transform = inputX.transform;
			RectTransform rectTransform = labelX.rectTransform;
			int num2 = 0;
			if ((object)transform == null || (object)transform != null)
			{
				Transform transform2 = inputW.transform;
				RectTransform rectTransform2 = labelW.rectTransform;
				if ((object)transform2 == null || (object)transform2 != null)
				{
					Transform transform3 = inputY.transform;
					RectTransform rectTransform3 = labelY.rectTransform;
					if ((object)transform3 == null || (object)transform3 != null)
					{
						Transform transform4 = inputH.transform;
						RectTransform rectTransform4 = labelH.rectTransform;
						if ((object)transform4 == null || (object)transform4 != null)
						{
							return;
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xF3B8A0", Offset = "0xF3A2A0", VA = "0x180F3B8A0", Slot = "14")]
		public override void Refresh()
		{
			object value = base.m_value;
			if (!isRectInt)
			{
				base.Refresh();
				object value2 = base.m_value;
				BoundInputField boundInputField = inputX;
				string text = default(string);
				boundInputField.Text = text;
				BoundInputField boundInputField2 = default(BoundInputField);
				if ((object)boundInputField != null)
				{
					boundInputField2 = inputY;
					string text2 = default(string);
					boundInputField2.Text = text2;
				}
				BoundInputField boundInputField3 = default(BoundInputField);
				if ((object)boundInputField2 != null)
				{
					boundInputField3 = inputW;
					string text3 = default(string);
					boundInputField3.Text = text3;
				}
				if ((object)boundInputField3 != null)
				{
					string text4 = default(string);
					inputH.Text = text4;
				}
				return;
			}
			base.Refresh();
			object value3 = base.m_value;
			string text5 = default(string);
			inputX.Text = text5;
			string text6 = default(string);
			inputY.Text = text6;
			string text7 = default(string);
			if (text6 != null)
			{
				inputW.Text = text7;
			}
			while (text7 == null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public RectField()
		{
		}
	}
}
