using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003DE")]
	public class InputTriggerDown : InputTrigger
	{
		[Cpp2IlInjected.Token(Token = "0x60010A5")]
		[Cpp2IlInjected.Address(RVA = "0x11B7300", Offset = "0x11B5D00", VA = "0x1811B7300", Slot = "4")]
		public override bool Update(float deltaTime, bool currentIsActuated, bool previousIsActuated)
		{
			return currentIsActuated;
		}

		[Cpp2IlInjected.Token(Token = "0x60010A6")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public InputTriggerDown()
		{
		}
	}
}
