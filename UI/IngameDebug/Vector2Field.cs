using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	public class Vector2Field : InspectorField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		[SerializeField]
		private BoundInputField inputX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		[SerializeField]
		private BoundInputField inputY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		[SerializeField]
		private Text labelX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		[SerializeField]
		private Text labelY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private bool isVector2Int;

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xCAC5D0", Offset = "0xCAAFD0", VA = "0x180CAC5D0", Slot = "6")]
		public override void Initialize()
		{
			//IL_004c: Expected O, but got I4
			base.Initialize();
			inputX.Initialize();
			inputY.Initialize();
			BoundInputField boundInputField = inputX;
			BoundInputField.OnValueChangedDelegate onValueChangedDelegate = OnValueChanged;
			Delegate @delegate = Delegate.Combine(onValueChangedDelegate, onValueChangedDelegate);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				boundInputField.OnValueChanged = (BoundInputField.OnValueChangedDelegate)num;
				BoundInputField boundInputField2 = inputY;
				BoundInputField.OnValueChangedDelegate onValueChanged = boundInputField2.OnValueChanged;
				BoundInputField.OnValueChangedDelegate b = OnValueChanged;
				Delegate delegate2 = Delegate.Combine(onValueChanged, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					boundInputField2.OnValueChanged = (BoundInputField.OnValueChangedDelegate)delegate2;
					BoundInputField boundInputField3 = inputX;
					BoundInputField.OnValueChangedDelegate onValueSubmitted = boundInputField3.OnValueSubmitted;
					BoundInputField.OnValueChangedDelegate b2 = OnValueSubmitted;
					Delegate delegate3 = Delegate.Combine(onValueSubmitted, b2);
					if ((object)delegate3 == null || (object)delegate3 != null)
					{
						boundInputField3.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate3;
						BoundInputField boundInputField4 = inputY;
						BoundInputField.OnValueChangedDelegate onValueSubmitted2 = boundInputField4.OnValueSubmitted;
						BoundInputField.OnValueChangedDelegate b3 = OnValueSubmitted;
						Delegate delegate4 = Delegate.Combine(onValueSubmitted2, b3);
						if ((object)delegate4 == null || (object)delegate4 != null)
						{
							boundInputField4.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate4;
							inputX.DefaultEmptyValue = "0";
							inputY.DefaultEmptyValue = "0";
							throw new NullReferenceException();
						}
					}
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xCAD1A0", Offset = "0xCABBA0", VA = "0x180CAD1A0", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			Type typeFromHandle = typeof(Vector2Int);
			if (!((object)type).Equals((object)typeFromHandle))
			{
				Type typeFromHandle2 = typeof(Vector2);
				return ((object)type).Equals((object)typeFromHandle2);
			}
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xCAC8B0", Offset = "0xCAB2B0", VA = "0x180CAC8B0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			//Discarded unreachable code: IL_0062
			base.OnBound(variable);
			Type boundVariableType = base.m_boundVariableType;
			Type typeFromHandle = typeof(Vector2Int);
			bool flag = ((object)boundVariableType).Equals((object)typeFromHandle);
			object value = base.m_value;
			isVector2Int = flag;
			if (!flag)
			{
				string text = default(string);
				inputX.Text = text;
			}
			BoundInputField boundInputField = inputX;
			object obj = value;
			string text2 = default(string);
			boundInputField.Text = text2;
			string text3 = default(string);
			inputY.Text = text3;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0xCACD00", Offset = "0xCAB700", VA = "0x180CACD00")]
		private unsafe bool OnValueChanged(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_0067
			//IL_0065: Expected O, but got I8
			int num = 0;
			int num2 = 0;
			if ((isVector2Int ? 1 : 0) == num2)
			{
				if (!float.TryParse(input, out *(float*)num))
				{
					goto IL_003c;
				}
				object value = base.m_value;
				BoundInputField boundInputField = inputX;
				object obj = value;
				object obj2 = value;
				if (source == boundInputField)
				{
				}
			}
			bool flag = default(bool);
			if (!flag)
			{
				goto IL_003c;
			}
			goto IL_003f;
			IL_003c:
			int num3 = 0;
			goto IL_003f;
			IL_003f:
			object value2 = base.m_value;
			BoundInputField boundInputField2 = inputX;
			object obj3 = value2;
			if (!(source == boundInputField2))
			{
			}
			ulong num4 = default(ulong);
			base.Value = num4;
			return true;
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xCACF10", Offset = "0xCAB910", VA = "0x180CACF10")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_0014
			base.m_inspector.RefreshDelayed();
			return OnValueChanged(source, input);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xCACA70", Offset = "0xCAB470", VA = "0x180CACA70", Slot = "12")]
		protected override void OnSkinChanged()
		{
			//Discarded unreachable code: IL_00cc
			//IL_0080: Expected O, but got I4
			base.OnSkinChanged();
			UISkin skin = base.m_skin;
			labelX.SetSkinText(skin);
			UISkin skin2 = base.m_skin;
			labelY.SetSkinText(skin2);
			BoundInputField boundInputField = inputX;
			UISkin uISkin = (boundInputField.Skin = base.m_skin);
			BoundInputField boundInputField2 = inputY;
			UISkin uISkin2 = (boundInputField2.Skin = base.m_skin);
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
					return;
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xCACF60", Offset = "0xCAB960", VA = "0x180CACF60", Slot = "14")]
		public override void Refresh()
		{
			object value = base.m_value;
			if (!isVector2Int)
			{
				base.Refresh();
				object value2 = base.m_value;
				BoundInputField boundInputField = inputX;
				string text = default(string);
				boundInputField.Text = text;
				if ((object)boundInputField != null)
				{
					string text2 = default(string);
					inputY.Text = text2;
				}
				return;
			}
			object obj = value;
			base.Refresh();
			object value3 = base.m_value;
			if (value3 != obj)
			{
				string text3 = default(string);
				inputX.Text = text3;
			}
			while (value3 == obj)
			{
			}
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public Vector2Field()
		{
		}
	}
}
