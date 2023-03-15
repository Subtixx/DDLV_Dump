using System;
using System.Diagnostics;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003CA")]
	public class InputActionModifier_Clamp : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400192B")]
		private Vector2 MinValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400192C")]
		private Vector2 MaxValue;

		[Cpp2IlInjected.Token(Token = "0x6001064")]
		[Cpp2IlInjected.Address(RVA = "0x11B3600", Offset = "0x11B2000", VA = "0x1811B3600")]
		public unsafe InputActionModifier_Clamp()
		{
			//IL_0023: Expected F4, but got I4
			//IL_001e: Expected native int or pointer, but got O
			//IL_003c: Expected F4, but got I4
			//IL_0037: Expected native int or pointer, but got O
			int num = 0;
			Vector2 one = Vector2.one;
			int num2 = 0;
			MinValue = one;
			((Vector2*)(IntPtr)MinValue)->y = 0f;
			Vector2 vector = (MaxValue = Vector2.one);
			((Vector2*)(IntPtr)MaxValue)->y = 0f;
		}

		[Cpp2IlInjected.Token(Token = "0x6001065")]
		[Cpp2IlInjected.Address(RVA = "0x11B3670", Offset = "0x11B2070", VA = "0x1811B3670")]
		public unsafe InputActionModifier_Clamp(float min, float max)
		{
			//IL_000d: Expected O, but got F4
			//IL_0014: Expected native int or pointer, but got O
			//IL_0020: Expected O, but got F4
			//IL_0027: Expected native int or pointer, but got O
			MinValue = (Vector2)min;
			((Vector2*)(IntPtr)MinValue)->y = min;
			MaxValue = (Vector2)max;
			((Vector2*)(IntPtr)MaxValue)->y = max;
		}

		[Cpp2IlInjected.Token(Token = "0x6001066")]
		[Cpp2IlInjected.Address(RVA = "0x11B36C0", Offset = "0x11B20C0", VA = "0x1811B36C0")]
		public InputActionModifier_Clamp(Vector2 min, Vector2 max)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6001067")]
		[Cpp2IlInjected.Address(RVA = "0x11B3590", Offset = "0x11B1F90", VA = "0x1811B3590")]
		[Conditional("DEBUG")]
		public void DebugUpdate(Vector2 min, Vector2 max)
		{
			MinValue = min;
			MaxValue = max;
		}

		[Cpp2IlInjected.Token(Token = "0x6001068")]
		[Cpp2IlInjected.Address(RVA = "0x11B35A0", Offset = "0x11B1FA0", VA = "0x1811B35A0", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			float y = MaxValue.y;
			float y2 = MinValue.y;
			float num = default(float);
			float num2 = Mathf.Clamp(num, y2, y);
			y2 = num;
		}
	}
}
