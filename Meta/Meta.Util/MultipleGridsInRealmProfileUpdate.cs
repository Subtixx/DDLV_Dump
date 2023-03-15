using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AD5")]
	internal class MultipleGridsInRealmProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D6F")]
		[Cpp2IlInjected.Address(RVA = "0x1394F90", Offset = "0x1393990", VA = "0x181394F90", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_0062, IL_006e
			int num = 0;
			if (!profile.TryGetValue("World", out *(JToken?*)num) || num == 0)
			{
				return;
			}
			int num2 = 0;
			bool flag = default(bool);
			if (num == 0 || !flag || num == 0)
			{
				return;
			}
			int num3 = 0;
			if (num == 0)
			{
				return;
			}
			IEnumerator<> enumerator = default(IEnumerator<>);
			if (enumerator != null)
			{
				uint num4 = default(uint);
				if (num < (int)num4)
				{
					num += num;
					if (num != (int)num4)
					{
						num++;
					}
				}
				int num5 = 0;
				if (enumerator == null)
				{
					throw new InvalidCastException();
				}
				JToken jToken = default(JToken);
				if (Extensions.Value<uint>((IEnumerable<>)jToken) != 0)
				{
					JArray jArray = new JArray(jToken);
				}
			}
			if (enumerator == null)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D70")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public MultipleGridsInRealmProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
