using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public class Vector4Field : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		[SerializeField]
		private BoundInputField inputX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		[SerializeField]
		private BoundInputField inputY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		[SerializeField]
		private BoundInputField inputZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		[SerializeField]
		private BoundInputField inputW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		[SerializeField]
		private Text labelX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		[SerializeField]
		private Text labelY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		[SerializeField]
		private Text labelZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		[SerializeField]
		private Text labelW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private bool isQuaternion;

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		protected override float HeightMultiplier
		{
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0xF3BDA0", Offset = "0xF3A7A0", VA = "0x180F3BDA0", Slot = "5")]
			get
			{
				throw new Cpp2IlInjected.AnalysisFailedException("CPP2IL failed to recover any usable IL for this method.");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x14D4B90", Offset = "0x14D3590", VA = "0x1814D4B90", Slot = "6")]
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
				inputZ.Initialize();
				inputW.Initialize();
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
					boundInputField3 = inputZ;
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
			BoundInputField boundInputField4 = inputW;
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
						BoundInputField boundInputField7 = inputZ;
						BoundInputField.OnValueChangedDelegate onValueSubmitted3 = boundInputField7.OnValueSubmitted;
						BoundInputField.OnValueChangedDelegate b6 = OnValueSubmitted;
						Delegate delegate7 = Delegate.Combine(onValueSubmitted3, b6);
						if ((object)delegate7 == null || (object)delegate7 != null)
						{
							boundInputField7.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate7;
							BoundInputField boundInputField8 = inputW;
							BoundInputField.OnValueChangedDelegate onValueSubmitted4 = boundInputField8.OnValueSubmitted;
							BoundInputField.OnValueChangedDelegate b7 = OnValueSubmitted;
							Delegate delegate8 = Delegate.Combine(onValueSubmitted4, b7);
							if ((object)delegate8 == null || (object)delegate8 != null)
							{
								boundInputField8.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate8;
								inputX.DefaultEmptyValue = "0";
								inputY.DefaultEmptyValue = "0";
								inputZ.DefaultEmptyValue = "0";
								inputW.DefaultEmptyValue = "0";
								throw new NullReferenceException();
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x14D5DF0", Offset = "0x14D47F0", VA = "0x1814D5DF0", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(Vector4);
			if (((object)type).Equals((object)typeFromHandle))
			{
				return true;
			}
			Type typeFromHandle2 = typeof(Quaternion);
			return ((object)type).Equals((object)typeFromHandle2);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x14D50E0", Offset = "0x14D3AE0", VA = "0x1814D50E0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			base.OnBound(variable);
			Type boundVariableType = base.m_boundVariableType;
			Type typeFromHandle = typeof(Quaternion);
			bool flag = ((object)boundVariableType).Equals((object)typeFromHandle);
			object value = base.m_value;
			isQuaternion = flag;
			if (!flag)
			{
				BoundInputField boundInputField = inputX;
				object obj = value;
				string text = default(string);
				boundInputField.Text = text;
				string text2 = default(string);
				inputY.Text = text2;
				string text3 = default(string);
				inputZ.Text = text3;
				string text4 = default(string);
				inputW.Text = text4;
				return;
			}
			BoundInputField boundInputField2 = inputX;
			object obj2 = value;
			string text5 = default(string);
			boundInputField2.Text = text5;
			string text6 = default(string);
			inputY.Text = text6;
			string text7 = default(string);
			inputZ.Text = text7;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x14D5780", Offset = "0x14D4180", VA = "0x1814D5780")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			//IL_0093: Expected O, but got I4
			bool flag = default(bool);
			if (!flag)
			{
				return flag;
			}
			object value = base.m_value;
			if (!isQuaternion)
			{
				BoundInputField boundInputField = inputX;
				if (!(source == boundInputField))
				{
					BoundInputField boundInputField2 = inputY;
					if (!(source == boundInputField2))
					{
						BoundInputField boundInputField3 = inputZ;
						int num = 0;
						if (source == boundInputField3)
						{
						}
					}
				}
			}
			BoundInputField boundInputField4 = inputX;
			bool flag2 = default(bool);
			if (!(source == boundInputField4))
			{
				BoundInputField boundInputField5 = inputY;
				if (!(source == boundInputField5))
				{
					BoundInputField boundInputField6 = inputZ;
					flag2 = source == boundInputField6;
					if (flag2)
					{
					}
				}
			}
			base.Value = flag2;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x14D5A90", Offset = "0x14D4490", VA = "0x1814D5A90")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_0014
			base.m_inspector.RefreshDelayed();
			return OnValueChanged(source, input);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x14D5350", Offset = "0x14D3D50", VA = "0x1814D5350", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_0170
			//IL_00dc: Expected O, but got I4
			base.OnSkinChanged();
			UISkin skin = base.m_skin;
			labelX.SetSkinText(skin);
			UISkin skin2 = base.m_skin;
			labelY.SetSkinText(skin2);
			UISkin skin3 = base.m_skin;
			labelZ.SetSkinText(skin3);
			UISkin skin4 = base.m_skin;
			labelW.SetSkinText(skin4);
			BoundInputField boundInputField = inputX;
			UISkin uISkin = (boundInputField.Skin = base.m_skin);
			BoundInputField boundInputField2 = inputY;
			UISkin uISkin2 = (boundInputField2.Skin = base.m_skin);
			BoundInputField boundInputField3 = inputZ;
			UISkin uISkin3 = (boundInputField3.Skin = base.m_skin);
			BoundInputField boundInputField4 = inputW;
			UISkin uISkin4 = (boundInputField4.Skin = base.m_skin);
			float labelWidthPercentage = base.m_skin.m_labelWidthPercentage;
			Image image = variableNameMask;
			int num = 0;
			image.rectTransform.anchorMin = (Vector2)num;
			Transform transform = inputX.transform;
			RectTransform rectTransform = labelX.rectTransform;
			if ((object)transform == null || (object)transform != null)
			{
				Transform transform2 = inputZ.transform;
				RectTransform rectTransform2 = labelZ.rectTransform;
				if ((object)transform2 == null || (object)transform2 != null)
				{
					Transform transform3 = inputY.transform;
					RectTransform rectTransform3 = labelY.rectTransform;
					if ((object)transform3 == null || (object)transform3 != null)
					{
						Transform transform4 = inputW.transform;
						RectTransform rectTransform4 = labelW.rectTransform;
						if ((object)transform4 == null || (object)transform4 != null)
						{
							return;
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x14D5AE0", Offset = "0x14D44E0", VA = "0x1814D5AE0", Slot = "14")]
		public override void Refresh()
		{
			object value = base.m_value;
			if (!isQuaternion)
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
					boundInputField3 = inputZ;
					string text3 = default(string);
					boundInputField3.Text = text3;
				}
				if ((object)boundInputField3 != null)
				{
					string text4 = default(string);
					inputW.Text = text4;
				}
				return;
			}
			base.Refresh();
			object value3 = base.m_value;
			BoundInputField boundInputField4 = inputX;
			string text5 = default(string);
			boundInputField4.Text = text5;
			BoundInputField boundInputField5 = default(BoundInputField);
			if ((object)boundInputField4 != null)
			{
				boundInputField5 = inputY;
				string text6 = default(string);
				boundInputField5.Text = text6;
			}
			BoundInputField boundInputField6 = default(BoundInputField);
			if ((object)boundInputField5 != null)
			{
				boundInputField6 = inputZ;
				string text7 = default(string);
				boundInputField6.Text = text7;
			}
			while ((object)boundInputField6 == null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public Vector4Field()
		{
		}
	}
}
