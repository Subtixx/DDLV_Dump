using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003C9")]
	public class InputActionModifier_Merge : InputActionModifier
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400192A")]
		public InputAction OtherAction;

		[Cpp2IlInjected.Token(Token = "0x6001062")]
		[Cpp2IlInjected.Address(RVA = "0x5391F0", Offset = "0x537BF0", VA = "0x1805391F0")]
		public InputActionModifier_Merge(InputAction otherAction)
		{
			OtherAction = otherAction;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001063")]
		[Cpp2IlInjected.Address(RVA = "0x11B3770", Offset = "0x11B2170", VA = "0x1811B3770", Slot = "4")]
		protected override void ModifyValue(float deltaTime, ref InputActionValue value)
		{
			//Discarded unreachable code: IL_001d
			if (OtherAction.IsTriggered)
			{
				InputActionValueType valueType = value.ValueType;
				int valueType2 = default(int);
				value.ValueType = (InputActionValueType)valueType2;
			}
		}
	}
}
