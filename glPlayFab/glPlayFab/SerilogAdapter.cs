using System;
using Cpp2IlInjected;
using Serilog;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public class SerilogAdapter : ILogger
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private readonly Serilog.ILogger logger;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x539220", Offset = "0x537C20", VA = "0x180539220")]
		public SerilogAdapter(Serilog.ILogger logger)
		{
			this.logger = logger;
			/*Error: Unexpected end of block*/;
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x14F5810", Offset = "0x14F4210", VA = "0x1814F5810", Slot = "6")]
		public void Error(string msg, params object[] parameters)
		{
			//Discarded unreachable code: IL_0008
			Serilog.ILogger logger = this.logger;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x14F5880", Offset = "0x14F4280", VA = "0x1814F5880", Slot = "7")]
		public void Error(Exception e, string msg, params object[] parameters)
		{
			//Discarded unreachable code: IL_001d
			Serilog.ILogger logger = this.logger;
			int num = 0;
			uint num2 = default(uint);
			if (num < (int)num2)
			{
				num += num;
				num++;
			}
			Serilog.ILogger logger2 = logger.ForContext<TSource>();
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x14F5970", Offset = "0x14F4370", VA = "0x1814F5970", Slot = "4")]
		public void Info(string msg, params object[] parameters)
		{
			//Discarded unreachable code: IL_0008
			Serilog.ILogger logger = this.logger;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x14F59E0", Offset = "0x14F43E0", VA = "0x1814F59E0", Slot = "5")]
		public void Warning(string msg, params object[] parameters)
		{
			//Discarded unreachable code: IL_0008
			Serilog.ILogger logger = this.logger;
		}
	}
}
