using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003DB")]
	public class InputTriggerPressed : InputTrigger
	{
		[Cpp2IlInjected.Token(Token = "0x600109E")]
		[Cpp2IlInjected.Address(RVA = "0x11B74E0", Offset = "0x11B5EE0", VA = "0x1811B74E0", Slot = "4")]
		public override bool Update(float deltaTime, bool currentIsActuated, bool previousIsActuated)
		{
			if (currentIsActuated && !previousIsActuated)
			{
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x600109F")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public InputTriggerPressed()
		{
		}
	}
}
