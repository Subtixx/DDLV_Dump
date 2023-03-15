using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003CC")]
	public class InputActionModifier_Chord : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400192D")]
		private InputAction chordedAction;

		[Cpp2IlInjected.Token(Token = "0x600106B")]
		[Cpp2IlInjected.Address(RVA = "0x5391F0", Offset = "0x537BF0", VA = "0x1805391F0")]
		public InputActionModifier_Chord(InputAction chordedAction)
		{
			this.chordedAction = chordedAction;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600106C")]
		[Cpp2IlInjected.Address(RVA = "0x11B3560", Offset = "0x11B1F60", VA = "0x1811B3560", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_001e
			if (!chordedAction.IsTriggered)
			{
				int num = 0;
				Vector2 vector = (value.Value = Vector2.zero);
			}
		}
	}
}
