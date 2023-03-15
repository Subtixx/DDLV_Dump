using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Gameloft.Tracking.Device.Platform.Windows
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	internal static class WinWmiLayer
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x40306E0", Offset = "0x402F0E0", VA = "0x1840306E0")]
		public static extern bool GetChipset([In][Out] ChipsetInfo chipset);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4030850", Offset = "0x402F250", VA = "0x184030850")]
		public static extern bool GetGpus(out IntPtr gpus, out int count);
	}
}
