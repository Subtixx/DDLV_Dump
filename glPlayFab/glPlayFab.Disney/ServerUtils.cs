using System.Diagnostics;
using System.IO;
using Cpp2IlInjected;

namespace glPlayFab.Disney
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	public static class ServerUtils
	{
		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public static string DataDir
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x14F63D0", Offset = "0x14F4DD0", VA = "0x1814F63D0")]
			get
			{
				int num = 0;
				if (Debugger.IsAttached)
				{
					int num2 = 0;
					return Path.Combine(Directory.GetCurrentDirectory(), "..", "Data");
				}
				return "Data";
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public static string LiveopsDir
		{
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x14F4900", Offset = "0x14F3300", VA = "0x1814F4900")]
			get
			{
				int num = 0;
				if (Debugger.IsAttached)
				{
					int num2 = 0;
					string text = Path.Combine(Directory.GetCurrentDirectory(), "..", "Data");
				}
				return Path.Combine("Data", "Liveops");
			}
		}
	}
}
