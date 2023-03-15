using System.IO;
using Cpp2IlInjected;
using Mdl.Log;
using Serilog;

namespace Meta
{
	[Cpp2IlInjected.Token(Token = "0x2000997")]
	public class Building
	{
		[Cpp2IlInjected.Token(Token = "0x17000E9B")]
		[field: Cpp2IlInjected.FieldOffset(Offset = "0x10"), Cpp2IlInjected.Token(Token = "0x40027BE")]
		private ILogger Logger
		{
			[Cpp2IlInjected.Token(Token = "0x6005423")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get;
		} = Serilogger.Create<Building>();


		[Cpp2IlInjected.Token(Token = "0x6005424")]
		[Cpp2IlInjected.Address(RVA = "0x1AC64D0", Offset = "0x1AC4ED0", VA = "0x181AC64D0")]
		public void Method1()
		{
			//Discarded unreachable code: IL_003d
			string[] files = Directory.GetFiles(".");
			int num = 0;
			int length = files.Length;
			if (num < length)
			{
				ILogger logger = Logger;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num++;
				num += num;
				num += 520;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005425")]
		[Cpp2IlInjected.Address(RVA = "0x1AC64D0", Offset = "0x1AC4ED0", VA = "0x181AC64D0")]
		public void Install(int x, int y)
		{
			//Discarded unreachable code: IL_003d
			string[] files = Directory.GetFiles(".");
			int num = 0;
			int length = files.Length;
			if (num < length)
			{
				ILogger logger = Logger;
				uint num2 = default(uint);
				if (num < (int)num2)
				{
					num += num;
					num++;
				}
				num++;
				num += num;
				num += 520;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005426")]
		[Cpp2IlInjected.Address(RVA = "0x1AC6620", Offset = "0x1AC5020", VA = "0x181AC6620")]
		public Building()
		{
		}
	}
}
