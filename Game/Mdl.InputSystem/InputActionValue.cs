using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003C3")]
	public struct InputActionValue
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4001921")]
		internal Vector2 Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4001922")]
		internal InputActionValueType ValueType;

		[Cpp2IlInjected.Token(Token = "0x6001052")]
		[Cpp2IlInjected.Address(RVA = "0x11B4080", Offset = "0x11B2A80", VA = "0x1811B4080")]
		public void Reset()
		{
			int num = 0;
			Vector2 vector = (Value = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x6001053")]
		[Cpp2IlInjected.Address(RVA = "0x11B40D0", Offset = "0x11B2AD0", VA = "0x1811B40D0")]
		public InputActionValue(InputActionValueType type)
		{
			int num = 0;
			Vector2 vector = (Value = Vector2.zero);
			ValueType = type;
		}

		[Cpp2IlInjected.Token(Token = "0x6001054")]
		[Cpp2IlInjected.Address(RVA = "0x11B4120", Offset = "0x11B2B20", VA = "0x1811B4120")]
		public InputActionValue(bool v)
		{
			//IL_000d: Expected I4, but got I8
			//IL_0017: Expected O, but got I4
			//IL_0020: Expected I4, but got I8
			if (v)
			{
				ValueType = InputActionValueType.Bool;
				return;
			}
			int num = 0;
			Value = (Vector2)num;
			ValueType = InputActionValueType.Bool;
		}

		[Cpp2IlInjected.Token(Token = "0x6001055")]
		[Cpp2IlInjected.Address(RVA = "0x11B4100", Offset = "0x11B2B00", VA = "0x1811B4100")]
		public InputActionValue(float v)
		{
			//IL_0009: Expected I4, but got I8
			ValueType = InputActionValueType.Float;
		}

		[Cpp2IlInjected.Token(Token = "0x6001056")]
		[Cpp2IlInjected.Address(RVA = "0x11B4160", Offset = "0x11B2B60", VA = "0x1811B4160")]
		public InputActionValue(Vector2 v)
		{
			//IL_0010: Expected I4, but got I8
			Value = v;
			ValueType = InputActionValueType.Vector2;
		}

		[Cpp2IlInjected.Token(Token = "0x6001057")]
		[Cpp2IlInjected.Address(RVA = "0x11B40A0", Offset = "0x11B2AA0", VA = "0x1811B40A0")]
		public InputActionValue(InputActionValue other)
		{
			InputActionValueType inputActionValueType = (ValueType = other.ValueType);
		}

		[Cpp2IlInjected.Token(Token = "0x6001058")]
		[Cpp2IlInjected.Address(RVA = "0x11B4170", Offset = "0x11B2B70", VA = "0x1811B4170")]
		public unsafe static InputActionValue operator +(InputActionValue lhs, InputActionValue rhs)
		{
			//IL_0009: Expected native int or pointer, but got O
			//IL_0017: Expected native int or pointer, but got O
			InputActionValueType inputActionValueType = (((InputActionValue*)(IntPtr)lhs)->ValueType = rhs.ValueType);
			InputActionValueType valueType = rhs.ValueType;
			int valueType2 = default(int);
			((InputActionValue*)(IntPtr)lhs)->ValueType = (InputActionValueType)valueType2;
			return lhs;
		}
	}
}
