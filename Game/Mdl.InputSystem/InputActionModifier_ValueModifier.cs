using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D0")]
	public class InputActionModifier_ValueModifier : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001934")]
		private readonly Func<Vector2, Vector2> modifier;

		[Cpp2IlInjected.Token(Token = "0x6001077")]
		[Cpp2IlInjected.Address(RVA = "0x5391F0", Offset = "0x537BF0", VA = "0x1805391F0")]
		public InputActionModifier_ValueModifier(Func<Vector2, Vector2> modifier)
		{
			this.modifier = modifier;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001078")]
		[Cpp2IlInjected.Address(RVA = "0x11B3EF0", Offset = "0x11B28F0", VA = "0x1811B3EF0", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_000f
			Func<Vector2, Vector2> func = modifier;
			Vector2 value2 = default(Vector2);
			value.Value = value2;
		}
	}
}
