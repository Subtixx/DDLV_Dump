using System;
using Cpp2IlInjected;
using Mdl.Gestures;
using Mdl.Systems;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003D1")]
	public class InputActionModifier_ScaleDeltaTime : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001935")]
		private readonly CustomizedPlayerInputSystem input;

		[Cpp2IlInjected.Token(Token = "0x6001079")]
		[Cpp2IlInjected.Address(RVA = "0x11B38C0", Offset = "0x11B22C0", VA = "0x1811B38C0")]
		public InputActionModifier_ScaleDeltaTime()
		{
			CustomizedPlayerInputSystem customizedPlayerInputSystem = (input = SystemRoot.Instance.GetSystem<CustomizedPlayerInputSystem>());
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x600107A")]
		[Cpp2IlInjected.Address(RVA = "0x11B3850", Offset = "0x11B2250", VA = "0x1811B3850", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_000f
			int num = 0;
			Vector2 mouseScaling = input.MouseScaling;
		}
	}
}
