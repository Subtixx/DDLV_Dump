using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D2")]
	public class InputActionModifier_Scale : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001936")]
		private Vector2 scale;

		[Cpp2IlInjected.Token(Token = "0x600107B")]
		[Cpp2IlInjected.Address(RVA = "0x11B3A70", Offset = "0x11B2470", VA = "0x1811B3A70")]
		public unsafe InputActionModifier_Scale(float x, float y)
		{
			//IL_001b: Expected F4, but got I4
			//IL_0016: Expected native int or pointer, but got O
			//IL_0028: Expected O, but got F4
			//IL_002f: Expected native int or pointer, but got O
			int num = 0;
			scale = Vector2.one;
			((Vector2*)(IntPtr)scale)->y = 0f;
			((object)this)._002Ector();
			scale = (Vector2)x;
			((Vector2*)(IntPtr)scale)->y = y;
		}

		[Cpp2IlInjected.Token(Token = "0x600107C")]
		[Cpp2IlInjected.Address(RVA = "0x11B3A50", Offset = "0x11B2450", VA = "0x1811B3A50", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
		}
	}
}
