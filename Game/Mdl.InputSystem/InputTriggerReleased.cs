using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003E0")]
	public class InputTriggerReleased : InputTrigger
	{
		[Cpp2IlInjected.Token(Token = "0x60010A9")]
		[Cpp2IlInjected.Address(RVA = "0x11B74F0", Offset = "0x11B5EF0", VA = "0x1811B74F0", Slot = "4")]
		public override bool Update(float deltaTime, bool currentIsActuated, bool previousIsActuated)
		{
			if (previousIsActuated && !currentIsActuated)
			{
				return true;
			}
			int num = 0;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010AA")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public InputTriggerReleased()
		{
		}
	}
}
