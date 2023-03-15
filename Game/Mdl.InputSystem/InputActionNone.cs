using Cpp2IlInjected;
using UnityEngine;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003BE")]
	public class InputActionNone : InputAction
	{
		[Cpp2IlInjected.Token(Token = "0x600103E")]
		[Cpp2IlInjected.Address(RVA = "0x11B3FC0", Offset = "0x11B29C0", VA = "0x1811B3FC0")]
		public InputActionNone()
			: base(new InputTriggerNone(), new NoInputProvider())
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600103F")]
		[Cpp2IlInjected.Address(RVA = "0x11B3FA0", Offset = "0x11B29A0", VA = "0x1811B3FA0", Slot = "4")]
		protected override void UpdateInputActionValueFromProvider(ref InputActionValue value)
		{
			int num = 0;
			Vector2 vector = (value.Value = Vector2.zero);
		}

		[Cpp2IlInjected.Token(Token = "0x6001040")]
		[Cpp2IlInjected.Address(RVA = "0xCCDB60", Offset = "0xCCC560", VA = "0x180CCDB60", Slot = "5")]
		public override float GetValueFloatRaw()
		{
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x6001041")]
		[Cpp2IlInjected.Address(RVA = "0xF03240", Offset = "0xF01C40", VA = "0x180F03240", Slot = "6")]
		public override Vector2 GetValueVector2Raw()
		{
			int num = 0;
			return Vector2.zero;
		}

		[Cpp2IlInjected.Token(Token = "0x6001042")]
		[Cpp2IlInjected.Address(RVA = "0x11B3F70", Offset = "0x11B2970", VA = "0x1811B3F70", Slot = "3")]
		public override string ToString()
		{
			return "None";
		}
	}
}
