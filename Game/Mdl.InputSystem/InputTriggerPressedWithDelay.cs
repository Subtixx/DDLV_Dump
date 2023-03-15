using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003DC")]
	public class InputTriggerPressedWithDelay : InputTrigger
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400193A")]
		private bool wantsToTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400193B")]
		private float timeRemainingUntilTrigger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400193C")]
		private float delay = 0.2f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400193D")]
		private Func<bool> cancellationCheck;

		[Cpp2IlInjected.Token(Token = "0x60010A0")]
		[Cpp2IlInjected.Address(RVA = "0x11B7400", Offset = "0x11B5E00", VA = "0x1811B7400")]
		public InputTriggerPressedWithDelay(float delay = 0.2f, [Optional] Func<bool> cancellationCheck)
		{
			this.cancellationCheck = cancellationCheck;
			this.delay = delay;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010A1")]
		[Cpp2IlInjected.Address(RVA = "0x11B7310", Offset = "0x11B5D10", VA = "0x1811B7310", Slot = "5")]
		protected virtual bool IsCancelled(bool currentIsActuated, bool previousIsActuated)
		{
			//IL_0012: Expected I4, but got O
			Func<bool> func = cancellationCheck;
			if (func == null)
			{
				int num = 0;
				/*Error: Unexpected end of block*/;
			}
			return (byte)(int)func() != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x60010A2")]
		[Cpp2IlInjected.Address(RVA = "0x11B7360", Offset = "0x11B5D60", VA = "0x1811B7360", Slot = "4")]
		public override bool Update(float deltaTime, bool currentIsActuated, bool previousIsActuated)
		{
			if (!IsCancelled(currentIsActuated, currentIsActuated))
			{
				bool flag = wantsToTrigger;
				if (!currentIsActuated || previousIsActuated)
				{
					goto IL_0038;
				}
				float num = (timeRemainingUntilTrigger = delay);
				wantsToTrigger = true;
			}
			wantsToTrigger = false;
			int num2 = 0;
			goto IL_0038;
			IL_0038:
			float num3 = (timeRemainingUntilTrigger = timeRemainingUntilTrigger);
			if (num2 != 0)
			{
				int num4 = 0;
				wantsToTrigger = false;
			}
			int num5 = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
