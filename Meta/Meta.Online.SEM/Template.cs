using Cpp2IlInjected;
using Gameloft.Common;
using Mono;
using Newtonsoft.Json.Linq;

namespace Meta.Online.SEM
{
	[Cpp2IlInjected.Token(Token = "0x2000FC2")]
	public class Template : JTokenAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x1700164D")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6007F73")]
			[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x787FA0", VA = "0x1807895A0")]
			get
			{
				return GetAs<string>("title");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164E")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6007F74")]
			[Cpp2IlInjected.Address(RVA = "0x789500", Offset = "0x787F00", VA = "0x180789500")]
			get
			{
				return GetAs<string>("description");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700164F")]
		public EventTuning EventTuning
		{
			[Cpp2IlInjected.Token(Token = "0x6007F75")]
			[Cpp2IlInjected.Address(RVA = "0x789550", Offset = "0x787F50", VA = "0x180789550")]
			get
			{
				return GetAccessor<EventTuning>("event_tuning");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007F76")]
		[Cpp2IlInjected.Address(RVA = "0x784780", Offset = "0x783180", VA = "0x180784780")]
		public Template(JObject data)
			: base(data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007F77")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public Template()
		{
			((Mono.DataConverter)(object)this)._002Ector();
		}
	}
}
