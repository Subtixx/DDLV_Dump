using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003DF")]
	public class InputTriggerDownWithDelay : InputTrigger
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400193E")]
		private float timeRemainingUntilTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400193F")]
		private float delay = 0.2f;

		[Cpp2IlInjected.Token(Token = "0x60010A7")]
		[Cpp2IlInjected.Address(RVA = "0x11B72D0", Offset = "0x11B5CD0", VA = "0x1811B72D0")]
		public InputTriggerDownWithDelay(float delay = 0.2f)
		{
			this.delay = delay;
		}

		[Cpp2IlInjected.Token(Token = "0x60010A8")]
		[Cpp2IlInjected.Address(RVA = "0x11B7290", Offset = "0x11B5C90", VA = "0x1811B7290", Slot = "4")]
		public override bool Update(float deltaTime, bool currentIsActuated, bool previousIsActuated)
		{
			if (currentIsActuated && !previousIsActuated)
			{
				float num = (timeRemainingUntilTrigger = delay);
			}
			float num2 = (timeRemainingUntilTrigger = timeRemainingUntilTrigger);
			if (currentIsActuated)
			{
				int num3 = 0;
				timeRemainingUntilTrigger = 0f;
				return true;
			}
			int num4 = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
