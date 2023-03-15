using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public class Vector3Field : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		[SerializeField]
		private BoundInputField inputX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		[SerializeField]
		private BoundInputField inputY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		[SerializeField]
		private BoundInputField inputZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		[SerializeField]
		private Text labelX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		[SerializeField]
		private Text labelY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		[SerializeField]
		private Text labelZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private bool isVector3Int;

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xCAD280", Offset = "0xCABC80", VA = "0x180CAD280", Slot = "6")]
		public override void Initialize()
		{
			//IL_0054: Expected O, but got I4
			BoundInputField boundInputField;
			Delegate @delegate;
			int num;
			do
			{
				base.Initialize();
				inputX.Initialize();
				inputY.Initialize();
				inputZ.Initialize();
				boundInputField = inputX;
				BoundInputField.OnValueChangedDelegate onValueChangedDelegate = OnValueChanged;
				@delegate = Delegate.Combine(onValueChangedDelegate, onValueChangedDelegate);
				num = 0;
			}
			while ((object)@delegate != null && (object)@delegate == null);
			boundInputField.OnValueChanged = (BoundInputField.OnValueChangedDelegate)num;
			BoundInputField boundInputField2 = inputY;
			BoundInputField.OnValueChangedDelegate onValueChanged = boundInputField2.OnValueChanged;
			BoundInputField.OnValueChangedDelegate b = OnValueChanged;
			Delegate delegate2 = Delegate.Combine(onValueChanged, b);
			if ((object)delegate2 == null || (object)delegate2 != null)
			{
				boundInputField2.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate2;
				BoundInputField boundInputField3 = inputZ;
				BoundInputField.OnValueChangedDelegate onValueChanged2 = boundInputField3.OnValueChanged;
				BoundInputField.OnValueChangedDelegate b2 = OnValueChanged;
				Delegate delegate3 = Delegate.Combine(onValueChanged2, b2);
				if ((object)delegate3 == null || (object)delegate3 != null)
				{
					boundInputField3.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate3;
					BoundInputField boundInputField4 = inputX;
					BoundInputField.OnValueChangedDelegate onValueSubmitted = boundInputField4.OnValueSubmitted;
					BoundInputField.OnValueChangedDelegate b3 = OnValueSubmitted;
					Delegate delegate4 = Delegate.Combine(onValueSubmitted, b3);
					if ((object)delegate4 == null || (object)delegate4 != null)
					{
						boundInputField4.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate4;
						BoundInputField boundInputField5 = inputY;
						BoundInputField.OnValueChangedDelegate onValueSubmitted2 = boundInputField5.OnValueSubmitted;
						BoundInputField.OnValueChangedDelegate b4 = OnValueSubmitted;
						Delegate delegate5 = Delegate.Combine(onValueSubmitted2, b4);
						if ((object)delegate5 == null || (object)delegate5 != null)
						{
							boundInputField5.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate5;
							BoundInputField boundInputField6 = inputZ;
							BoundInputField.OnValueChangedDelegate onValueSubmitted3 = boundInputField6.OnValueSubmitted;
							BoundInputField.OnValueChangedDelegate b5 = OnValueSubmitted;
							Delegate delegate6 = Delegate.Combine(onValueSubmitted3, b5);
							if ((object)delegate6 == null || (object)delegate6 != null)
							{
								boundInputField6.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate6;
								inputX.DefaultEmptyValue = "0";
								inputY.DefaultEmptyValue = "0";
								inputZ.DefaultEmptyValue = "0";
								throw new NullReferenceException();
							}
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xCAE240", Offset = "0xCACC40", VA = "0x180CAE240", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(Vector3Int);
			if (!((object)type).Equals((object)typeFromHandle))
			{
				Type typeFromHandle2 = typeof(Vector3);
				return ((object)type).Equals((object)typeFromHandle2);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xCAD690", Offset = "0xCAC090", VA = "0x180CAD690", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			//Discarded unreachable code: IL_0083
			base.OnBound(variable);
			Type boundVariableType = base.m_boundVariableType;
			Type typeFromHandle = typeof(Vector3Int);
			bool flag = ((object)boundVariableType).Equals((object)typeFromHandle);
			object value = base.m_value;
			isVector3Int = flag;
			if (!flag)
			{
				BoundInputField boundInputField = inputX;
				object obj = value;
				string text = default(string);
				boundInputField.Text = text;
				string text2 = default(string);
				inputY.Text = text2;
			}
			BoundInputField boundInputField2 = inputX;
			object obj2 = value;
			string text3 = default(string);
			boundInputField2.Text = text3;
			string text4 = default(string);
			inputY.Text = text4;
			string text5 = default(string);
			inputZ.Text = text5;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xCADC10", Offset = "0xCAC610", VA = "0x180CADC10")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_005c
			//IL_0046: Expected O, but got I4
			int num = 0;
			bool flag3 = default(bool);
			if ((isVector3Int ? 1 : 0) == num)
			{
				bool flag = default(bool);
				if (flag)
				{
					object value = base.m_value;
					BoundInputField boundInputField = inputX;
					bool flag2 = source == boundInputField;
					if (!flag2)
					{
						BoundInputField boundInputField2 = inputY;
						if (source == boundInputField2)
						{
						}
					}
					base.Value = flag2;
					return true;
				}
			}
			else if (flag3)
			{
				goto IL_0050;
			}
			int num2 = 0;
			goto IL_0050;
			IL_0050:
			bool flag4 = default(bool);
			bool flag5 = default(bool);
			if (flag4 || !flag5)
			{
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xCADEE0", Offset = "0xCAC8E0", VA = "0x180CADEE0")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_0014
			base.m_inspector.RefreshDelayed();
			return OnValueChanged(source, input);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xCAD8F0", Offset = "0xCAC2F0", VA = "0x180CAD8F0", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_011e
			//IL_00ae: Expected O, but got I4
			base.OnSkinChanged();
			UISkin skin = base.m_skin;
			labelX.SetSkinText(skin);
			UISkin skin2 = base.m_skin;
			labelY.SetSkinText(skin2);
			UISkin skin3 = base.m_skin;
			labelZ.SetSkinText(skin3);
			BoundInputField boundInputField = inputX;
			UISkin uISkin = (boundInputField.Skin = base.m_skin);
			BoundInputField boundInputField2 = inputY;
			UISkin uISkin2 = (boundInputField2.Skin = base.m_skin);
			BoundInputField boundInputField3 = inputZ;
			UISkin uISkin3 = (boundInputField3.Skin = base.m_skin);
			float labelWidthPercentage = base.m_skin.m_labelWidthPercentage;
			Image image = variableNameMask;
			int num = 0;
			image.rectTransform.anchorMin = (Vector2)num;
			Transform transform = inputX.transform;
			RectTransform rectTransform = labelX.rectTransform;
			int num2 = 0;
			if ((object)transform == null || (object)transform != null)
			{
				Transform transform2 = inputY.transform;
				RectTransform rectTransform2 = labelY.rectTransform;
				if ((object)transform2 == null || (object)transform2 != null)
				{
					Transform transform3 = inputZ.transform;
					RectTransform rectTransform3 = labelZ.rectTransform;
					if ((object)transform3 == null || (object)transform3 != null)
					{
						return;
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xCADF30", Offset = "0xCAC930", VA = "0x180CADF30", Slot = "14")]
		public override void Refresh()
		{
			object value = base.m_value;
			if (!isVector3Int)
			{
				object obj = value;
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
				if ((object)boundInputField2 != null)
				{
					string text3 = default(string);
					inputZ.Text = text3;
				}
				return;
			}
			object obj2 = value;
			base.Refresh();
			object value3 = base.m_value;
			if (value3 != null)
			{
				string text4 = default(string);
				inputX.Text = text4;
			}
			string text5 = default(string);
			if (value3 != null)
			{
				inputY.Text = text5;
			}
			while (text5 == null)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public Vector3Field()
		{
		}
	}
}
