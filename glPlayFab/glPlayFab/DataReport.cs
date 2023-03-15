using System.Collections.Generic;
using Cpp2IlInjected;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	public class DataReport
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private List<IDataReport> data = (List<IDataReport>)(object)new List<T>();

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		public List<IDataReport> Reports
		{
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			get
			{
				return data;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x16D8C60", Offset = "0x16D7660", VA = "0x1816D8C60")]
		public void Add<T>() where T : IDataReport, new()
		{
			//Discarded unreachable code: IL_0008
			List<IDataReport> list = data;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x102BA10", Offset = "0x102A410", VA = "0x18102BA10")]
		public DataReport()
		{
		}
	}
}
