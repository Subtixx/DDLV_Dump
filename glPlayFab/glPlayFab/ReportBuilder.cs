using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Newtonsoft.Json;

namespace glPlayFab
{
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	public class ReportBuilder
	{
		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		public DataReport DataReport
		{
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0x52C4E0", Offset = "0x52AEE0", VA = "0x18052C4E0")]
			[CompilerGenerated]
			get
			{
				return _003CDataReport_003Ek__BackingField;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x52C500", Offset = "0x52AF00", VA = "0x18052C500")]
			[CompilerGenerated]
			set
			{
				_003CDataReport_003Ek__BackingField = value;
				/*Error: Unexpected end of block*/;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x14F4F90", Offset = "0x14F3990", VA = "0x1814F4F90")]
		public void BuildData(BaseDataReport.Context ctx)
		{
			//Discarded unreachable code: IL_002a
			int num = 0;
			DataReport dataReport = DataReport;
			if (dataReport != null)
			{
				List<IDataReport> data = dataReport.data;
				bool flag = default(bool);
				if (flag)
				{
					num += num;
					num++;
					num += 408;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x14F5290", Offset = "0x14F3C90", VA = "0x1814F5290")]
		public string Serialize(BaseDataReport.Context ctx, JsonSerializerSettings settings)
		{
			BuildData(ctx);
			return JsonConvert.SerializeObject(DataReport, settings);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x14F5140", Offset = "0x14F3B40", VA = "0x1814F5140")]
		public (bool, string) Deserialize(string value, JsonSerializerSettings settings)
		{
			//IL_0009: Expected I4, but got O
			int num = 0;
			DataReport dataReport = default(DataReport);
			value.m_stringLength = (int)dataReport;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			throw new NullReferenceException();
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x52C4A0", Offset = "0x52AEA0", VA = "0x18052C4A0")]
		public ReportBuilder()
		{
		}
	}
}
