using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Definitions.Items;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000ACC")]
	internal class PostEarlyAccessRemovalProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D5C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7F0", Offset = "0x7BE1F0", VA = "0x1807BF7F0", Slot = "4")]
		protected override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_005c
			bool flag = default(bool);
			ulong num = default(ulong);
			if (!flag || num == 0)
			{
				return;
			}
			int num2 = 0;
			bool flag2 = default(bool);
			ulong num3 = default(ulong);
			if (num == 0 || !flag2 || num3 == 0)
			{
				return;
			}
			int num4 = 0;
			int num5 = default(int);
			if (num3 == 0 || num5 == 0)
			{
				return;
			}
			int num6 = 0;
			bool flag3 = default(bool);
			ulong num7 = default(ulong);
			if (num5 == 0 || !flag3 || num7 == 0)
			{
				return;
			}
			int num8 = 0;
			if (num7 != 0)
			{
				JToken jToken = default(JToken);
				long num9 = Convert.ToInt64((uint)Extensions.Value<int>((IEnumerable<>)jToken));
				CharacterItemData characterItemData = default(CharacterItemData);
				if (characterItemData != null)
				{
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D5D")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public PostEarlyAccessRemovalProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
