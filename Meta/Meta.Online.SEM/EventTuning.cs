using Cpp2IlInjected;
using Gameloft.Common;
using Mono;
using Newtonsoft.Json.Linq;

namespace Meta.Online.SEM
{
	[Cpp2IlInjected.Token(Token = "0x2000FC1")]
	public class EventTuning : JTokenAccessor
	{
		[Cpp2IlInjected.Token(Token = "0x1700164C")]
		public string EventType
		{
			[Cpp2IlInjected.Token(Token = "0x6007F70")]
			[Cpp2IlInjected.Address(RVA = "0x17F80D0", Offset = "0x17F6AD0", VA = "0x1817F80D0")]
			get
			{
				//IL_000e: Expected O, but got I4
				JObject asOrDefault;
				do
				{
					int num = 0;
					asOrDefault = GetAsOrDefault("event_type", (JObject)num);
				}
				while (asOrDefault == null);
				return asOrDefault.GetAs<string>("value");
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6007F71")]
		[Cpp2IlInjected.Address(RVA = "0x784780", Offset = "0x783180", VA = "0x180784780")]
		public EventTuning(JObject data)
			: base(data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6007F72")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public EventTuning()
		{
			((Mono.DataConverter)(object)this)._002Ector();
		}
	}
}
