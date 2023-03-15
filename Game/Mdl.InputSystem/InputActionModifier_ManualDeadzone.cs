using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003C8")]
	public class InputActionModifier_ManualDeadzone : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4001929")]
		private float deadzone = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x6001060")]
		[Cpp2IlInjected.Address(RVA = "0x11B3740", Offset = "0x11B2140", VA = "0x1811B3740")]
		public InputActionModifier_ManualDeadzone(float deadzone = 0.25f)
		{
			this.deadzone = deadzone;
		}

		[Cpp2IlInjected.Token(Token = "0x6001061")]
		[Cpp2IlInjected.Address(RVA = "0x11B3700", Offset = "0x11B2100", VA = "0x1811B3700", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			float num = deadzone;
			int num2 = 0;
			Vector2 vector = (value.Value = Vector2.zero);
		}
	}
}
