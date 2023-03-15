using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

namespace IngameDebug
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class NumberField : InspectorField
	{
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private static readonly HashSet<Type> supportedTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		[SerializeField]
		protected BoundInputField input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		protected INumberHandler numberHandler;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x12A0B40", Offset = "0x129F540", VA = "0x1812A0B40", Slot = "6")]
		public override void Initialize()
		{
			//IL_0031: Expected O, but got I4
			base.Initialize();
			input.Initialize();
			BoundInputField boundInputField = input;
			BoundInputField.OnValueChangedDelegate onValueChangedDelegate = default(BoundInputField.OnValueChangedDelegate);
			Delegate @delegate = Delegate.Combine(onValueChangedDelegate, onValueChangedDelegate);
			int num = 0;
			if ((object)@delegate == null || (object)@delegate != null)
			{
				boundInputField.OnValueChanged = (BoundInputField.OnValueChangedDelegate)num;
				BoundInputField boundInputField2 = input;
				BoundInputField.OnValueChangedDelegate onValueSubmitted = boundInputField2.OnValueSubmitted;
				BoundInputField.OnValueChangedDelegate b = OnValueSubmitted;
				Delegate delegate2 = Delegate.Combine(onValueSubmitted, b);
				if ((object)delegate2 == null || (object)delegate2 != null)
				{
					boundInputField2.OnValueSubmitted = (BoundInputField.OnValueChangedDelegate)delegate2;
					input.DefaultEmptyValue = "0";
					throw new NullReferenceException();
				}
			}
			throw new InvalidCastException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x12A1260", Offset = "0x129FC60", VA = "0x1812A1260", Slot = "7")]
		public override bool SupportsType(Type type)
		{
			//Discarded unreachable code: IL_000c
			return ((HashSet<T>)(object)supportedTypes).Contains((T)type);
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x12A0CE0", Offset = "0x129F6E0", VA = "0x1812A0CE0", Slot = "9")]
		protected override void OnBound(MemberInfo variable)
		{
			base.OnBound(variable);
			INumberHandler numberHandler = (this.numberHandler = NumberHandlers.Get(base.m_boundVariableType));
			object value = base.m_value;
			BoundInputField boundInputField = input;
			string text2 = (boundInputField.Text = value.ToString());
			Type boundVariableType = base.m_boundVariableType;
			Type typeFromHandle = typeof(float);
			if (!((object)boundVariableType).Equals((object)typeFromHandle))
			{
				Type boundVariableType2 = base.m_boundVariableType;
				Type typeFromHandle2 = typeof(double);
				if (!((object)boundVariableType2).Equals((object)typeFromHandle2))
				{
					Type boundVariableType3 = base.m_boundVariableType;
					Type typeFromHandle3 = typeof(decimal);
					if (!((object)boundVariableType3).Equals((object)typeFromHandle3))
					{
						input.inputField.contentType = InputField.ContentType.IntegerNumber;
						return;
					}
				}
			}
			InputField inputField = input.inputField;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x12A0FE0", Offset = "0x129F9E0", VA = "0x1812A0FE0", Slot = "15")]
		protected virtual bool OnValueChanged(BoundInputField source, string input)
		{
			//Discarded unreachable code: IL_0023
			//IL_0023: Expected I4, but got O
			//IL_002e: Expected O, but got I4
			INumberHandler numberHandler = this.numberHandler;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			if ((object)typeof(INumberHandler).TypeHandle == null)
			{
				return (byte)(int)typeof(INumberHandler).TypeHandle != 0;
			}
			base.Value = num;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x12A10E0", Offset = "0x129FAE0", VA = "0x1812A10E0")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			base.m_inspector.RefreshDelayed();
			int count = ((XmlNodeList)(object)this).Count;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x12A0EF0", Offset = "0x129F8F0", VA = "0x1812A0EF0", Slot = "12")]
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

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x12A1140", Offset = "0x129FB40", VA = "0x1812A1140", Slot = "14")]
		public override void Refresh()
		{
			//Discarded unreachable code: IL_0049
			//IL_0009: Expected O, but got I4
			int num = 0;
			base.OnBound((MemberInfo)num);
			INumberHandler numberHandler = this.numberHandler;
			int num2 = 0;
			uint num3 = default(uint);
			if (num2 < (int)num3)
			{
				num2 += num2;
				num2++;
			}
			if ((object)typeof(INumberHandler).TypeHandle == null)
			{
				object value = base.m_value;
				BoundInputField boundInputField = input;
				string text2 = (boundInputField.Text = value.ToString());
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xA63100", Offset = "0xA61B00", VA = "0x180A63100")]
		public NumberField()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x12A12F0", Offset = "0x129FCF0", VA = "0x1812A12F0")]
		static NumberField()
		{
			HashSet<Type> hashSet = (HashSet<Type>)(object)new HashSet<T>();
			Type typeFromHandle = typeof(int);
			bool flag = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle);
			Type typeFromHandle2 = typeof(uint);
			bool flag2 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle2);
			Type typeFromHandle3 = typeof(long);
			bool flag3 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle3);
			Type typeFromHandle4 = typeof(ulong);
			bool flag4 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle4);
			Type typeFromHandle5 = typeof(byte);
			bool flag5 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle5);
			Type typeFromHandle6 = typeof(sbyte);
			bool flag6 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle6);
			Type typeFromHandle7 = typeof(short);
			bool flag7 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle7);
			Type typeFromHandle8 = typeof(ushort);
			bool flag8 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle8);
			Type typeFromHandle9 = typeof(char);
			bool flag9 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle9);
			Type typeFromHandle10 = typeof(float);
			bool flag10 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle10);
			Type typeFromHandle11 = typeof(double);
			bool flag11 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle11);
			Type typeFromHandle12 = typeof(decimal);
			bool flag12 = ((HashSet<T>)(object)hashSet).Add((T)typeFromHandle12);
			supportedTypes = hashSet;
			throw new NullReferenceException();
		}
	}
}
