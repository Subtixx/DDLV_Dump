using System.Collections.Generic;
using Cpp2IlInjected;
using glPlayFab.Disney;
using Newtonsoft.Json.Linq;

namespace Meta.Util
{
	[Cpp2IlInjected.Token(Token = "0x2000AD6")]
	internal class DecalInventoryProfileUpdate : ProfileUpdate
	{
		[Cpp2IlInjected.Token(Token = "0x6005D71")]
		[Cpp2IlInjected.Address(RVA = "0x1A1DDE0", Offset = "0x1A1C7E0", VA = "0x181A1DDE0", Slot = "4")]
		protected unsafe override void DoApplyJson(JObject profile)
		{
			//Discarded unreachable code: IL_004c
			int num = 0;
			if (!profile.TryGetValue("Player", out *(JToken?*)num) || num == 0)
			{
				return;
			}
			int num2 = 0;
			bool flag = default(bool);
			if (num != 0 && flag && num != 0)
			{
				int num3 = 0;
				bool flag2 = default(bool);
				if (num != 0 && flag2)
				{
					JObject jObject = JObject.Parse(((int*)num)->ToString());
					JToken jToken = default(JToken);
					JToken jToken2 = Extensions.Value<uint>((IEnumerable<>)jToken) + 1;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005D72")]
		[Cpp2IlInjected.Address(RVA = "0x52C490", Offset = "0x52AE90", VA = "0x18052C490")]
		public DecalInventoryProfileUpdate()
		{
			((BattlePassReward)(object)this)._002Ector();
		}
	}
}
