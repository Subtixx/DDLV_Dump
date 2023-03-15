using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Mdl.InputSystem
{
	[Cpp2IlInjected.Token(Token = "0x20003DD")]
	public class InputTriggerPressedWithMinDuration : InputTriggerPressedWithDelay
	{
		[Cpp2IlInjected.Token(Token = "0x60010A3")]
		[Cpp2IlInjected.Address(RVA = "0x11B7400", Offset = "0x11B5E00", VA = "0x1811B7400")]
		public InputTriggerPressedWithMinDuration(float holdTime = 0.2f, [Optional] Func<bool> cancellationCheck)
		{
			base.delay = 0.2f;
			((object)this)._002Ector();
			base.cancellationCheck = cancellationCheck;
			base.delay = holdTime;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60010A4")]
		[Cpp2IlInjected.Address(RVA = "0x11B7450", Offset = "0x11B5E50", VA = "0x1811B7450", Slot = "5")]
		protected override bool IsCancelled(bool currentIsActuated, bool previousIsActuated)
		{
			do
			{
				Func<bool> func = base.cancellationCheck;
				if (func != null && func() != null)
				{
					return true;
				}
			}
			while (previousIsActuated);
			int num = 0;
			/*Error: Unexpected end of block*/;
		}
	}
}
