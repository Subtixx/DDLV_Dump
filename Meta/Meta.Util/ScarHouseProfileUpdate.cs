using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ADC")]
	internal class ScarHouseProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D7B")]
		[Cpp2IlInjected.Address(RVA = "0x176A390", Offset = "0x1768D90", VA = "0x18176A390", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_00f5
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
			bool flag2 = default(bool);
			if (num == 0 || !flag2 || num == 0)
			{
				return;
			}
			int num4 = 0;
			bool flag3 = default(bool);
			if (num == 0 || !flag3 || num == 0)
			{
				return;
			}
			int num5 = 0;
			if (num == 0)
			{
				return;
			}
			int num6 = 0;
			int num7 = 0;
			Func<JToken, uint> _003C_003E9__0_ = _003C_003Ec._003C_003E9__0_0;
			JToken jToken = default(JToken);
			if (jToken == null)
			{
			}
			int num8 = 0;
			if (_003C_003E9__0_ != null)
			{
				if (jToken == null)
				{
				}
				int num9 = 0;
			}
			JEnumerable<JToken> jEnumerable = default(JEnumerable<JToken>);
			uint[] array = Enumerable.Select<JToken, uint>((IEnumerable<>)jEnumerable, (Func<, >)(object)(_003C_003Ec._003C_003E9 = (_003C_003Ec)(object)(Func<T, TResult>)((JToken x) => x.ToObject<uint>()))).ToArray<uint>();
			bool flag4 = default(bool);
			if (!flag4 || num == 0)
			{
				return;
			}
			int num10 = 0;
			bool flag5 = default(bool);
			if (num == 0 || !flag5 || num == 0)
			{
				return;
			}
			int num11 = 0;
			if (num != 0)
			{
				int length = array.Length;
				if (num < length)
				{
					uint num12 = array[num];
					num++;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D7C")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public ScarHouseProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
