using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003E1")]
	public class InputTriggerTapped : InputTrigger
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4001940")]
		private float timeRemainingUntilTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4001941")]
		private float delay = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x60010AB")]
		[Cpp2IlInjected.Address(RVA = "0x11B72D0", Offset = "0x11B5CD0", VA = "0x1811B72D0")]
		public InputTriggerTapped(float delay = 0.2f)
		{
			this.delay = delay;
		}

		[Cpp2IlInjected.Token(Token = "0x60010AC")]
		[Cpp2IlInjected.Address(RVA = "0x11B7500", Offset = "0x11B5F00", VA = "0x1811B7500", Slot = "4")]
		public override bool Update(float deltaTime, bool currentIsActuated, bool previousIsActuated)
		{
			//IL_0030: Invalid comparison between F4 and I4
			if (currentIsActuated && !previousIsActuated)
			{
				float num = (timeRemainingUntilTrigger = delay);
			}
			float num2 = (timeRemainingUntilTrigger = timeRemainingUntilTrigger);
			if (previousIsActuated && !currentIsActuated)
			{
				int num3 = 0;
				if (!(num2 <= (float)num3))
				{
					return true;
				}
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
