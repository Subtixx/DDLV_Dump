using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003CF")]
	public class InputActionModifier_SuppressIf : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001933")]
		private readonly Func<bool> shouldSuppress;

		[Cpp2IlInjected.Token(Token = "0x6001075")]
		[Cpp2IlInjected.Address(RVA = "0x5391F0", Offset = "0x537BF0", VA = "0x1805391F0")]
		public InputActionModifier_SuppressIf(Func<bool> check)
		{
			shouldSuppress = check;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001076")]
		[Cpp2IlInjected.Address(RVA = "0x11B3E70", Offset = "0x11B2870", VA = "0x1811B3E70", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_001e
			if (shouldSuppress() != null)
			{
				int num = 0;
				Vector2 vector = (value.Value = Vector2.zero);
			}
		}
	}
}
