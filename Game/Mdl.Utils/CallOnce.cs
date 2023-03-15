using System;
using System.Threading;
using Cpp2IlInjected;

namespace Mdl.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000721")]
	public class CallOnce
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4002967")]
		private bool alreadyInvoked;

		[Cpp2IlInjected.Token(Token = "0x6001FA3")]
		[Cpp2IlInjected.Address(RVA = "0x1647EF0", Offset = "0x16468F0", VA = "0x181647EF0")]
		public unsafe void InvokeOnce(Action a)
		{
			//Discarded unreachable code: IL_0029
			int num = 0;
			if ((alreadyInvoked ? 1 : 0) == num)
			{
				Monitor.Enter(this, ref *(bool*)num);
				if ((alreadyInvoked ? 1 : 0) == num)
				{
					a();
					alreadyInvoked = true;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA4")]
		[Cpp2IlInjected.Address(RVA = "0x1647F90", Offset = "0x1646990", VA = "0x181647F90")]
		public unsafe void Reset()
		{
			int num = 0;
			Monitor.Enter(this, ref *(bool*)num);
			alreadyInvoked = (byte)num != 0;
		}

		[Cpp2IlInjected.Token(Token = "0x6001FA5")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public CallOnce()
		{
		}
	}
}
