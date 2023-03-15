using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003C7")]
	public class InputActionModifier_Zero : InputActionModifier
	{
		[Cpp2IlInjected.Token(Token = "0x600105E")]
		[Cpp2IlInjected.Address(RVA = "0x11B3F50", Offset = "0x11B2950", VA = "0x1811B3F50", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			int num = 0;
			Vector2 vector = (value.Value = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x600105F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public InputActionModifier_Zero()
		{
		}
	}
}
